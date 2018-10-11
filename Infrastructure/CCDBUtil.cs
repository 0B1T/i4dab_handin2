using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DomainModel;

namespace Infrastructure
{
    public class CCDBUtil
    {
        private readonly Person _currentPerson;

        // CTOR:
        public CCDBUtil()
        {
            _currentPerson = new Person()
            {
                PersonID = 0,
                FirstName = "",
                MiddleName = "",
                LastName = "",
                ContactType = "",
            };
        }

        // Opens SQL Connection:
        private SqlConnection OpenConnection
        {
            get
            {
                var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactCatalogDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True");

                connection.Open();

                return connection;
            }
        }

        // Add Person function:
        #region AddPersonToDB

        public void AddPersonToDB(ref Person per)
        {
            string insertStringParam = @"INSERT INTO [Person] (FirstName, MiddleName, LastName, ContactType)
                                                OUTPUT INSERTED.PersonID
                                                VALUES (@FirstName, @MiddleName, @LastName, @ContactType)";

            using (SqlCommand cmd = new SqlCommand(insertStringParam, OpenConnection))
            {
                cmd.Parameters.AddWithValue("@FirstName", per.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", per.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", per.LastName);
                cmd.Parameters.AddWithValue("@ContactType", per.ContactType);

                per.PersonID = (int)cmd.ExecuteScalar(); //Returns the identity of the new tuple/record
            }
        }

        #endregion

        // Read Person function:
        #region ReadPersons

        public List<Person> ReadPersons()
        {
            string sqlCmd = @"SELECT * FROM Person";

            using (var cmd = new SqlCommand(sqlCmd, OpenConnection))
            {
                var rdr = cmd.ExecuteReader();

                var eachPerson = new List<Person>();

                while (rdr.Read())
                {
                    var per = new Person();
                    per.PersonID = (int)rdr["PersonID"];
                    per.FirstName = (string)rdr["FirstName"];
                    per.MiddleName = (string)rdr["MiddleName"];
                    per.LastName = (string)rdr["LastName"];
                    per.ContactType = (string)rdr["ContactType"];
                    eachPerson.Add(per);
                }

                return eachPerson;
            }
        }

        #endregion

        // TODO: Implement more functions...
    }
}
