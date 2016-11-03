using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinEFTest.Droid
{
    public class FolderService : IFolderService
    {
        public string GetDBPath()
        {
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath + "/MultiTest.2.cruise";
        }
    }
}