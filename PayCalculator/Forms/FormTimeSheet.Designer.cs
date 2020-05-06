namespace PayCalculator.Forms
{
    partial class FormTimeSheet
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgtimesheet = new System.Windows.Forms.DataGridView();
            this.Columnweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnbasic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnstdot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnhrot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntravel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnholiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnbankholiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnillness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnchangeover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columntotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblselect = new System.Windows.Forms.Label();
            this.btnexport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtimesheet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(188, 15);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 42);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE DATA";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(82, 37);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.Text = "Ziad0412";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(82, 15);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 7;
            this.txtusername.Text = "ASOUIRITE1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            // 
            // dgtimesheet
            // 
            this.dgtimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtimesheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnweek,
            this.Columnbasic,
            this.Columnstdot,
            this.Columnhrot,
            this.Columnnight,
            this.Columntravel,
            this.Columnholiday,
            this.Columnbankholiday,
            this.Columnillness,
            this.Columnchangeover,
            this.Columntotal});
            this.dgtimesheet.Location = new System.Drawing.Point(12, 63);
            this.dgtimesheet.Name = "dgtimesheet";
            this.dgtimesheet.Size = new System.Drawing.Size(776, 375);
            this.dgtimesheet.TabIndex = 10;
            // 
            // Columnweek
            // 
            this.Columnweek.HeaderText = "Week";
            this.Columnweek.Name = "Columnweek";
            // 
            // Columnbasic
            // 
            this.Columnbasic.HeaderText = "Basic";
            this.Columnbasic.Name = "Columnbasic";
            // 
            // Columnstdot
            // 
            this.Columnstdot.HeaderText = "Standard Overtime";
            this.Columnstdot.Name = "Columnstdot";
            // 
            // Columnhrot
            // 
            this.Columnhrot.HeaderText = "High Rate Overtime";
            this.Columnhrot.Name = "Columnhrot";
            // 
            // Columnnight
            // 
            this.Columnnight.HeaderText = "Nights";
            this.Columnnight.Name = "Columnnight";
            // 
            // Columntravel
            // 
            this.Columntravel.HeaderText = "Travel";
            this.Columntravel.Name = "Columntravel";
            // 
            // Columnholiday
            // 
            this.Columnholiday.HeaderText = "Holiday";
            this.Columnholiday.Name = "Columnholiday";
            // 
            // Columnbankholiday
            // 
            this.Columnbankholiday.HeaderText = "Bank Holiday";
            this.Columnbankholiday.Name = "Columnbankholiday";
            // 
            // Columnillness
            // 
            this.Columnillness.HeaderText = "Illness";
            this.Columnillness.Name = "Columnillness";
            // 
            // Columnchangeover
            // 
            this.Columnchangeover.HeaderText = "Changeover";
            this.Columnchangeover.Name = "Columnchangeover";
            // 
            // Columntotal
            // 
            this.Columntotal.HeaderText = "Total";
            this.Columntotal.Name = "Columntotal";
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(387, 44);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(28, 13);
            this.lblselect.TabIndex = 11;
            this.lblselect.Text = "data";
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(713, 15);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(75, 41);
            this.btnexport.TabIndex = 12;
            this.btnexport.Text = "Export To Excel";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(454, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(243, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Week Selected :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Progress :";
            // 
            // FormTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.dgtimesheet);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTimeSheet";
            this.Text = "Time Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.dgtimesheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnweek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnbasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnstdot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnhrot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnholiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnbankholiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnillness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnchangeover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columntotal;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Button btnexport;
        public System.Windows.Forms.DataGridView dgtimesheet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}