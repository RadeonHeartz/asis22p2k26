using CapaModelo_Mantenimiento2k26.Contratos;
using CapaModelo_Mantenimiento2k26.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Mantenimiento2k26.Repositorios
{
    public class clsRepositorioFacultad : clsSentencias, IRepositorioFacultad
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public clsRepositorioFacultad()
        {
            _SelectAll = "SELECT * FROM tblfacultades;";
            _Insert = "Inserto into tblfacultades values (?, ?, ?);";
            _Update = "UPDATE tblfacultades set codigoFacultad = ?, nombreFacultad = ?, nombreFacultad = ?;";
            _Delete = "DELETE FROM tblfacultades WHERE codigoFacultad = ?, AND nombreFacultad = ?, AND nombreFacultad = ?;";
        }

        public int FacultadMetAgregar(ClsFacultad Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("codigoFacultad", Entidad.codigoFacultad));
            Parametros.Add(new OdbcParameter("nombreFacultad", Entidad.nombreFacultad));
            Parametros.Add(new OdbcParameter("estatusFacultad", Entidad.estatusFacultad));

            return MantenimientoMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int FacultadMetEditar(ClsFacultad Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("codigoFacultad", Entidad.codigoFacultad));
            Parametros.Add(new OdbcParameter("nombreFacultad", Entidad.nombreFacultad));
            Parametros.Add(new OdbcParameter("estatusFacultad", Entidad.estatusFacultad));


            return MantenimientoMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int FacultadMetRemover(ClsFacultad Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("codigoFacultad", Entidad.codigoFacultad));
            Parametros.Add(new OdbcParameter("nombreFacultad", Entidad.nombreFacultad));
            Parametros.Add(new OdbcParameter("estatusFacultad", Entidad.estatusFacultad));

            return MantenimientoMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }
        public IEnumerable<ClsFacultad> FacultadMetObtenerTodos()
        {
            var _listaFacultades = new List<ClsFacultad>();
            var TblTabla = MantenimientoMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow row in TblTabla.Rows)
            {
                var Facultad = new ClsFacultad();
                Facultad.codigoFacultad = row[0].ToString();
                Facultad.nombreFacultad = row[1].ToString();
                Facultad.estatusFacultad= row[2].ToString();

                _listaFacultades.Add(Facultad);
            }
            TblTabla.Clear();
            TblTabla = null;
            return _listaFacultades;
        }
    }
}

