namespace DomainModel
{
    public class PhoneNumbers
    {
        public virtual int PhoneID { get; set; }

        public virtual int PhoneNumber { get; set; }

        public virtual string Provider { get; set; }

        public virtual string PhoneType { get; set; }
    }
}


/*
CREATE TABLE PhoneNumber (
    PhoneID        INT NOT NULL,
    PersonID       INT NOT NULL,
    PhoneNumber    INT NULL,
    Provider       VARCHAR(50) NULL,
    PhoneType      VARCHAR(50) NULL,
CONSTRAINT pk_PhoneNumber PRIMARY KEY CLUSTERED (PhoneID),
CONSTRAINT fk_PhoneNumber FOREIGN KEY (PersonID)
    REFERENCES Person (PersonID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE) 
*/