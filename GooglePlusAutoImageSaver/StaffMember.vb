Imports GooglePlusClassLibrary.CustomObjects


Public Class StaffMember
    Private lstStaff As New List(Of MemberData)

    Private Sub StaffMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildStaffList()

    End Sub

    Private Sub BuildStaffList()
        Dim staff As MemberData

        Dim dataString(10) As Array
        dataString(0) = {"Akimoto Yasushi", "113474433041552257864", "Staff"}
        dataString(1) = {"Togasaki Tomonobu", "103388469578205010447", "Staff"}
        dataString(2) = {"Yuasa Hiroshi", "103959130721189812017", "Staff"}
        dataString(3) = {"Kaneko Tsuyoshi", "103350333579457321452", "Staff"}
        dataString(4) = {"Shiba Tomoya", "101698755652225940459", "Staff"}
        dataString(5) = {"Ozaki Mitsuru", "116932464999954700023", "Staff"}
        dataString(6) = {"Kayano Shinobu", "112435502021367429566", "Staff"}
        dataString(7) = {"Kijima Mori", "113091703821013997975", "Staff"}
        dataString(8) = {"Nishiyama Kyoko", "111110869630425643279", "Staff"}
        dataString(9) = {"Satou Kazuya", "117905992285697890829", "Staff"}

        For i = 0 To 9 Step 1
            staff = New MemberData(dataString(i)(0),
                                   "https://plus.google.com/" + dataString(i)(1) + "/posts",
                                   dataString(i)(2))
            lstStaff.Add(staff)
        Next

        For Each i In lstStaff
            chklstStaffMember.Items.Add(i)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Form1.AddAlbumNameObjectToDownloadToList(chklstStaffMember)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        For i = 0 To chklstStaffMember.Items.Count - 1
            chklstStaffMember.SetItemChecked(i, True)
        Next
        Form1.AddAlbumNameObjectToDownloadToList(chklstStaffMember)
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class