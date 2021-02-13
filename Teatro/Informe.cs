using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            String texto_qr = "";
            List<Asientos> asientos = new List<Asientos>();
            int precio = 0;
            ReportParameter[] parameters = new ReportParameter[6];
            parameters[0] = new ReportParameter("nombre_obra", salas.NombreEvento);
            parameters[1] = new ReportParameter("fecha_obra", salas.Fecha);
            parameters[2] = new ReportParameter("hora_obra", salas.Hora);

            

            foreach (Asientos a in salas.Asiento)
            {
                if (a.Estado.Equals("ocupado") || a.Estado.Equals("reservado"))
                {
                    asientos.Add(a);
                    texto_qr += "Asiento:" + a.Fila + "_" + a.Columna+"\n";
                    precio = precio + 8;
                   

                }
            }
            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrEncoder.Encode(texto_qr);
            var renderer = new GraphicsRenderer(new FixedModuleSize(5,
            QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (var stream = new FileStream(Application.UserAppDataPath +
            @"\qrcode.png", FileMode.Create))
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            reportViewer1.LocalReport.EnableExternalImages = true;

            string ruta = Application.UserAppDataPath + @"\qrcode.png";
            string ruta1 = @"C:\Users\Francisco\source\repos\Teatro\Imagenes\reyleon.jpg";
            string ruta2 = @"C:\Users\Francisco\source\repos\Teatro\Imagenes\berto.jpg";
            string ruta3 = @"C:\Users\Francisco\source\repos\Teatro\Imagenes\humor.jpg";
            string ruta4 = @"C:\Users\Francisco\source\repos\Teatro\Imagenes\macbeth.jpg";
            string ruta5 = @"C:\Users\Francisco\source\repos\Teatro\Imagenes\romeojulieta.jpg";



            parameters[4] = new ReportParameter("ruta_imagen",
            @"file:\" + ruta, true);



            parameters[3] = new ReportParameter("precio", Convert.ToString(precio+" Euros"));
            if(salas.NombreEvento.Equals("El rey leon"))
            {
                parameters[5] = new ReportParameter("ruta_cartel",@"file:\"+ruta1,true);
            }else if(salas.NombreEvento.Equals("El show de Berto"))
            {
                parameters[5] = new ReportParameter("ruta_cartel", @"file:\"+ruta2,true);
            }
            else if (salas.NombreEvento.Equals("El sentido del Humor"))
            {
                parameters[5] = new ReportParameter("ruta_cartel", @"file:\"+ruta3,true);
            }
            else if (salas.NombreEvento.Equals("Mcbeth"))
            {
                parameters[5] = new ReportParameter("ruta_cartel", @"file:\"+ruta4,true);
            }
            else if (salas.NombreEvento.Equals("Romeo y Julieta"))
            {
                parameters[5] = new ReportParameter("ruta_cartel", @"file:\"+ruta5,true);
            }

            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Clear();
            //metodo necesario para añadir una lista
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Datos_asientos", asientos));
            
            this.reportViewer1.RefreshReport();
            
        }
    }
}
