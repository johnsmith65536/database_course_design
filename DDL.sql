create table customer_info
(
	job_num char(6) primary key,
	idcard_num char(18) not null,
	address_ char(256) not null,
	phone_num char(11) not null,
	amout_money int not null,
	pwd varbinary(1024) not null,
	name nchar(10) not null,
	sex nchar(2) not null,
	frozen bit not null
);
alter table user_info add constraint VAR_LEN check(len(phone_num)=11)


create table user_info
(
	job_num char(6) primary key,	
	pwd varbinary(1024) not null,	
	is_admin bit not null,
	name nchar(10) not null,
	sex nchar(2) not null
)
alter table user_info add constraint job_num_LEN check(len(job_num)=6)

create table operation_info
(
	serial_number char(12) primary key not null,
	time_stamp int not null,
	operator char(6) foreign key not null,
	source char(6) foreign key not null,
	destination char(6) foreign key not null,
	op_type int not null,
	delta int not null,
	balance int not null,
);

create user John_User for login John
grant select,insert,update,delete on customer_info to John_User
grant select,insert,update,delete on operation_info to John_User
