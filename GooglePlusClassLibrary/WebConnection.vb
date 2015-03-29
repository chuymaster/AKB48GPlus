Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

''' <summary>
''' WebConnection downloader class
''' </summary>
''' <remarks></remarks>
Public Class WebConnection
    ' Dim WebBr As WebBrowser
    Dim remotefilename As Uri
    ''' <summary>
    ''' Directory and file name to save
    ''' </summary>
    ''' <remarks></remarks>
    Public Property fullDirFilename As String
    ''' <summary>
    ''' Name of set member, available to public
    ''' </summary>
    ''' <remarks></remarks>
    Public Property publicname As String
    ''' <summary>
    ''' Name of saved file, available to public
    ''' </summary>
    ''' <remarks></remarks>
    Public Property publicfilename As String

    ''' <summary>
    ''' Constructor for WebConnection downloader class
    ''' </summary>
    ''' <param name="remote">URL of photo</param>
    ''' <param name="dir">full directory and file name to save</param>
    ''' <param name="publicn">member name</param>
    ''' <param name="publicf">file name</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal remote As Uri, ByVal dir As String, ByVal publicn As String, ByVal publicf As String)
        remotefilename = remote
        fullDirFilename = dir
        publicname = publicn
        publicfilename = publicf
    End Sub

#Region "Use cookie and DL file"

    Public Function DownloadFile() As Boolean
        Try
            Dim webRequest As HttpWebRequest = Net.WebRequest.Create(remotefilename)
            Dim bytesProcessed As Integer = 0
            Dim remoteStream As Stream
            Dim localStream As Stream
            Dim response As WebResponse

            response = webRequest.GetResponse()
            If Not response Is Nothing Then
                remoteStream = response.GetResponseStream()
                localStream = File.Create(fullDirFilename)

                'Declare buffer as byte array
                Dim myBuffer As Byte()
                'Byte array initialization 
                ReDim myBuffer(1024)


                Dim bytesRead As Integer
                bytesRead = remoteStream.Read(myBuffer, 0, 1024)
                Do While (bytesRead > 0)
                    localStream.Write(myBuffer, 0, bytesRead)
                    bytesProcessed += bytesRead
                    bytesRead = remoteStream.Read(myBuffer, 0, 1024)
                Loop
                localStream.Close()
                'RecordDownloadedFiles(remoteFilename.ToString)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ErrorRecord(ex.ToString)
            Return False
        End Try

    End Function

    Private Sub RecordDownloadedFiles(ByVal remotefilesname As String)
        Dim destination As String = "loadedfiles.txt"
        Dim objWriter As New System.IO.StreamWriter(destination, True)
        objWriter.WriteLine(remotefilesname)
        objWriter.Close()

    End Sub

    Private Sub ErrorRecord(ByVal rec As String)
        'MessageBox.Show(rec)
        Dim destination As String = "Errors.txt"
        Dim objWriter As New System.IO.StreamWriter(destination, True)
        objWriter.WriteLine(Date.Now.Year.ToString + "/" + Date.Now.Month.ToString + "/" + Date.Now.Day.ToString + " " + Date.Now.Hour.ToString + ":" + Date.Now.Minute.ToString)
        objWriter.WriteLine(rec)
        objWriter.Close()

    End Sub

#End Region


End Class
