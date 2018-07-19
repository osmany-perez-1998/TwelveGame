namespace Twuelve.Visual
{
    partial class TwuelvePlay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwuelvePlay));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NOR5X4Load = new System.Windows.Forms.ToolStripMenuItem();
            this.NOR6X5Load = new System.Windows.Forms.ToolStripMenuItem();
            this.NOR7X6Load = new System.Windows.Forms.ToolStripMenuItem();
            this.NOR8X8Load = new System.Windows.Forms.ToolStripMenuItem();
            this.NOR9X9Load = new System.Windows.Forms.ToolStripMenuItem();
            this.NOR10X10Load = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AG5X4Load = new System.Windows.Forms.ToolStripMenuItem();
            this.AG6X5Load = new System.Windows.Forms.ToolStripMenuItem();
            this.AG7X6Load = new System.Windows.Forms.ToolStripMenuItem();
            this.AG8X8Load = new System.Windows.Forms.ToolStripMenuItem();
            this.AG9X9Load = new System.Windows.Forms.ToolStripMenuItem();
            this.AG10X10Load = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GameBoard = new System.Windows.Forms.PictureBox();
            this.ImLNumbers = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.lbTellScore = new System.Windows.Forms.Label();
            this.lbHScore = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.lbMode1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(89, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "New Game\r\nLoad Game...\r\nSave Game...\r\nExit";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x6ToolStripMenuItem,
            this.x8ToolStripMenuItem});
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game...";
            // 
            // x6ToolStripMenuItem
            // 
            this.x6ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NOR5X4Load,
            this.NOR6X5Load,
            this.NOR7X6Load,
            this.NOR8X8Load,
            this.NOR9X9Load,
            this.NOR10X10Load});
            this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
            this.x6ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.x6ToolStripMenuItem.Text = "Normal Mode";
            // 
            // NOR5X4Load
            // 
            this.NOR5X4Load.Name = "NOR5X4Load";
            this.NOR5X4Load.Size = new System.Drawing.Size(103, 22);
            this.NOR5X4Load.Text = "5x4";
            this.NOR5X4Load.Click += new System.EventHandler(this.NOR5X4Load_Click);
            // 
            // NOR6X5Load
            // 
            this.NOR6X5Load.Name = "NOR6X5Load";
            this.NOR6X5Load.Size = new System.Drawing.Size(103, 22);
            this.NOR6X5Load.Text = "6x5";
            this.NOR6X5Load.Click += new System.EventHandler(this.NOR6X5Load_Click);
            // 
            // NOR7X6Load
            // 
            this.NOR7X6Load.Name = "NOR7X6Load";
            this.NOR7X6Load.Size = new System.Drawing.Size(103, 22);
            this.NOR7X6Load.Text = "7x6";
            this.NOR7X6Load.Click += new System.EventHandler(this.NOR7X6Load_Click);
            // 
            // NOR8X8Load
            // 
            this.NOR8X8Load.Name = "NOR8X8Load";
            this.NOR8X8Load.Size = new System.Drawing.Size(103, 22);
            this.NOR8X8Load.Text = "8x8";
            this.NOR8X8Load.Click += new System.EventHandler(this.NOR8X8Load_Click);
            // 
            // NOR9X9Load
            // 
            this.NOR9X9Load.Name = "NOR9X9Load";
            this.NOR9X9Load.Size = new System.Drawing.Size(103, 22);
            this.NOR9X9Load.Text = "9x9";
            this.NOR9X9Load.Click += new System.EventHandler(this.NOR9X9Load_Click);
            // 
            // NOR10X10Load
            // 
            this.NOR10X10Load.Name = "NOR10X10Load";
            this.NOR10X10Load.Size = new System.Drawing.Size(103, 22);
            this.NOR10X10Load.Text = "10x10";
            this.NOR10X10Load.Click += new System.EventHandler(this.NOR10X10Load_Click);
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AG5X4Load,
            this.AG6X5Load,
            this.AG7X6Load,
            this.AG8X8Load,
            this.AG9X9Load,
            this.AG10X10Load});
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.x8ToolStripMenuItem.Text = "Aggressive Mode";
            // 
            // AG5X4Load
            // 
            this.AG5X4Load.Name = "AG5X4Load";
            this.AG5X4Load.Size = new System.Drawing.Size(103, 22);
            this.AG5X4Load.Text = "5x4";
            this.AG5X4Load.Click += new System.EventHandler(this.AG5X4Load_Click);
            // 
            // AG6X5Load
            // 
            this.AG6X5Load.Name = "AG6X5Load";
            this.AG6X5Load.Size = new System.Drawing.Size(103, 22);
            this.AG6X5Load.Text = "6x5";
            this.AG6X5Load.Click += new System.EventHandler(this.AG6X5Load_Click);
            // 
            // AG7X6Load
            // 
            this.AG7X6Load.Name = "AG7X6Load";
            this.AG7X6Load.Size = new System.Drawing.Size(103, 22);
            this.AG7X6Load.Text = "7x6";
            this.AG7X6Load.Click += new System.EventHandler(this.AG7X6Load_Click);
            // 
            // AG8X8Load
            // 
            this.AG8X8Load.Name = "AG8X8Load";
            this.AG8X8Load.Size = new System.Drawing.Size(103, 22);
            this.AG8X8Load.Text = "8x8";
            this.AG8X8Load.Click += new System.EventHandler(this.AG8X8Load_Click);
            // 
            // AG9X9Load
            // 
            this.AG9X9Load.Name = "AG9X9Load";
            this.AG9X9Load.Size = new System.Drawing.Size(103, 22);
            this.AG9X9Load.Text = "9x9";
            this.AG9X9Load.Click += new System.EventHandler(this.AG9X9Load_Click);
            // 
            // AG10X10Load
            // 
            this.AG10X10Load.Name = "AG10X10Load";
            this.AG10X10Load.Size = new System.Drawing.Size(103, 22);
            this.AG10X10Load.Text = "10x10";
            this.AG10X10Load.Click += new System.EventHandler(this.AG10X10Load_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us...";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // GameBoard
            // 
            this.GameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameBoard.Location = new System.Drawing.Point(12, 27);
            this.GameBoard.Margin = new System.Windows.Forms.Padding(10);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(280, 249);
            this.GameBoard.TabIndex = 2;
            this.GameBoard.TabStop = false;
            this.GameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.GameBoard_Paint);
            this.GameBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameBoard_MouseClick);
            // 
            // ImLNumbers
            // 
            this.ImLNumbers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImLNumbers.ImageStream")));
            this.ImLNumbers.TransparentColor = System.Drawing.Color.Transparent;
            this.ImLNumbers.Images.SetKeyName(0, "0.png");
            this.ImLNumbers.Images.SetKeyName(1, "1.png");
            this.ImLNumbers.Images.SetKeyName(2, "2.png");
            this.ImLNumbers.Images.SetKeyName(3, "3.png");
            this.ImLNumbers.Images.SetKeyName(4, "4.png");
            this.ImLNumbers.Images.SetKeyName(5, "5.png");
            this.ImLNumbers.Images.SetKeyName(6, "6.png");
            this.ImLNumbers.Images.SetKeyName(7, "7.png");
            this.ImLNumbers.Images.SetKeyName(8, "8.png");
            this.ImLNumbers.Images.SetKeyName(9, "9.png");
            this.ImLNumbers.Images.SetKeyName(10, "10.png");
            this.ImLNumbers.Images.SetKeyName(11, "11.png");
            this.ImLNumbers.Images.SetKeyName(12, "12.png");
            this.ImLNumbers.Images.SetKeyName(13, "13.png");
            this.ImLNumbers.Images.SetKeyName(14, "14.png");
            this.ImLNumbers.Images.SetKeyName(15, "15.png");
            this.ImLNumbers.Images.SetKeyName(16, "16.png");
            this.ImLNumbers.Images.SetKeyName(17, "17.png");
            this.ImLNumbers.Images.SetKeyName(18, "18.png");
            this.ImLNumbers.Images.SetKeyName(19, "19.png");
            this.ImLNumbers.Images.SetKeyName(20, "20.png");
            this.ImLNumbers.Images.SetKeyName(21, "21.png");
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(224, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // lbScore
            // 
            this.lbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(9, 310);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(38, 13);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "Score:";
            // 
            // lbHighScore
            // 
            this.lbHighScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.Location = new System.Drawing.Point(12, 355);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(60, 13);
            this.lbHighScore.TabIndex = 5;
            this.lbHighScore.Text = "HighScore:";
            // 
            // lbTellScore
            // 
            this.lbTellScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTellScore.AutoSize = true;
            this.lbTellScore.Location = new System.Drawing.Point(53, 310);
            this.lbTellScore.Name = "lbTellScore";
            this.lbTellScore.Size = new System.Drawing.Size(13, 13);
            this.lbTellScore.TabIndex = 6;
            this.lbTellScore.Text = "0";
            // 
            // lbHScore
            // 
            this.lbHScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbHScore.AutoSize = true;
            this.lbHScore.Location = new System.Drawing.Point(80, 355);
            this.lbHScore.Name = "lbHScore";
            this.lbHScore.Size = new System.Drawing.Size(13, 13);
            this.lbHScore.TabIndex = 7;
            this.lbHScore.Text = "0";
            // 
            // lbMode
            // 
            this.lbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMode.AutoSize = true;
            this.lbMode.Location = new System.Drawing.Point(9, 324);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(37, 13);
            this.lbMode.TabIndex = 8;
            this.lbMode.Text = "Mode:";
            // 
            // lbMode1
            // 
            this.lbMode1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMode1.AutoSize = true;
            this.lbMode1.Location = new System.Drawing.Point(55, 324);
            this.lbMode1.Name = "lbMode1";
            this.lbMode1.Size = new System.Drawing.Size(0, 13);
            this.lbMode1.TabIndex = 9;
            // 
            // timer1
            // 
          
            // 
            // TwuelvePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(311, 380);
            this.Controls.Add(this.lbMode1);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.lbHScore);
            this.Controls.Add(this.lbTellScore);
            this.Controls.Add(this.lbHighScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TwuelvePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwuelvePlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwuelvePlay_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TwuelvePlay_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TwuelvePlay_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox GameBoard;
        private System.Windows.Forms.ImageList ImLNumbers;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Label lbTellScore;
        private System.Windows.Forms.Label lbHScore;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Label lbMode1;
        private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NOR5X4Load;
        private System.Windows.Forms.ToolStripMenuItem NOR6X5Load;
        private System.Windows.Forms.ToolStripMenuItem NOR7X6Load;
        private System.Windows.Forms.ToolStripMenuItem NOR8X8Load;
        private System.Windows.Forms.ToolStripMenuItem NOR9X9Load;
        private System.Windows.Forms.ToolStripMenuItem NOR10X10Load;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AG5X4Load;
        private System.Windows.Forms.ToolStripMenuItem AG6X5Load;
        private System.Windows.Forms.ToolStripMenuItem AG7X6Load;
        private System.Windows.Forms.ToolStripMenuItem AG8X8Load;
        private System.Windows.Forms.ToolStripMenuItem AG9X9Load;
        private System.Windows.Forms.ToolStripMenuItem AG10X10Load;
        private System.Windows.Forms.Timer timer1;
    }
}