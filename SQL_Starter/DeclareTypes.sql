declare @Name nvarchar(20)
declare @Birthday date
declare @Surname varchar(20)
declare @Gender nchar(10)
declare @Age tinyint

set @Name = 'MyName'
set @Surname = 'MySurname'
set @Gender = 'Male'
set @Age = 18
set @Birthday = '1999-12-23'

print @Name
print @Surname
print @Gender
print @Age
print @Birthday