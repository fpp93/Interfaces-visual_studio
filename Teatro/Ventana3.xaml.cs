using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Teatro
{
    /// <summary>
    /// Lógica de interacción para Ventana3.xaml
    /// </summary>
    public partial class Ventana3 : Window
    {
        public Ventana3()
        {
            InitializeComponent();
        }
        Sala salas = new Sala();
        
         
        public Ventana3(Sala s)
        {
            salas = s;
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
           
            if (salas.NombreEvento=="El rey leon")
            {
                this.Title = "Teatro Lope De Vega";
            }else if(salas.NombreEvento == "El show de Berto")
            {
                this.Title = "Teatro La Rambleta";
            }
            else if (salas.NombreEvento == "El sentido del Humor")
            {
                this.Title = " Gran Teatro Bankia";
            }
            else if (salas.NombreEvento == "Mcbeth")
            {
                this.Title = "Teatro Sheakspeare";
            }
            else if (salas.NombreEvento == "Romeo y Julieta")
            {
                this.Title = "Antiguo Teatro Capuleto";
            }

            for (int x = 0; x <= salas.Num_filas; x++)
                {
                    grid2.RowDefinitions.Add(new RowDefinition());
                }
                for(int y = 0; y <= salas.Num_columnas; y++)
                {
                    grid2.ColumnDefinitions.Add(new ColumnDefinition());
                }

                for(int i = 1; i <= salas.Num_filas; i++)
                {
                    for(int n = 1; n <= salas.Num_columnas; n++)
                    {
                        
                        Button button = new Button();
                        button.Content = i + "." + n;
                        button.Background = Brushes.GreenYellow;
                        button.Click += btn_Click;
                        grid2.Children.Add(button);
                        Grid.SetRow(button, i);
                        Grid.SetColumn(button, n);
                    }
                }
            
            
                UIElementCollection u = grid2.Children;
                bool filtro = false;
                //cuando cargo la ventana, añado a esa sala los asientos que va a llevar(uno por boton recorriendo filas y columnas)
                for (int i = 1; i <=salas.Num_filas; i++)
                {
                    for (int x = 1; x <=salas.Num_columnas; x++)
                    {
                        //recorro los asientos de sala
                        foreach (Asientos a in salas.Asiento)
                        {
                            //dependiendo del estado entrara
                            if (a.Estado.Equals("ocupado"))
                            {
                                //string  que guarda el formato exacto del content de mis botones
                                String temporal = a.Fila + "." + a.Columna;
                                //recorro los elementos de mi grid
                                foreach (UIElement elements in u)
                                {
                                    //dentro del grid tengo elementos distintos al boton, por lo que compruebo con getType que el elemento sea un boton
                                    if (elements.GetType().ToString().Equals("System.Windows.Controls.Button"))
                                    {
                                        //si el content coincide con la string, cambia el color del boton
                                        if (temporal.Equals(((Button)elements).Content))
                                        {
                                            ((Button)elements).Background = Brushes.Red;
                                            //filtro para saber si es la primera vez que entro en esta ventana o estan todos libres
                                            filtro = true;
                                        }
                                    }

                                }
                            }
                            //igual pero con el estado "reservado"
                            if (a.Estado.Equals("reservado"))
                            {
                                String temporal = a.Fila + "." + a.Columna;
                                foreach (UIElement elements in u)
                                {
                                    if (elements.GetType().ToString().Equals("System.Windows.Controls.Button"))
                                    {
                                        if (temporal.Equals(((Button)elements).Content))
                                        {
                                            ((Button)elements).Background = Brushes.Yellow;
                                            filtro = true;
                                        }
                                    }
                                }
                            }
                        }
                        if (filtro == false)
                        {
                            salas.Asiento.Add(new Asientos(i, x, "libre"));
                        }

                    }
                }



            
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
           //cada boton esta relacionado a este evento(hecho en el xml)
           //paso a la siguiente ventana el boton seleccionado y la informacion de sala con los asientos ya cargados
            Ventana4 v4 = new Ventana4(salas,(Button)sender);
            v4.Show();
            
        }

        private void btn_informe_Click(object sender, RoutedEventArgs e)
        {
            Informe i = new Informe(salas);
            i.Show();
        }
    }
}
