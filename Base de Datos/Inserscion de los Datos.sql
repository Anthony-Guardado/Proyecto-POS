--INSERSION DE LOS DATOS PARA LA CAFETERIA
-- =============================================
-- 1. CATEGORIA (Categorías de un Café)
-- =============================================
INSERT INTO Categoria (Nombre) VALUES 
('Bebidas Calientes'),      -- 1
('Bebidas Frías / Iced'),   -- 2
('Frappés y Batidos'),      -- 3
('Repostería y Pasteles'),  -- 4
('Sandwiches y Paninis'),   -- 5
('Desayunos'),              -- 6
('Café en Grano (Bolsa)'),  -- 7
('Té e Infusiones'),        -- 8
('Bebidas Embotelladas'),   -- 9
('Mercancía (Tazas/Termos)'); -- 10

-- =============================================
-- 2. TIPO PAGO (Métodos comunes en cafeterías)
-- =============================================
INSERT INTO TipoPago (Nombre) VALUES 
('Efectivo'),
('Tarjeta de Crédito'),
('Tarjeta de Débito')


-- =============================================
-- 3. USUARIO (Personal del Café)
-- =============================================
INSERT INTO Usuario (Usuario, Clave, Estado) VALUES 
('admin_gerente', HASHBYTES('SHA2_256', 'AdminCafe2024'), 1),
('barista_jefe', HASHBYTES('SHA2_256', 'EspressoMaster'), 1),
('cajero_turno1', HASHBYTES('SHA2_256', 'CajaUno123'), 1),
('mesero_luis', HASHBYTES('SHA2_256', 'MesaLuis'), 1),
('barista_ana', HASHBYTES('SHA2_256', 'LatteArt99'), 1),
('cocinero_panini', HASHBYTES('SHA2_256', 'CocinaPass'), 1),
('repartidor_express', HASHBYTES('SHA2_256', 'MotoCafe'), 1),
('admin_invitado', HASHBYTES('SHA2_256', 'Guest123'), 0), -- Inactivo
('contador_externo', HASHBYTES('SHA2_256', 'ContaFiscal'), 1),
('cajero_turno2', HASHBYTES('SHA2_256', 'CajaDos456'), 1);

-- =============================================
-- 4. CLIENTE (Clientes frecuentes)
-- =============================================
INSERT INTO Cliente (NombreCompleto, Dui, Telefono, Email, Estado) VALUES 
('Fernanda Castillo', 102030405, 70001111, 'fer@mail.com', 1),
('Jorge "El Cafetero"', 504030201, 71112222, 'jorge@mail.com', 1),
('Mariana Solis', 112233445, 72223333, 'mari@mail.com', 1),
('Carlos Vives', 554433221, 73334444, 'vives@mail.com', 1),
('Andrea Legarreta', 998877665, 74445555, 'andrea@mail.com', 1),
('Ricardo Arjona', 667788990, 75556666, 'ricardo@mail.com', 1),
('Cliente Genérico 1', 000000000, 22220000, 'anonimo1@mail.com', 1),
('Sofia Vergara', 123123123, 76667777, 'sofia@mail.com', 1),
('Cliente Moroso', 999999999, 70000000, 'nodebe@mail.com', 0), -- Inactivo
('Diego Luna', 456456456, 78889999, 'diego@mail.com', 1);

-- =============================================
-- 5. PRODUCTO (Menú del Café)
-- =============================================
INSERT INTO Producto (Nombre, Precio, Id_Categoria, Stock, Estado) VALUES 
('Café Americano 12oz', 2.50, 1, 500, 1),          -- Cat: Calientes
('Cappuccino Italiano', 3.25, 1, 400, 1),          -- Cat: Calientes
('Latte Vainilla', 3.75, 1, 350, 1),               -- Cat: Calientes
('Iced Latte Caramelo', 4.00, 2, 200, 1),          -- Cat: Frías
('Frappé de Moca', 4.50, 3, 150, 1),               -- Cat: Frappés
('Cheesecake de Fresa', 3.50, 4, 20, 1),           -- Cat: Repostería
('Croissant de Mantequilla', 2.00, 4, 30, 1),      -- Cat: Repostería
('Panini de Pollo Pesto', 5.75, 5, 15, 1),         -- Cat: Sandwiches
('Bagel con Queso Crema', 3.00, 6, 25, 1),         -- Cat: Desayunos
('Bolsa Café Altura (1lb)', 12.00, 7, 10, 1);      -- Cat: Grano

-- =============================================
-- 6. VENTA (Tickets de compra)
-- =============================================
INSERT INTO Venta (FechaVenta, MontoTotal, Id_TipoPago, Id_Cliente, Stock, Estado) VALUES 
('2023-11-01', 5.00, 1, 1, 2, 1),   -- Venta 1: 2 Americanos
('2023-11-01', 3.25, 2, 2, 1, 1),   -- Venta 2: 1 Cappuccino
('2023-11-01', 7.50, 3, 3, 2, 1),   -- Venta 3: 2 Lattes
('2023-11-02', 4.00, 1, 4, 1, 1),   -- Venta 4: 1 Iced Latte
('2023-11-02', 9.00, 2, 5, 2, 1),   -- Venta 5: 2 Frappés
('2023-11-03', 3.50, 1, 6, 1, 1),   -- Venta 6: 1 Cheesecake
('2023-11-03', 7.75, 2, 7, 2, 1),   -- Venta 7: 1 Panini + 1 Croissant
('2023-11-04', 12.00, 2, 8, 1, 1),  -- Venta 8: 1 Bolsa Café
('2023-11-04', 2.50, 1, 9, 1, 0),   -- Venta 9: Cancelada
('2023-11-05', 11.50, 3, 10, 2, 1); -- Venta 10: 2 Paninis

-- =============================================
-- 7. DETALLE VENTA (Items específicos de cada ticket)
-- Nota: Los IDs de Producto coinciden con la lista de arriba
-- =============================================
INSERT INTO DetalleVenta (Cantidad, PrecioUnitario, SubTotal, Id_Venta, Id_Producto) VALUES 
(2, 2.50, 5.00, 11, 1),    -- Venta 1: 2 Americanos
(1, 3.25, 3.25, 12, 2),    -- Venta 2: 1 Cappuccino
(2, 3.75, 7.50, 13, 3),    -- Venta 3: 2 Lattes Vainilla
(1, 4.00, 4.00, 14, 4),    -- Venta 4: 1 Iced Latte
(2, 4.50, 9.00, 15, 5),    -- Venta 5: 2 Frappés Moca
(1, 3.50, 3.50, 16, 6),    -- Venta 6: 1 Cheesecake
(1, 5.75, 5.75, 17, 8),    -- Venta 7: 1 Panini
(1, 2.00, 2.00, 17, 7),    -- Venta 7: 1 Croissant (Total Venta 7 = 7.75)
(1, 12.00, 12.00,18, 10), -- Venta 8: 1 Bolsa Café
(2, 5.75, 11.50, 20, 8);  -- Venta 10: 2 Paninis

-- 1. Tabla Categoria
SELECT * FROM Categoria;

-- 2. Tabla TipoPago
SELECT * FROM TipoPago;

-- 3. Tabla Cliente
SELECT * FROM Cliente;

-- 4. Tabla Usuario
SELECT * FROM Usuario;

-- 5. Tabla Producto
SELECT * FROM Producto;

-- 6. Tabla Venta
SELECT * FROM Venta;

-- 7. Tabla DetalleVenta
SELECT * FROM DetalleVenta;
