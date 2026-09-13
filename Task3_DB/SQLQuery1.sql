create database hospital;
use hospital;
drop table if exists Examination;
drop table if exists Patient;
drop table if exists Nurse;
drop table if exists Ward;
drop table if exists Drug;
drop table if exists Consultant;

create table Consultant
(
consultant_id int primary key,
name nvarchar(100)

);
create table Ward
(
ward_id int primary key,
name nvarchar(100),

);
create table Nurse
(
number int primary key,
name nvarchar(100),
address nvarchar(100),
ward_id int,
constraint FK_ward_id foreign key (ward_id) references Ward(ward_id),

);

create table Drug
(
code_number int primary key,
dosgase nvarchar(100),
brand_name nvarchar(100),

);
create table Patient
(
patient_id int primary key,
name nvarchar(100),
date_of_birth date,
ward_id int,
constraint FK_Patient_Ward foreign key (ward_id) references Ward(ward_id),
consultant_id int,
constraint FK_consultant_id foreign key (consultant_id) references Consultant(consultant_id),
);
create table Examination
(
consultant_id int,
patient_id int ,
constraint PK_Examination primary key (consultant_id, patient_id),
constraint FK_consultant_id foreign key (consultant_id) references Consultant(consultant_id),
constraint FK_patient_id foreign key (patient_id) references Patient(patient_id),
);