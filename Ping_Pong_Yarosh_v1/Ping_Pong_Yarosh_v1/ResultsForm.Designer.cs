using System.ComponentModel;

namespace Ping_Pong_Yarosh_v1 {
   partial class ResultsForm {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private IContainer components = null;

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
         this.GameTypeChooser = new System.Windows.Forms.ComboBox();
         this.ResultsBoardTextBox = new System.Windows.Forms.TextBox();
         this.BestScoreLable = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // GameTypeChooser
         // 
         this.GameTypeChooser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
         this.GameTypeChooser.FormattingEnabled = true;
         this.GameTypeChooser.Location = new System.Drawing.Point(33, 28);
         this.GameTypeChooser.Name = "GameTypeChooser";
         this.GameTypeChooser.Size = new System.Drawing.Size(171, 31);
         this.GameTypeChooser.TabIndex = 0;
         this.GameTypeChooser.SelectedIndexChanged += new System.EventHandler(this.GameTypeChooser_SelectedIndexChanged);
         // 
         // ResultsBoardTextBox
         // 
         this.ResultsBoardTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ResultsBoardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.ResultsBoardTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.ResultsBoardTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.ResultsBoardTextBox.ForeColor = System.Drawing.Color.White;
         this.ResultsBoardTextBox.Location = new System.Drawing.Point(0, 125);
         this.ResultsBoardTextBox.Multiline = true;
         this.ResultsBoardTextBox.Name = "ResultsBoardTextBox";
         this.ResultsBoardTextBox.ReadOnly = true;
         this.ResultsBoardTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.ResultsBoardTextBox.Size = new System.Drawing.Size(749, 362);
         this.ResultsBoardTextBox.TabIndex = 2;
         this.ResultsBoardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // BestScoreLable
         // 
         this.BestScoreLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
         this.BestScoreLable.ForeColor = System.Drawing.Color.White;
         this.BestScoreLable.Location = new System.Drawing.Point(25, 76);
         this.BestScoreLable.Name = "BestScoreLable";
         this.BestScoreLable.Size = new System.Drawing.Size(691, 23);
         this.BestScoreLable.TabIndex = 3;
         // 
         // ResultsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
         this.ClientSize = new System.Drawing.Size(749, 487);
         this.Controls.Add(this.BestScoreLable);
         this.Controls.Add(this.ResultsBoardTextBox);
         this.Controls.Add(this.GameTypeChooser);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ResultsForm";
         this.Text = "ResultsForm";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultsForm_FormClosing);
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.Label BestScoreLable;

      private System.Windows.Forms.ComboBox GameTypeChooser;
      private System.Windows.Forms.TextBox ResultsBoardTextBox;

      #endregion
   }
}