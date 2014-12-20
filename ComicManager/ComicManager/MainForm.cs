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
                MessageBox.Show(ofd.FileName);
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            }
        }
    }
}
