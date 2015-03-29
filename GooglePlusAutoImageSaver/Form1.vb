Imports System.IO
Imports System.Text.RegularExpressions
Imports GooglePlusClassLibrary
Imports GooglePlusClassLibrary.CustomObjects
Imports System.ComponentModel
Imports System.Threading

Public Class Form1
    Dim localdirectory As String = My.Settings.strDirToSave
    Dim AutoLoadWhenStart As String = My.Settings.boolAutoLoadWhenStart
    'Dim streamTXT As String
    Dim listOfAlbumToDownload As New List(Of AlbumNameObject)
    Dim listOfDownloadedObj As New List(Of DownloadedObject)
    Dim gugutasuJapaneseBoolean As Boolean = My.Settings.boolGplusJP
    Dim listOfMemberData As New List(Of MemberData)
    Dim integerCountAlbumToDL As Integer = 0
    Dim TimerInterval As Integer = My.Settings.intTimerInterval
    Dim AutoDLBoolean As Boolean = My.Settings.boolAutoDL
    Dim timeleft As Integer = 0
    Dim TimerSetterVal As Integer = My.Settings.intTimerSetterVal
    Dim FormLoadCompletedFlag As Boolean = False
    Dim showDownloadedPicture As Boolean = My.Settings.boolShowPicture
    Dim CombineDir As Boolean = My.Settings.boolCombineDir
    Dim CancelAllDownloadFlag As Boolean = False
    Dim URLTextFilePath As String = My.Settings.strURLTextFilePath
    Dim DownloadedURLTextFilePath As String = My.Settings.strDownloadedURLTextFilePath


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblVersion.Text = My.Application.Info.Version.ToString
        backgroundDLworker.WorkerReportsProgress = True
        backgroundDLworker.WorkerSupportsCancellation = True
        txtDir.Text = localdirectory
        chkAutoLoadWhenStart.Checked = AutoLoadWhenStart
        chkAutoDownload.Checked = AutoDLBoolean
        timeleft = TimerInterval
        TimerSetter.Value = TimerSetterVal
        chkShowDownloadedPic.Checked = showDownloadedPicture
        chkCombineDir.Checked = CombineDir
        If AutoDLBoolean = True Then TimerUpdateTimerStatus.Enabled = True
        If gugutasuJapaneseBoolean = True Then cmbGooglePlusLanguage.SelectedIndex = 0
        If gugutasuJapaneseBoolean = False Then cmbGooglePlusLanguage.SelectedIndex = 1

        'Auto load google+ member list
        If AutoLoadWhenStart Then LoadGPlusMembersInformation()
        'Load URL of album, name and referenceID
        If File.Exists(URLTextFilePath) = False Then
            Using t As StreamWriter = New StreamWriter(URLTextFilePath)

            End Using
        End If
        Using read As StreamReader = New StreamReader(URLTextFilePath)
            Try
                While read.EndOfStream = False
                    Dim a As String() = read.ReadLine.Split(",")
                    If a.Count > 0 Then
                        Dim b = New AlbumNameObject(a(0), a(1), a(2), a(3))
                        listOfAlbumToDownload.Add(b)
                    End If
                End While

                If listOfAlbumToDownload.Count > 0 Then
                    integerCountAlbumToDL = listOfAlbumToDownload.Item(listOfAlbumToDownload.Count - 1).ReferenceDownloadedID
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End Using

        'Load list of images loaded
        If File.Exists(DownloadedURLTextFilePath) = False Then
            Using t As StreamWriter = New StreamWriter(DownloadedURLTextFilePath)

            End Using
        End If
        Using read As StreamReader = New StreamReader(DownloadedURLTextFilePath)
            Try
                While read.EndOfStream = False
                    Dim a As String() = read.ReadLine.Split(",")
                    If a.Count > 0 Then
                        Dim b = New DownloadedObject(a(0), a(1))
                        listOfDownloadedObj.Add(b)
                    End If
                End While
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End Using

        'UI Update
        If listOfAlbumToDownload.Count > 0 Then
            For Each i In listOfAlbumToDownload
                lstDLName.Items.Add(i)
            Next
        End If
        FormLoadCompletedFlag = True
        UpdateStatusLabel("Initialization completed")
    End Sub


#Region "Downloader"

    Private WithEvents backgroundNavigateWorker As New BackgroundWorker()
    Dim backgroundThreadNavigateurl As String = ""
    Dim backgroundThreadDirName As String = ""
    Dim backgroundThreadRootID As Integer = 0
    Private Function NavigateWorkerOnBackgroundThread(ByVal navigateurl As String, ByVal dirName As String, ByVal rootID As Integer) As Boolean
        While backgroundNavigateWorker.IsBusy
            Application.DoEvents()
        End While

        If backgroundNavigateWorker.CancellationPending <> True Then
            If backgroundNavigateWorker.IsBusy <> True Then
                backgroundThreadNavigateurl = navigateurl
                backgroundThreadDirName = dirName
                backgroundThreadRootID = rootID
                backgroundNavigateWorker.RunWorkerAsync()
                Thread.Sleep(100) 'Add a delay
            End If
        End If
        Return dlcomp
    End Function

    ' This event handler is where the time-consuming work is done. 
    Private Sub NavigateWorkerOnBackgroundThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles backgroundNavigateWorker.DoWork
        NavigateAndDownload(backgroundThreadNavigateurl, backgroundThreadDirName, backgroundThreadRootID)
    End Sub

    '' This event handler deals with the results of the background operation. 
    'Private Sub NavigateWorkerOnBackgroundThread_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundNavigateWorker.RunWorkerCompleted

    'End Sub

    Dim thisRunDLnumber As Integer = 0 'Current file number that is being downloaded
    Dim fileinqueue As Integer = 0
    Private Sub NavigateAndDownload(ByVal navigateurl As String, ByVal dirName As String, ByVal rootID As Integer)
        ' MessageBox.Show(Chr(34)) // Test function for getting character "
        'Initialize downloding by reset values
        cancelFlag = False
        fileinqueue = 0
        thisRunDLnumber = 0

        If CancelAllDownloadFlag <> True Then

            Try
                UpdateStatusLabel("Start downloading photo from " + dirName)

                'Create directory for storing downloaded images
                Dim dlDir As String
                If CombineDir = False Then
                    dlDir = localdirectory + dirName + "\"
                Else
                    dlDir = localdirectory
                End If

                If (Not System.IO.Directory.Exists(dlDir)) Then
                    System.IO.Directory.CreateDirectory(dlDir)
                End If


                'Create object for building listimage of each member to download
                Dim listImageBuilder As ListImageBuilder
                listImageBuilder = New ListImageBuilder(navigateurl)
                'Get list of image
                Dim Listimgobj = listImageBuilder.ListImageBuild()

                'Got list of URL and file name. Select photos to download now.
                If Listimgobj.Count > 0 Then

                    'Get total number of files to download to show to GUI
                    fileinqueue = Listimgobj.Count
                    For Each a In Listimgobj
                        For Each z In listOfDownloadedObj
                            If z.URL = a.imageFullSizeSource Then
                                fileinqueue -= 1
                            End If
                        Next
                    Next

                    'Compare each URL in Lists0 to the existing downloaded images
                    'If unique, then download it.
                    For Each a As ImageObject In Listimgobj
                        If cancelFlag = False Then
                            Dim skipDL As Boolean = False
                            For Each z In listOfDownloadedObj
                                'If z.ReferenceNameID = rootID Then
                                If z.URL = a.imageFullSizeSource Then
                                    skipDL = True
                                End If
                                'End If
                            Next
                            'If found downloaded, skip this photo
                            If skipDL = True Then
                                Continue For
                            End If
                            thisRunDLnumber += 1
                            Dim DLcompleted As Boolean
                            'If a.imagesource.Contains("mp4") Then
                            '    Dim b = a.imagesource.Replace("mp4", "jpg") 'replace .mp4 to .jpg for movie thumbnails
                            '    DLcompleted = DownloadFeeder(thisRunDLnumber, a.imagesource, dlDir, b.Split("/")(8), dirName)
                            'Else
                            'Create filename for photos based on yymmdd posted
                            'Dim b() As String = a.imagepostDate.Split("/") 'clean unneccessary info
                            'Dim c = b(4).Split("#")(0)
                            DLcompleted = DownloadFeeder(thisRunDLnumber, a.imageFullSizeSource, dlDir, a.imagePostedDate + " " + dirName + "-" + Now.Millisecond.ToString + ".jpg", dirName)
                            'End If
                            If DLcompleted = True Then
                                Dim D As DownloadedObject = New DownloadedObject(a.imageFullSizeSource, rootID)
                                listOfDownloadedObj.Add(D)
                            End If
                        End If
                    Next
                    If thisRunDLnumber = 0 Then UpdateStatusLabel("No new photos to download for " + dirName + ".")
                Else
                    UpdateStatusLabel("Unable to retrieve photo url to download.")
                End If


                cancelFlag = False
                SavedownloadedURL()
                ''UpdateStatusLabel("Download of " + fileinqueue.ToString + " images is completed for " + dirName)

            Catch ex As Exception
                UpdateStatusLabel(ex.ToString)
                btnStartDL.Enabled = True
            End Try

        End If
    End Sub

    Private WithEvents backgroundDLworker As New BackgroundWorker()
    Dim wb As WebConnection
    Dim dlcomp As Boolean = False
    Dim allDLcomp As Boolean = False
    Dim cancelFlag As Boolean = False
    Dim picLocation As String = ""
    Private Function DownloadFeeder(ByVal runnumber As Integer, ByVal link As String, ByVal myDir As String, ByVal filename As String, ByVal publicn As String) As Boolean
        While backgroundDLworker.IsBusy
            Application.DoEvents()
        End While

        wb = New WebConnection(New Uri(link), myDir + filename, publicn, filename)
        If backgroundDLworker.CancellationPending <> True Then
            If backgroundDLworker.IsBusy <> True Then
                backgroundDLworker.RunWorkerAsync()
                Thread.Sleep(75) 'Add delay so that no file is skipped
            End If
        End If
        Return dlcomp
    End Function

    ' This event handler is where the time-consuming work is done. 
    Private Sub backgroundDLworker_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles backgroundDLworker.DoWork
        dlcomp = wb.DownloadFile()
    End Sub

    ' This event handler updates the progress. 
    Private Sub backgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As ProgressChangedEventArgs) Handles backgroundDLworker.ProgressChanged
        'UpdateStatusLabel(e.ProgressPercentage.ToString() + "%")
    End Sub

    ' This event handler deals with the results of the background operation. 
    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundDLworker.RunWorkerCompleted
        If e.Cancelled = True Then
            UpdateStatusLabel("Cancelled")
        ElseIf e.Error IsNot Nothing Then
            UpdateStatusLabel("Error! " & e.Error.Message)
        Else
            UpdateStatusLabel("Download completed for " + wb.publicname + " : " + wb.publicfilename + " (" + thisRunDLnumber.ToString + "/" + fileinqueue.ToString + ")")
            'Show picture
            If showDownloadedPicture = True Then
                picLocation = wb.fullDirFilename
                pictureBox.ImageLocation = picLocation
            End If
        End If
    End Sub

    Private Function SavedownloadedURL() As Boolean
        Using a As StreamWriter = New StreamWriter("downloadedURL.txt")
            For Each i In listOfDownloadedObj
                a.WriteLine(i.URL + "," + i.ReferenceNameID.ToString)
            Next
            a.Close()
            Return True
        End Using
    End Function

    Private Sub StopDownload()
        'backgroundDLworker.CancelAsync()
        cancelFlag = True
        CancelAllDownloadFlag = True
        UpdateStatusLabel("Downloading of photos is stopped.")
    End Sub

    Private Sub AutoDownloader()
        btnDelName.Enabled = False
        btnBrowseDir.Enabled = False
        btnStartDL.Enabled = False
        btnDownloadAll.Enabled = False
        CancelAllDownloadFlag = False
        TimerUpdateTimerStatus.Enabled = False
        UpdateStatusLabel("Downloading of photos has been started. This may take some time.")
        Try
            For Each a As AlbumNameObject In listOfAlbumToDownload
                NavigateWorkerOnBackgroundThread(a.URL, a.Name, a.ReferenceDownloadedID)
            Next
            imageform.setnewImage(localdirectory) 'Get new list of photos to image viewer
        Catch ex As Exception
            UpdateStatusLabel(ex.ToString)
        End Try
        If AutoDLBoolean = True Then TimerUpdateTimerStatus.Enabled = True
        btnBrowseDir.Enabled = True
        CancelAllDownloadFlag = False
        btnDownloadAll.Enabled = True
        btnStartDL.Enabled = True
        btnDelName.Enabled = True
    End Sub
#End Region

#Region "Member and Album information"

    Private Sub LoadGPlusMembersInformation()

        Try
            Dim gplusObject As New ListGooglePlusBuilder(gugutasuJapaneseBoolean)
            UpdateStatusLabel("Retrieving Google+ members information.")
            listOfMemberData = gplusObject.retrieveListMemberData()

            Dim listTeamTemp As New List(Of String)
            For Each i As MemberData In listOfMemberData
                listTeamTemp.Add(i.Team) 'Add team data
            Next

            'Remove duplicate teams
            listTeamTemp.Sort()

            Dim index As Integer
            Dim itemcount As Integer = listTeamTemp.Count

            If itemcount > 1 Then
                Dim lastitem As String = listTeamTemp(itemcount - 1)
                For index = itemcount - 2 To 0 Step -1
                    If listTeamTemp(index) = lastitem Then
                        listTeamTemp.RemoveAt(index)
                    Else
                        lastitem = listTeamTemp(index)
                    End If
                Next
            End If

            'UI update
            chklstMembers.Items.Clear()
            For Each i As MemberData In listOfMemberData
                chklstMembers.Items.Add(i) 'Add member object
            Next
            lstTeam.Items.Clear()
            For Each i In listTeamTemp
                lstTeam.Items.Add(i)
            Next

            UpdateStatusLabel("Completed retrieving Google+ members information.")
        Catch ex As Exception
            UpdateStatusLabel(ex.ToString)
        End Try
    End Sub

    Public Function AddAlbumNameObjectToDownloadToList(ByVal chklst As CheckedListBox)

        'Check for duplicate name first (by URL so Japanese and English will be same)
        Dim skipDL As Boolean = False
        For Each i As MemberData In chklst.CheckedItems
            For Each z In lstDLName.Items
                If z.URL = i.URL Then
                    skipDL = True
                End If
            Next

            'Create new album object and add to list
            If skipDL = False Then
                integerCountAlbumToDL += 1
                Dim NewDLObj As New AlbumNameObject(i.URL, i.Name, integerCountAlbumToDL, True)
                listOfAlbumToDownload.Add(NewDLObj)
                UpdateStatusLabel("Added " + i.Name + " to album list.")
            Else
                UpdateStatusLabel(i.Name + " is already in the album list. May be you added her in different language?")
            End If
            skipDL = False
        Next

        lstDLName.Items.Clear()
        For Each i In listOfAlbumToDownload
            lstDLName.Items.Add(i)
        Next
        Return Nothing
    End Function

    Private Function SaveAlbumNameToDownloadToFile()
        Dim writestring As String = ""

        For Each i As AlbumNameObject In lstDLName.Items
            writestring += i.URL + "," + i.Name + "," + i.ReferenceDownloadedID.ToString + "," + i.AutoDLFlag.ToString + vbCrLf
        Next
        Using write As StreamWriter = New StreamWriter("url.txt")
            write.Write(writestring)
            UpdateStatusLabel("Saved member album list.")
        End Using
        Return Nothing
    End Function

    Private Sub DeleteMemberToDLFromList(ByVal lst As ListBox)
        Dim s As Integer = lst.SelectedIndex
        If lst.SelectedIndex <> -1 Then

            Dim lstalbumtodelete As New List(Of AlbumNameObject)
            For Each albumtodelete As AlbumNameObject In listOfAlbumToDownload
                If lst.SelectedItem.Equals(albumtodelete) Then
                    lstalbumtodelete.Add(albumtodelete)
                End If
            Next

            For Each l In lstalbumtodelete
                listOfAlbumToDownload.Remove(l)
            Next
            lst.Items.Remove(lstDLName.SelectedItem)
            Try
                lst.SelectedIndex = s - 1
            Catch ex As Exception
            End Try

        End If
    End Sub


#End Region

#Region "Page Loading Functions"

    Private Property pageready As Boolean = False
    Private Property WebBrowserUsing As WebBrowser
    Private Sub WaitForPageLoad(ByVal webbrowserobj As WebBrowser)
        WebBrowserUsing = webbrowserobj
        AddHandler WebBrowserUsing.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()

        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowserUsing.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowserUsing.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

#End Region

#Region "GUI"
    Private Sub btnStartDL_Click(sender As System.Object, e As System.EventArgs) Handles btnStartDL.Click
        If lstDLName.SelectedIndex <> -1 Then
            btnStartDL.Enabled = False
            btnBrowseDir.Enabled = False
            btnDownloadAll.Enabled = False
            CancelAllDownloadFlag = False
            Dim a As AlbumNameObject = lstDLName.SelectedItem
            NavigateAndDownload(a.URL, a.Name, a.ReferenceDownloadedID) 'Start operation from foreground thread for easiness
            btnDownloadAll.Enabled = True
            btnStartDL.Enabled = True
            btnBrowseDir.Enabled = True
        End If

    End Sub

    Private Sub btnLoadGPlus_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadGPlus.Click
        LoadGPlusMembersInformation()
    End Sub

    Private Sub cmbGooglePlusLanguage_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbGooglePlusLanguage.SelectedIndexChanged
        If FormLoadCompletedFlag = True Then
            If cmbGooglePlusLanguage.SelectedIndex = 0 Then
                gugutasuJapaneseBoolean = True
            Else
                gugutasuJapaneseBoolean = False
            End If
        End If

    End Sub

    Private Delegate Sub dlgUpdateUI(ByVal s As String) 'Delegate for calling Log UI from the generated thread

    Public Sub UpdateStatusLabel(ByVal s As String)
        If lstLog.InvokeRequired = True Then 'If lstLog is invoked from background thread, call it from the foreground thread instead
            Dim d As New dlgUpdateUI(AddressOf UpdateStatusLabel)
            lstLog.Invoke(d, s)
        Else
            stsLabel.Text = Date.Now.ToString + ": " + s

            If lstLog.Items.Count > 1000 Then lstLog.Items.Clear()
            lstLog.Items.Add(Date.Now.ToString + ": " + s)
            'lstLog.SetSelected(lstLog.Items.Count - 1, True)
        End If
    End Sub


    Private Sub btnAddAutoDownloadMember_Click(sender As System.Object, e As System.EventArgs) Handles btnAddAutoDownloadMember.Click
        AddAlbumNameObjectToDownloadToList(chklstMembers)
    End Sub

    Private Sub btnSaveMemberToDLList_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveMemberToDLList.Click
        SaveAlbumNameToDownloadToFile()
    End Sub

    'Delete album object from both GUI and Nested Object
    Private Sub btnDelName_Click(sender As System.Object, e As System.EventArgs) Handles btnDelName.Click
        DeleteMemberToDLFromList(lstDLName)
    End Sub

    Private Sub lstDLName_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lstDLName.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Delete) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then
            DeleteMemberToDLFromList(lstDLName)
        End If
    End Sub


    Private Sub btnBrowseDir_Click(sender As Object, e As EventArgs) Handles btnBrowseDir.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            localdirectory = FolderBrowserDialog1.SelectedPath + "\"
            txtDir.Text = localdirectory
        End If
    End Sub

    Private Sub btnStopDownload_Click(sender As Object, e As EventArgs) Handles btnStopDownload.Click
        StopDownload()
        btnStartDL.Enabled = True
        btnDownloadAll.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoLoadWhenStart.CheckedChanged
        AutoLoadWhenStart = chkAutoLoadWhenStart.Checked
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click

        For i = 0 To chklstMembers.Items.Count - 1
            chklstMembers.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btnDeselect_Click(sender As Object, e As EventArgs) Handles btnDeselect.Click

        For i = 0 To chklstMembers.Items.Count - 1
            chklstMembers.SetItemChecked(i, False)
        Next
    End Sub


    Private Sub btnClearDownloadedURL_Click(sender As Object, e As EventArgs) Handles btnClearDownloadedURL.Click
        listOfDownloadedObj.Clear()
        SavedownloadedURL()
        UpdateStatusLabel("Successfully clear list of downloaded photos. All photos will be retrieved again on the next time.")
    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click
        lstLog.Items.Clear()
        UpdateStatusLabel("Log is cleared.")
    End Sub

    Private Sub btnClearAlbum_Click(sender As Object, e As EventArgs) Handles btnClearAlbum.Click
        listOfAlbumToDownload.Clear()
        lstDLName.Items.Clear()
        SaveAlbumNameToDownloadToFile()
        UpdateStatusLabel("Successfully clear member albums list. Please add members to the list again.")
    End Sub

    Private Sub lstTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeam.SelectedIndexChanged

        If lstTeam.SelectedIndex <> -1 Then
            For i = 0 To chklstMembers.Items.Count - 1
                chklstMembers.SetItemChecked(i, False)
            Next
            For i = 0 To chklstMembers.Items.Count - 1
                Dim b As MemberData = chklstMembers.Items(i)

                If b.Team = lstTeam.SelectedItem.ToString Then
                    chklstMembers.SetItemChecked(i, True)
                End If
            Next
            UpdateStatusLabel("Team " + lstTeam.SelectedItem.ToString + "'s members are checked.")
        End If

    End Sub

    Private Sub chkAutoDownload_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoDownload.CheckedChanged
        AutoDLBoolean = chkAutoDownload.Checked
        If AutoDLBoolean = True Then
            TimerUpdateTimerStatus.Enabled = True
        Else
            TimerUpdateTimerStatus.Enabled = False
        End If
    End Sub


    Private Sub TimerUpdateTimerStatus_Tick(sender As Object, e As EventArgs) Handles TimerUpdateTimerStatus.Tick
        Dim t As String = (timeleft / 1000).ToString
        timeleft -= 1000
        If timeleft = 0 Then 'AutoDownload
            timeleft = TimerInterval
            AutoDownloader()
        End If
        lblTimer.Text = t
    End Sub

    Private Sub TimerSetter_ValueChanged(sender As Object, e As EventArgs) Handles TimerSetter.ValueChanged
        If FormLoadCompletedFlag = True Then
            TimerSetterVal = TimerSetter.Value
            TimerInterval = TimerSetter.Value * 60 * 60 * 1000
            If timeleft > TimerInterval Then
                timeleft = TimerInterval
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDownloadAll.Click
        AutoDownloader()
    End Sub


    Private Sub chkShowDownloadedPic_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowDownloadedPic.CheckedChanged
        showDownloadedPicture = chkShowDownloadedPic.Checked

    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopDownload()
        SaveAlbumNameToDownloadToFile()
        My.Settings.strDirToSave = localdirectory
        My.Settings.boolAutoLoadWhenStart = AutoLoadWhenStart
        My.Settings.boolGplusJP = gugutasuJapaneseBoolean
        My.Settings.intTimerInterval = TimerInterval
        My.Settings.boolAutoDL = AutoDLBoolean
        My.Settings.intTimerSetterVal = TimerSetterVal
        My.Settings.boolShowPicture = showDownloadedPicture
        My.Settings.boolCombineDir = CombineDir
        My.Settings.Save()

    End Sub


    Private Sub chkCombineDir_CheckedChanged(sender As Object, e As EventArgs) Handles chkCombineDir.CheckedChanged
        CombineDir = chkCombineDir.Checked
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        panelAdmin.Visible = True
    End Sub

    Private Sub btnManualDL_Click(sender As Object, e As EventArgs) Handles btnManualDL.Click
        NavigateAndDownload(txtManualURL.Text, txtManualName.Text, 0)
    End Sub

    ''' <summary>
    ''' Open image form and play fullscreen picturess
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFullscreen_Click_1(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        imageform.Show()
        imageform.createPhotoList(localdirectory, nmrSlideshowSecond.Value, chkSlideshowShuffle.Checked)
    End Sub


    Private Sub btnSelectStaff_Click(sender As Object, e As EventArgs) Handles btnSelectStaff.Click
        StaffMember.Show()
    End Sub
#End Region

End Class
