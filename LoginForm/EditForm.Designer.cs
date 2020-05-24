namespace LoginForm
{
    partial class EditForm
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
            this.Backbuttonedit = new System.Windows.Forms.Button();
            this.EditView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Backbuttonedit
            // 
            this.Backbuttonedit.Location = new System.Drawing.Point(16, 15);
            this.Backbuttonedit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Backbuttonedit.Name = "Backbuttonedit";
            this.Backbuttonedit.Size = new System.Drawing.Size(188, 48);
            this.Backbuttonedit.TabIndex = 0;
            this.Backbuttonedit.Text = "Back to orders";
            this.Backbuttonedit.UseVisualStyleBackColor = true;
            this.Backbuttonedit.Click += new System.EventHandler(this.Backbuttonedit_Click);
            // 
            // EditView
            // 
            this.EditView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.EditView.HideSelection = false;
            this.EditView.Location = new System.Drawing.Point(644, 15);
            this.EditView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditView.Name = "EditView";
            this.EditView.Size = new System.Drawing.Size(405, 189);
            this.EditView.TabIndex = 1;
            this.EditView.UseCompatibleStateImageBehavior = false;
            this.EditView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 75;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.EditView);
            this.Controls.Add(this.Backbuttonedit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditForm";
            this.Text = "Edit form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbuttonedit;
        private System.Windows.Forms.ListView EditView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}