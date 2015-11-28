using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileRenamer
{
    public class FormBase : Form
    {
        public FormBase()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected void UpdateForm(bool isFormEnabled)
        {
            this.Enabled = isFormEnabled;
            this.Invalidate();
            this.Update();
            this.Refresh();
            Application.DoEvents();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBase";
            this.ResumeLayout(false);

        }
    }
}
