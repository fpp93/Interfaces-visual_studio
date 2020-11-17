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
    public partial class Form2 : Form
    {
        //creo la variable que utilizare para desplazar el id de las agendas a tareas
        int id_agenda = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet1.agenda);

        }

        private void agendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           //luis, estos son pruebas de codigo que quiero conservar comentadas

            // String id;

            // id = agendaDataGridView(0, agendaDataGridView.CurrentRow.Index).Value;

            //Recuperar fila y celda que quiera al hacer click en una celda:
            //agendaDataGridView.Rows[e.RowIndex].Cells[0];
            //Ejecutar consulta sobre tabla:
            //agendaTableAdapter.(nombre de la consulta)+parámetro;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //evento de boton que me consulta las tareas por id de agenda
            Form3 f3 = new Form3(id_agenda);
            f3.Show();
        }

        private void agendaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //guardo en la variable a desplazar,el valor de las celdas 0, que son el id
            id_agenda = Convert.ToInt32(agendaDataGridView.CurrentRow.Cells[0].Value.ToString());


        }
    }
}
