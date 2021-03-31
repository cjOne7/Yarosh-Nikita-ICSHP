namespace Ping_Pong_Yarosh_v1 {
   partial class StartMenu {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)){
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
         this.StartPracticeGame = new System.Windows.Forms.Button();
         this.ExitBtn = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.PvsPBtn = new System.Windows.Forms.Button();
         this.DestroyBlocksBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // StartPracticeGame
         // 
         this.StartPracticeGame.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.StartPracticeGame.Location = new System.Drawing.Point(276, 149);
         this.StartPracticeGame.Name = "StartPracticeGame";
         this.StartPracticeGame.Size = new System.Drawing.Size(225, 40);
         this.StartPracticeGame.TabIndex = 0;
         this.StartPracticeGame.Text = "Start practice";
         this.StartPracticeGame.UseVisualStyleBackColor = true;
         this.StartPracticeGame.Click += new System.EventHandler(this.startNewGame_Click);
         // 
         // ExitBtn
         // 
         this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.ExitBtn.Location = new System.Drawing.Point(276, 304);
         this.ExitBtn.Name = "ExitBtn";
         this.ExitBtn.Size = new System.Drawing.Size(225, 40);
         this.ExitBtn.TabIndex = 1;
         this.ExitBtn.Text = "Exit";
         this.ExitBtn.UseVisualStyleBackColor = true;
         this.ExitBtn.Click += new System.EventHandler(this.exit_Click);
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(218, 91);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(340, 55);
         this.label1.TabIndex = 2;
         this.label1.Text = "PING PONG GAME";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // PvsPBtn
         // 
         this.PvsPBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.PvsPBtn.Location = new System.Drawing.Point(276, 200);
         this.PvsPBtn.Name = "PvsPBtn";
         this.PvsPBtn.Size = new System.Drawing.Size(225, 40);
         this.PvsPBtn.TabIndex = 3;
         this.PvsPBtn.Text = "1 vs. 1";
         this.PvsPBtn.UseVisualStyleBackColor = true;
         this.PvsPBtn.Click += new System.EventHandler(this.PvsPBtn_Click);
         // 
         // DestroyBlocksBtn
         // 
         this.DestroyBlocksBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.DestroyBlocksBtn.Location = new System.Drawing.Point(276, 252);
         this.DestroyBlocksBtn.Name = "DestroyBlocksBtn";
         this.DestroyBlocksBtn.Size = new System.Drawing.Size(225, 40);
         this.DestroyBlocksBtn.TabIndex = 4;
         this.DestroyBlocksBtn.Text = "Destroy blocks";
         this.DestroyBlocksBtn.UseVisualStyleBackColor = true;
         this.DestroyBlocksBtn.Click += new System.EventHandler(this.DestroyBlocksBtn_Click);
         // 
         // StartMenu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.DestroyBlocksBtn);
         this.Controls.Add(this.PvsPBtn);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.ExitBtn);
         this.Controls.Add(this.StartPracticeGame);
         this.ForeColor = System.Drawing.Color.Black;
         this.Name = "StartMenu";
         this.Text = "Form1";
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.Button DestroyBlocksBtn;
      private System.Windows.Forms.Button PvsPBtn;
      private System.Windows.Forms.Button StartPracticeGame;

      private System.Windows.Forms.Button ExitBtn;

      private System.Windows.Forms.Label label1;

      #endregion
   }
}