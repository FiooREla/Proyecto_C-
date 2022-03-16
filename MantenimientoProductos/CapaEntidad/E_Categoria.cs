using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Categoria
    {
        private int idcategoria;
        private string Codigocategoria;
        private string Nombrecategoria;
        private string descripcioncategoria;

        //recibimos y enviamos informacion
        //de la cap de presentacion y negocios envia info a entidad y esta info eesta ahi para ser obtenida por otras capas

        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Codigocategoria1 { get => Codigocategoria; set => Codigocategoria = value; }
        public string Nombrecategoria1 { get => Nombrecategoria; set => Nombrecategoria = value; }
        public string Descripcioncategoria { get => descripcioncategoria; set => descripcioncategoria = value; }
    }
}
