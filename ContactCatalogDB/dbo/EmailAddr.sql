--
-- Create Table    : 'EmailAddr'   
-- EmailID         :  
-- PersonID        :  (references Person.PersonID)
-- IsPrimary       :  
-- EmailAddr       :  
--
CREATE TABLE EmailAddr (
    EmailID        INT NOT NULL,
    PersonID       INT NOT NULL,
    IsPrimary      CHAR(1) NULL,
    EmailAddr      VARCHAR(50) NOT NULL,
CONSTRAINT pk_EmailAddr PRIMARY KEY CLUSTERED (EmailID),
CONSTRAINT fk_EmailAddr FOREIGN KEY (PersonID)
    REFERENCES Person (PersonID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)