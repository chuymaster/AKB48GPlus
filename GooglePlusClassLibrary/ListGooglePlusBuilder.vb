Imports System.Text.RegularExpressions
Imports GooglePlusClassLibrary.CustomObjects
Imports System.Web
Imports System.Net
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class ListGooglePlusBuilder
    Private listMemberData As List(Of MemberData)
    Private navigateUrl As String
    Private gugutasuJapaneseBoolean As Boolean

    Public Sub New(ByVal gJP As Boolean)
        navigateUrl = "http://www.google.com/intl/ja/+/project48/"
        gugutasuJapaneseBoolean = gJP
    End Sub

    ''' <summary>
    ''' Retrieve URLs from Google+ Project 48 portal page
    ''' and return List of MemberData
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function retrieveListMemberData() As List(Of MemberData)

        'Dim webClient As New System.Net.WebClient
        'webClient.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
        'Dim html = webClient.DownloadString("http://www.google.com/intl/ja/+/project48/").ToString

        'Using d As StreamWriter = New StreamWriter("48.html", False, System.Text.Encoding.GetEncoding("UTF-8")
        '                                           )
        '    d.Write(html)
        '    d.Close()
        'End Using

        listMemberData = New List(Of MemberData)

        Dim wb As WebBrowser = New WebBrowser
        wb.Navigate(navigateUrl)

        While wb.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        End While

        'Get content inside <li>, <a>: member team and url and name
        Dim li = wb.Document.GetElementById("contents").GetElementsByTagName("li")
        Dim ahref = wb.Document.GetElementById("contents").GetElementsByTagName("a")
        For i = 0 To li.Count - 1
            Try

                Dim l = li(i)
                'Split at "
                Dim tempAhrefData() = l.OuterHtml.Split(Chr(34))

                'Get URL (a href)
                Dim a = ahref(i)
                'Find split data where "data-team" exists and +1 to an index to get Team Name
                'Get Team Name and correction of it *Make Big character, none=未定, kenkyusei=研究生
                Dim noOfTeamName As Integer = 5
                For z = 0 To tempAhrefData.Length - 1
                    If tempAhrefData(z).Contains("data-team") Then
                        noOfTeamName = z + 1
                        Exit For
                    End If
                Next
                Dim teamname = tempAhrefData(noOfTeamName)
                teamname = teamname.ToUpper

                Dim obj As MemberData
                If gugutasuJapaneseBoolean = True Then
                    If teamname = "" Then teamname = "未定"
                    If teamname.Contains("KENKYUSEI") Then teamname = teamname.Replace("KENKYUSEI", "研究生")
                    'Dim aa() = a.OuterHtml.Split(Chr(34))

                    ''Find split data where "name" exists and +1 to an index to get Member name in Kanji
                    'Dim noOfMemberName As Integer = 5
                    'For z = 0 To aa.Length - 1
                    '    If aa(z).Contains("name") Then
                    '        noOfMemberName = z + 1
                    '        Exit For
                    '    End If
                    'Next
                    'Dim nameFieldinjapanese As String = aa(noOfMemberName)
                    'Dim nameinjapanese As String = ""
                    'If nameFieldinjapanese.Contains("<") Then
                    '    nameinjapanese = nameFieldinjapanese.Split("<")(1).Split(">")(1).Replace(" ", "")

                    'Else
                    '    nameinjapanese = nameFieldinjapanese
                    'End If

                    'obj = New MemberData(nameinjapanese, a.DomElement.href, teamname)
                    obj = New MemberData(a.OuterText, a.DomElement.href, teamname)
                Else 'If English is selected, get english name
                    If teamname = "" Then teamname = "Undecided"
                    Dim aa()
                    aa = a.OuterHtml.Split(Chr(34))

                    'Find split data where "data-g-label" exists and +1 to an index to get Member name in English
                    Dim noOfMemberName As Integer = 5
                    For z = 0 To aa.Length - 1
                        If aa(z).Contains("data-g-label") Then
                            noOfMemberName = z + 1
                            Exit For
                        End If
                    Next
                    Dim nameinenglish As String = aa(noOfMemberName)
                    obj = New MemberData(nameinenglish, a.DomElement.href, teamname)
                End If

                listMemberData.Add(obj)

            Catch ex As Exception
                Continue For
            End Try
        Next

        Return listMemberData
    End Function


End Class
