namespace DomainModel
{
    public class Person
    {
        public virtual int PersonID { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string MiddleName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string ContactType { get; set; }

    }
}

/*
CREATE TABLE Person (
    PersonID       INT NOT NULL,
    FirstName      VARCHAR(50) NOT NULL,
    MiddleName     VARCHAR(50) NULL,
    LastName       VARCHAR(50) NOT NULL,
    ContactType    VARCHAR(50) NULL,
CONSTRAINT pk_Person PRIMARY KEY CLUSTERED (PersonID))
 */