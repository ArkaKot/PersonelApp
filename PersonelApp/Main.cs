using PersonelApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PersonelApp
{
    public partial class Main : Form
    {
        private FileHelper<List<Person>> _fileHelper = new FileHelper<List<Person>>(Path.Combine(Program.FilePath));

        private List<Contract> _contractType;

        private List<EmploymentStatus> _employmentStatus;

        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximazie;
            }
            set
            {
                Settings.Default.IsMaximazie = value;
            }
        }

        public Main()
        {
            InitializeComponent();

            _contractType = ContractList.GetPersonContractList("Rodzaj Umowy");
            _employmentStatus = EmploymentStatusList.GetPersonEmploymentStatusList("Wszystkie");

            InitContractPerson();
            InitEmplymentStatus();

            RefreshPersonalList();
            SetColumnHeader();
            SetColumnDateTimeFormat();

            HideColumns();

            if (IsMaximize)
            {
                WindowState = FormWindowState.Maximized;
            }

            ActualTime();

            SetUserName();

            Load += Main_Load;
        }

        private void SetColumnDateTimeFormat()
        {
            dgvPersonel.Columns[nameof(Person.BirthDate)].DefaultCellStyle.Format = "MM.dd.yyyy";
            dgvPersonel.Columns[nameof(Person.StartDate)].DefaultCellStyle.Format = "MM.dd.yyyy";
            dgvPersonel.Columns[nameof(Person.EndDate)].DefaultCellStyle.Format = "MM.dd.yyyy";
        }

        private void Main_Load(object sender, EventArgs e)
        {

            dgvPersonel.SelectionChanged += DgvPersonel_SelectionChanged;
            CheckDismissButton();
        }

        private void ActualTime()
        {
            if (Settings.Default.TimerVisible == true)
            {
                lbActualDateTime.Visible = true;
                lbActualDateTime.Text = DateTime.Now.ToString();
            }
            else
            {
                lbActualDateTime.Visible = false;
            }
        }

        private void SetUserName()
        {
            if (Settings.Default.UserName == null)
            {
                lbNameUser.Visible = false;
            }
            else
            {
                lbNameUser.Text = "Witaj " + Settings.Default.UserName;

                lbNameUser.Visible = true;
            }
        }

        private void InitContractPerson()
        {
            cbContractType.DataSource = _contractType;
            cbContractType.DisplayMember = "Name";
            cbContractType.ValueMember = "Id";
        }

        private void InitEmplymentStatus()
        {
            cmbEmplymentStatus.DataSource = _employmentStatus;
            cmbEmplymentStatus.DisplayMember = "Name";
            cmbEmplymentStatus.ValueMember = "Id";
        }

        private void HideColumns()
        {
            dgvPersonel.Columns[nameof(Person.Id)].Visible = false;
            dgvPersonel.Columns[nameof(Person.ContractId)].Visible = false;
            dgvPersonel.Columns[nameof(Person.EmploymentStatusId)].Visible = false;
        }

        private void DgvPersonel_SelectionChanged(object sender, EventArgs e)
        {
            CheckDismissButton();
        }

        private void RefreshPersonalList()
        {
            var persons = _fileHelper.DeserializeFromFile();

            var selectedContractId = (cbContractType.SelectedItem as Contract).Id;

            var selectedEmplymentStatus = (cmbEmplymentStatus.SelectedItem as EmploymentStatus).Id;


            if (selectedContractId != 0)
            {
                persons = persons.Where(x => x.ContractId == selectedContractId).ToList();
               
            }

            if (selectedEmplymentStatus != 0)
            {
                persons = persons.Where(y => y.EmploymentStatusId == selectedEmplymentStatus).ToList();
            }

            persons = persons.OrderBy(p => p.Id).ToList();

            dgvPersonel.DataSource = persons;
        }

        private void SetColumnHeader()
        {
            dgvPersonel.Columns[nameof(Person.Id)].HeaderText = "Numer";
            dgvPersonel.Columns[nameof(Person.FirstName)].HeaderText = "Imię";
            dgvPersonel.Columns[nameof(Person.LastName)].HeaderText = "Nazwisko";
            dgvPersonel.Columns[nameof(Person.BirthDate)].HeaderText = "Data Urodzenia";
            dgvPersonel.Columns[nameof(Person.StartDate)].HeaderText = "Data rozpoczęcia";
            dgvPersonel.Columns[nameof(Person.EndDate)].HeaderText = "Data zakończenia";
            dgvPersonel.Columns[nameof(Person.Comments)].HeaderText = "Komentarz";
            dgvPersonel.Columns[nameof(Person.Salary)].HeaderText = "Wynagrodzenie";
            dgvPersonel.Columns[nameof(Person.ContractId)].HeaderText = "Id Umowy";
            dgvPersonel.Columns[nameof(Person.ContractName)].HeaderText = "Rodzaj Umowy";
            dgvPersonel.Columns[nameof(Person.Student)].HeaderText = "Student";
            dgvPersonel.Columns[nameof(Person.EmploymentStatusId)].HeaderText = "Numer Statusu";
            dgvPersonel.Columns[nameof(Person.EmploymentStatusName)].HeaderText = "Status";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditPerson = new AddEditPerson();

            addEditPerson.FormClosing += AddEditPerson_FormClosing;

            addEditPerson.ShowDialog();
        }

        private void AddEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshPersonalList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedPerson = dgvPersonel.SelectedRows[0];

            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę o zaznaczenie pracownika, którego dane chcesz edytować");
                return;
            }

            var addEditPerson = new AddEditPerson(
                Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells[0].Value));
            addEditPerson.FormClosing += AddEditPerson_FormClosing;
            addEditPerson.ShowDialog();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            var selectedPerson = dgvPersonel.SelectedRows[0];

            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę o zaznaczenie pracownika, którego chcesz zwolnić");
                return;
            }

            var confirmQuit = MessageBox.Show($"Czy na pewno chcesz zwolnić osobę o{(selectedPerson.Cells[1].Value.ToString() + " " + selectedPerson.Cells[2].Value.ToString()).Trim()}", "Zwalnianie Pracownika", MessageBoxButtons.OKCancel);

            if (confirmQuit == DialogResult.OK)
            {
                DismissPerson(Convert.ToInt32(selectedPerson.Cells[0].Value));
                RefreshPersonalList();

            }
        }

        private void DismissPerson(int id)
        {
            var persons = _fileHelper.DeserializeFromFile();

            var checkPerson = persons.FirstOrDefault(x => x.Id == id);

            checkPerson.EndDate = DateTime.Now;
            checkPerson.EmploymentStatusId = 2;
            checkPerson.EmploymentStatusName = "Zwolniony/a";

            _fileHelper.SerializeToFile(persons);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPersonalList();
        }

        private void CheckDismissButton()
        {
            if (dgvPersonel.SelectedRows.Count == 0)
            {
                DissmissAndEdit(false);
                return;
            }
            var checkValueDateEnd = dgvPersonel.SelectedRows[0];

            var ValueCheck = checkValueDateEnd.Cells["EndDate"].Value;

            if (dgvPersonel.SelectedRows.Count == 0)
            {
                btnDismiss.Enabled = true;
                return;
            }

            if (ValueCheck == null)
            {
                var check = true;
                DissmissAndEdit(check);
            }
            else
            {
                var check = false;
                DissmissAndEdit(check);
            }
        }

        private void DissmissAndEdit(bool check)
        {
            btnDismiss.Enabled = check;
            btnDismiss.BackColor = Color.IndianRed;
            btnEdit.Enabled = check;
            btnEdit.BackColor = Color.DodgerBlue;
        }

        private void dgvPersonel_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var persons = _fileHelper.DeserializeFromFile();

            var personWithHighestId = persons.OrderByDescending(x => x.Id).FirstOrDefault();

            var row = dgvPersonel.Rows.Count - 1;

            if (personWithHighestId.Id - 1 > 0)
            {
                dgvPersonel.Rows[row].DefaultCellStyle.BackColor = Color.Yellow;
            }

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var userSettingsApp = new UserSettingsApp();

            userSettingsApp.FormClosing += UserSettingsApp_FormClosing;

            userSettingsApp.ShowDialog();
        }

        private void UserSettingsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshPersonalList();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();
        }
    }
}