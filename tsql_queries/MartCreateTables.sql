--CREATE TABLE Organisation
--(
--	org_id INTEGER,
--	area_id INTEGER NOT NULL,
--	org_name VARCHAR(50) NOT NULL,
--	trade_profile_name VARCHAR(50) NOT NULL,
--	country VARCHAR(50),
--	payment_terms VARCHAR(50) DEFAULT '��������',
--	delivery_method VARCHAR(50) DEFAULT '���������',
--	contact_person VARCHAR(50) NOT NULL,
--	UNIQUE(area_id, org_name),
--	PRIMARY KEY(org_id),
--	FOREIGN KEY(area_id) REFERENCES Area(area_id),
--	FOREIGN KEY(trade_profile_name) REFERENCES TradeProfile (trade_profile_name)
--)

--CREATE TABLE Area
--(
--	area_id INTEGER,
--	area_square REAL,
--	floor_number INTEGER,
--	PRIMARY KEY(area_id)
--)

--CREATE TABLE Outlet
--(
--	outlet_id INTEGER,
--	org_id INTEGER NOT NULL,
--	area_id INTEGER NOT NULL,
--	outlet_name VARCHAR(50) NOT NULL,
--	outlet_type VARCHAR(50),
--	timetable VARCHAR(50) DEFAULT '9:00-18:00',
--	rating REAL DEFAULT 0 CHECK ((rating >= 1) AND (rating <= 5)),
--	contact_person VARCHAR(50) NOT NULL,
--	PRIMARY KEY(outlet_id),
--	FOREIGN KEY(org_id) REFERENCES Organisation(org_id),
--	FOREIGN KEY(area_id) REFERENCES Area(area_id)
--)

--CREATE TABLE Booking
--(
--	booking_id INTEGER,
--	org_id INTEGER NOT NULL,
--	area_id INTEGER NOT NULL,
--	cost INTEGER NOT NULL,
--	booking_start_date DATE CHECK (booking_start_date <= GETDATE()) NOT NULL,
--	booking_end_date DATE NOT NULL,
--	PRIMARY KEY(booking_id),
--	FOREIGN KEY(org_id) REFERENCES Organisation(org_id),
--	FOREIGN KEY(area_id) REFERENCES Area(area_id)
--)

--CREATE TABLE TradeProfile
--(
--	trade_profile_id INTEGER,
--	trade_profile_name VARCHAR(50) NOT NULL,
--	UNIQUE(trade_profile_name),
--	PRIMARY KEY(trade_profile_id)
--)

--CREATE TABLE Employee
--(
--	employee_id INTEGER,
--	org_id INTEGER NOT NULL,
--	fio VARCHAR(50) NOT NULL,
--	gender VARCHAR(1) DEFAULT '�' CHECK((gender = '�') OR (gender = '�')),
--	position VARCHAR(50) DEFAULT '��������',
--	phone_number VARCHAR(50) NOT NULL,
--	email VARCHAR(50),
--	PRIMARY KEY(employee_id),
--	FOREIGN KEY(org_id) REFERENCES Organisation(org_id)
--)

--CREATE TABLE Review
--(
--	review_id INTEGER,
--	org_id INTEGER NOT NULL,
--	rating INTEGER CHECK((rating >= 1) AND (rating <= 5)) NOT NULL,
--	content VARCHAR(200) DEFAULT '...',
--	PRIMARY KEY(review_id),
--	FOREIGN KEY(org_id) REFERENCES Organisation(org_id)
--)

--ALTER TABLE Outlet
--ADD CONSTRAINT ct_rating CHECK(rating >= 1 AND rating <= 5)
