namespace Exercise04 {
    partial class GameForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.AccessibleName = "";
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 152;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(802, 166);
            this.gameListBox.TabIndex = 0;
            this.gameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameListBox_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.correctLabel, this.missedLabel, this.accuracyLabel, this.difficultyLabel, this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 144);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.AccessibleName = "correctLabel";
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(58, 17);
            this.correctLabel.Text = "Correct: 0";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(56, 17);
            this.missedLabel.Text = "Missed: 0";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(78, 17);
            this.accuracyLabel.Text = "Accuracy: 0%";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(462, 17);
            this.difficultyLabel.Spring = true;
            this.difficultyLabel.Text = "Difficulty:";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.progressBar.Enabled = false;
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Maximum = 800;
            this.progressBar.Name = "progressBar";
            this.progressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Step = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.newGameMenu, this.exitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameMenu
            // 
            this.newGameMenu.Name = "newGameMenu";
            this.newGameMenu.Size = new System.Drawing.Size(74, 20);
            this.newGameMenu.Text = "NewGame";
            this.newGameMenu.Click += new System.EventHandler(this.newGameMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(38, 20);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 166);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Typing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem newGameMenu;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.ToolStripProgressBar progressBar;

        private System.Windows.Forms.ToolStripStatusLabel difficultyLabel;

        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;

        private System.Windows.Forms.ToolStripStatusLabel missedLabel;

        private System.Windows.Forms.ToolStripStatusLabel correctLabel;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.ListBox gameListBox;

        #endregion
    }
}