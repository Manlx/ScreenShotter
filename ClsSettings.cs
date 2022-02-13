//Manuel A Nunes™
namespace ScreenShotter
{
    [Serializable]
    public class ClsSettings
    {
        public string FilePath = "";
        public string FileName = "";
        public int FileType;
        public bool CapMouse = false;
        public ClsSettings(){}
        public ClsSettings(string Path, string Name,int FileType,bool CapMouse)
        {
            FilePath = Path;
            FileName = Name;
            this.FileType = FileType;
            this.CapMouse = CapMouse;
        }
    }
}
