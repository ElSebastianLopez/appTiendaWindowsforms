
CREATE DATABASE Tienda_db
USE Tienda_db;

CREATE TABLE cliente (
    id INT PRIMARY KEY,
    documento VARCHAR(15),
    nombres VARCHAR(100),
    apellidos VARCHAR(100),
    telefono VARCHAR(16),
    email VARCHAR(100),
    CONSTRAINT documento_INDEX_UNIQUE UNIQUE (documento),
    CONSTRAINT email_INDEX_UNIQUE UNIQUE (email)
);

CREATE TABLE ventas (
    id INT PRIMARY KEY,
    fecha DATE,
    hora TIME,
    cliente_id INT,
    valor_total REAL,
    impuesto REAL,
    pago_total REAL,
    FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);

CREATE TABLE categorias (
    id INT PRIMARY KEY,
    nombre VARCHAR(100)
);

CREATE TABLE productos (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    precio_compra REAL,
    precio_venta REAL,
    cantidad_actual INT,
    categoria_id INT,
    CONSTRAINT nombre_INDEX_UNIQUE UNIQUE (nombre),
    FOREIGN KEY (categoria_id) REFERENCES categorias(id)
);

CREATE TABLE detalle_venta (
    id INT PRIMARY KEY,
    venta_id INT,
    producto_id INT,
    cantidad INT,
    impuesto REAL,
    valor_unitario REAL,
    sub_total REAL,
    FOREIGN KEY (venta_id) REFERENCES ventas(id),
    FOREIGN KEY (producto_id) REFERENCES productos(id)
);


--Insertar 4 clientes en el sistema
INSERT INTO cliente (id, documento, nombres, apellidos, telefono, email) 
VALUES 
(1, '58977893', 'Juan', 'Pérez', '3104567890', 'juan@gmail.com'),
(2, '23656375', 'María', 'González', '320654321', 'maria@gmail.com'),
(3, '37863692', 'Pedro', 'López', '315789123', 'pedro@gmail.com'),
(4, '34629936', 'Ana', 'Martínez', '311123456', 'ana@gmail.com');

-- Crear 4 categorías de productos
INSERT INTO categorias (id, nombre) 
VALUES 
(1, 'Electrónica'),
(2, 'Ropa'),
(3, 'Hogar'),
(4, 'Alimentos');

-- Crear 4 productos
INSERT INTO productos (id, nombre, precio_compra, precio_venta, cantidad_actual, categoria_id) 
VALUES 
(1, 'Televisor', 500000, 700000, 10, 1),
(2, 'Camiseta', 10000, 20000, 50, 2),
(3, 'Sartén', 15000, 25000, 30, 3),
(4, 'Arroz', 5000, 8000, 100, 4);

-- Crear 4 ventas cada una con 3 detalles de venta
-- Primera venta
INSERT INTO ventas (id, fecha, hora, cliente_id, valor_total, impuesto, pago_total) 
VALUES 
(1, '2024-03-22', '12:00:00', 1, 800000, 50000, 850000);

-- Detalles de la primera venta
INSERT INTO detalle_venta (id, venta_id, producto_id, cantidad, impuesto, valor_unitario, sub_total) 
VALUES 
(1, 1, 1, 2, 20000, 700000, 1400000),
(2, 1, 2, 3, 6000, 20000, 60000),
(3, 1, 4, 5, 24000, 8000, 40000);

-- Segunda venta
INSERT INTO ventas (id, fecha, hora, cliente_id, valor_total, impuesto, pago_total) 
VALUES 
(2, '2024-03-23', '13:00:00', 2, 500000, 30000, 530000);

-- Detalles de la segunda venta
INSERT INTO detalle_venta (id, venta_id, producto_id, cantidad, impuesto, valor_unitario, sub_total) 
VALUES 
(4, 2, 2, 2, 4000, 20000, 40000),
(5, 2, 3, 1, 3000, 25000, 25000),
(6, 2, 4, 3, 9000, 8000, 24000);

-- Tercera venta
INSERT INTO ventas (id, fecha, hora, cliente_id, valor_total, impuesto, pago_total) 
VALUES 
(3, '2024-03-24', '14:00:00', 3, 1000000, 60000, 1060000);

-- Detalles de la tercera venta
INSERT INTO detalle_venta (id, venta_id, producto_id, cantidad, impuesto, valor_unitario, sub_total) 
VALUES 
(7, 3, 1, 3, 30000, 700000, 2100000),
(8, 3, 2, 2, 6000, 20000, 40000),
(9, 3, 4, 4, 24000, 8000, 32000);

-- Cuarta venta
INSERT INTO ventas (id, fecha, hora, cliente_id, valor_total, impuesto, pago_total) 
VALUES 
(4, '2024-03-25', '15:00:00', 4, 300000, 18000, 318000);

-- Detalles de la cuarta venta
INSERT INTO detalle_venta (id, venta_id, producto_id, cantidad, impuesto, valor_unitario, sub_total) 
VALUES 
(10, 4, 2, 1, 2000, 20000, 20000),
(11, 4, 3, 2, 5000, 25000, 50000),
(12, 4, 4, 3, 9000, 8000, 24000);

--3
-- Modificar los datos de un cliente
UPDATE cliente
SET telefono = '320654321', email = 'juan12@gmail.com'
WHERE id = 1;

--4
--Eliminar 1 registro de uno de los detalles de venta
DELETE FROM detalle_venta
WHERE id = 3;

--5
--Listar las ventas realizadas en una fecha ordenadas de mayor a menor según el valor total de pago:
SELECT *
FROM ventas
WHERE fecha = '2024-03-22'
ORDER BY valor_total DESC;

--Listar el producto más vendido:
SELECT TOP 1 p.nombre AS producto, SUM(dv.cantidad) AS total_vendido
FROM detalle_venta dv
JOIN productos p ON dv.producto_id = p.id
GROUP BY p.nombre
ORDER BY total_vendido DESC;

--Calcular la ganancia obtenida en un día determinado:
SELECT fecha, SUM(valor_total - impuesto) AS ganancia_obtenida
FROM ventas
WHERE fecha = '2024-03-22'
GROUP BY fecha;

--Listar las ventas realizadas a un cliente: para cada venta se debe obtener: id de la venta, fecha de la venta, hora de la venta, documento del cliente, nombres del cliente, apellidos, total de la venta y ganancia obtenida:
SELECT v.id AS id_venta, v.fecha, v.hora, c.documento, c.nombres, c.apellidos, v.valor_total AS total_venta, (v.valor_total - v.impuesto) AS ganancia_obtenida
FROM ventas v
JOIN cliente c ON v.cliente_id = c.id
WHERE c.id = 1;

--6
--Listar el producto con menor precio
SELECT TOP 1 nombre AS producto, precio_venta AS precio
FROM productos
ORDER BY precio_venta ASC;

--7
--Calcular el promedio de ventas de la tienda
SELECT AVG(valor_total) AS promedio_ventas
FROM ventas;


