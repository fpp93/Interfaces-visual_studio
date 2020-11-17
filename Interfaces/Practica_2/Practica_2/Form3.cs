using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form3 : Form
    {
        int idagenda;
        public Form3()
        {
            InitializeComponent();
        }

        //constructor pasando por parametro el id de agenda
        public Form3(int id_agenda)
        {
            idagenda = id_agenda;
            InitializeComponent();
        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //con esto permito guardar en el evento de guardar, con el id de agenda vacio, asignando el id ya pasado
            tareaDataGridView.CurrentRow.Cells[0].Value = idagenda;
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.seleccionatarea(this.miagendaDataSet1.tarea, idagenda);
            //con esto llamo a mi consulta para seleccionar las tareas por id de agenda





        }

        private void tareaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tareaTableAdapter.Fill(this.miagendaDataSet1.tarea);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscadia_Click(object sender, EventArgs e)
        {
            //consulta para filtrar las tareas por dia con el boton 
            this.tareaTableAdapter.Filtrarpordia(this.miagendaDataSet1.tarea,int.Parse(txtDia.Text));
        }
    }
}
