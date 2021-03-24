using System.ComponentModel;

namespace Cv5 {
   partial class Form2 {
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
         this.ClubComboBox = new System.Windows.Forms.ComboBox();
         this.NameTextBox = new System.Windows.Forms.TextBox();
         this.GoalsTextBox = new System.Windows.Forms.TextBox();
         this.ConfirmBtn = new System.Windows.Forms.Button();
         this.CancelBtn = new System.Windows.Forms.Button();
         this.NameLabel = new System.Windows.Forms.Label();
         this.ClubLabel = new System.Windows.Forms.Label();
         this.GoalsLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // ClubComboBox
         // 
         this.ClubComboBox.FormattingEnabled = true;
         this.ClubComboBox.Location = new System.Drawing.Point(118, 76);
         this.ClubComboBox.Name = "ClubComboBox";
         this.ClubComboBox.Size = new System.Drawing.Size(165, 24);
         this.ClubComboBox.TabIndex = 0;
         // 
         // NameTextBox
         // 
         this.NameTextBox.Location = new System.Drawing.Point(118, 33);
         this.NameTextBox.Name = "NameTextBox";
         this.NameTextBox.Size = new System.Drawing.Size(165, 22);
         this.NameTextBox.TabIndex = 1;
         // 
         // GoalsTextBox
         // 
         this.GoalsTextBox.Location = new System.Drawing.Point(118, 125);
         this.GoalsTextBox.Name = "GoalsTextBox";
         this.GoalsTextBox.Size = new System.Drawing.Size(165, 22);
         this.GoalsTextBox.TabIndex = 2;
         // 
         // ConfirmBtn
         // 
         this.ConfirmBtn.Location = new System.Drawing.Point(37, 192);
         this.ConfirmBtn.Name = "ConfirmBtn";
         this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
         this.ConfirmBtn.TabIndex = 3;
         this.ConfirmBtn.Text = "Confirm";
         this.ConfirmBtn.UseVisualStyleBackColor = true;
         // 
         // CancelBtn
         // 
         this.CancelBtn.Location = new System.Drawing.Point(179, 192);
         this.CancelBtn.Name = "CancelBtn";
         this.CancelBtn.Size = new System.Drawing.Size(75, 23);
         this.CancelBtn.TabIndex = 4;
         this.CancelBtn.Text = "Cancel";
         this.CancelBtn.UseVisualStyleBackColor = true;
         // 
         // NameLabel
         // 
         this.NameLabel.Location = new System.Drawing.Point(11, 32);
         this.NameLabel.Name = "NameLabel";
         this.NameLabel.Size = new System.Drawing.Size(100, 23);
         this.NameLabel.TabIndex = 5;
         this.NameLabel.Text = "Name";
         // 
         // ClubLabel
         // 
         this.ClubLabel.Location = new System.Drawing.Point(12, 76);
         this.ClubLabel.Name = "ClubLabel";
         this.ClubLabel.Size = new System.Drawing.Size(100, 23);
         this.ClubLabel.TabIndex = 6;
         this.ClubLabel.Text = "Club";
         // 
         // GoalsLabel
         // 
         this.GoalsLabel.Location = new System.Drawing.Point(12, 128);
         this.GoalsLabel.Name = "GoalsLabel";
         this.GoalsLabel.Size = new System.Drawing.Size(100, 23);
         this.GoalsLabel.TabIndex = 7;
         this.GoalsLabel.Text = "Goals";
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(320, 238);
         this.Controls.Add(this.GoalsLabel);
         this.Controls.Add(this.ClubLabel);
         this.Controls.Add(this.NameLabel);
         this.Controls.Add(this.CancelBtn);
         this.Controls.Add(this.ConfirmBtn);
         this.Controls.Add(this.GoalsTextBox);
         this.Controls.Add(this.NameTextBox);
         this.Controls.Add(this.ClubComboBox);
         this.Name = "Form2";
         this.Text = "Form2";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.ComboBox ClubComboBox;
      private System.Windows.Forms.TextBox GoalsTextBox;
      private System.Windows.Forms.TextBox NameTextBox;

      private System.Windows.Forms.Button CancelBtn;
      private System.Windows.Forms.Button ConfirmBtn;

      private System.Windows.Forms.Label GoalsLabel;

      private System.Windows.Forms.Label ClubLabel;
      private System.Windows.Forms.Label NameLabel;

      #endregion
   }
}