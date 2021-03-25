using System.ComponentModel;

namespace Cv5 {
   partial class TheBestClubs {
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.GoalsNumber = new System.Windows.Forms.TextBox();
         this.ClubsList = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(67, 48);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Goals number";
         // 
         // label2
         // 
         this.label2.Location = new System.Drawing.Point(67, 130);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Clubs";
         // 
         // GoalsNumber
         // 
         this.GoalsNumber.Location = new System.Drawing.Point(67, 74);
         this.GoalsNumber.Name = "GoalsNumber";
         this.GoalsNumber.ReadOnly = true;
         this.GoalsNumber.Size = new System.Drawing.Size(209, 22);
         this.GoalsNumber.TabIndex = 2;
         // 
         // ClubsList
         // 
         this.ClubsList.Location = new System.Drawing.Point(67, 166);
         this.ClubsList.Multiline = true;
         this.ClubsList.Name = "ClubsList";
         this.ClubsList.Size = new System.Drawing.Size(209, 82);
         this.ClubsList.TabIndex = 3;
         // 
         // TheBestClubs
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(344, 291);
         this.Controls.Add(this.ClubsList);
         this.Controls.Add(this.GoalsNumber);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "TheBestClubs";
         this.Text = "TheBestClubs";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.TextBox ClubsList;
      private System.Windows.Forms.TextBox GoalsNumber;

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;

      #endregion
   }
}