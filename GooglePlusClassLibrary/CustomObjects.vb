Namespace CustomObjects

    ''' <summary>
    ''' An item for inserting into Member ListBox with Text and Tag properties.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class AlbumNameObject

        Public URL As String
        Public Name As String
        Public ReferenceDownloadedID As Integer
        Public AutoDLFlag As Boolean

        Public Overrides Function ToString() As String
            Return Me.Name
        End Function

        Public Sub New(ByVal theURL As String, ByVal theName As String, ByVal ID As Integer, ByVal flag As Boolean)
            URL = theURL
            Name = theName
            ReferenceDownloadedID = ID
            AutoDLFlag = flag
        End Sub

    End Class

    Public Class DownloadedObject

        Public URL As String
        Public ReferenceNameID As Integer

        Public Overrides Function ToString() As String
            Return Me.URL
        End Function

        Public Sub New(ByVal imgURL As String, ByVal ID As Integer)
            URL = imgURL
            ReferenceNameID = ID
        End Sub

    End Class

    ''' <summary>
    ''' Member data from google plus url.
    ''' Name/Photo from posts URL/Team/Google+ ID number
    ''' </summary>
    ''' <remarks></remarks>
    Public Class MemberData
        Public Name As String
        Public URL As String
        Public Team As String
        Public ID As String

        Public Overrides Function ToString() As String
            Return Me.Name
        End Function

        Public Sub New(ByVal n As String, ByVal u As String, ByVal t As String)

            'Format Name
            If n.StartsWith(" ") Then
                n = n.Remove(0, 1)
            End If
            Name = n

            'Format URL to album
            Dim x() = u.Split("/")
            'x(4) =
            u = x(0) + "//" + x(2) + "/photos/" + x(3) + "/albums/posts"
            ID = x(3)
            URL = u
            Team = t
        End Sub

    End Class

    ''' <summary>
    ''' Image object that will be used for downloading.
    ''' containing "source url.jpg" and "post date"
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ImageObject
        Public Property imageFullSizeSource As String
        Public Property imageDefaultSizeSource As String
        Public Property imagePostedDate As String
        Public Property imagePostURL As String
        Public Property postPassage As String
        Public Property imageFileName As String


        Public Overrides Function ToString() As String
            Return Me.imageFullSizeSource
        End Function

        Public Sub New(ByVal source As String, ByVal url As String, ByVal passage As String)
            imageFullSizeSource = source
            imagePostURL = url 'URL to the post of that image
            Dim b() As String = url.Split("/") 'clean unneccessary info
            Dim c = b(4).Split("#")(0)
            imagePostedDate = c 'original post date of the image
            Try
                imageFileName = imageFullSizeSource.Split("/")(8)
            Catch ex As Exception
                imageFileName = ""
            End Try
            postPassage = passage
        End Sub
    End Class
End Namespace
