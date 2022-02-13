using SerializerUtil;
using System.Drawing.Imaging;
//Manuel A Nunes™
namespace ScreenShotter
{
    public partial class frmMain : Form
    {
        private static Serializer<ClsSettings> serializer = new Serializer<ClsSettings>("Settings.Data");
        private static ClsSettings mySettings  = new ClsSettings();
        private KeyboardHook hook = new KeyboardHook();
        public frmMain()
        {
            InitializeComponent();
            mySettings = serializer.DeSerializer();
            if (mySettings == null)
            {
                mySettings = new ClsSettings();
                cmbFileFormat.SelectedIndex = 0;
                return;
            }   
            edtName.Text = mySettings.FileName;
            lblDebug.Text = mySettings.FilePath;
            cmbFileFormat.SelectedIndex = mySettings.FileType;
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(ScreenShotter.ModifierKeys.Shift,Keys.PrintScreen);
            chkSnipMouseScreen.Checked = mySettings.CapMouse;
        }
        private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            btnMain.PerformClick();
        }
        private void btnChooseOutputPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    mySettings.FilePath = fbd.SelectedPath;
            }
            serializer.Serialize(mySettings);
        }
        private int IndexOfPrime()
        {
            int i = 0;
            while (!Screen.AllScreens[i].Primary)
                i++;
            return i;
        }
        private ImageFormat[] Files = new ImageFormat[] {ImageFormat.Png,ImageFormat.Bmp,ImageFormat.Jpeg};
        private void btnMain_Click(object sender, EventArgs e)
        {
            int iScreen = ConvertMousePointToScreenIndex(System.Windows.Forms.Cursor.Position);
            if (!chkSnipMouseScreen.Checked)
                iScreen = IndexOfPrime();
            mySettings.FileName = edtName.Text;
            mySettings.FileType = cmbFileFormat.SelectedIndex;
            Bitmap bitmap = new Bitmap
            (Screen.AllScreens[iScreen].Bounds.Width, Screen.AllScreens[iScreen].Bounds.Height); 
            Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);
            int y = Screen.AllScreens[iScreen].Bounds.Top;
            int x = Screen.AllScreens[iScreen].Bounds.Left;
            graphics.CopyFromScreen(x,y, 0,0, bitmap.Size);
            string OutFile = $"{mySettings.FilePath}\\{mySettings.FileName}.{Files[mySettings.FileType].ToString()}";
            if (OutFile[0] == '\\')
                OutFile = OutFile.Substring(1);
            if (File.Exists(OutFile))
                OutFile = FindFile();

            bitmap.Save(OutFile, Files[mySettings.FileType]);
        }
        private string FindFile()
        {
            int x = 0;
            string Out = $"{mySettings.FilePath}\\{mySettings.FileName} ({x}).{Files[mySettings.FileType].ToString()}";
            if (Out[0] == '\\')
                Out = Out.Substring(1);
            while (File.Exists(Out))
            {
                x++;
                Out = $"{mySettings.FilePath}\\{mySettings.FileName} ({x}).{Files[mySettings.FileType].ToString()}";
                if (Out[0] == '\\')
                    Out = Out.Substring(1);
            }
            
            return Out;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySettings.FileName = edtName.Text;
            mySettings.FileType = cmbFileFormat.SelectedIndex;
            mySettings.CapMouse = chkSnipMouseScreen.Checked;
            serializer.Serialize(mySettings);
            hook.Dispose();
        }
        private int ConvertMousePointToScreenIndex(Point mousePoint)
        {//Thanks overflow
            //first get all the screens 
            System.Drawing.Rectangle ret;

            for (int i = 1; i <= Screen.AllScreens.Count(); i++)
            {
                ret = Screen.AllScreens[i - 1].Bounds;
                if (ret.Contains(mousePoint))
                    return i - 1;
            }
            return 0;
        }

        private void chkSnipMouseScreen_CheckedChanged(object sender, EventArgs e)
        {
            mySettings.CapMouse = chkSnipMouseScreen.Checked;
        }
    }
}