using System;
using System.Windows.Forms;
using ApplicationLogic;

namespace ContactCatalogApp.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, System.EventArgs e)
        {
            new AppCalls().CreatePerson();
            MessageBox.Show("Created new Person in Database");
        }

        private void btnReadPerson_Click(object sender, EventArgs e)
        {
            var readAllPersons = new AppCalls().ReadPerson();

            listBoxDatabaseList.MultiColumn = true;
            listBoxDatabaseList.HorizontalScrollbar = true;
            listBoxDatabaseList.Items.Clear();

            listBoxDatabaseList.BeginUpdate();
            foreach (var item in readAllPersons)
            {
                listBoxDatabaseList.Items.Add(item.PersonID);
                listBoxDatabaseList.Items.Add(item.FirstName);
                listBoxDatabaseList.Items.Add(item.MiddleName);
                listBoxDatabaseList.Items.Add(item.LastName);
                listBoxDatabaseList.Items.Add(item.ContactType);
            }
            listBoxDatabaseList.EndUpdate();

            //MessageBox.Show("Reading all Persons in Database");
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            //new AppCalls().UpdatePerson();
            MessageBox.Show("Updated Person in Database");
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            //new AppCalls().DeletePerson();
            MessageBox.Show("Deleted Person in Database");
        }
    }
}
