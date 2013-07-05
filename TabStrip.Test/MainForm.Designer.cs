namespace TabStrip.Test
{
    partial class MainForm
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
            this.btnDemo1 = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.btnDemo3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDemo1
            // 
            this.btnDemo1.Location = new System.Drawing.Point(12, 102);
            this.btnDemo1.Name = "btnDemo1";
            this.btnDemo1.Size = new System.Drawing.Size(143, 35);
            this.btnDemo1.TabIndex = 0;
            this.btnDemo1.Text = "LTR and RTL";
            this.btnDemo1.UseVisualStyleBackColor = true;
            this.btnDemo1.Click += new System.EventHandler(this.btnDemo1_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(12, 143);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(143, 35);
            this.btnDemo2.TabIndex = 1;
            this.btnDemo2.Text = "Inside UserControls";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // btnDemo3
            // 
            this.btnDemo3.Location = new System.Drawing.Point(12, 184);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(143, 35);
            this.btnDemo3.TabIndex = 2;
            this.btnDemo3.Text = "Design-Time Persistence";
            this.btnDemo3.UseVisualStyleBackColor = true;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(166, 99);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 317);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDemo3);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.btnDemo1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemo1;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Button btnDemo3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMessage;
    }
}