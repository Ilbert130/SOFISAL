create table Venta(
IdVenta int identity primary key not null,
IdCliente int not null,
IdTrabajador int not null,
Fecha date not null,
Tipo_comprobante varchar(20)not null,
Serie varchar(4) not null,
Correlativo varchar(7) not null,
IGV decimal(4,2) not null,
Pago money not null)

create table Detalle_Venta(
IdDetalle_venta int identity primary key not null,
IdVenta int not null,
IdDetalle_ingreso int not null,
Cantidad int not null,
Precio_venta money not null,
Descuento money not null)

create table Articulo(
IdArticulo int identity primary key not null,
Codigo varchar(50) not null,
Nombre varchar(50) not null,
Descripcion varchar(1024),
Imagen image,
IdCategoria int not null,
IdPresentacion int not null
)

create table Categoria(
IdCategoria int identity primary key not null,
Nombre varchar(50) not null,
Descripcion varchar(256)
)

create table Cliente(
IdCliente int identity primary key not null,
Nombre varchar(20) not null,
Apellidos varchar(40),
Sexo varchar(1),
Fecha_nacimiento date not null,
Tipo_documento varchar(20) not null,
Num_documento varchar(11)not null,
Direccion varchar(100),
Telefono varchar(10),
Email varchar(50)
)

create table Detalle_ingreso(
IdDetalle_ingreso int identity primary key not null,
IdIngreso int not null,
IdArticulo int not null,
Precio_compra money not null,
Precio_venta money not null,
Stock_inicial int not null,
Stock_final int not null,
Fecha_produccion date not null,
Fecha_vencimiento date not null
)

create table Ingreso(
IdIngreso int identity primary key not null,
IdTrabajadorr int not null,
IdProveedor int not null,
Fecha date not null,
Tipo_comprobante varchar(20)not null,
Serie varchar(4)not null,
Correlativo varchar(7)not null,
IGV decimal(4,2)not null,
Estado varchar(7)not null
)

create table Presentacion(
IdPresentacion int identity primary key not null,
Nombre varchar(50) not null,
Descripcion varchar(256)
)

create table Proveedor(
IdProveedor int identity primary key not null,
Razon_social varchar(150) not null,
Sector_comercial varchar(50) not null,
Tipo_documento varchar(20)not null,
Num_documento varchar(11)not null,
Direccion varchar(100),
Telefono varchar(50),
Email varchar(50),
URL varchar(100)
)

create table Trabajador(
IdTrabajador int identity primary key not null,
Nombre varchar(20)not null,
Apellido varchar(40)not null,
Sexo varchar(1)not null,
Fecha_nacimiento date not null,
Num_documento varchar(11) not null,
Direccion varchar(100),
Telefono varchar(10),
Email varchar(50),
Acceso varchar(20) not null,
Usuario varchar(20)not null,
Password varchar(20)not null
)