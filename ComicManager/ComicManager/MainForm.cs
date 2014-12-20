using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开文件对话框并加载文件内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开文件";
            ofd.Multiselect = false;
            ofd.Filter = "文本文件(*.txt)|*.txt";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                ofd.Dispose();
                MessageBox.Show(filePath);
                bool isExists = File.Exists(filePath);
                if (isExists)
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open);
                    fs.Close();
                }
            }
        }

        private void copyBookNameBtn_Click(object sender, EventArgs e)
        {
            string name = this.bookNameTextBox.Text;
            Clipboard.SetDataObject(name.Substring(1, name.Length - 2));
        }
    }
}
