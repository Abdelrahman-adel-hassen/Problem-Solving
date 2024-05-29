/* Write your T-SQL query statement below */
select e1.employee_id,e1.name,count(e1.employee_id)reports_count,round(avg(e2.age*1.0),0)average_age
from Employees  e1,employees e2
where e1.employee_id=e2.reports_to
group by e1.employee_id,e1.name
order by e1.employee_id