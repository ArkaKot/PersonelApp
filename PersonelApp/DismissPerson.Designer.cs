namespace PersonelApp
{
    partial class DismissPerson
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
            this.btnAkcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbDismiss = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAkcept
            // 
            this.btnAkcept.Location = new System.Drawing.Point(168, 95);
            this.btnAkcept.Name = "btnAkcept";
            this.btnAkcept.Size = new System.Drawing.Size(75, 23);
            this.btnAkcept.TabIndex = 0;
            this.btnAkcept.Text = "Akceptuj";
            this.btnAkcept.UseVisualStyleBackColor = true;
            this.btnAkcept.Click += new System.EventHandler(this.btnAkcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(78, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbDismiss
            // 
            this.lbDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDismiss.AutoSize = true;
            this.lbDismiss.Location = new System.Drawing.Point(55, 20);
            this.lbDismiss.Name = "lbDismiss";
            this.lbDismiss.Size = new System.Drawing.Size(168, 13);
            this.lbDismiss.TabIndex = 2;
            this.lbDismiss.Text = "Podaj datę zwolnienia pracownika";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(43, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // DismissPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 138);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lbDismiss);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAkcept);
            this.Name = "DismissPerson";
            this.Text = "Zwolnienie Pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAkcept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbDismiss;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}