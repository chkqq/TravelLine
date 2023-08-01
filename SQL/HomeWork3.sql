use CarMechanic

create table Car (
    CarId int identity(1, 1) not null constraint PK_Car primary key,
    CarName nvarchar(50) not null,
    HorsePower int not null,
    TypeOfRepair nvarchar(50) null
)

create table Client (
    ClientId int identity(1, 1) not null constraint PK_Client primary key,
    ClientFirstName nvarchar(50) not null,
    ClientLastName nvarchar(50) not null
)

create table CarMechanic (
    CarMechanicId int identity(1, 1) not null constraint PK_CarMechanic primary key,
    CarId int not null constraint FK_CarMechanic_Car references Car(CarId)
        on delete cascade
        on update cascade,
    ClientId int not null constraint FK_CarMechanic_Client references Client(ClientId)
        on delete cascade
        on update cascade,
    RepairCost int not null
)

insert into Car (CarName, HorsePower, TypeOfRepair)
values
	(N'Porshe Cayenne 2018', 300, N'Замена масла'),
	(N'Toyota Camry 2003', 210, N'Замена свечей'),
	(N'Vaz 2107', 74, N'Шиномонтаж'),
	(N'Mercedec GLE', 255, N'Ремонт компьютера'),
	(N'Bmw X5', 310, N'Ремонт коробки передач')

insert into Client(ClientFirstName, ClientLastName)
values
    (N'Иванов', N'Максим'),
	(N'Лебедев', N'Иван'),
	(N'Попова', N'Маша'),
    (N'Александр', N'Мудренко'),
	(N'Сергей', N'Горняков')


insert into CarMechanic(CarId, ClientId, RepairCost)
values
    (1, 3, 10000),
	(2, 1, 12000),
	(3, 2, 3000),
    (7, 5, 5000),
	(8, 4, 20000)

-- selects
select CarName from Car where HorsePower like 300

select RepairCost from CarMechanic where RepairCost < 10000

select CarId, RepairCost from CarMechanic 
	where RepairCost >= 10000

select ClientFirstName, ClientLastName from Client 
    where ClientFirstName = 'Cергей'

select top 3 * from Car

select * from Car order by HorsePower

select ClientFirstName from Client where ClientId in (2, 3)

select CarName from Car where HorsePower > 300

update Car set TypeOfRepair = N'Компьютерная Диагностика' where CarId = 1

update Client set ClientLastName = N'Иванов' where ClientFirstName like 'С%'

update CarMechanic set RepairCost = 5000 where CarId = 3 or ClientId = 5

delete from Car where CarId = 2
-- inner select join
select
	Client.ClientFirstName as ClientFirstName,
	Car.CarName as CarName,
	Car.HorsePower as CarHorsePower,
	CarMechanic.RepairCost
from CarMechanic
join Client on CarMechanic.ClientId = Client.ClientId
join Car on CarMechanic.CarId = Car.CarId
-- left join
select
	Client.CLientLastName as ClientLastName,
	CarMechanic.RepairCost
from Client
left join CarMechanic on Client.ClientId = CarMechanic.ClientId
-- right join
select
	CarMechanic.RepairCost,
	Car.CarName as CarName
from Car
right join CarMechanic on Car.CarId = CarMechanic.CarId
