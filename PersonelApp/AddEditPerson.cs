using PersonelApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PersonelApp
{
    public partial class AddEditPerson : Form
    {
        private int _personId;

        private Person _person;

        private List<Contract> _contractType;

        private FileHelper<List<Person>> _fileHelper = new FileHelper<List<Person>>(Program.FilePath);

        public AddEditPerson(int id = 0)
        {
            InitializeComponent();
            _personId = id;

            _contractType = ContractList.GetPersonContractList("Nie wybrano");

            InitContractPerson();

            GetPersonDate();
            tbName.Select();
        }

        private void InitContractPerson()
        {
            cbTypeContract.DataSource = _contractType;
            cbTypeContract.DisplayMember = "Name";
            cbTypeContract.ValueMember = "Id";
        }

        private void GetPersonDate()
        {

            if (_personId != 0)
            {
                Text = "Edycja Osoby";

                var persons = _fileHelper.DeserializeFromFile();
                _person = persons.FirstOrDefault(x => x.Id == _personId);

                if (_person == null)
                {
                    throw new Exception("Brak osoby o podanym Id");
                }

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _person.Id.ToString();
            tbName.Text = _person.FirstName;
            tbLastName.Text = _person.LastName;
            dtpAge.Text = _person.BirthDate.ToString();
            dtpStartDate.Text = _person.StartDate.ToString();
            dtpEndDate.Text = _person.EndDate.ToString();
            nupSalary.Text = _person.Salary.ToString();
            ckbStudent.Checked = _person.Student;
            rtbComment.Text = _person.Comments;
            cbTypeContract.SelectedItem = _contractType.FirstOrDefault(x => x.Id == _person.ContractId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAkcept_Click(object sender, EventArgs e)
        {
            if (VerifyUserData() == false)
            {
                return;
            }
            else
            {
                var persons = _fileHelper.DeserializeFromFile();

                if (_personId != 0)
                    persons.RemoveAll(x => x.Id == _personId);
                else
                    AssignIdToNewPerson(persons);

                AddNewPersonToList(persons);

                _fileHelper.SerializeToFile(persons);

                Close();
            }
        }

        private bool VerifyUserData()
        {
            var validationName = false;
            var validationLastName = false;
            var validationSalary = false;
            var validationContractType = false;
            var validationAge = false;
            bool isValid = false;

            if (string.IsNullOrEmpty(tbName.Text) == true)
            {
                MessageBox.Show("Wpisz Imię pracownika");
                tbName.BackColor = System.Drawing.Color.Red;
                validationName = false;
            }
            else
            {
                tbName.BackColor = System.Drawing.Color.White;
                validationName |= true;
            }

            if (string.IsNullOrEmpty(tbLastName.Text) == true)
            {
                MessageBox.Show("Wpisz Nazwisko pracownika");
                tbLastName.BackColor = System.Drawing.Color.Red;
                validationLastName = false;
            }
            else
            {
                tbLastName.BackColor = System.Drawing.Color.White;
                validationLastName = true;
            }

            if (nupSalary.Value <= 0)
            {
                MessageBox.Show("Wpisz wynagrodzenie pracownika");
                nupSalary.BackColor = System.Drawing.Color.Red;
                validationSalary = false;
            }
            else
            {
                nupSalary.BackColor = System.Drawing.Color.White;
                validationSalary = true;
            }

            if ((cbTypeContract.SelectedItem as Contract).Id == 0)
            {
                MessageBox.Show("Wybierz rodzaj umowy");
                cbTypeContract.BackColor = System.Drawing.Color.Red;
                validationContractType = false;
            }
            else
            {
                cbTypeContract.BackColor = System.Drawing.Color.White;
                validationContractType = true;
            }

            if (verifyAge() < Settings.Default.minAge)
            {
                MessageBox.Show("Pracownik jest za młody");
                validationAge = false;
            }
            else
                validationAge = true;

            if (validationName == true && validationLastName == true && validationSalary == true && validationContractType == true && validationAge == true)
            {
                return isValid = true;
            }
            return isValid = false;
        }

        private int verifyAge()
        {
            var personYear = dtpAge.Value.Year;
            var personMonth = dtpAge.Value.Month;
            var personDay = dtpAge.Value.Day;

            var result = DateTime.Now.Year - personYear;

            if (personMonth > DateTime.Now.Month)
            {
                return result = -1;
            }
            if (personMonth == DateTime.Now.Month && personDay > DateTime.Now.Day)
            {
                return result = -1;
            }
            return result;
        }

        private void AddNewPersonToList(List<Person> persons)
        {

            var person = new Person
            {
                Id = _personId,
                FirstName = tbName.Text,
                LastName = tbLastName.Text,
                BirthDate = dtpAge.Value,
                StartDate = dtpStartDate.Value,
                EndDate = null,
                Comments = rtbComment.Text,
                Salary = nupSalary.Value,
                Student = ckbStudent.Checked,
                ContractId = (cbTypeContract.SelectedItem as Contract).Id,
                ContractName = (cbTypeContract.SelectedItem as Contract).Name,
                EmploymentStatusId = 1,
                EmploymentStatusName = "Zatrudniony/a"

            };
            persons.Add(person);
        }

        private void AssignIdToNewPerson(List<Person> persons)
        {
            var personWithHighestId = persons.OrderByDescending(x => x.Id).FirstOrDefault();

            _personId = personWithHighestId == null ?
                1 : personWithHighestId.Id + 1;
        }
    }
}
