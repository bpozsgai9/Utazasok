CREATE TABLE Items (
 ID integer not null PRIMARY key AUTOINCREMENT,
 Name text not null,
 Category text not null,
 Country text not null,
 Description text not null,
 Priority integer not null,
 UNIQUE(Name)
);
