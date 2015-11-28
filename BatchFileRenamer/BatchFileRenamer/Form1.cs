using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kahia.Common.Extensions.GeneralExtensions;
using Kahia.Common.Extensions.StringExtensions;

namespace BatchFileRenamer
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RenameFiles(string path, out int countOfFiles, string prefix, bool groupByExt)
        {
            countOfFiles = 1;
            var directory = new DirectoryInfo(path);
            var filter = txtFilter.Text.ToStringByDefaultValue("*");
            var files = directory.GetFiles(filter, cbSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).OrderBy(f => f.LastWriteTime).ToArray();
            if (groupByExt)
            {
                var grouped = files.GroupBy(f => f.Extension);
                foreach (var group in grouped)
                {
                    var groupArr = group.ToArray();
                    for (var i = 1; i <= groupArr.Length; i++)
                    {
                        var file = groupArr[i - 1];
                        file.MoveTo(Path.Combine(file.DirectoryName, "{0}-{1}{2:D5}{3}".FormatString(group.Key.RemoveFromBeginning("."), prefix, i, file.Extension)));
                        countOfFiles++;
                    }
                }
            }
            else
            {
                foreach (var file in files)
                {
                    file.MoveTo(Path.Combine(file.DirectoryName, "{0}{1:D5}{2}".FormatString(prefix, countOfFiles, file.Extension)));
                    countOfFiles++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateForm(false);
            var path = textBox1.Text;
            int countOfFiles = 0;
            var groupByExt = cbGroupByExtension.Checked;
            if (Debugger.IsAttached)
            {
                RenameFiles(path, out countOfFiles, "@@@@@", groupByExt);
                RenameFiles(path, out countOfFiles, "", groupByExt);
            }
            else
            {
                try
                {
                    RenameFiles(path, out countOfFiles, "@@@@@", groupByExt);
                    RenameFiles(path, out countOfFiles, "", groupByExt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ConvertExceptionToString());
                }
            }
            MessageBox.Show("Renamed {0} files!".FormatString(countOfFiles));
            Process.Start("explorer.exe", path);
            UpdateForm(true);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Resources.Title;
            btnBrowse.Text = Resources.btnBrowser;
            button1.Text = Resources.btnStart;
            cbGroupByExtension.Text = Resources.cbGroupByExt;
            cbSubfolders.Text = Resources.cbIncludeSubfolders;
            label1.Text = Resources.lblFilter;
        }
    }
}
