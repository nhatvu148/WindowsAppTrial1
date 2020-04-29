namespace FirstApp
{
    partial class FrmFirstApp
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
            this.BtnApply = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.PicOne = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrpOne = new System.Windows.Forms.GroupBox();
            this.RBtnOne = new System.Windows.Forms.RadioButton();
            this.RBtnTwo = new System.Windows.Forms.RadioButton();
            this.PicTwo = new System.Windows.Forms.PictureBox();
            this.HsbNumber = new System.Windows.Forms.HScrollBar();
            this.MnuColors = new System.Windows.Forms.MenuStrip();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).BeginInit();
            this.GrpOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).BeginInit();
            this.MnuColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(88, 340);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(120, 53);
            this.BtnApply.TabIndex = 0;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtBox.Location = new System.Drawing.Point(171, 102);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(185, 27);
            this.TxtBox.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblName.Location = new System.Drawing.Point(266, 54);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(249, 24);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Welcome to my program";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicOne
            // 
            this.PicOne.Image = global::FirstApp.Properties.Resources._1200px_React_icon_svg;
            this.PicOne.Location = new System.Drawing.Point(171, 156);
            this.PicOne.Name = "PicOne";
            this.PicOne.Size = new System.Drawing.Size(91, 55);
            this.PicOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOne.TabIndex = 3;
            this.PicOne.TabStop = false;
            this.PicOne.Visible = false;
            this.PicOne.Click += new System.EventHandler(this.PicOne_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(330, 340);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(120, 53);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GrpOne
            // 
            this.GrpOne.Controls.Add(this.RBtnTwo);
            this.GrpOne.Controls.Add(this.RBtnOne);
            this.GrpOne.Location = new System.Drawing.Point(419, 156);
            this.GrpOne.Name = "GrpOne";
            this.GrpOne.Size = new System.Drawing.Size(181, 111);
            this.GrpOne.TabIndex = 5;
            this.GrpOne.TabStop = false;
            this.GrpOne.Text = "React Logo";
            // 
            // RBtnOne
            // 
            this.RBtnOne.AutoSize = true;
            this.RBtnOne.Location = new System.Drawing.Point(20, 22);
            this.RBtnOne.Name = "RBtnOne";
            this.RBtnOne.Size = new System.Drawing.Size(78, 19);
            this.RBtnOne.TabIndex = 0;
            this.RBtnOne.TabStop = true;
            this.RBtnOne.Text = "React 1";
            this.RBtnOne.UseVisualStyleBackColor = true;
            this.RBtnOne.CheckedChanged += new System.EventHandler(this.RBtnOne_CheckedChanged);
            // 
            // RBtnTwo
            // 
            this.RBtnTwo.AutoSize = true;
            this.RBtnTwo.Location = new System.Drawing.Point(20, 61);
            this.RBtnTwo.Name = "RBtnTwo";
            this.RBtnTwo.Size = new System.Drawing.Size(78, 19);
            this.RBtnTwo.TabIndex = 1;
            this.RBtnTwo.TabStop = true;
            this.RBtnTwo.Text = "React 2";
            this.RBtnTwo.UseVisualStyleBackColor = true;
            this.RBtnTwo.CheckedChanged += new System.EventHandler(this.RBtnTwo_CheckedChanged);
            // 
            // PicTwo
            // 
            this.PicTwo.Image = global::FirstApp.Properties.Resources._1200px_React_icon_svg;
            this.PicTwo.Location = new System.Drawing.Point(171, 217);
            this.PicTwo.Name = "PicTwo";
            this.PicTwo.Size = new System.Drawing.Size(91, 50);
            this.PicTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTwo.TabIndex = 3;
            this.PicTwo.TabStop = false;
            this.PicTwo.Visible = false;
            this.PicTwo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HsbNumber
            // 
            this.HsbNumber.LargeChange = 1;
            this.HsbNumber.Location = new System.Drawing.Point(464, 99);
            this.HsbNumber.Maximum = 50;
            this.HsbNumber.Name = "HsbNumber";
            this.HsbNumber.Size = new System.Drawing.Size(218, 30);
            this.HsbNumber.TabIndex = 6;
            this.HsbNumber.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbNumber_Scroll);
            // 
            // MnuColors
            // 
            this.MnuColors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.MnuColors.Location = new System.Drawing.Point(0, 0);
            this.MnuColors.Name = "MnuColors";
            this.MnuColors.Size = new System.Drawing.Size(800, 28);
            this.MnuColors.TabIndex = 7;
            this.MnuColors.Text = "menuStrip1";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // BtnMove
            // 
            this.BtnMove.Location = new System.Drawing.Point(566, 340);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(133, 53);
            this.BtnMove.TabIndex = 8;
            this.BtnMove.Text = "Move";
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // FrmFirstApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.HsbNumber);
            this.Controls.Add(this.GrpOne);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PicTwo);
            this.Controls.Add(this.PicOne);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.MnuColors);
            this.MainMenuStrip = this.MnuColors;
            this.Name = "FrmFirstApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Program";
            this.Load += new System.EventHandler(this.FrmFirstApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicOne)).EndInit();
            this.GrpOne.ResumeLayout(false);
            this.GrpOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTwo)).EndInit();
            this.MnuColors.ResumeLayout(false);
            this.MnuColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox PicOne;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GrpOne;
        private System.Windows.Forms.RadioButton RBtnTwo;
        private System.Windows.Forms.RadioButton RBtnOne;
        private System.Windows.Forms.PictureBox PicTwo;
        private System.Windows.Forms.HScrollBar HsbNumber;
        private System.Windows.Forms.MenuStrip MnuColors;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button BtnMove;
    }
}

