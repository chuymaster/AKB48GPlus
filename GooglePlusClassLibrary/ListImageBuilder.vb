Imports System.Text.RegularExpressions
Imports GooglePlusClassLibrary.CustomObjects
Imports System.IO


''' <summary>
''' Build image url and name to save from each member's google+
''' </summary>
''' <remarks></remarks>
Public Class ListImageBuilder

    Private listOfImageObject As New List(Of ImageObject)
    Private navigateUrl As String

    Public Sub New(ByVal navigateUrl As String)
        Me.navigateUrl = navigateUrl
    End Sub

    Public Function ListImageBuild() As List(Of ImageObject)

        Dim webClient As New System.Net.WebClient
        webClient.Encoding = System.Text.Encoding.UTF8
        Dim html = webClient.DownloadString(navigateUrl).ToString

        Dim listSources0d As New List(Of String)
        Dim listPosturl As New List(Of String)
        Dim listPassage As New List(Of String)
        Dim ww As String() = html.Split("[") 'Split at [, which is the beginning of any image tag. e.g. ["https://picasaweb.google.com/105015705151101532017/20130121#5835835592460140978",1,["https://lh6.googleusercontent.com/-3Bq2Z1c_gKE/UP0NjUArAbI/AAAAAAABZRI/DSbK89Z7d1s/s0-d/21%2B-%2B1",768,1024]
        Dim listSplitHTML As List(Of String) = New List(Of String)
        For Each item In ww
            listSplitHTML.Add(item)
        Next

        For Each d In listSplitHTML 'Check each split string if containing s0-d
            If d.Contains("s0-d") Then 'Get only full-size image, containing s0-d
                Dim y As String() = d.Split(Chr(34)) 'Split " away to get only image URL
                If y.Length = 3 Then
                    If y(1) IsNot Nothing And y(1).Contains("s0-d") Then 'Check for s0-d tag again
                        Dim duplicateds0dFlag As Boolean = False ' Check if this url is duplicated or not
                        For Each s0ditem In listSources0d
                            If s0ditem.Contains(y(1)) Then
                                duplicateds0dFlag = True
                            End If
                        Next
                        If duplicateds0dFlag = False Then listSources0d.Add(y(1)) 'Add pure image URL to the list
                    End If
                End If
            End If

            'Find post URL of the photo to generate name for image
            ' Add text posted by member
            Dim l() As String = navigateUrl.Split("/")
            If d.Contains(l(4)) And d.Contains("http") Then 'Check for member ID and http link
                Dim z() As String = d.Split(Chr(34)) 'Split " away
                If z.Length = 3 And z(1).Contains("timedtext") = False Then
                    listPosturl.Add(z(1))

                    'Add member's post message to the list
                    Dim passagePosted As String
                    Try
                        passagePosted =
                        listSplitHTML(listSplitHTML.IndexOf(d) + 2).Split(Chr(34))(1)
                    Catch ex As Exception
                        passagePosted = ""
                    End Try
                    listPassage.Add(passagePosted)
                End If

            End If
        Next

        For i = 0 To listSources0d.Count - 1
            listOfImageObject.Add(New ImageObject(listSources0d(i), listPosturl(i), listPassage(i)))
        Next

        'Debug(html, Listsources0d, listSplitHTML)
        Return listOfImageObject

    End Function

    Private Sub Debug(html As String, l1 As List(Of String), l2 As List(Of String))


        Using d As StreamWriter = New StreamWriter("1.html", False, System.Text.Encoding.GetEncoding("UTF-8")
                                                   )
            d.Write(html)
            d.Close()
        End Using

        'For debugging; export list of source image file and list of date posted to txt file
        Dim i As Integer = 1
        Using s As New StreamWriter("s0d.txt")
            For Each ss In l1
                s.WriteLine(i.ToString & " " & ss)
                i += 1
            Next
        End Using
        i = 1
        Using s As New StreamWriter("posturl.txt")
            For Each ss In l2
                s.WriteLine(i.ToString & " " & ss)
                i += 1
            Next
        End Using

    End Sub


End Class
