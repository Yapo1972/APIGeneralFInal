using Dapper;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
namespace UtilesGenerales
{

  
    public static  class DatosTecnicos
    {
        public static List<string> obtenerTodosDatosTecnicos( string comienzaPor)
        {
            var resultado = new List<string>();

            var cadConexion = new ConexionSql("AccesoDatos");
            using (var conn = new SqlConnection(cadConexion.obtener()))
                resultado = conn.Query<string>("pr_listaDatosTecnicos", new { comienzaPor }, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return resultado;

        }

 

    }

    public static class OperacionesClientes
    {

        public static bool solicitarIncluirNuevoCliente(VMDatosClientes cliente)
        {
            var resultado = true;



            return resultado;
        }

        public static bool introducirNuevoCliente(VMDatosClientes cliente)
        {
            var resultado = true;
            var cadConexion = new ConexionSql("CORPORATIVO");
            var sql = $"insert into Cliente (Id_Cliente,Desc_Cliente,Nombre_Contacto,Cargo_Contacto,Direccion,Telefono,Id_Organismo,E_mail,Id_Clasifactura,NoSucursal,NoCtas,Moneda_Factura,NoCtasMC,Fecha_Entrada) " +
                                    $"VALUES ('{cliente.idcliente}','{cliente.nombrecliente}','{cliente.contactocomercial}','{cliente.cargo}','{cliente.direccion}','{cliente.telefono}','{cliente.idorganismo}','{cliente.correoelectronico}'," +
                                    $"'{cliente.idclasificacionfactura}','{cliente.sucursal}','{cliente.cuentacup}','{cliente.monedafactura}','{cliente.nrocuentacl}','{DateTime.Now.ToString("yyyy-MM-dd")}' )";
            using (var conn = new SqlConnection(cadConexion.obtener()))
                conn.Execute(sql);
            return resultado;
        }

        public static List<VMDatosOrganismo> obtenerOrganismos()
        {

            var resultado = new List<VMDatosOrganismo>();
            var cadConexion = new ConexionSql("AccesoDatos");
            using (var conn = new SqlConnection(cadConexion.obtener()))
                resultado = conn.Query<VMDatosOrganismo>("pr_listaOrganismos", null, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return resultado;
        }
       public static List<VMMonedas> obtenerMonedas()
        {

            var resultado = new List<VMMonedas>();
            var cadConexion = new ConexionSql("AccesoDatos");
            using (var conn = new SqlConnection(cadConexion.obtener()))
                resultado = conn.Query<VMMonedas>("pr_listaMonedas", null, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return resultado;
        }
       public static List<VMClasificacionFacturas> obtenerClasificacionFacturas()
        {

            var resultado = new List<VMClasificacionFacturas>();
            var cadConexion = new ConexionSql("AccesoDatos");
            using (var conn = new SqlConnection(cadConexion.obtener()))
                resultado = conn.Query<VMClasificacionFacturas>("pr_listaClasificacion", null, commandType: System.Data.CommandType.StoredProcedure).AsList();
            return resultado;
        }
       public static bool existeCliente( string idcliente )
        {

            var resultado = true;
            var cadConexion = new ConexionSql("AccesoDatos");
            using (var conn = new SqlConnection(cadConexion.obtener()))
                resultado = conn.Query("pr_existeCliente", new { idcliente }, commandType: System.Data.CommandType.StoredProcedure).AsList().Count >  0;
            return resultado;
        }

    }
}
