
create table logins(
id int NOT NULL IDENTITY(1,1) primary key,
username varchar(50) not null,
pass varchar(50) not null
)

insert into logins (username,pass) values ('admin','skills@123');

select * from logins

create table registration
(
	regno int NOT NULL primary key,
	firstname varchar(50),
	lastname varchar(50),
	dateofbirth dateTime,
	gender varchar(50),
	address1 varchar(50),
	email varchar(50),
	mobilephone int,
	homephone int,
	parentname varchar(50),
	nic varchar(50),
	contactno int,
);

select * from registration

drop table registration