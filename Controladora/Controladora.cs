﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using Entidad;
using System.Runtime.Remoting;

namespace Controladora
{
    public class Controladora
    {
        public static bool VerificarAutenticacion(string nombreUsuario, string claveCifrada)
        {
            return ConsultasModelo.VerificarAutenticacion(nombreUsuario, claveCifrada);
        }
        public static string ObtenerRolUsuario(string nombreUsuario)
        {
            return ConsultasModelo.ObtenerRolUsuario(nombreUsuario);
        }
        public static List<string> ObtenerRolesDisponibles()
        {
            return ConsultasModelo.ObtenerRolesDisponibles();
        }
        public static List<string> ObtenerPermisosPorRol(string rol)
        {
            return ConsultasModelo.ObtenerPermisosPorRol(rol);
        }
        public static List<string> ObtenerPermisos()
        {
            return ConsultasModelo.ObtenerPermisos();
        }
        public static DataTable ObtenerPermisosPaginados(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerPermisosPaginados(indiceInicio, tamañoPagina);
        }
        public static bool ActualizarPermiso(string nombrePermisoSeleccionado, string nuevoNombrePermiso)
        {
            return ConsultasModelo.ActualizarPermiso(nombrePermisoSeleccionado, nuevoNombrePermiso);
        }
        public static int ObtenerCantidadTotalPermisos()
        {
            return ConsultasModelo.ObtenerCantidadTotalPermisos();
        }
        public static void CrearNuevoRol(string nombreRol, List<string> permisos)
        {
            ConsultasModelo.CrearNuevoRol(nombreRol, permisos);
        }
        public static List<string> ObtenerNombresRoles()
        {
            return ConsultasModelo.ObtenerNombresRoles();
        }
        public static bool ActualizarRol(string nombreRolAnterior, string nuevoNombreRol, List<string> nuevosPermisos)
        {
            return ConsultasModelo.ActualizarRol(nombreRolAnterior, nuevoNombreRol, nuevosPermisos);
        }
        public static bool EliminarRol(string nombreRol)
        {
            return ConsultasModelo.EliminarRol(nombreRol);
        }
        public static bool DeshabilitarRol(string nombreRol)
        {
            return ConsultasModelo.DeshabilitarRol(nombreRol);
        }
        public static bool VerificarRolHabilitado(string rol)
        {
            return ConsultasModelo.VerificarRolHabilitado(rol);
        }
        public static bool ActualizarEstadoRol(string nombreRol, bool nuevoEstado)
        {
            return ConsultasModelo.ActualizarEstadoRol(nombreRol, nuevoEstado);
        }
        public static bool ExisteRol(string nombreRol)
        {
            return ConsultasModelo.ExisteRol(nombreRol);
        }
        public static int ObtenerCantidadTotalRoles()
        {
            return ConsultasModelo.ObtenerCantidadTotalRoles();
        }
        public static DataTable ObtenerRolesPaginados(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerRolesPaginados(indiceInicio, tamañoPagina);
        }
        public static DataTable ObtenerTodosLosPermisos()
        {
            return ConsultasModelo.ObtenerTodosLosPermisos();
        }
        public static void CrearNuevoPermiso(string nombrePermiso)
        {
            ConsultasModelo.CrearNuevoPermiso(nombrePermiso);
        }
        public static bool ExistePermiso(string nombrePermiso)
        {
            return ConsultasModelo.ExistePermiso(nombrePermiso);
        }
        public static bool PermisoAsociadoARol(string nombrePermisoSeleccionado)
        {
            return ConsultasModelo.PermisoAsociadoARol(nombrePermisoSeleccionado);
        }
        public static bool EliminarPermiso(string nombrePermisoSeleccionado)
        {
            return ConsultasModelo.EliminarPermiso(nombrePermisoSeleccionado);
        }
        public static bool VerificarExistenciaUsuario(string nombreUsuario)
        {
            return ConsultasModelo.VerificarExistenciaUsuario(nombreUsuario);
        }
        public static string ObtenerCorreoUsuarioPorID(int idUsuario)
        {
            return ConsultasModelo.ObtenerCorreoUsuarioPorID(idUsuario);
        }
        public static bool VerificarUsuarioHabilitadoPorID(int idUsuario)
        {
            return ConsultasModelo.VerificarUsuarioHabilitadoPorID(idUsuario);
        }
        public static bool ActualizarEstadoUsuarioPorID(int idUsuario, bool nuevoEstadoUsuario)
        {
            return ConsultasModelo.ActualizarEstadoUsuarioPorID(idUsuario, nuevoEstadoUsuario);
        }
        public static bool VerificarUsuarioHabilitado(string nombreUsuario)
        {
            return ConsultasModelo.VerificarUsuarioHabilitado(nombreUsuario);
        }
        public static bool VerificarExistenciaEmail(string email)
        {
            return ConsultasModelo.VerificarExistenciaEmail(email);
        }
        public static void GuardarNuevoUsuario(Usuario usuario)
        {
            ConsultasModelo.GuardarNuevoUsuario(usuario);
        }
        public static int ObtenerIdUsuario(string nombreUsuario)
        {
            return ConsultasModelo.ObtenerIdUsuario(nombreUsuario);
        }
        public static Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            return ConsultasModelo.ObtenerUsuarioPorId(idUsuario);
        }
        public static bool VerificarEmailExistente(string email)
        {
            return ConsultasModelo.VerificarEmailExistente(email);
        }
        public static string GenerarCodigoVerificacion()
        {
            return ConsultasModelo.GenerarCodigoVerificacion();
        }
        public static void ActualizarContraseñaUsuario(string email, string nuevaContraseña)
        {
            ConsultasModelo.ActualizarContraseñaUsuario(email, nuevaContraseña);
        }
        public static bool VerificarProveedorExistente(ProveedorInfo proveedorInfo)
        {
            return ConsultasModelo.VerificarProveedorExistente(proveedorInfo);
        }
        public static void InsertarProveedor(ProveedorInfo proveedorInfo)
        {
            ConsultasModelo.InsertarProveedor(proveedorInfo);
        }
        public static void ActualizarProveedor(ProveedorInfo proveedorInfo)
        {
            ConsultasModelo.ActualizarProveedor(proveedorInfo);
        }
        public static void ActualizarProducto(int idProductoSeleccionado, string nuevoNombre)
        {
            ConsultasModelo.ActualizarProducto(idProductoSeleccionado, nuevoNombre);
        }
        public static List<Proveedor> ObtenerDatosProveedores()
        {
            return ConsultasModelo.ObtenerDatosProveedores()
                .Select(proveedor => new Proveedor
                {
                    Nombre = proveedor.Nombre,
                    Apellido = proveedor.Apellido,
                    Email = proveedor.Email
                })
                .ToList();
        }
        public static DataTable ObtenerProveedores()
        {
            return ConsultasModelo.ObtenerProveedores();
        }
        public static DataTable ObtenerProveedoresPaginados(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerProveedoresPaginados(indiceInicio, tamañoPagina);
        }
        public static int ObtenerCantidadTotalProveedores()
        {
            return ConsultasModelo.ObtenerCantidadTotalProveedores();
        }
        public static DataTable ObtenerUsuarios()
        {
            return ConsultasModelo.ObtenerUsuarios();
        }
        public static DataTable ObtenerUsuariosPaginados(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerUsuariosPaginados(indiceInicio, tamañoPagina);
        }
        public static int ObtenerCantidadTotalUsuarios()
        {
            return ConsultasModelo.ObtenerCantidadTotalUsuarios();
        }
        public static DataTable ExecuteQuery(string sql)
        {
            return ConsultasModelo.ExecuteQuery(sql);
        }
        public static DataTable ObtenerProductosCompleto()
        {
            return ConsultasModelo.ObtenerProductosCompleto();
        }
        public static DataTable ObtenerProductosPaginados(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerProductosPaginados(indiceInicio, tamañoPagina);
        }
        public static int ObtenerCantidadTotalProductos()
        {
            return ConsultasModelo.ObtenerCantidadTotalProductos();
        }
        public static List<string> ObtenerProductosComboBox()
        {
            return ConsultasModelo.ObtenerProductosComboBox();
        }
        public static bool VerificarProductoExistente(Producto producto)
        {
            return ConsultasModelo.VerificarProductoExistente(producto);
        }
        public static int InsertarProducto(Producto producto)
        {
            return ConsultasModelo.InsertarProducto(producto);
        }
        public static void InsertarPrecioProducto(int productoId, decimal precioUnitario)
        {
            ConsultasModelo.InsertarPrecioProducto(productoId, precioUnitario);
        }
        public static int GuardarCompra(CompraInfo compraInfo)
        {
            return ConsultasModelo.GuardarCompra(compraInfo);
        }
        public static void GuardarDetalleCompra(DetalleCompraInfo detalleCompraInfo)
        {
            ConsultasModelo.GuardarDetalleCompra(detalleCompraInfo);
        }
        public static int GuardarDonacion(DonacionInfo donacionInfo)
        {
            return ConsultasModelo.GuardarDonacion(donacionInfo);
        }
        public static void GuardarDetalleDonacion(DetalleDonacionInfo detalleDonacionInfo)
        {
            ConsultasModelo.GuardarDetalleDonacion(detalleDonacionInfo);
        }
        public static int GuardarRecoleccion(RecoleccionInfo recoleccionInfo)
        {
            return ConsultasModelo.GuardarRecoleccion(recoleccionInfo);
        }
        public static void GuardarDetalleRecoleccion(DetalleRecoleccionInfo detalleRecoleccionInfo)
        {
            ConsultasModelo.GuardarDetalleRecoleccion(detalleRecoleccionInfo);
        }
        public static void ActualizarStock(int productoId, int cantidad)
        {
            ConsultasModelo.ActualizarStock(productoId, cantidad);
        }
        public static void DisminuirStock(int productoId, int cantidad)
        {
            ConsultasModelo.DisminuirStock(productoId, cantidad);
        }
        public static int ObtenerIdProducto(string nombre, int tipoProducto, int tipoEspecifico)
        {
            return ConsultasModelo.ObtenerIdProducto(nombre, tipoProducto, tipoEspecifico);
        }
        public static int ObtenerTamSemillaIdDeProducto(int productoId)
        {
            return ConsultasModelo.ObtenerTamSemillaIdDeProducto(productoId);
        }
        public static int ObtenerSemillasPorGramo(int tamSemillaId)
        {
            return ConsultasModelo.ObtenerSemillasPorGramo(tamSemillaId);
        }
        public static DataTable ObtenerDatosGraficoProductos()
        {
            return ConsultasModelo.ObtenerDatosGraficoProductos();
        }
        public static DataTable ObtenerDatosGraficoArboles()
        {
            return ConsultasModelo.ObtenerDatosGraficoArboles();
        }
        public static DataTable ObtenerDatosGraficoSemillas()
        {
            return ConsultasModelo.ObtenerDatosGraficoSemillas();
        }
        public static int ObtenerTotalCompras()
        {
            return ConsultasModelo.ObtenerTotalCompras();
        }
        public static int ObtenerTotalDonaciones()
        {
            return ConsultasModelo.ObtenerTotalDonaciones();
        }
        public static int ObtenerTotalRecoleccion()
        {
            return ConsultasModelo.ObtenerTotalRecoleccion();
        }
        public static void EliminarProducto(int idProducto)
        {
            ConsultasModelo.EliminarProducto(idProducto);
        }
        public static bool VerificarProductoEnCompra(int idProducto)
        {
            return ConsultasModelo.VerificarProductoEnCompras(idProducto);
        }
        public static bool VerificarProductoEnDetalleSiembra(int idProducto)
        {
            return ConsultasModelo.VerificarProductoEnDetalleSiembra(idProducto);
        }
        public static void EliminarProveedor(int idProveedor)
        {
            ConsultasModelo.EliminarProveedor(idProveedor);
        }
        public static void EliminarUsuario(int idUsuario)
        {
            ConsultasModelo.EliminarUsuario(idUsuario);
        }
        public static bool VerificarProveedorEnCompras(int idProveedor)
        {
            return ConsultasModelo.VerificarProveedorEnCompras(idProveedor);
        }
        public static DataTable ObtenerMontosComprasPorTipo()
        {
            return ConsultasModelo.ObtenerMontosComprasPorTipo();
        }
        public static List<Producto> ObtenerSemillasConStockMayorCero()
        {
            return ConsultasModelo.ObtenerSemillasConStockMayorCero();
        }
        public static int GuardarSiembra(SiembraInfo siembraInfo)
        {
            return ConsultasModelo.GuardarSiembra(siembraInfo);
        }
        public static void GuardarDetalleSiembra(DetalleSiembraInfo detalleSiembraInfo)
        {
            ConsultasModelo.GuardarDetalleSiembra(detalleSiembraInfo);
        }
        public static Producto ObtenerProductoArbolPorNombre(string nombre)
        {
            return ConsultasModelo.ObtenerProductoArbolPorNombre(nombre);
        }
        public static Producto ObtenerProductoPorId(int productoId)
        {
            return ConsultasModelo.ObtenerProductoPorId(productoId);
        }
        public static int InsertarProductoSiembra(Producto producto, int stockInicial)
        {
            return ConsultasModelo.InsertarProductoSiembra(producto, stockInicial);
        }
        public static void ActualizarUsuario(Usuario usuario)
        {
            ConsultasModelo.ActualizarUsuario(usuario);
        }
        public static string ObtenerCorreoUsuario(string nombreUsuario)
        {
            return ConsultasModelo.ObtenerCorreoUsuario(nombreUsuario);
        }
        public static string ObtenerCorreoUsuarioAEliminar(int idUsuario)
        {
            return ConsultasModelo.ObtenerCorreoUsuarioAEliminar(idUsuario);
        }
        public static bool UsuarioUtilizadoEnCompras(int idUsuario)
        {
            return ConsultasModelo.UsuarioUtilizadoEnCompras(idUsuario);
        }
        public static bool UsuarioUtilizadoEnVentas(int idUsuario)
        {
            return ConsultasModelo.UsuarioUtilizadoEnVentas(idUsuario);
        }
        public static bool VerificarClienteExistente(ClienteInfo clienteInfo)
        {
            return ConsultasModelo.VerificarClienteExistente(clienteInfo);
        }
        public static void ActualizarCliente(ClienteInfo clienteInfo)
        {
            ConsultasModelo.ActualizarCliente(clienteInfo);
        }
        public static void InsertarCliente(ClienteInfo clienteInfo)
        {
            ConsultasModelo.InsertarCliente(clienteInfo);
        }
        public static DataTable ObtenerClientes()
        {
            return ConsultasModelo.ObtenerClientes();
        }
        public static DataTable ObtenerClientesPaginados(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerClientesPaginados(indiceInicio, tamañoPagina);
        }
        public static int ObtenerCantidadTotalClientes()
        {
            return ConsultasModelo.ObtenerCantidadTotalClientes();
        }
        public static void EliminarCliente(int idCliente)
        {
            ConsultasModelo.EliminarCliente(idCliente);
        }
        public static bool VerificarClienteEnVentas(int idCliente)
        {
            return ConsultasModelo.VerificarClienteEnVentas(idCliente);
        }
        public static List<Cliente> ObtenerDatosClientes()
        {
            return ConsultasModelo.ObtenerDatosClientes()
                .Select(cliente => new Cliente
                {
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Email = cliente.Email
                })
                .ToList();
        }
        public static List<ProductoInfo> ObtenerProductosStockComboBox()
        {
            return ConsultasModelo.ObtenerProductosStockComboBox();
        }
        public static List<ProductoInfo> ObtenerProductosArbolStockComboBox()
        {
            return ConsultasModelo.ObtenerProductosArbolStockComboBox();
        }
        public static int GuardarVenta(VentaInfo ventaInfo)
        {
            return ConsultasModelo.GuardarVenta(ventaInfo);
        }
        public static void GuardarDetalleVenta(DetalleVentaInfo detalleVentaInfo)
        {
            ConsultasModelo.GuardarDetalleVenta(detalleVentaInfo);
        }
        public static DataTable ObtenerMontosVentasPorTipo()
        {
            return ConsultasModelo.ObtenerMontosVentasPorTipo();
        }
        public static DataTable ObtenerTresSemillasMasCompradas()
        {
            return ConsultasModelo.ObtenerTresSemillasMasCompradas();
        }
        public static DataTable ObtenerTresArbolesMasComprados()
        {
            return ConsultasModelo.ObtenerTresArbolesMasComprados();
        }
        public static DataTable ObtenerComprasPorProveedor()
        {
            return ConsultasModelo.ObtenerComprasPorProveedor();
        }
        public static DataTable ObtenerPreciosUnitariosArboles()
        {
            return ConsultasModelo.ObtenerPreciosUnitariosArboles();
        }
        public static int ObtenerStockProducto(string productName, string tipoProducto)
        {
            return ConsultasModelo.ObtenerStockProducto(productName, tipoProducto);
        }
        public static void DisminuirStockProducto(string productName, int cantidad, string tipoProducto)
        {
            ConsultasModelo.DisminuirStockProducto(productName, cantidad, tipoProducto);
        }
        public static void ActualizarStockArbol(int productoId, int cantidad)
        {
            ConsultasModelo.ActualizarStockArbol(productoId, cantidad);
        }
        public static void RegistrarBajaProducto(string productName, int cantidadBaja, string motivo)
        {
            ConsultasModelo.RegistrarBajaProducto(productName, cantidadBaja, motivo);
        }
        public static DataTable ObtenerDatosBajasProductos()
        {
            return ConsultasModelo.ObtenerDatosBajasProductos();
        }
        public static DataTable ObtenerDatosBajasTotales()
        {
            return ConsultasModelo.ObtenerDatosBajasTotales();
        }
        public static DataTable ObtenerHistorialComprasConNombres()
        {
            return ConsultasModelo.ObtenerHistorialComprasConNombres();
        }
        public static int ObtenerCantidadTotalCompras()
        {
            return ConsultasModelo.ObtenerCantidadTotalCompras();
        }
        public static DataTable ObtenerHistorialDonacionesConNombres()
        {
            return ConsultasModelo.ObtenerHistorialDonacionesConNombres();
        }
        public static int ObtenerCantidadTotalDonaciones()
        {
            return ConsultasModelo.ObtenerCantidadTotalDonaciones();
        }
        public static DataTable ObtenerHistorialRecoleccionesConNombres()
        {
            return ConsultasModelo.ObtenerHistorialRecoleccionesConNombres();
        }
        public static int ObtenerCantidadTotalRecolecciones()
        {
            return ConsultasModelo.ObtenerCantidadTotalRecolecciones();
        }
        public static DataTable ObtenerHistorialReproduccionesConNombres()
        {
            return ConsultasModelo.ObtenerHistorialReproduccionesConNombres();
        }
        public static int ObtenerCantidadTotalReproducciones()
        {
            return ConsultasModelo.ObtenerCantidadTotalReproducciones();
        }
        public static bool FueComprado(int productoId)
        {
            return ConsultasModelo.FueComprado(productoId);
        }
        public static DataTable ObtenerHistorialVentasConNombres()
        {
            return ConsultasModelo.ObtenerHistorialVentasConNombres();
        }
        public static int ObtenerCantidadTotalVentas()
        {
            return ConsultasModelo.ObtenerCantidadTotalVentas();
        }
        public static DataTable ObtenerTresArbolesMasVendidos()
        {
            return ConsultasModelo.ObtenerTresArbolesMasVendidos();
        }
        public static DataTable ObtenerTresMediosPagoMasUtilizados()
        {
            return ConsultasModelo.ObtenerTresMediosPagoMasUtilizados();
        }
        public static DataTable ObtenerVentasPorCliente()
        {
            return ConsultasModelo.ObtenerVentasPorCliente();
        }
        public static DataTable ObtenerVentasPorProducto()
        {
            return ConsultasModelo.ObtenerVentasPorProducto();
        }
        public static void GuardarPrecioUnitario(int idProducto, decimal precioUnitario)
        {
            ConsultasModelo.GuardarPrecioUnitario(idProducto, precioUnitario);
        }
        public static decimal ObtenerPrecioUnitarioFijado(int productoId)
        {
            return ConsultasModelo.ObtenerPrecioUnitarioFijado(productoId);
        }
        public static decimal ObtenerPrecioMasAltoEnCompras(int productoId)
        {
            return ConsultasModelo.ObtenerPrecioMasAltoEnCompras(productoId);
        }
        public static void RegistrarAuditoria(string nombreUsuario, string accion)
        {
            ConsultasModelo.RegistrarAuditoria(nombreUsuario, accion);
        }
        public static DataTable ObtenerAuditoriaInicioyCerrarPaginada(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerAuditoriaInicioyCerrarPaginada(indiceInicio, tamañoPagina);
        }
        public static int ObtenerCantidadTotalInicioyCierre()
        {
            return ConsultasModelo.ObtenerCantidadTotalInicioyCierre();
        }
        public static DataTable ObtenerAuditoriaProductosPaginada(int indiceInicio, int tamañoPagina)
        {
            return ConsultasModelo.ObtenerAuditoriaProductosPaginada(indiceInicio, tamañoPagina);
        }
        public static int ObtenerCantidadTotalAuditoriaProductos()
        {
            return ConsultasModelo.ObtenerCantidadTotalAuditoriaProductos();
        }
        public static void RegistrarAuditoriaProducto(string nombreUsuario, string accion, string nombreProducto, string origen)
        {
            ConsultasModelo.RegistrarAuditoriaProducto(nombreUsuario, accion, nombreProducto, origen);
        }
        public static DataTable ObtenerTresUsuariosMasIniciaronSesion()
        {
            return ConsultasModelo.ObtenerTresUsuariosMasIniciaronSesion();
        }
        public static DataTable ObtenerUsuariosSesionNocturna()
        {
            return ConsultasModelo.ObtenerUsuariosSesionNocturna();
        }
        public static DataTable ObtenerTresUsuariosMasProductosAgregaron()
        {
            return ConsultasModelo.ObtenerTresUsuariosMasProductosAgregaron();
        }
        public static DataTable ObtenerProductosUltimoMes()
        {
            return ConsultasModelo.ObtenerProductosUltimoMes();
        }
        public static bool RealizarRespaldoBaseDatos(string rutaRespaldo)
        {
            return ConsultasModelo.RealizarRespaldoBaseDatos(rutaRespaldo);
        }
        public static void GuardarInfoRespaldo(string rutaRespaldo)
        {
            ConsultasModelo.GuardarInfoRespaldo(rutaRespaldo);
        }
        public static bool RealizarRestauracionBaseDatos(string rutaArchivo)
        {
            return ConsultasModelo.RealizarRestauracionBaseDatos(rutaArchivo);
        }
        public static bool HaPasadoUnaSemanaDesdeUltimoRespaldo()
        {
            return ConsultasModelo.HaPasadoUnaSemanaDesdeUltimoRespaldo();
        }
        public static DateTime ObtenerFechaUltimoRespaldo()
        {
            return ConsultasModelo.ObtenerFechaUltimoRespaldo();
        }
    }
}
