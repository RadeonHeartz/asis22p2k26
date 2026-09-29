using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26.Ayudas
{
    public class Validación
    {
        private ValidationContext _context;
        private List<ValidationResult> _results;
        private bool _valido;
        private string _mensaje;

        public Validación(object instancia)
        {
            _context = new ValidationContext(instancia);
            _results = new List<ValidationResult>();
            _valido = Validator.TryValidateObject(instancia, _context, _results, true);
        }
        public bool validar()
        {
            if (_valido == false)
            {
                foreach (ValidationResult item in _results)
                {
                    _mensaje += item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(_mensaje);
            }
            return _valido;
        }

    }
}
