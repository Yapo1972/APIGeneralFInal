using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilesGenerales
{
    public class VMDatosClientes
    {
        public string idcliente { get; set; }
        public string nombrecliente { get; set; }
        public string direccion { get; set; }
        public string nombredirector { get; set; }
        public string correoelectronico { get; set; }
        public string telefono { get; set; }
        public string contactocomercial { get; set; }
        public string idclasificacionfactura { get; set; }
        public string monedafactura { get; set; }

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
        public string sucursalcl { get; set; }
        public string direccionbancocl { get; set; }
        public string idorganismo { get; set; }
    }

    public class VMDatosOrganismo
    {

        public string Id_Organismo { get; set; }
        public string Organismo { get; set; }
        public string Sector { get; set; }
    }

    public class VMMonedas
    {
        public string Moneda { get; set; }
        public string Desc_Moneda { get; set; }
    }

    public class VMClasificacionFacturas
    {
        public string Id_Clasifactura { get; set; }
        public string Desc_Clasifactura { get; set; }
    }
    public class VMDatosProductos
    {

    }
    public class ConexionSql
    {
        private readonly Dictionary<string, string> _cadenaConexion = new Dictionary<string, string> {
            {"AccesoDatos", "data source=server-assets;initial catalog=AccesoDatos;user id=user_assetsp;password=Super2009" },
            {"CORPORATIVO", "data source=server-assets;initial catalog=CORPORATIVO_COMPACTO;user id=user_assetsp;password=Super2009" },
            {"HABANA", "data source=server-assets;initial catalog=COMPACTO_PLANTA_HAB;user id=user_assetsp;password=Super2009" },
            {"SANTIAGO", "data source=192.168.12.6;initial catalog=COMPACTO_SANTIAGO;user id=user_assetsp;password=Super2009" },
            {"PALMA", "data source=192.168.11.6;initial catalog=COMPACTO_PALMA;user id=user_assetsp;password=Super2009" },
        };
        private string cadenaConexion { get; set; }
        public ConexionSql(string _conex)
        {
            cadenaConexion = _cadenaConexion[_conex];
        }
        public string obtener() => cadenaConexion;
    }

}
