create table Specialization(
	SpecializationID int Identity(1,1) primary key,
	SpecializationName varchar(50)
)

go

create table Doctor(
	DoctorID int Identity(1,1) primary key,
	DoctorName varchar(50),
	SpecializationID int,
	Address varchar(50),
	foreign key (SpecializationID) references Specialization(SpecializationID)
)	

go

insert into Specialization(SpecializationName) values 
('Internal Medicine'),
('Pediatrics'),
('Dentistry')

go

insert into Doctor(DoctorName, SpecializationID, Address) values 
('Dang Van Nam', 1, 'Quang Nam'),
('Nguyen The Bao', 2, 'Da Nang'),
('Tran Thi Ha', 3, 'Hue'),
('Thai Van Gioi', 3, 'Da Nang')