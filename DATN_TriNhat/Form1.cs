using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DATN_TriNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string ext = ".jpg";

        int LoadImageName()
        {
            int maxIndexFileName = 0;
            string pathFilesImage = @"C:\\Users\\DELL\\Documents\\GitHub\\DATN_TRINHAT\\DATN_TriNhat\\bin\\Debug\\Images";
            DirectoryInfo dirImage = new DirectoryInfo(pathFilesImage);
            FileInfo[] imgFiles = dirImage.GetFiles();
            foreach (FileInfo file in imgFiles)
            {
                
                string newfile = file.Name.Remove(5);
                int intNewFile = int.Parse(newfile);
                int[] ints = new int[intNewFile];
                foreach (int i in ints)
                {
                    if (ints[i] > maxIndexFileName)
                    {
                        maxIndexFileName = ints[i];
                    }
                }
            }
            int reN = maxIndexFileName;
            return reN;
        }
        private void ptbImage_Click(object sender, EventArgs e)
        {
           
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ptbImage.Image = new Bitmap(Application.StartupPath + "\\Images\\104211" + ext);
            int n = LoadImageName();
            textBox1.Text = n.ToString();
        }
    }
}