namespace PersonelApp
{
    partial class UserSettingsApp
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
            this.cbVisibleTime = new System.Windows.Forms.CheckBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnAkceptSettings = new System.Windows.Forms.Button();
            this.btnCancelSetting = new System.Windows.Forms.Button();
            this.lbMinAge = new System.Windows.Forms.Label();
            this.nupMinAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinAge)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVisibleTime
            // 
            this.cbVisibleTime.AutoSize = true;
            this.cbVisibleTime.Location = new System.Drawing.Point(167, 84);
            this.cbVisibleTime.Name = "cbVisibleTime";
            this.cbVisibleTime.Size = new System.Drawing.Size(87, 17);
            this.cbVisibleTime.TabIndex = 0;
            this.cbVisibleTime.Text = "Pokaż Zegar";
            this.cbVisibleTime.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(12, 17);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(104, 13);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "Nazwa Użytkownika";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(122, 14);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(139, 20);
            this.tbUserName.TabIndex = 2;
            // 
            // btnAkceptSettings
            // 
            this.btnAkceptSettings.Location = new System.Drawing.Point(186, 117);
            this.btnAkceptSettings.Name = "btnAkceptSettings";
            this.btnAkceptSettings.Size = new System.Drawing.Size(75, 23);
            this.btnAkceptSettings.TabIndex = 3;
            this.btnAkceptSettings.Text = "Akceptuj";
            this.btnAkceptSettings.UseVisualStyleBackColor = true;
            this.btnAkceptSettings.Click += new System.EventHandler(this.btnAkceptSettings_Click);
            // 
            // btnCancelSetting
            // 
            this.btnCancelSetting.Location = new System.Drawing.Point(105, 117);
            this.btnCancelSetting.Name = "btnCancelSetting";
            this.btnCancelSetting.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSetting.TabIndex = 4;
            this.btnCancelSetting.Text = "Anuluj";
            this.btnCancelSetting.UseVisualStyleBackColor = true;
            this.btnCancelSetting.Click += new System.EventHandler(this.btnCancelSetting_Click);
            // 
            // lbMinAge
            // 
            this.lbMinAge.AutoSize = true;
            this.lbMinAge.Location = new System.Drawing.Point(12, 52);
            this.lbMinAge.Name = "lbMinAge";
            this.lbMinAge.Size = new System.Drawing.Size(81, 13);
            this.lbMinAge.TabIndex = 5;
            this.lbMinAge.Text = "Minimalny Wiek";
            // 
            // nupMinAge
            // 
            this.nupMinAge.Location = new System.Drawing.Point(122, 45);
            this.nupMinAge.Name = "nupMinAge";
            this.nupMinAge.Size = new System.Drawing.Size(139, 20);
            this.nupMinAge.TabIndex = 0;
            // 
            // UserSettingsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 152);
            this.Controls.Add(this.nupMinAge);
            this.Controls.Add(this.lbMinAge);
            this.Controls.Add(this.btnCancelSetting);
            this.Controls.Add(this.btnAkceptSettings);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.cbVisibleTime);
            this.Name = "UserSettingsApp";
            this.Text = "UserSettingsApp";
            ((System.ComponentModel.ISupportInitialize)(this.nupMinAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbVisibleTime;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnAkceptSettings;
        private System.Windows.Forms.Button btnCancelSetting;
        private System.Windows.Forms.Label lbMinAge;
        private System.Windows.Forms.NumericUpDown nupMinAge;
    }
}