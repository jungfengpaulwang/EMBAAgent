namespace Agent.Viewer
{
    partial class DoWork
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new DevComponents.DotNetBar.LabelX();
            this.progress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMessage.BackgroundStyle.Class = "";
            this.lblMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMessage.Location = new System.Drawing.Point(78, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(138, 21);
            this.lblMessage.TabIndex = 31;
            this.lblMessage.Text = "資料處理中，請稍候…";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.progress.BackgroundStyle.Class = "";
            this.progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progress.Location = new System.Drawing.Point(23, 22);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(49, 23);
            this.progress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.progress.TabIndex = 32;
            this.progress.Visible = false;
            // 
            // DoWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 62);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblMessage);
            this.DoubleBuffered = true;
            this.Name = "DoWork";
            this.Text = "";
            this.TitleText = "提示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoWork_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblMessage;
        private DevComponents.DotNetBar.Controls.CircularProgress progress;
    }
}