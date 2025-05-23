using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelApp
{

    public partial class DismissPerson : Form
    {

        private FileHelper<List<Person>> _fileHelper = new FileHelper<List<Person>>(Path.Combine(Program.FilePath));

        private DataGridView _dgvPerson;

        private int _personId;

        private Person _person;

        public DismissPerson(int id = 0, DataGridView dgv = null)
        {
            InitializeComponent();

            _dgvPerson = dgv;

            _personId = id;

            GetDismissDate();

            GetDateTime();
        }

        private void GetDateTime()
        {
            dtpEndDate.Text = _person.EndDate.ToString();
        }

        private void GetDismissDate()
        {
            var persons = _fileHelper.DeserializeFromFile();
            _person = persons.FirstOrDefault(x => x.Id == _personId);

            if (_person == null)
            {
                throw new Exception("Brak osoby o podanym Id");
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAkcept_Click(object sender, EventArgs e)
        {

            var selectedPerson = _dgvPerson.SelectedRows[0];

            var persons = _fileHelper.DeserializeFromFile();

            var confirmQuit = MessageBox.Show($"Czy na pewno chcesz zwolnić osobę o{(selectedPerson.Cells[1].Value.ToString() + " " + selectedPerson.Cells[2].Value.ToString()).Trim()}", "Zwalnianie Pracownika", MessageBoxButtons.OKCancel);

            if (confirmQuit == DialogResult.OK)
            {
                DismissActivePerson(Convert.ToInt32(selectedPerson.Cells[0].Value));

            }

            Close();
        }


        private void DismissActivePerson(int id)
        {

            var persons = _fileHelper.DeserializeFromFile();

            var checkPerson = persons.FirstOrDefault(x => x.Id == id);

            checkPerson.EndDate = dtpEndDate.Value;
            checkPerson.EmploymentStatusId = 2;
            checkPerson.EmploymentStatusName = "Zwolniony/a";

            _fileHelper.SerializeToFile(persons);

        }
    }
}
