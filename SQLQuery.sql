use Test7
select Products.P_Name, Kategorogyes.K_Name
from Products
left join Kategorogyes on Products.P_Id = Kategorogyes.P_Id