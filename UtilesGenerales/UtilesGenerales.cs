using Dapper;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
namespace UtilesGenerales
{

    public class VMDatosClientes
    {
        public string idcliente { get; set; }
        public string nombrecliente { get; set; }
        public string codigo { get; set; }
        public string direccion { get; set; }
        public string nombredirector { get; set; }
        public string correoelectronico { get; set; }
        public string telefono { get; set; }
        public string contactocomercial { get; set; }

        public string cargo { get; set; }
        public string telefonocontacto { get; set; }
        public string correocontacto { get; set; }
        public string cuentacup { get; set; }
        public string banco { get; set; }
        public string sucursal { get; set; }
        public string direccionbanco { get; set; }
        public string nrocuentacl { get; set; }
        public string titularcuentacl { get; set; }
        public string bancocl { get; set; }
        public string   sucursalcl { get; set; }
        public string direccionbancocl { get; set; }
        public string idorganismo { get; set; }
    }

    public class ConexionSql
    {
        private readonly Dictionary<string, string> _cadenaConexion = new Dictionary<string, string> {
            {"AccesoDatos", "data source=server-assets;initial catalog=AccesoDatos;user id=user_assetsp;password=Super2009" }
        };
        private string cadenaConexion { get; set; }
        public ConexionSql(string _conex)
        {
            cadenaConexion = _cadenaConexion[_conex];
        }
        public string obtener() => cadenaConexion;
    }

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

        public static bool introducirNuevoCliente( VMDatosClientes cliente)
        {

        }


    }
}
