declare @t table
(
	name nvarchar(max),
	manager nvarchar(max)
)

insert into @t (name, manager) values
('dev 1', 'man 1'),
('dev 2', 'man 1'),
('dev 3', 'man 2'),
('man 1', 'dir 1'),
('man 2', 'dir 1')

select t1.name, t2.manager
from @t t1
left join @t t2 on t1.manager = t2.name