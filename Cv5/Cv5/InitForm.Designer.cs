﻿namespace Cv5 {
   partial class InitForm {
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
         this.PlayersListView = new System.Windows.Forms.ListView();
         this.NameColumn = new System.Windows.Forms.ColumnHeader();
         this.ClubColumn = new System.Windows.Forms.ColumnHeader();
         this.GoalsColumn = new System.Windows.Forms.ColumnHeader();
         this.AddBtn = new System.Windows.Forms.Button();
         this.DeleteBtn = new System.Windows.Forms.Button();
         this.ChangeBtn = new System.Windows.Forms.Button();
         this.TheBestPlayerBtn = new System.Windows.Forms.Button();
         this.RegisterBtn = new System.Windows.Forms.Button();
         this.CancelRegistrationBtn = new System.Windows.Forms.Button();
         this.CloseBtn = new System.Windows.Forms.Button();
         this.MessageTextBox = new System.Windows.Forms.TextBox();
         this.SaveBtn = new System.Windows.Forms.Button();
         this.LoadBtn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // PlayersListView
         // 
         this.PlayersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.NameColumn, this.ClubColumn, this.GoalsColumn});
         this.PlayersListView.FullRowSelect = true;
         this.PlayersListView.Location = new System.Drawing.Point(21, 19);
         this.PlayersListView.Name = "PlayersListView";
         this.PlayersListView.Size = new System.Drawing.Size(562, 293);
         this.PlayersListView.TabIndex = 0;
         this.PlayersListView.UseCompatibleStateImageBehavior = false;
         this.PlayersListView.View = System.Windows.Forms.View.Details;
         // 
         // NameColumn
         // 
         this.NameColumn.Text = "Name";
         this.NameColumn.Width = 150;
         // 
         // ClubColumn
         // 
         this.ClubColumn.Text = "Club";
         this.ClubColumn.Width = 150;
         // 
         // GoalsColumn
         // 
         this.GoalsColumn.Text = "Goals";
         this.GoalsColumn.Width = 150;
         // 
         // AddBtn
         // 
         this.AddBtn.Location = new System.Drawing.Point(630, 19);
         this.AddBtn.Name = "AddBtn";
         this.AddBtn.Size = new System.Drawing.Size(136, 38);
         this.AddBtn.TabIndex = 1;
         this.AddBtn.Text = "Add";
         this.AddBtn.UseVisualStyleBackColor = true;
         this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
         // 
         // DeleteBtn
         // 
         this.DeleteBtn.Location = new System.Drawing.Point(630, 63);
         this.DeleteBtn.Name = "DeleteBtn";
         this.DeleteBtn.Size = new System.Drawing.Size(136, 38);
         this.DeleteBtn.TabIndex = 2;
         this.DeleteBtn.Text = "Delete";
         this.DeleteBtn.UseVisualStyleBackColor = true;
         this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
         // 
         // ChangeBtn
         // 
         this.ChangeBtn.Location = new System.Drawing.Point(630, 107);
         this.ChangeBtn.Name = "ChangeBtn";
         this.ChangeBtn.Size = new System.Drawing.Size(136, 38);
         this.ChangeBtn.TabIndex = 3;
         this.ChangeBtn.Text = "Change";
         this.ChangeBtn.UseVisualStyleBackColor = true;
         this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
         // 
         // TheBestPlayerBtn
         // 
         this.TheBestPlayerBtn.Location = new System.Drawing.Point(630, 151);
         this.TheBestPlayerBtn.Name = "TheBestPlayerBtn";
         this.TheBestPlayerBtn.Size = new System.Drawing.Size(136, 38);
         this.TheBestPlayerBtn.TabIndex = 4;
         this.TheBestPlayerBtn.Text = "The best player";
         this.TheBestPlayerBtn.UseVisualStyleBackColor = true;
         this.TheBestPlayerBtn.Click += new System.EventHandler(this.TheBestPlayerBtn_Click);
         // 
         // RegisterBtn
         // 
         this.RegisterBtn.Location = new System.Drawing.Point(630, 195);
         this.RegisterBtn.Name = "RegisterBtn";
         this.RegisterBtn.Size = new System.Drawing.Size(136, 38);
         this.RegisterBtn.TabIndex = 5;
         this.RegisterBtn.Text = "Register";
         this.RegisterBtn.UseVisualStyleBackColor = true;
         this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
         // 
         // CancelRegistrationBtn
         // 
         this.CancelRegistrationBtn.Location = new System.Drawing.Point(630, 239);
         this.CancelRegistrationBtn.Name = "CancelRegistrationBtn";
         this.CancelRegistrationBtn.Size = new System.Drawing.Size(136, 38);
         this.CancelRegistrationBtn.TabIndex = 6;
         this.CancelRegistrationBtn.Text = "Cancel registration";
         this.CancelRegistrationBtn.UseVisualStyleBackColor = true;
         this.CancelRegistrationBtn.Click += new System.EventHandler(this.CancelRegistrationBtn_Click);
         // 
         // CloseBtn
         // 
         this.CloseBtn.Location = new System.Drawing.Point(630, 371);
         this.CloseBtn.Name = "CloseBtn";
         this.CloseBtn.Size = new System.Drawing.Size(136, 38);
         this.CloseBtn.TabIndex = 7;
         this.CloseBtn.Text = "Close";
         this.CloseBtn.UseVisualStyleBackColor = true;
         this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
         // 
         // MessageTextBox
         // 
         this.MessageTextBox.Location = new System.Drawing.Point(21, 317);
         this.MessageTextBox.Multiline = true;
         this.MessageTextBox.Name = "MessageTextBox";
         this.MessageTextBox.Size = new System.Drawing.Size(562, 92);
         this.MessageTextBox.TabIndex = 9;
         // 
         // SaveBtn
         // 
         this.SaveBtn.Location = new System.Drawing.Point(630, 283);
         this.SaveBtn.Name = "SaveBtn";
         this.SaveBtn.Size = new System.Drawing.Size(136, 38);
         this.SaveBtn.TabIndex = 10;
         this.SaveBtn.Text = "Save";
         this.SaveBtn.UseVisualStyleBackColor = true;
         this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
         // 
         // LoadBtn
         // 
         this.LoadBtn.Location = new System.Drawing.Point(630, 327);
         this.LoadBtn.Name = "LoadBtn";
         this.LoadBtn.Size = new System.Drawing.Size(136, 38);
         this.LoadBtn.TabIndex = 11;
         this.LoadBtn.Text = "Load";
         this.LoadBtn.UseVisualStyleBackColor = true;
         this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 425);
         this.Controls.Add(this.LoadBtn);
         this.Controls.Add(this.SaveBtn);
         this.Controls.Add(this.MessageTextBox);
         this.Controls.Add(this.CloseBtn);
         this.Controls.Add(this.CancelRegistrationBtn);
         this.Controls.Add(this.RegisterBtn);
         this.Controls.Add(this.TheBestPlayerBtn);
         this.Controls.Add(this.ChangeBtn);
         this.Controls.Add(this.DeleteBtn);
         this.Controls.Add(this.AddBtn);
         this.Controls.Add(this.PlayersListView);
         this.Name = "InitForm";
         this.Text = "Champions League";
         this.ResumeLayout(false);
         this.PerformLayout();
      }

      private System.Windows.Forms.Button LoadBtn;
      private System.Windows.Forms.Button SaveBtn;

      private System.Windows.Forms.TextBox MessageTextBox;

      private System.Windows.Forms.ColumnHeader ClubColumn;
      private System.Windows.Forms.ColumnHeader GoalsColumn;
      private System.Windows.Forms.ColumnHeader NameColumn;

      public System.Windows.Forms.ListView PlayersListView;

      private System.Windows.Forms.Button CancelRegistrationBtn;

      private System.Windows.Forms.Button RegisterBtn;

      private System.Windows.Forms.Button TheBestPlayerBtn;

      private System.Windows.Forms.Button ChangeBtn;

      private System.Windows.Forms.Button CloseBtn;
      private System.Windows.Forms.Button DeleteBtn;

      private System.Windows.Forms.Button AddBtn;


      #endregion
   }
}