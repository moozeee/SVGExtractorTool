using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace SVGExtractorTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetDefaultOutputPath();
        }
        


        private void ChooseOutputFolderButtonClick(object sender, EventArgs e)
        {
            var folderDlg = new CommonOpenFileDialog();
            folderDlg.IsFolderPicker = true;
            if (folderDlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputPathTextBox.Text = folderDlg.FileName;
            }
            folderDlg.Dispose();
        }

 
        private void SetDefaultOutputPath()
        {
            outputPathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MyReadySVGs";
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            var svgCodeText = string.Empty;
            var outputSvgFilePath = string.Empty;

            if (SVGCodeRTB.Text != string.Empty && outputPathTextBox.Text != string.Empty)
            {
                svgCodeText = SVGCodeRTB.Text;
                outputSvgFilePath = outputPathTextBox.Text;
                CreateFile(outputSvgFilePath, svgCodeText);
                try
                {
                    System.Diagnostics.Process.Start(outputSvgFilePath);
                }
                catch (Exception ex)
                { }
            }
            else
            {
                MessageBox.Show("Please ensure there are no empty fields", "Error");
            }
        }

        private void CreateFile(string path, string content)
        {
            var finalPath = path + @"\MySvg.svg";
            if (!Directory.Exists(finalPath))
            {
                Directory.CreateDirectory(path);
                File.Create(finalPath).Dispose();
                using (TextWriter tw = new StreamWriter(finalPath))
                {
                    tw.WriteLine(content);
                }
            }
        }

        private void svgCodeRTB_TextChanged(object sender, EventArgs e){}
        private void SVGCodeRTB_TextChanged_1(object sender, EventArgs e){ }
        private void svgPathTextBox(object sender, EventArgs e) { }
        private void outputPathTextBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
    }
}
