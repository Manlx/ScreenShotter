using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenShotter
{
    [Serializable]
    public class ClsSettings
    {
        public string FilePath = "";
        public string FileName = "";
        public int FileType;
        public ClsSettings(){}
        public ClsSettings(string Path, string Name,int FileType)
        {
            FilePath = Path;
            FileName = Name;
            this.FileType = FileType;  
        }
    }
}
