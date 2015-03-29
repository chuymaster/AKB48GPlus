Imports System.IO

Public Class imageform

    Private Sub imageform_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Space) Then
            ShowNextImage()
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Me.Close()
        End If
        
    End Sub

    Dim imagelist As New List(Of String)
    Dim images() As String
    Dim slideshowInterval As Integer = 5
    Dim shuffleSlide As Boolean = True
    Dim slideshowCount As Integer = 0

    Public Sub createPhotoList(ByVal dir As String, ByVal interval As Integer, ByVal shuffle As Boolean)
        Try
            images = Directory.GetFiles(dir, "*.jpg", SearchOption.AllDirectories)
            slideshowInterval = interval
            shuffleSlide = shuffle
            If images.Count > 0 Then
                Dim randomimgnumber As Integer = Rnd() * images.Count
                imageBoxFull.ImageLocation = images(randomimgnumber)
                timerShowpic.Interval = interval * 1000
                timerShowpic.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Me.Close()

        End Try
    End Sub

    Private Sub timerShowpic_Tick(sender As Object, e As EventArgs) Handles timerShowpic.Tick
        ShowNextImage()

    End Sub

    Public Sub setnewImage(ByVal dir As String)
        images = Directory.GetFiles(dir, "*.jpg", SearchOption.AllDirectories)
    End Sub

    Private Sub imageform_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        slideshowCount = 0
    End Sub

    Private Sub ShowNextImage()
        If shuffleSlide = True Then
            Dim randomimgnumber As Integer = Rnd() * images.Count
            imageBoxFull.ImageLocation = images(randomimgnumber)
        Else
            imageBoxFull.ImageLocation = images(slideshowCount)
            slideshowCount += 1
        End If

    End Sub

End Class