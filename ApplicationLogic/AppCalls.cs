using System.Collections.Generic;
using DomainModel;
using Infrastructure;

namespace ApplicationLogic
{
    public class AppCalls
    {
        public void CreatePerson(Person newPerson)
        {
            new CCDBUtil().AddPersonToDB(ref newPerson);

            //var ccdbUtil = new CCDBUtil();

            //var newPerson = new Person()
            //    {FirstName = "John", MiddleName = "Romby", LastName = "Andersson", ContactType = "Private"};

            //ccdbUtil.AddPersonToDB(ref newPerson);
        }

        public List<Person> ReadPerson()
        {
            CCDBUtil ccdbUtil = new CCDBUtil();

            return ccdbUtil.ReadPersons();
        }

        public void UpdatePerson()
        {
            // TODO: Add functionality
        }

        public void DeletePerson()
        {
            // TODO: Add functionality
        }
    }
}
