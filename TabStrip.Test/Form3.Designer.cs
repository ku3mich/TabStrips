namespace TabStrip.Test
{
    partial class Form3
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
            this.faTabStrip1 = new FarsiLibrary.Win.FATabStrip();
            this.faTabStripItem1 = new FarsiLibrary.Win.FATabStripItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnButtomRight = new System.Windows.Forms.Button();
            this.btnButtomLeft = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.faTabStripItem3 = new FarsiLibrary.Win.FATabStripItem();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.faTabStripItem4 = new FarsiLibrary.Win.FATabStripItem();
            this.complicatedUserControl1 = new TabStrip.Test.ComplicatedUserControl();
            this.faTabStripItem2 = new FarsiLibrary.Win.FATabStripItem();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).BeginInit();
            this.faTabStrip1.SuspendLayout();
            this.faTabStripItem1.SuspendLayout();
            this.faTabStripItem3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.faTabStripItem4.SuspendLayout();
            this.SuspendLayout();
            // 
            // faTabStrip1
            // 
            this.faTabStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faTabStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.faTabStrip1.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.faTabStripItem1,
            this.faTabStripItem3,
            this.faTabStripItem4});
            this.faTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.faTabStrip1.Name = "faTabStrip1";
            this.faTabStrip1.SelectedItem = this.faTabStripItem3;
            this.faTabStrip1.Size = new System.Drawing.Size(488, 187);
            this.faTabStrip1.TabIndex = 0;
            this.faTabStrip1.Text = "faTabStrip1";
            // 
            // faTabStripItem1
            // 
            this.faTabStripItem1.Controls.Add(this.label1);
            this.faTabStripItem1.Controls.Add(this.btnButtomRight);
            this.faTabStripItem1.Controls.Add(this.btnButtomLeft);
            this.faTabStripItem1.Controls.Add(this.btnTopRight);
            this.faTabStripItem1.Controls.Add(this.btnTopLeft);
            this.faTabStripItem1.Image = global::TabStrip.Test.Properties.Resources._12_em_plus;
            this.faTabStripItem1.IsDrawn = true;
            this.faTabStripItem1.Name = "faTabStripItem1";
            this.faTabStripItem1.Size = new System.Drawing.Size(486, 166);
            this.faTabStripItem1.TabIndex = 0;
            this.faTabStripItem1.Title = "Anchoring";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 87);
            this.label1.TabIndex = 4;
            this.label1.Text = "This shows how to set anchors in tab pages";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnButtomRight
            // 
            this.btnButtomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnButtomRight.Location = new System.Drawing.Point(398, 126);
            this.btnButtomRight.Name = "btnButtomRight";
            this.btnButtomRight.Size = new System.Drawing.Size(75, 23);
            this.btnButtomRight.TabIndex = 3;
            this.btnButtomRight.Text = "BottomRight";
            this.btnButtomRight.UseVisualStyleBackColor = true;
            // 
            // btnButtomLeft
            // 
            this.btnButtomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnButtomLeft.Location = new System.Drawing.Point(15, 126);
            this.btnButtomLeft.Name = "btnButtomLeft";
            this.btnButtomLeft.Size = new System.Drawing.Size(75, 23);
            this.btnButtomLeft.TabIndex = 2;
            this.btnButtomLeft.Text = "Bottom-Left";
            this.btnButtomLeft.UseVisualStyleBackColor = true;
            // 
            // btnTopRight
            // 
            this.btnTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopRight.Location = new System.Drawing.Point(398, 10);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(75, 23);
            this.btnTopRight.TabIndex = 1;
            this.btnTopRight.Text = "Top-Right";
            this.btnTopRight.UseVisualStyleBackColor = true;
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.Location = new System.Drawing.Point(15, 10);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.Text = "Top-Left";
            this.btnTopLeft.UseVisualStyleBackColor = true;
            this.btnTopLeft.Click += new System.EventHandler(this.button1_Click);
            // 
            // faTabStripItem3
            // 
            this.faTabStripItem3.Controls.Add(this.label2);
            this.faTabStripItem3.Controls.Add(this.trackBar6);
            this.faTabStripItem3.Controls.Add(this.button6);
            this.faTabStripItem3.Controls.Add(this.trackBar5);
            this.faTabStripItem3.Controls.Add(this.trackBar4);
            this.faTabStripItem3.Controls.Add(this.trackBar3);
            this.faTabStripItem3.Controls.Add(this.trackBar2);
            this.faTabStripItem3.Controls.Add(this.trackBar1);
            this.faTabStripItem3.Controls.Add(this.button5);
            this.faTabStripItem3.Controls.Add(this.button4);
            this.faTabStripItem3.Controls.Add(this.button3);
            this.faTabStripItem3.Controls.Add(this.button2);
            this.faTabStripItem3.Controls.Add(this.button1);
            this.faTabStripItem3.Image = global::TabStrip.Test.Properties.Resources._12_em_cross;
            this.faTabStripItem3.IsDrawn = true;
            this.faTabStripItem3.Name = "faTabStripItem3";
            this.faTabStripItem3.Selected = true;
            this.faTabStripItem3.Size = new System.Drawing.Size(486, 166);
            this.faTabStripItem3.TabIndex = 4;
            this.faTabStripItem3.Title = "Control Persistence";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "This page shows that you can add controls directly to a tab page without losing a" +
                "ny design-time added controls (problem with previous version)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar6
            // 
            this.trackBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar6.Location = new System.Drawing.Point(325, 84);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 45);
            this.trackBar6.TabIndex = 11;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(232, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // trackBar5
            // 
            this.trackBar5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar5.Location = new System.Drawing.Point(325, 60);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 9;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar4.Location = new System.Drawing.Point(325, 34);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 8;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar3.Location = new System.Drawing.Point(124, 84);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 7;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBar2.Location = new System.Drawing.Point(124, 60);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(124, 34);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(43, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(232, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(232, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(43, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // faTabStripItem4
            // 
            this.faTabStripItem4.CanClose = false;
            this.faTabStripItem4.Controls.Add(this.complicatedUserControl1);
            this.faTabStripItem4.IsDrawn = true;
            this.faTabStripItem4.Name = "faTabStripItem4";
            this.faTabStripItem4.Size = new System.Drawing.Size(486, 166);
            this.faTabStripItem4.TabIndex = 3;
            this.faTabStripItem4.Title = "Complicated User Control";
            // 
            // complicatedUserControl1
            // 
            this.complicatedUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complicatedUserControl1.Location = new System.Drawing.Point(0, 0);
            this.complicatedUserControl1.Name = "complicatedUserControl1";
            this.complicatedUserControl1.Size = new System.Drawing.Size(486, 166);
            this.complicatedUserControl1.TabIndex = 0;
            // 
            // faTabStripItem2
            // 
            this.faTabStripItem2.Image = global::TabStrip.Test.Properties.Resources._12_em_cross;
            this.faTabStripItem2.IsDrawn = true;
            this.faTabStripItem2.Name = "faTabStripItem2";
            this.faTabStripItem2.Size = new System.Drawing.Size(397, 179);
            this.faTabStripItem2.TabIndex = 1;
            this.faTabStripItem2.Title = "TabStrip Page 2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 187);
            this.Controls.Add(this.faTabStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).EndInit();
            this.faTabStrip1.ResumeLayout(false);
            this.faTabStripItem1.ResumeLayout(false);
            this.faTabStripItem3.ResumeLayout(false);
            this.faTabStripItem3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.faTabStripItem4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.FATabStrip faTabStrip1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem2;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnTopLeft;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem4;
        private System.Windows.Forms.Button btnButtomRight;
        private System.Windows.Forms.Button btnButtomLeft;
        private ComplicatedUserControl complicatedUserControl1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}