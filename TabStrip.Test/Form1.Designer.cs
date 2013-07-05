namespace TabStrip.Test
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Node12", new System.Windows.Forms.TreeNode[] {
            treeNode41});
            this.LTRTabStrip = new FarsiLibrary.Win.FATabStrip();
            this.faTabStripItem1 = new FarsiLibrary.Win.FATabStripItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.faTabStripItem2 = new FarsiLibrary.Win.FATabStripItem();
            this.ToggleDirection = new System.Windows.Forms.Button();
            this.RemoveTab = new System.Windows.Forms.Button();
            this.AddTab = new System.Windows.Forms.Button();
            this.RTLTabStrip = new FarsiLibrary.Win.FATabStrip();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cbCloseable = new System.Windows.Forms.CheckBox();
            this.btnForceClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LTRTabStrip)).BeginInit();
            this.LTRTabStrip.SuspendLayout();
            this.faTabStripItem1.SuspendLayout();
            this.faTabStripItem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTLTabStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // LTRTabStrip
            // 
            this.LTRTabStrip.AlwaysShowClose = false;
            this.LTRTabStrip.AlwaysShowMenuGlyph = false;
            this.LTRTabStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.LTRTabStrip.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LTRTabStrip.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.faTabStripItem1,
            this.faTabStripItem2});
            this.LTRTabStrip.Location = new System.Drawing.Point(0, 0);
            this.LTRTabStrip.Name = "LTRTabStrip";
            this.LTRTabStrip.SelectedItem = this.faTabStripItem2;
            this.LTRTabStrip.Size = new System.Drawing.Size(316, 266);
            this.LTRTabStrip.TabIndex = 0;
            // 
            // faTabStripItem1
            // 
            this.faTabStripItem1.Controls.Add(this.treeView1);
            this.faTabStripItem1.Controls.Add(this.dateTimePicker1);
            this.faTabStripItem1.IsDrawn = true;
            this.faTabStripItem1.Name = "faTabStripItem1";
            this.faTabStripItem1.Size = new System.Drawing.Size(314, 245);
            this.faTabStripItem1.TabIndex = 0;
            this.faTabStripItem1.Title = "Test TabStrip LTR";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(35, 46);
            this.treeView1.Name = "treeView1";
            treeNode29.Name = "Node7";
            treeNode29.Text = "Node7";
            treeNode30.Name = "Node0";
            treeNode30.Text = "Node0";
            treeNode31.Name = "Node5";
            treeNode31.Text = "Node5";
            treeNode32.Name = "Node1";
            treeNode32.Text = "Node1";
            treeNode33.Name = "Node6";
            treeNode33.Text = "Node6";
            treeNode34.Name = "Node2";
            treeNode34.Text = "Node2";
            treeNode35.Name = "Node4";
            treeNode35.Text = "Node4";
            treeNode36.Name = "Node3";
            treeNode36.Text = "Node3";
            treeNode37.Name = "Node8";
            treeNode37.Text = "Node8";
            treeNode38.Name = "Node9";
            treeNode38.Text = "Node9";
            treeNode39.Name = "Node11";
            treeNode39.Text = "Node11";
            treeNode40.Name = "Node10";
            treeNode40.Text = "Node10";
            treeNode41.Name = "Node13";
            treeNode41.Text = "Node13";
            treeNode42.Name = "Node12";
            treeNode42.Text = "Node12";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode32,
            treeNode34,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode40,
            treeNode42});
            this.treeView1.Size = new System.Drawing.Size(245, 188);
            this.treeView1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // faTabStripItem2
            // 
            this.faTabStripItem2.Controls.Add(this.btnForceClose);
            this.faTabStripItem2.Controls.Add(this.cbCloseable);
            this.faTabStripItem2.Controls.Add(this.ToggleDirection);
            this.faTabStripItem2.Controls.Add(this.RemoveTab);
            this.faTabStripItem2.Controls.Add(this.AddTab);
            this.faTabStripItem2.IsDrawn = true;
            this.faTabStripItem2.Name = "faTabStripItem2";
            this.faTabStripItem2.Selected = true;
            this.faTabStripItem2.Size = new System.Drawing.Size(314, 245);
            this.faTabStripItem2.TabIndex = 1;
            this.faTabStripItem2.Title = "Add/Remove TabStrip";
            // 
            // ToggleDirection
            // 
            this.ToggleDirection.Location = new System.Drawing.Point(42, 182);
            this.ToggleDirection.Name = "ToggleDirection";
            this.ToggleDirection.Size = new System.Drawing.Size(231, 23);
            this.ToggleDirection.TabIndex = 5;
            this.ToggleDirection.Text = "Toggle Direction";
            this.ToggleDirection.UseVisualStyleBackColor = true;
            this.ToggleDirection.Click += new System.EventHandler(this.ToggleDirection_Click);
            // 
            // RemoveTab
            // 
            this.RemoveTab.Location = new System.Drawing.Point(161, 211);
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Size = new System.Drawing.Size(112, 23);
            this.RemoveTab.TabIndex = 3;
            this.RemoveTab.Text = "Remove Tab Page";
            this.RemoveTab.UseVisualStyleBackColor = true;
            this.RemoveTab.Click += new System.EventHandler(this.RemoveTab_Click);
            // 
            // AddTab
            // 
            this.AddTab.Location = new System.Drawing.Point(42, 211);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(112, 23);
            this.AddTab.TabIndex = 4;
            this.AddTab.Text = "Add Tab Page";
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.AddTab_Click);
            // 
            // RTLTabStrip
            // 
            this.RTLTabStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTLTabStrip.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RTLTabStrip.Location = new System.Drawing.Point(316, 0);
            this.RTLTabStrip.Name = "RTLTabStrip";
            this.RTLTabStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RTLTabStrip.Size = new System.Drawing.Size(458, 266);
            this.RTLTabStrip.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(316, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 266);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // cbCloseable
            // 
            this.cbCloseable.AutoSize = true;
            this.cbCloseable.Location = new System.Drawing.Point(42, 126);
            this.cbCloseable.Name = "cbCloseable";
            this.cbCloseable.Size = new System.Drawing.Size(143, 17);
            this.cbCloseable.TabIndex = 6;
            this.cbCloseable.Text = "Can close this tab page?";
            this.cbCloseable.UseVisualStyleBackColor = true;
            this.cbCloseable.CheckedChanged += new System.EventHandler(this.cbCloseable_CheckedChanged);
            // 
            // btnForceClose
            // 
            this.btnForceClose.Location = new System.Drawing.Point(42, 153);
            this.btnForceClose.Name = "btnForceClose";
            this.btnForceClose.Size = new System.Drawing.Size(231, 23);
            this.btnForceClose.TabIndex = 7;
            this.btnForceClose.Text = "Force Close";
            this.btnForceClose.UseVisualStyleBackColor = true;
            this.btnForceClose.Click += new System.EventHandler(this.btnForceClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 266);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.RTLTabStrip);
            this.Controls.Add(this.LTRTabStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LTRTabStrip)).EndInit();
            this.LTRTabStrip.ResumeLayout(false);
            this.faTabStripItem1.ResumeLayout(false);
            this.faTabStripItem2.ResumeLayout(false);
            this.faTabStripItem2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTLTabStrip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.FATabStrip LTRTabStrip;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem2;
        private FarsiLibrary.Win.FATabStrip RTLTabStrip;
        private System.Windows.Forms.Button RemoveTab;
        private System.Windows.Forms.Button AddTab;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ToggleDirection;
        private System.Windows.Forms.CheckBox cbCloseable;
        private System.Windows.Forms.Button btnForceClose;
    }
}

