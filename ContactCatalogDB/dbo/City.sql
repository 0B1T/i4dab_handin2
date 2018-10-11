--
-- Create Table    : 'City'   
-- CityID          :  
-- CityName        :  
-- PostalCode      :  
--
CREATE TABLE City (
    CityID         INT NOT NULL,
    CityName       VARCHAR(50) NULL,
    PostalCode     VARCHAR(50) NULL,
CONSTRAINT pk_City PRIMARY KEY CLUSTERED (CityID))