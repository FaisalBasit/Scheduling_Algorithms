create Database FCFS_lOGIN
use FCFS_lOGIN

CREATE TABLE users (
    username VARCHAR(50) PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    pass VARCHAR(255) NOT NULL, 
    cardnum VARCHAR(16) NULL, 
    cardexpirydate varchar(20) NULL,
    cvv INT CHECK (cvv >= 100 AND cvv <= 999) NULL,
	feedback Varchar(500) NULL,
	paid varchar(50) NULL
);

drop table users


select * from users

delete from users
