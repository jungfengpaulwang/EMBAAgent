using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FISCA.Presentation.Controls;

namespace Agent.Viewer
{
    /// <summary>
    /// 使用者選擇欄位
    /// </summary>
    public partial class SelectField : BaseForm
    {
        private List<string> SelectedFields;
        private string TitleText;

        public SelectField() 
        {
            InitializeComponent();

            this.SelectedFields = new List<string>();
        }

        public SelectField SetFields(List<string> Fields)
        {
            this.FieldContainer.Items.Clear();
            Fields.ForEach((x) =>
            {
                ListViewItem item = new ListViewItem(x);
                item.Checked = true;
                this.FieldContainer.Items.Add(item);
            });
            return this;
        }

        public SelectField SetConfirmButtonText(string Text)
        {
            this.btnConfirm.Text = Text;
            return this;
        }

        public SelectField SetExitButtonText(string Text)
        {
            this.btnExit.Text = Text;
            return this;
        }

        public SelectField SetSelectAllState(bool State)
        {
            this.chkSelectAll.Checked = State;
            return this;
        }

        public SelectField SetTitleText(string Text)
        {
            this.Text = Text;
            this.TitleText = Text;
            return this;
        }

        public List<string> GetSelectedFields()
        {
            return this.SelectedFields;
        }

        private void OnConfirmButtonClick(object sender, EventArgs e)
        {
            this.SelectedFields.Clear();
            this.FieldContainer.Items.Cast<ListViewItem>().Where(x=>x.Checked == true).ToList().ForEach(x => this.SelectedFields.Add(x.Text));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void OnExitButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            this.FieldContainer.Items.Cast<ListViewItem>().ToList().ForEach(x => x.Checked = this.chkSelectAll.Checked);
        }
    }    
}