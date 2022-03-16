using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Marca
    {
        public int idMarca;
        public string codigoMarca;
        public string nombreMarca;
        public string descripcionMarca;

        public int IdMarca { get => idMarca; set=> idMarca = value; }
        public string CodigoMarca { get => codigoMarca; set => codigoMarca = value; }
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }
        public string DescripcionMarca { get => descripcionMarca; set => descripcionMarca = value; }

    }
}
