create trigger trrestablecer_stock
on [Detalle_venta]
for delete
as
update di set di.Stock_final=di.Stock_final+dv.Cantidad
from Detalle_ingreso as di inner join 
deleted as dv on di.IdDetalle_ingreso=dv.IdDetalle_ingreso
go