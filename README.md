# VeryStreamSDK
.NET API Library for verystream.com


`Download:`[https://github.com/loudKode/VeryStreamSDK/releases](https://github.com/loudKode/VeryStreamSDK/releases)<br>
`NuGet:`
[![NuGet](https://img.shields.io/nuget/v/DeQmaTech.VeryStreamSDK.svg?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DeQmaTech.VeryStreamSDK)<br>

# Functions:
* UserInfo
* ListFolder
* CreateNewFolder
* Upload
* RemoteUpload
* RenameFolder
* DeleteFolder
* RenameFile
* MoveFile
* DeleteFile
* GetSplash
* CopyFile
* GenerateDownloadUrl
* Download
* FileInfo
* RunningConvertsQueue
* DownloadFileAsStream


# Example:
**set client**
```vb
Dim cLENT As VeryStreamSDK.IClient = New VeryStreamSDK.VClient("xxxx", "xxxx")
```

**list files / folders**
```vb
        Dim RSLT = Await cLENT.ListFolder(TextBox1.Text)
        For Each fold In RSLT.result.folders
            DataGridView1.Rows.Add(fold.name, fold.id)
        Next
        For Each fle In RSLT.result.files
            DataGridView1.Rows.Add(fle.name, fle.ID)
        Next
```
