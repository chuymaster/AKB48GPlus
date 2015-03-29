<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDownloadAll = New System.Windows.Forms.Button()
        Me.btnDelName = New System.Windows.Forms.Button()
        Me.btnSaveMemberToDLList = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnStopDownload = New System.Windows.Forms.Button()
        Me.btnStartDL = New System.Windows.Forms.Button()
        Me.lstDLName = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chklstMembers = New System.Windows.Forms.CheckedListBox()
        Me.btnAddAutoDownloadMember = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSelectStaff = New System.Windows.Forms.Button()
        Me.btnDeselect = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstTeam = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkCombineDir = New System.Windows.Forms.CheckBox()
        Me.chkShowDownloadedPic = New System.Windows.Forms.CheckBox()
        Me.chkAutoDownload = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.TimerSetter = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLoadGPlus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbGooglePlusLanguage = New System.Windows.Forms.ComboBox()
        Me.btnBrowseDir = New System.Windows.Forms.Button()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkAutoLoadWhenStart = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstLog = New System.Windows.Forms.ListBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nmrSlideshowSecond = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkSlideshowShuffle = New System.Windows.Forms.CheckBox()
        Me.btnFullscreen = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClearAlbum = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClearDownloadedURL = New System.Windows.Forms.Button()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.panelAdmin = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtManualName = New System.Windows.Forms.TextBox()
        Me.btnManualDL = New System.Windows.Forms.Button()
        Me.txtManualURL = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerUpdateTimerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        CType(Me.pictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel5.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.Panel3.SuspendLayout
        CType(Me.TimerSetter,System.ComponentModel.ISupportInitialize).BeginInit
        Me.StatusStrip1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.Panel7.SuspendLayout
        CType(Me.nmrSlideshowSecond,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel6.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.panelAdmin.SuspendLayout
        Me.SuspendLayout
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 562)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.StatusStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 536)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Control Panel"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.pictureBox)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(365, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 415)
        Me.Panel1.TabIndex = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(13, 288)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(87, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = false
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
            Or System.Windows.Forms.Keys.T),System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(79, 20)
        Me.ToolStripMenuItem1.Text = "menuShow"
        '
        'pictureBox
        '
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.ImageLocation = ""
        Me.pictureBox.Location = New System.Drawing.Point(0, 269)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(408, 146)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox.TabIndex = 30
        Me.pictureBox.TabStop = false
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.btnDownloadAll)
        Me.Panel5.Controls.Add(Me.btnDelName)
        Me.Panel5.Controls.Add(Me.btnSaveMemberToDLList)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.btnStopDownload)
        Me.Panel5.Controls.Add(Me.btnStartDL)
        Me.Panel5.Controls.Add(Me.lstDLName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(408, 269)
        Me.Panel5.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(3, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Last picture downloaded:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Album List to be downloaded"
        '
        'btnDownloadAll
        '
        Me.btnDownloadAll.Location = New System.Drawing.Point(266, 62)
        Me.btnDownloadAll.Name = "btnDownloadAll"
        Me.btnDownloadAll.Size = New System.Drawing.Size(124, 36)
        Me.btnDownloadAll.TabIndex = 31
        Me.btnDownloadAll.Text = "Download ALL in album list"
        Me.btnDownloadAll.UseVisualStyleBackColor = true
        '
        'btnDelName
        '
        Me.btnDelName.Location = New System.Drawing.Point(266, 155)
        Me.btnDelName.Name = "btnDelName"
        Me.btnDelName.Size = New System.Drawing.Size(124, 31)
        Me.btnDelName.TabIndex = 14
        Me.btnDelName.Text = "Delete Selected"
        Me.btnDelName.UseVisualStyleBackColor = true
        '
        'btnSaveMemberToDLList
        '
        Me.btnSaveMemberToDLList.Location = New System.Drawing.Point(266, 190)
        Me.btnSaveMemberToDLList.Name = "btnSaveMemberToDLList"
        Me.btnSaveMemberToDLList.Size = New System.Drawing.Size(124, 27)
        Me.btnSaveMemberToDLList.TabIndex = 10
        Me.btnSaveMemberToDLList.Text = "Save List"
        Me.btnSaveMemberToDLList.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(11, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(359, 26)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Warning: Adding too many members into album list will cause the download"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"time to"& _ 
    " be very long. The program may not response for a while."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnStopDownload
        '
        Me.btnStopDownload.Location = New System.Drawing.Point(266, 104)
        Me.btnStopDownload.Name = "btnStopDownload"
        Me.btnStopDownload.Size = New System.Drawing.Size(126, 26)
        Me.btnStopDownload.TabIndex = 20
        Me.btnStopDownload.Text = "Stop Downloading"
        Me.btnStopDownload.UseVisualStyleBackColor = true
        '
        'btnStartDL
        '
        Me.btnStartDL.Location = New System.Drawing.Point(272, 8)
        Me.btnStartDL.Name = "btnStartDL"
        Me.btnStartDL.Size = New System.Drawing.Size(107, 48)
        Me.btnStartDL.TabIndex = 1
        Me.btnStartDL.Text = "Download selected member"
        Me.btnStartDL.UseVisualStyleBackColor = true
        '
        'lstDLName
        '
        Me.lstDLName.FormattingEnabled = true
        Me.lstDLName.Location = New System.Drawing.Point(5, 18)
        Me.lstDLName.Name = "lstDLName"
        Me.lstDLName.Size = New System.Drawing.Size(251, 199)
        Me.lstDLName.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 415)
        Me.Panel2.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chklstMembers)
        Me.GroupBox1.Controls.Add(Me.btnAddAutoDownloadMember)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 219)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Member List"
        '
        'chklstMembers
        '
        Me.chklstMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chklstMembers.FormattingEnabled = true
        Me.chklstMembers.Location = New System.Drawing.Point(3, 16)
        Me.chklstMembers.Name = "chklstMembers"
        Me.chklstMembers.Size = New System.Drawing.Size(356, 177)
        Me.chklstMembers.TabIndex = 11
        '
        'btnAddAutoDownloadMember
        '
        Me.btnAddAutoDownloadMember.BackColor = System.Drawing.Color.Yellow
        Me.btnAddAutoDownloadMember.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAddAutoDownloadMember.Location = New System.Drawing.Point(3, 193)
        Me.btnAddAutoDownloadMember.Name = "btnAddAutoDownloadMember"
        Me.btnAddAutoDownloadMember.Size = New System.Drawing.Size(356, 23)
        Me.btnAddAutoDownloadMember.TabIndex = 9
        Me.btnAddAutoDownloadMember.Text = "Add checked members to album list"
        Me.btnAddAutoDownloadMember.UseVisualStyleBackColor = false
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(362, 196)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSelectStaff)
        Me.Panel4.Controls.Add(Me.btnDeselect)
        Me.Panel4.Controls.Add(Me.btnSelectAll)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(359, 213)
        Me.Panel4.TabIndex = 22
        '
        'btnSelectStaff
        '
        Me.btnSelectStaff.Location = New System.Drawing.Point(6, 139)
        Me.btnSelectStaff.Name = "btnSelectStaff"
        Me.btnSelectStaff.Size = New System.Drawing.Size(193, 23)
        Me.btnSelectStaff.TabIndex = 31
        Me.btnSelectStaff.Text = "Select Staffs"
        Me.btnSelectStaff.UseVisualStyleBackColor = true
        '
        'btnDeselect
        '
        Me.btnDeselect.Location = New System.Drawing.Point(227, 153)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(123, 22)
        Me.btnDeselect.TabIndex = 10
        Me.btnDeselect.Text = "Deselect All"
        Me.btnDeselect.UseVisualStyleBackColor = true
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(6, 165)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(193, 22)
        Me.btnSelectAll.TabIndex = 9
        Me.btnSelectAll.Text = "Select All Members"
        Me.btnSelectAll.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstTeam)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 132)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Select Team to be checked"
        '
        'lstTeam
        '
        Me.lstTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTeam.FormattingEnabled = true
        Me.lstTeam.Location = New System.Drawing.Point(3, 16)
        Me.lstTeam.Name = "lstTeam"
        Me.lstTeam.Size = New System.Drawing.Size(344, 113)
        Me.lstTeam.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkCombineDir)
        Me.Panel3.Controls.Add(Me.chkShowDownloadedPic)
        Me.Panel3.Controls.Add(Me.chkAutoDownload)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblTimer)
        Me.Panel3.Controls.Add(Me.TimerSetter)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.btnLoadGPlus)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cmbGooglePlusLanguage)
        Me.Panel3.Controls.Add(Me.btnBrowseDir)
        Me.Panel3.Controls.Add(Me.txtDir)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.chkAutoLoadWhenStart)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(770, 93)
        Me.Panel3.TabIndex = 24
        '
        'chkCombineDir
        '
        Me.chkCombineDir.AutoSize = true
        Me.chkCombineDir.Location = New System.Drawing.Point(191, 76)
        Me.chkCombineDir.Name = "chkCombineDir"
        Me.chkCombineDir.Size = New System.Drawing.Size(168, 17)
        Me.chkCombineDir.TabIndex = 30
        Me.chkCombineDir.Text = "Save photos in same directory"
        Me.chkCombineDir.UseVisualStyleBackColor = true
        '
        'chkShowDownloadedPic
        '
        Me.chkShowDownloadedPic.AutoSize = true
        Me.chkShowDownloadedPic.Location = New System.Drawing.Point(191, 54)
        Me.chkShowDownloadedPic.Name = "chkShowDownloadedPic"
        Me.chkShowDownloadedPic.Size = New System.Drawing.Size(280, 17)
        Me.chkShowDownloadedPic.TabIndex = 29
        Me.chkShowDownloadedPic.Text = "Show downloaded pictures (Disable if your PC is slow)"
        Me.chkShowDownloadedPic.UseVisualStyleBackColor = true
        '
        'chkAutoDownload
        '
        Me.chkAutoDownload.AutoSize = true
        Me.chkAutoDownload.Location = New System.Drawing.Point(191, 30)
        Me.chkAutoDownload.Name = "chkAutoDownload"
        Me.chkAutoDownload.Size = New System.Drawing.Size(132, 17)
        Me.chkAutoDownload.TabIndex = 25
        Me.chkAutoDownload.Text = "Auto download photos"
        Me.chkAutoDownload.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(729, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "hours"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = true
        Me.lblTimer.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTimer.Location = New System.Drawing.Point(660, 66)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(12, 12)
        Me.lblTimer.TabIndex = 28
        Me.lblTimer.Text = "0"
        '
        'TimerSetter
        '
        Me.TimerSetter.Location = New System.Drawing.Point(677, 30)
        Me.TimerSetter.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.TimerSetter.Name = "TimerSetter"
        Me.TimerSetter.Size = New System.Drawing.Size(46, 20)
        Me.TimerSetter.TabIndex = 22
        Me.TimerSetter.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(719, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "seconds"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLoadGPlus
        '
        Me.btnLoadGPlus.Location = New System.Drawing.Point(32, 38)
        Me.btnLoadGPlus.Name = "btnLoadGPlus"
        Me.btnLoadGPlus.Size = New System.Drawing.Size(123, 41)
        Me.btnLoadGPlus.TabIndex = 4
        Me.btnLoadGPlus.Text = "Load G+ List"
        Me.btnLoadGPlus.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(359, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Check and download photos of members in album list every:"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(511, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Time until auto download:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Google+ Language"
        '
        'cmbGooglePlusLanguage
        '
        Me.cmbGooglePlusLanguage.FormattingEnabled = true
        Me.cmbGooglePlusLanguage.Items.AddRange(New Object() {"日本語", "English"})
        Me.cmbGooglePlusLanguage.Location = New System.Drawing.Point(108, 5)
        Me.cmbGooglePlusLanguage.Name = "cmbGooglePlusLanguage"
        Me.cmbGooglePlusLanguage.Size = New System.Drawing.Size(77, 21)
        Me.cmbGooglePlusLanguage.TabIndex = 12
        Me.cmbGooglePlusLanguage.Text = "日本語"
        '
        'btnBrowseDir
        '
        Me.btnBrowseDir.Font = New System.Drawing.Font("MS UI Gothic", 7!)
        Me.btnBrowseDir.Location = New System.Drawing.Point(703, 3)
        Me.btnBrowseDir.Name = "btnBrowseDir"
        Me.btnBrowseDir.Size = New System.Drawing.Size(53, 25)
        Me.btnBrowseDir.TabIndex = 19
        Me.btnBrowseDir.Text = "Browse"
        Me.btnBrowseDir.UseVisualStyleBackColor = true
        '
        'txtDir
        '
        Me.txtDir.Enabled = false
        Me.txtDir.Location = New System.Drawing.Point(446, 5)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(250, 20)
        Me.txtDir.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(404, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "DL dir:"
        '
        'chkAutoLoadWhenStart
        '
        Me.chkAutoLoadWhenStart.AutoSize = true
        Me.chkAutoLoadWhenStart.Location = New System.Drawing.Point(191, 5)
        Me.chkAutoLoadWhenStart.Name = "chkAutoLoadWhenStart"
        Me.chkAutoLoadWhenStart.Size = New System.Drawing.Size(160, 17)
        Me.chkAutoLoadWhenStart.TabIndex = 17
        Me.chkAutoLoadWhenStart.Text = "Auto load G+ list when starts"
        Me.chkAutoLoadWhenStart.UseVisualStyleBackColor = true
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 511)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(770, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusBar"
        '
        'stsLabel
        '
        Me.stsLabel.Name = "stsLabel"
        Me.stsLabel.Size = New System.Drawing.Size(0, 17)
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstLog)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 536)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Picture Player & Log"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'lstLog
        '
        Me.lstLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLog.FormattingEnabled = true
        Me.lstLog.HorizontalScrollbar = true
        Me.lstLog.Location = New System.Drawing.Point(3, 60)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.ScrollAlwaysVisible = true
        Me.lstLog.Size = New System.Drawing.Size(770, 429)
        Me.lstLog.TabIndex = 16
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.nmrSlideshowSecond)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.chkSlideshowShuffle)
        Me.Panel7.Controls.Add(Me.btnFullscreen)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(770, 57)
        Me.Panel7.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Location = New System.Drawing.Point(489, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "seconds"
        '
        'nmrSlideshowSecond
        '
        Me.nmrSlideshowSecond.Location = New System.Drawing.Point(437, 15)
        Me.nmrSlideshowSecond.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrSlideshowSecond.Name = "nmrSlideshowSecond"
        Me.nmrSlideshowSecond.Size = New System.Drawing.Size(46, 20)
        Me.nmrSlideshowSecond.TabIndex = 36
        Me.nmrSlideshowSecond.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(388, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Interval"
        '
        'chkSlideshowShuffle
        '
        Me.chkSlideshowShuffle.AutoSize = true
        Me.chkSlideshowShuffle.Checked = true
        Me.chkSlideshowShuffle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSlideshowShuffle.Location = New System.Drawing.Point(322, 17)
        Me.chkSlideshowShuffle.Name = "chkSlideshowShuffle"
        Me.chkSlideshowShuffle.Size = New System.Drawing.Size(59, 17)
        Me.chkSlideshowShuffle.TabIndex = 35
        Me.chkSlideshowShuffle.Text = "Shuffle"
        Me.chkSlideshowShuffle.UseVisualStyleBackColor = true
        '
        'btnFullscreen
        '
        Me.btnFullscreen.Location = New System.Drawing.Point(554, 3)
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(129, 49)
        Me.btnFullscreen.TabIndex = 34
        Me.btnFullscreen.Text = "Start playing fullscreen slideshow"
        Me.btnFullscreen.UseVisualStyleBackColor = true
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnClearAlbum)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.btnClearDownloadedURL)
        Me.Panel6.Controls.Add(Me.btnClearLog)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 489)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(770, 44)
        Me.Panel6.TabIndex = 17
        '
        'btnClearAlbum
        '
        Me.btnClearAlbum.Location = New System.Drawing.Point(640, 7)
        Me.btnClearAlbum.Name = "btnClearAlbum"
        Me.btnClearAlbum.Size = New System.Drawing.Size(125, 35)
        Me.btnClearAlbum.TabIndex = 5
        Me.btnClearAlbum.Text = "Clear Member List"
        Me.btnClearAlbum.UseVisualStyleBackColor = true
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(293, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(309, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "All photos will be retrieved again if you clear the downloaded list."
        '
        'btnClearDownloadedURL
        '
        Me.btnClearDownloadedURL.Location = New System.Drawing.Point(118, 7)
        Me.btnClearDownloadedURL.Name = "btnClearDownloadedURL"
        Me.btnClearDownloadedURL.Size = New System.Drawing.Size(169, 35)
        Me.btnClearDownloadedURL.TabIndex = 3
        Me.btnClearDownloadedURL.Text = "Clear downloaded photo list"
        Me.btnClearDownloadedURL.UseVisualStyleBackColor = true
        '
        'btnClearLog
        '
        Me.btnClearLog.Location = New System.Drawing.Point(5, 7)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(107, 35)
        Me.btnClearLog.TabIndex = 2
        Me.btnClearLog.Text = "Clear Log"
        Me.btnClearLog.UseVisualStyleBackColor = true
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblVersion)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.panelAdmin)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 536)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Help"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = true
        Me.lblVersion.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblVersion.Location = New System.Drawing.Point(707, 18)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(51, 13)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "0.0.0.0"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(655, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Version:"
        '
        'panelAdmin
        '
        Me.panelAdmin.Controls.Add(Me.Label13)
        Me.panelAdmin.Controls.Add(Me.Label12)
        Me.panelAdmin.Controls.Add(Me.txtManualName)
        Me.panelAdmin.Controls.Add(Me.btnManualDL)
        Me.panelAdmin.Controls.Add(Me.txtManualURL)
        Me.panelAdmin.Location = New System.Drawing.Point(467, 395)
        Me.panelAdmin.Name = "panelAdmin"
        Me.panelAdmin.Size = New System.Drawing.Size(303, 119)
        Me.panelAdmin.TabIndex = 1
        Me.panelAdmin.Visible = false
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(36, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(43, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "URL"
        '
        'txtManualName
        '
        Me.txtManualName.Location = New System.Drawing.Point(76, 50)
        Me.txtManualName.Name = "txtManualName"
        Me.txtManualName.Size = New System.Drawing.Size(205, 20)
        Me.txtManualName.TabIndex = 2
        '
        'btnManualDL
        '
        Me.btnManualDL.Location = New System.Drawing.Point(135, 75)
        Me.btnManualDL.Name = "btnManualDL"
        Me.btnManualDL.Size = New System.Drawing.Size(75, 25)
        Me.btnManualDL.TabIndex = 1
        Me.btnManualDL.Text = "DL!"
        Me.btnManualDL.UseVisualStyleBackColor = true
        '
        'txtManualURL
        '
        Me.txtManualURL.Location = New System.Drawing.Point(76, 23)
        Me.txtManualURL.Name = "txtManualURL"
        Me.txtManualURL.Size = New System.Drawing.Size(205, 20)
        Me.txtManualURL.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(8, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(632, 494)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = resources.GetString("Label11.Text")
        '
        'TimerUpdateTimerStatus
        '
        Me.TimerUpdateTimerStatus.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "AKB48 Google+ Auto Image Saver"
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.pictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel5.ResumeLayout(false)
        Me.Panel5.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        CType(Me.TimerSetter,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.TabPage1.ResumeLayout(false)
        Me.Panel7.ResumeLayout(false)
        Me.Panel7.PerformLayout
        CType(Me.nmrSlideshowSecond,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel6.ResumeLayout(false)
        Me.Panel6.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.panelAdmin.ResumeLayout(false)
        Me.panelAdmin.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstDLName As System.Windows.Forms.ListBox
    Friend WithEvents btnStartDL As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnLoadGPlus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddAutoDownloadMember As System.Windows.Forms.Button
    Friend WithEvents btnSaveMemberToDLList As System.Windows.Forms.Button
    Friend WithEvents cmbGooglePlusLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents chklstMembers As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelName As System.Windows.Forms.Button
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents lstLog As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkAutoLoadWhenStart As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowseDir As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnStopDownload As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TimerSetter As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkAutoDownload As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TimerUpdateTimerStatus As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnDownloadAll As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chkShowDownloadedPic As System.Windows.Forms.CheckBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnClearDownloadedURL As System.Windows.Forms.Button
    Friend WithEvents btnClearLog As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClearAlbum As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents chkCombineDir As System.Windows.Forms.CheckBox
    Friend WithEvents panelAdmin As System.Windows.Forms.Panel
    Friend WithEvents btnManualDL As System.Windows.Forms.Button
    Friend WithEvents txtManualURL As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtManualName As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnFullscreen As System.Windows.Forms.Button
    Friend WithEvents chkSlideshowShuffle As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents nmrSlideshowSecond As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSelectStaff As System.Windows.Forms.Button
    Friend WithEvents btnDeselect As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTeam As System.Windows.Forms.ListBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

End Class
