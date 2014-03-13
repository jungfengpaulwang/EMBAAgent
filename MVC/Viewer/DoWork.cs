using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FISCA.Presentation.Controls;

namespace Agent.Viewer
{
    public partial class DoWork : BaseForm
    {
        private bool enable_user_closing;

        public DoWork(bool EnableUserClosing = false)
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.Form_Load);
        }

        private void Form_Load(object sender, System.EventArgs e)
        {
            this.progress.Visible = true;
            this.progress.IsRunning = true;
        }

        private void DoWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing && !this.enable_user_closing)
            //    e.Cancel = true;
        }
    }
}