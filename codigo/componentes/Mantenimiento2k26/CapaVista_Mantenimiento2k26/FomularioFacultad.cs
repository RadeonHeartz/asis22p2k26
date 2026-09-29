using CapaControlador_Mantenimiento2k26;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26
{
    public partial class FomularioFacultad : Form
    {
        private ClsModeloFacultad Facultad = new ClsModeloFacultad();
        public FomularioFacultad()
        {
            InitializeComponent();
            panel1.Enabled = false;


        }

        private void FormularioFacultad_Load(object sender, EventArgs e)
        {
            FacultadMetListaFacultad();
        }
        private void FacultadMetListaFacultad()
        {
            try
            {
                dataGridView1.DataSource = Facultad.GetAll();
            }catch(Exception e)
            {
                MessageBox.Show("Error al cargar la lista de facultades: " + e.Message);
            }
        }
        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            Facultad.codigoFacultad = Codigo.Text;
            Facultad.nombreFacultad = Nombre.Text;  
            Facultad.estatusFacultad = Estadp.Text;

            bool valido = new Ayudas.Validación(Facultad).validar();
            if (valido)
            {
                string resultado = Facultad.GrabarCambios();
                MessageBox.Show(resultado);
                FacultadMetListaFacultad();
                reinicio();
            }
        }
        private void reinicio()
        {
            panel1.Enabled = false;
            Codigo.Clear();
            Nombre.Clear();
            Estadp.Clear();
        }

        private void Nuevobtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            Facultad.Estadoentidad = Estadoentidad.Added;
        }

        private void Editarbtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                Facultad.Estadoentidad = Estadoentidad.Modified;
                Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Estadp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void borrarbtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Enabled = true;
                Facultad.Estadoentidad = Estadoentidad.Deleted;
                Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Estadp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void Imprimirbtn_Click(object sender, EventArgs e)
        {
            FrmReporte reporte = new FrmReporte();
            reporte.Show();
        }
    }
}
