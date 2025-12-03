CREATE PROCEDURE sp_reporte_ventas_periodo
@FechaInicio DATE,
@FechaFin DATE
AS
BEGIN
SET NOCOUNT ON;


SELECT
v.Id,
v.FechaVenta,
c.NombreCompleto AS CLiente,
p.Nombre,
dv.Cantidad,
dv.PrecioUnitario,
(dv.Cantidad * dv.PrecioUnitario) AS SubTotal,
v.MontoTotal
FROM Venta v
INNER JOIN Cliente c ON v.Id_Cliente = c.Id
INNER JOIN DetalleVenta dv ON dv.Id_Venta = v.Id
INNER JOIN Producto p ON p.Id = dv.Id_Producto
WHERE CONVERT(date, v.FechaVenta) BETWEEN @FechaInicio AND @FechaFin
ORDER BY v.FechaVenta ASC;
END
GO
