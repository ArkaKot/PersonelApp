using PersonelApp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonelApp
{
    public partial class UserSettingsApp : Form
    {
        public UserSettingsApp()
        {
            InitializeComponent();

            FillUserSetting();
        }

        public int minAge {
            get
            { 
                return Settings.Default.minAge;
            } 
            set
            {
                Settings.Default.minAge = value;
            }
        }

        public string UserName
        {
            get
            {
                return Settings.Default.UserName;
            }
            set
            {
                Settings.Default.UserName = value;
            }
        }

        public bool TimerVisible
        {
            get
            {
                return Settings.Default.TimerVisible;
            }
            set
            {
                Settings.Default.TimerVisible = value;
            }
        }

        private void FillUserSetting()
        {
            tbUserName.Text = Settings.Default.UserName;
            cbVisibleTime.Checked = Settings.Default.TimerVisible;
            nupMinAge.Value = Settings.Default.minAge;
        }

        private void btnCancelSetting_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAkceptSettings_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                tbUserName.BackColor = Color.Red;
                MessageBox.Show("Musisz podać nazwę użytkownika!");
                return;
            }
            else
            {
                tbUserName.BackColor = Color.White;
            }

            AddNewSettings();
            Close(); 
            Application.Restart();
        }

        private void AddNewSettings()
        {
            UserName = tbUserName.Text;
            TimerVisible = cbVisibleTime.Checked;
            minAge = Convert.ToInt32(nupMinAge.Value);

            Settings.Default.Save();
        }
    }
}
