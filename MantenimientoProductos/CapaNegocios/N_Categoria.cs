using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class N_Categoria
    {
        D_Categoria objDato = new D_Categoria();
        public List<E_Categoria> ListandoCategoria(string buscar)
        {
            return objDato.listarCategoria(buscar);
        }

        public void InsertandoCategoria(E_Categoria categoria)
        {
            objDato.insertarCategora(categoria);
        }
        public void EditandoCategoria(E_Categoria categoria)
        {
            objDato.editarCategoria(categoria);
        }
        public void EliminarCategoria(E_Categoria categoria)
        {
            objDato.eliminarCategoria(categoria);
        }
        
        
    }
} 
