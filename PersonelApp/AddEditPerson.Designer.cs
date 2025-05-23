namespace PersonelApp
{
    partial class AddEditPerson
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.ckbStudent = new System.Windows.Forms.CheckBox();
            this.cbTypeContract = new System.Windows.Forms.ComboBox();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAkcept = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dtpAge = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.nupSalary = new System.Windows.Forms.NumericUpDown();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lb5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(30, 40);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(26, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Imię";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(30, 76);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "Nazwisko";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(30, 112);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(78, 13);
            this.lbDateOfBirth.TabIndex = 2;
            this.lbDateOfBirth.Text = "DataUrodzenia";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(30, 148);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(90, 13);
            this.lb4.TabIndex = 3;
            this.lb4.Text = "Data rozpoczęcia";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(30, 262);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(76, 13);
            this.lb6.TabIndex = 5;
            this.lb6.Text = "Rodzaj umowy";
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Location = new System.Drawing.Point(30, 296);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(37, 13);
            this.lb9.TabIndex = 6;
            this.lb9.Text = "Uwagi";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(30, 221);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(81, 13);
            this.lb8.TabIndex = 8;
            this.lb8.Text = "Wynagrodzenie";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 9;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(141, 69);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(146, 20);
            this.tbLastName.TabIndex = 10;
            // 
            // ckbStudent
            // 
            this.ckbStudent.AutoSize = true;
            this.ckbStudent.Location = new System.Drawing.Point(224, 398);
            this.ckbStudent.Name = "ckbStudent";
            this.ckbStudent.Size = new System.Drawing.Size(63, 17);
            this.ckbStudent.TabIndex = 14;
            this.ckbStudent.Text = "Student";
            this.ckbStudent.UseVisualStyleBackColor = true;
            // 
            // cbTypeContract
            // 
            this.cbTypeContract.FormattingEnabled = true;
            this.cbTypeContract.Location = new System.Drawing.Point(141, 254);
            this.cbTypeContract.Name = "cbTypeContract";
            this.cbTypeContract.Size = new System.Drawing.Size(146, 21);
            this.cbTypeContract.TabIndex = 16;
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(140, 296);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(146, 96);
            this.rtbComment.TabIndex = 17;
            this.rtbComment.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAkcept
            // 
            this.btnAkcept.Location = new System.Drawing.Point(221, 433);
            this.btnAkcept.Name = "btnAkcept";
            this.btnAkcept.Size = new System.Drawing.Size(75, 23);
            this.btnAkcept.TabIndex = 19;
            this.btnAkcept.Text = "Akceptuj";
            this.btnAkcept.UseVisualStyleBackColor = true;
            this.btnAkcept.Click += new System.EventHandler(this.btnAkcept_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(30, 12);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(141, 9);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(146, 20);
            this.tbId.TabIndex = 21;
            // 
            // dtpAge
            // 
            this.dtpAge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAge.Location = new System.Drawing.Point(141, 105);
            this.dtpAge.Name = "dtpAge";
            this.dtpAge.Size = new System.Drawing.Size(147, 20);
            this.dtpAge.TabIndex = 22;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(140, 142);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(147, 20);
            this.dtpStartDate.TabIndex = 23;
            // 
            // nupSalary
            // 
            this.nupSalary.DecimalPlaces = 2;
            this.nupSalary.Location = new System.Drawing.Point(141, 219);
            this.nupSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupSalary.Name = "nupSalary";
            this.nupSalary.Size = new System.Drawing.Size(146, 20);
            this.nupSalary.TabIndex = 25;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(140, 181);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(147, 20);
            this.dtpEndDate.TabIndex = 24;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(30, 187);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(93, 13);
            this.lb5.TabIndex = 4;
            this.lb5.Text = "Data zakończenia";
            // 
            // AddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 470);
            this.Controls.Add(this.nupSalary);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpAge);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnAkcept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.cbTypeContract);
            this.Controls.Add(this.ckbStudent);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.MaximumSize = new System.Drawing.Size(327, 509);
            this.MinimumSize = new System.Drawing.Size(327, 509);
            this.Name = "AddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Osobę";
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.CheckBox ckbStudent;
        private System.Windows.Forms.ComboBox cbTypeContract;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAkcept;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DateTimePicker dtpAge;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown nupSalary;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}