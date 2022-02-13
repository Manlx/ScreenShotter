using SerializerUtil;
using System.Drawing.Imaging;

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
            //hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            //hook.RegisterHotKey(ScreenShotter.ModifierKeys.Shift,Keys.F12);
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
        private ImageFormat[] Files = new ImageFormat[] {ImageFormat.Png,ImageFormat.Bmp,ImageFormat.Jpeg};
        private void btnMain_Click(object sender, EventArgs e)
        {
            mySettings.FileName = edtName.Text;
            mySettings.FileType = cmbFileFormat.SelectedIndex;
            Bitmap bitmap = new Bitmap
            (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); 
            Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);
            graphics.CopyFromScreen(0, 0,0,0, bitmap.Size);
            string OutFile = $"{mySettings.FilePath}\\{mySettings.FileName}.{Files[mySettings.FileType].ToString()}";
            if (File.Exists(OutFile))
                OutFile = FindFile();

            bitmap.Save(OutFile, Files[mySettings.FileType]);
        }
        private string FindFile()
        {
            int x = 0;
            string Out = $"{mySettings.FilePath}\\{mySettings.FileName} ({x}).{Files[mySettings.FileType].ToString()}";
            while (File.Exists(Out))
            {
                x++;
                Out = $"{mySettings.FilePath}\\{mySettings.FileName} ({x}).{Files[mySettings.FileType].ToString()}";
            }
            return Out;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySettings.FileName = edtName.Text;
            mySettings.FileType = cmbFileFormat.SelectedIndex;
            serializer.Serialize(mySettings);
            hook.Dispose();
        }
    }
}