

drop table Rental;
drop table RentalOption;
drop table DriversLicense;
drop table DriversLicenseCategory;
drop table Client ;
drop table CarFeatureMap ;
drop table CarFeature;
drop table Car;


create table Car 
(
	id serial primary key,
	mark text,
	model text,
	vin text,
	color text
);

create table CarFeature
(
	id serial primary key,
	feature text
);

create table CarFeatureMap 
(
	id serial primary key,
	id_Car integer references Car(id) not null,
	id_CarFeature integer references CarFeature(id) not null
);

create table Client
(
	id serial primary key,
	name text,
	surname text,
	nationalid text,
	birthdate timestamp
);

create table DriversLicenseCategory
(
	id serial primary key,
	name text
);

insert into DriversLicenseCategory (name) values ('A');
insert into DriversLicenseCategory (name) values ('B');
insert into DriversLicenseCategory (name) values ('C');
insert into DriversLicenseCategory (name) values ('D');
insert into DriversLicenseCategory (name) values ('E');

create table DriversLicense
(
	id serial primary key,
	licensenumber text,
	issuedate timestamp,
	id_DriversLicenseCategory integer references DriversLicenseCategory(id) not null
);




create table RentalOption
(
	id serial primary key,
	kilometerlimit numeric,
	price numeric,
	rentalinterval integer,
	startdate timestamp,
	id_Client integer references Client(id) not null
);


create table Rental
(
	id serial primary key,
	id_RentalOption integer references RentalOption(id) not null
);
----------------

create table CarFeatures
(
	id serial primary key,
	feature text
);

create table CarFeatures
(
	id serial primary key,
	feature text
);

