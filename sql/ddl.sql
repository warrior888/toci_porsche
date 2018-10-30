drop table CarFeaturesMap ;
drop table CarFeatures;
drop table Car;


create table Car 
(
	id serial primary key,
	mark text,
	model text,
	vin text
	color text
);

create table CarFeatures
(
	id serial primary key,
	feature text
);

create table CarFeaturesMap 
(
	id serial primary key,
	id_Car integer references Car(id) not null,
	id_CarFeatures integer references Car(id) not null
);

