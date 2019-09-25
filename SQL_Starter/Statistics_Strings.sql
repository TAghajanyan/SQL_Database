CREATE TABLE strs
(
	[str] varchar(50) not null
)

insert into strs 
	([str])
	values
	('ffffffff'),
	('ffff'),	
	('aab'),
	('abaaba'),
	('bbbbb')

CREATE TABLE chars
(
	ch char
);

insert into chars
	values
	('a'), ('b'), ('c'), ('d'), ('e'), ('f'), ('g'), ('h'), ('i'), ('j'), ('k'), ('l'), ('m'),
	('n'), ('o'), ('p'), ('q'), ('r'), ('s'), ('t'), ('u'), ('v'), ('w'), ('x'), ('y'), ('z')

CREATE TABLE outputTable
(
    letter VARCHAR(20),
	total int,
	occurance int,
	max_occurance int,
	max_occurance_reached int
);

truncate table outputTable
insert into outputTable(letter, total, occurance, max_occurance)
select ch, sum(len([str]) - len(replace([str],c.ch,''))), count(ch), max(len([str]) - len(replace([str], c.ch,''))) from chars c, strs s 
where s.[str] like '%' + c.ch + '%'
group by ch

--update outputTable
--set max_occurance_reached = count(i.[str])
--from(
--select [str] from strs s, chars c) i
--where len(replace([str], c.ch,'')) = 0
	

select * from outputTable
select * from strs

--select count(*) from strs s, chars c
--where len(replace([str], c.ch,'')) = 0


