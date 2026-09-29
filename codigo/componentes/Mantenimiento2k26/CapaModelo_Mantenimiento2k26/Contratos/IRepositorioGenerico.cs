using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Mantenimiento2k26.Contratos
{
    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        int FacultadMetAgregar(Entidad Entidad);
        int FacultadMetEditar(Entidad Entidad);
        int FacultadMetRemover(Entidad Entidad);
        IEnumerable<Entidad> FacultadMetObtenerTodos();
    }
}
