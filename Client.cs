using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using VeryStreamSDK.JSON;

namespace VeryStreamSDK
{
	public interface IClient
	{
		Task<JSON_UserInfo> UserInfo();

		Task<JSON_ListFolder> ListFolder(string DestinationFolder = null);

		Task<JSON_CreateNewFolder> CreateNewFolder(string DestinationFolder, string FolderName);

		Task Upload(object FileToUpload, VClient.UploadTypes UploadType, string DestinationFolder, string FileName, IProgress<ReportStatus> ReportCls = null, CancellationToken token = default(CancellationToken));

		Task<JSON_RemoteUpload> RemoteUpload(string FileUrl, string DestinationFolder);

		Task<bool> RenameFolder(string DestinationFolder, string NewName);

		Task<bool> DeleteFolder(string DestinationFolderID);

		Task<bool> RenameFile(string DestinationFile, string NewName);

		Task<bool> MoveFile(string SourceFile, string DestinationFolder);

		Task<bool> DeleteFile(string DestinationFile);

		Task<JSON_GetSplash> GetSplash(string DestinationFile);

		Task<JSON_CopyFile> CopyFile(string SourceFile, string DestinationFolder);

		Task<JSON_GenerateDownloadUrl> GenerateDownloadUrl(string DestinationFileID);

		Task Download(string DestinationFileID, string FileSaveDir, IProgress<ReportStatus> ReportCls = null, int TimeOut = 60, CancellationToken token = default(CancellationToken));

		Task<JSON_FileInfo> FileInfo(string DestinationFileID);

		Task<JSON_RunningConvertsQueue> RunningConvertsQueue(string DestinationFolder = null);

		Task<Stream> DownloadFileAsStream(string DestinationFileID, IProgress<ReportStatus> ReportCls = null, int TimeOut = 60, CancellationToken token = default(CancellationToken));
	}
}
