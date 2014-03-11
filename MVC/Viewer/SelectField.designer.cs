namespace Agent.Viewer
{
    partial class SelectField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkSelectAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.FieldContainer = new System.Windows.Forms.ListView();
            this.lblExplanation = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkSelectAll.BackgroundStyle.Class = "";
            this.chkSelectAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSelectAll.Checked = true;
            this.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelectAll.CheckValue = "Y";
            this.chkSelectAll.Location = new System.Drawing.Point(34, 317);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(54, 21);
            this.chkSelectAll.TabIndex = 3;
            this.chkSelectAll.Text = "全選";
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(298, 329);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 25);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "匯出";
            this.btnConfirm.Click += new System.EventHandler(this.OnConfirmButtonClick);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(383, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "離開";
            this.btnExit.Click += new System.EventHandler(this.OnExitButtonClick);
            // 
            // FieldContainer
            // 
            this.FieldContainer.CheckBoxes = true;
            this.FieldContainer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.FieldContainer.HideSelection = false;
            this.FieldContainer.Location = new System.Drawing.Point(34, 51);
            this.FieldContainer.Name = "FieldContainer";
            this.FieldContainer.Size = new System.Drawing.Size(424, 260);
            this.FieldContainer.TabIndex = 19;
            this.FieldContainer.UseCompatibleStateImageBehavior = false;
            this.FieldContainer.View = System.Windows.Forms.View.List;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblExplanation.BackgroundStyle.Class = "";
            this.lblExplanation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblExplanation.Location = new System.Drawing.Point(34, 15);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(74, 21);
            this.lblExplanation.TabIndex = 20;
            this.lblExplanation.Text = "請選擇欄位";
            // 
            // SelectField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 366);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.FieldContainer);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkSelectAll);
            this.DoubleBuffered = true;
            this.Name = "SelectField";
            this.Text = "GatherData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btnConfirm;
        public DevComponents.DotNetBar.ButtonX btnExit;
        public DevComponents.DotNetBar.Controls.CheckBoxX chkSelectAll;
        public DevComponents.DotNetBar.LabelX lblExplanation;
        public System.Windows.Forms.ListView FieldContainer;
    }
}