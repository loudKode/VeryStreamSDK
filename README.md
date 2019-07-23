# VeryStreamSDK
.NET API Library for verystream.com

`Download:`[https://github.com/loudKode/VeryStreamSDK/releases](https://github.com/loudKode/VeryStreamSDK/releases)
# Functions:
```vb.net
    Function UserInfo() As Task(Of JSON_UserInfo)
    Function ListFolder(Optional DestinationFolder As String = Nothing) As Task(Of JSON_ListFolder)
    Function CreateNewFolder(FolderName As String, Optional DestinationFolder As String = Nothing) As Task(Of JSON_CreateNewFolder)
    Function Upload(FileToUpload As Object, UploadType As VClient.UploadTypes, DestinationFolder As String, FileName As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional token As Threading.CancellationToken = Nothing) As Task
    Function RemoteUpload(FileUrl As String, DestinationFolder As String) As Task(Of JSON_RemoteUpload)
    Function RenameFolder(DestinationFolder As String, NewName As String) As Task(Of JSON_RenameFolder)
    Function DeleteFolder(DestinationFolder As String) As Task(Of JSON_RenameFolder)
    Function RenameFile(DestinationFile As String, NewName As String) As Task(Of JSON_RenameFolder)
    Function MoveFile(SourceFile As String, DestinationFolder As String) As Task(Of JSON_RenameFolder)
    Function DeleteFile(DestinationFile As String) As Task(Of JSON_RenameFolder)
    Function GetSplash(DestinationFile As String) As Task(Of JSON_GetSplash)
    Function CopyFile(SourceFile As String, DestinationFolder As String) As Task(Of JSON_CopyFile)
    Function GetDownloadUrl(DestinationFile As String) As Task(Of JSON_GetDownloadUrl)
    Function GenerateDownloadUrl(DestinationFileID As String, DownloadTicket As String, Optional Captcha As String = Nothing) As Task(Of JSON_GenerateDownloadUrl)
    Function Download(DestinationFileID As String, FileSaveDir As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task
    Function DirectDownloadUrl(DestinationFileID As String) As Task(Of JSON_GenerateDownloadUrl)
    Function FileInfo(DestinationFileID As String) As Task(Of JSON_FileInfo)
```

# Example:
```vb.net
Dim cLENT As VeryStreamSDK.IClient = New VeryStreamSDK.VClient("e22ca2e3f", "BqrZMg")
Dim RSLT = Await cLENT.UserInfo
Dim RSLT = Await cLENT.ListFolder(TextBox1.Text)
Dim RSLT = Await cLENT.CreateNewFolder("tzt2", String.Empty)
Await cLENT.Upload(frm.FileName, VeryStreamSDK.VClient.UploadTypes.FilePath, "", IO.Path.GetFileName(frm.FileName), progressIndicator_ReportCls, Nothing, UploadCancellationToken.Token)
Dim RSLT = Await cLENT.RemoteUpload("https://pcloud.com/1690.MP4", String.Empty)
Dim RSLT = Await cLENT.DeleteFile("C1rXH9iuuRs")
Dim RSLT = Await cLENT.DeleteFolder("720353")
Dim RSLT = Await cLENT.RenameFile("h8aAsQAgKa1", "GOGO.MP4")
Dim RSLT = Await cLENT.RenameFolder("720353", "TOBEDELETE")
Dim RSLT = Await cLENT.MoveFile("h8aAsQAgKa1", "720340")
Dim RSLT = Await cLENT.GetSplash("h8aAsQAgKa1")
Dim RSLT = Await cLENT.CopyFile("jSMnzBXtwhf", "720340")
Await cLENT.Download("jSMnzBXtwhf", "C:\Users\PointNine\Desktop\Data\", progressIndicator_ReportCls, roxy, 30, UploadCancellationToken.Token)
Dim RSLT = Await cLENT.DirectDownloadUrl("jSMnzBXtwhf")
Dim RSLT = Await cLENT.FileInfo("jSMnzBXtwhf")
```
