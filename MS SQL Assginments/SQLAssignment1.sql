create database DatabaseOne
alter database DatabaseOne modify name=  DatabaseTwo
sp_renameDB 'DatabaseTwo', 'SpDatabase'
drop database SpDatabase