namespace LoginForm
{
    partial class Revenue
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
            this.lblcaldate1 = new System.Windows.Forms.Label();
            this.lblcaldate2 = new System.Windows.Forms.Label();
            this.listviewrevenue = new System.Windows.Forms.ListView();
            this.colmenuitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorderitem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colsales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colturnover = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butcalrevenue = new System.Windows.Forms.Button();
            this.datetimestartdate = new System.Windows.Forms.DateTimePicker();
            this.datetimeenddate = new System.Windows.Forms.DateTimePicker();
            this.monthcalendarrevenue = new System.Windows.Forms.MonthCalendar();
            this.lbldateerror = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcaldate1
            // 
            this.lblcaldate1.AutoSize = true;
            this.lblcaldate1.Location = new System.Drawing.Point(99, 145);
            this.lblcaldate1.Name = "lblcaldate1";
            this.lblcaldate1.Size = new System.Drawing.Size(70, 17);
            this.lblcaldate1.TabIndex = 0;
            this.lblcaldate1.Text = "Start date";
            // 
            // lblcaldate2
            // 
            this.lblcaldate2.AutoSize = true;
            this.lblcaldate2.Location = new System.Drawing.Point(371, 145);
            this.lblcaldate2.Name = "lblcaldate2";
            this.lblcaldate2.Size = new System.Drawing.Size(65, 17);
            this.lblcaldate2.TabIndex = 0;
            this.lblcaldate2.Text = "End date";
            // 
            // listviewrevenue
            // 
            this.listviewrevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmenuitem,
            this.colorderitem,
            this.colsales,
            this.colturnover});
            this.listviewrevenue.HideSelection = false;
            this.listviewrevenue.Location = new System.Drawing.Point(36, 312);
            this.listviewrevenue.MultiSelect = false;
            this.listviewrevenue.Name = "listviewrevenue";
            this.listviewrevenue.OwnerDraw = true;
            this.listviewrevenue.Size = new System.Drawing.Size(558, 386);
            this.listviewrevenue.TabIndex = 1;
            this.listviewrevenue.UseCompatibleStateImageBehavior = false;
            this.listviewrevenue.View = System.Windows.Forms.View.Details;
            // 
            // colmenuitem
            // 
            this.colmenuitem.Text = "Menu Item";
            this.colmenuitem.Width = 200;
            // 
            // colorderitem
            // 
            this.colorderitem.Text = "Order Item";
            this.colorderitem.Width = 75;
            // 
            // colsales
            // 
            this.colsales.Text = "Sales";
            // 
            // colturnover
            // 
            this.colturnover.Text = "Turnover";
            this.colturnover.Width = 80;
            // 
            // butcalrevenue
            // 
            this.butcalrevenue.Location = new System.Drawing.Point(621, 626);
            this.butcalrevenue.Name = "butcalrevenue";
            this.butcalrevenue.Size = new System.Drawing.Size(157, 47);
            this.butcalrevenue.TabIndex = 4;
            this.butcalrevenue.Text = "Calculate Revenue";
            this.butcalrevenue.UseVisualStyleBackColor = true;
            // 
            // datetimestartdate
            // 
            this.datetimestartdate.Location = new System.Drawing.Point(36, 164);
            this.datetimestartdate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.datetimestartdate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.datetimestartdate.Name = "datetimestartdate";
            this.datetimestartdate.Size = new System.Drawing.Size(200, 22);
            this.datetimestartdate.TabIndex = 5;
            this.datetimestartdate.ValueChanged += new System.EventHandler(this.datetimestartdate_ValueChanged);
            // 
            // datetimeenddate
            // 
            this.datetimeenddate.Location = new System.Drawing.Point(302, 165);
            this.datetimeenddate.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.datetimeenddate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.datetimeenddate.Name = "datetimeenddate";
            this.datetimeenddate.Size = new System.Drawing.Size(200, 22);
            this.datetimeenddate.TabIndex = 6;
            this.datetimeenddate.ValueChanged += new System.EventHandler(this.datetimeenddate_ValueChanged);
            // 
            // monthcalendarrevenue
            // 
            this.monthcalendarrevenue.Location = new System.Drawing.Point(650, 164);
            this.monthcalendarrevenue.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.monthcalendarrevenue.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.monthcalendarrevenue.Name = "monthcalendarrevenue";
            this.monthcalendarrevenue.TabIndex = 7;
            // 
            // lbldateerror
            // 
            this.lbldateerror.AutoSize = true;
            this.lbldateerror.ForeColor = System.Drawing.Color.Red;
            this.lbldateerror.Location = new System.Drawing.Point(33, 292);
            this.lbldateerror.Name = "lbldateerror";
            this.lbldateerror.Size = new System.Drawing.Size(235, 17);
            this.lbldateerror.TabIndex = 8;
            this.lbldateerror.Text = "Use start date before the end date *";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldateerror);
            this.Controls.Add(this.monthcalendarrevenue);
            this.Controls.Add(this.datetimeenddate);
            this.Controls.Add(this.datetimestartdate);
            this.Controls.Add(this.butcalrevenue);
            this.Controls.Add(this.listviewrevenue);
            this.Controls.Add(this.lblcaldate2);
            this.Controls.Add(this.lblcaldate1);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcaldate1;
        private System.Windows.Forms.Label lblcaldate2;
        private System.Windows.Forms.ListView listviewrevenue;
        private System.Windows.Forms.Button butcalrevenue;
        private System.Windows.Forms.DateTimePicker datetimestartdate;
        private System.Windows.Forms.DateTimePicker datetimeenddate;
        private System.Windows.Forms.MonthCalendar monthcalendarrevenue;
        private System.Windows.Forms.Label lbldateerror;
        private System.Windows.Forms.ColumnHeader colmenuitem;
        private System.Windows.Forms.ColumnHeader colorderitem;
        private System.Windows.Forms.ColumnHeader colsales;
        private System.Windows.Forms.ColumnHeader colturnover;
        private System.Windows.Forms.Button button1;
    }
}