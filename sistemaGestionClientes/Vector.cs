using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestionClientes
{
    internal class Vector
    {
        public struct RegCli
        {
            public Int32 codigo;
            public string nombre;
            public decimal limite;
            public decimal deuda;
        }

        public static RegCli[] cliente = new RegCli[100];
        public static Int32 IND;

        public static String[] meses = new String[12] {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };

        public static String[] sucursales = new String[4] { "Sur", "Norte", "Central", "Oriental" };
    }
}
