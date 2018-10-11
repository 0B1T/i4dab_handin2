--
-- Create Table    : 'Address'   
-- AddressID       :  
-- RoadName        :  
-- HouseNumber     :  
-- Story           :  
-- IsRegisteredAddress :  
-- AddressType     :  
-- CityID          :  (references City.CityID)
--
CREATE TABLE Address (
    AddressID      INT NOT NULL,
    RoadName       VARCHAR(50) NULL,
    HouseNumber    VARCHAR(50) NULL,
    Story          INT NULL,
    IsRegisteredAddress CHAR(1) NULL,
    AddressType    VARCHAR(50) NULL,
    CityID         INT NOT NULL,
CONSTRAINT pk_Address PRIMARY KEY CLUSTERED (AddressID),
CONSTRAINT fk_Address FOREIGN KEY (CityID)
    REFERENCES City (CityID)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)