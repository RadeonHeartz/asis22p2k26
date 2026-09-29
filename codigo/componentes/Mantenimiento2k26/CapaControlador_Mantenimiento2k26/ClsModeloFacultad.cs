using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Mantenimiento2k26;
using CapaModelo_Mantenimiento2k26.Repositorios;
using System.ComponentModel.DataAnnotations;
using CapaModelo_Mantenimiento2k26.Entidades;

namespace CapaControlador_Mantenimiento2k26
{
    public class ClsModeloFacultad
    {
        private string _codigoFacultad;
        private string _nombreFacultad;
        private string _estatusFacultad;
        
        private clsRepositorioFacultad _RepositorioFacultad;

        public Estadoentidad Estadoentidad { get; set; }
        private List<ClsModeloFacultad> _ListaFacultades;


        [Required(ErrorMessage = "El codigo de la facultad es obligatorio")]
        [StringLength(maximumLength: 5, ErrorMessage = "El codigo de la facultad no puede exceder 5 caracteres")]
        public string codigoFacultad
        {
            get => _codigoFacultad;
            set => _codigoFacultad = value; }

        [Required(ErrorMessage = "El nombre de la facultad es obligatorio")]
        [StringLength(maximumLength:45, ErrorMessage = "El nombre de la facultad debe tener al menos 45 caracteres")]
            public string nombreFacultad
            {
                get => _nombreFacultad;
                set => _nombreFacultad = value;
            }

        [Required(ErrorMessage = "El estatus de la facultad es obligatorio")]
        [RegularExpression("[0-1]", ErrorMessage = "El estatus de la facultad debe ser 0 o 1")]
        [StringLength(maximumLength: 1, ErrorMessage = "El estatus de la facultad debe tener al menos 1 caracter")]
        public string estatusFacultad
        {
            get => _estatusFacultad;
            set => _estatusFacultad = value;
        }
        public ClsModeloFacultad()
        {
            _RepositorioFacultad = new clsRepositorioFacultad();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var modeloDatosFacultad = new ClsFacultad();
                modeloDatosFacultad.nombreFacultad = _nombreFacultad;
                modeloDatosFacultad.codigoFacultad = _codigoFacultad;
                modeloDatosFacultad.estatusFacultad = _estatusFacultad;

                switch (Estadoentidad)
                {
                    case Estadoentidad.Added:
                        _RepositorioFacultad.FacultadMetAgregar(modeloDatosFacultad);
                        mensaje = "Registro agregado correctamente.";
                        break;
                    case Estadoentidad.Deleted:
                        _RepositorioFacultad.FacultadMetRemover(modeloDatosFacultad);
                        mensaje = "Registro eliminado correctamente.";
                        break;
                    case Estadoentidad.Modified:
                        _RepositorioFacultad.FacultadMetEditar(modeloDatosFacultad);
                        mensaje = "Registro modificado correctamente.";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            return mensaje;
        }
        public List<ClsModeloFacultad> GetAll()
        {
            var ModeloDatosFacultades = _RepositorioFacultad.FacultadMetObtenerTodos();
            _ListaFacultades = new List<ClsModeloFacultad>();
            foreach (ClsFacultad item in ModeloDatosFacultades)
            {
                _ListaFacultades.Add(new ClsModeloFacultad
                {
                    _codigoFacultad = item.codigoFacultad,
                    _nombreFacultad = item.nombreFacultad,
                    _estatusFacultad = item.estatusFacultad
                });

            }
            return _ListaFacultades;
        }
        public IEnumerable<ClsModeloFacultad> GetById(string filter)
        {
            return _ListaFacultades.FindAll(e => e._codigoFacultad.ToString().Contains(filter) || e._nombreFacultad.ToString().Contains(filter) || e._estatusFacultad.ToString().Contains(filter));
        }
    }
}

