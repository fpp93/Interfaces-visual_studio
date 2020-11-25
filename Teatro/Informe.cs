using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatro
{
    public partial class Informe : Form
    {
        public Informe()
        {
            InitializeComponent();
        }
        Sala salas = new Sala();
        public Informe(Sala s)
        {
            salas = s;
            InitializeComponent();
        }

        private void Informe_Load(object sender, EventArgs e)
        {
            List<Asientos> asientos = new List<Asientos>();
            int precio = 0;
            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("nombre_obra", salas.NombreEvento);
            parameters[1] = new ReportParameter("fecha_obra", salas.Fecha);
            parameters[2] = new ReportParameter("hora_obra", salas.Hora);
          
            foreach (Asientos a in salas.Asiento)
            {
                if (a.Estado.Equals("ocupado"))
                {
                    asientos.Add(a);
                    precio = precio + 8;
                }
            }
            parameters[3] = new ReportParameter("precio", Convert.ToString(precio+" Euros"));
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            //metodo necesario para añadir una lista
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos_asientos", asientos));
            
            this.reportViewer1.RefreshReport();
        }
    }
}
