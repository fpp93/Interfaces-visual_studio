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

namespace Teatro
{
    /// <summary>
    /// Lógica de interacción para Ventana4.xaml
    /// </summary>
    public partial class Ventana4 : Window
    {
        public Ventana4()
        {
            InitializeComponent();
        }

        Asientos asientos;
        Sala salas;
        Button boton;

        public Ventana4(Sala s,Button b)
        {
            salas = s;
            boton = b;
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, RoutedEventArgs e)
        {
            //recorro los asientos de mi sala
            foreach(Asientos a in salas.Asiento)
            {
                //creo un string que contiene el mismo nombre que mis asientos
                String temporal = a.Fila + "." + a.Columna;
                //si coincide con el content del boton entra y me cambia el estado y color del boton
                if (temporal.Equals(boton.Content))
                {
                    if (a.Estado.Equals("ocupado"))
                    {
                        System.Windows.MessageBox.Show("Este asiento ya está ocupado", "Información", (MessageBoxButton)MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    else
                    {
                        a.Estado = "ocupado";
                        boton.Background = Brushes.Red;
                        this.Close();
                    }
                }
                
            }
        }

        private void btn_reservar_Click(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in salas.Asiento)
            {
                String temporal = a.Fila + "." + a.Columna;
                if (temporal.Equals(boton.Content))
                {
                    if (a.Estado.Equals("reservado"))
                    {
                        System.Windows.MessageBox.Show("Este asiento ya está reservado", "Información", (MessageBoxButton)MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    else
                    {
                        a.Estado = "reservado";
                        boton.Background = Brushes.Yellow;
                        this.Close();
                    }
                }
                
            }
        }

        private void btn_cancelar1_Click(object sender, RoutedEventArgs e)
        {
            foreach (Asientos a in salas.Asiento)
            {
                String temporal = a.Fila + "." + a.Columna;
                if (temporal.Equals(boton.Content))
                {
                    //control sobre que el asiento ya este libre al cancelar gestion
                    if (a.Estado.Equals("libre"))
                    {
                        System.Windows.MessageBox.Show("Este asiento ya está libre", "Información", (MessageBoxButton)MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
                    }
                    else
                    {
                        a.Estado = "libre";
                        boton.Background = Brushes.GreenYellow;
                        this.Close();
                    }
                   
                }
            }
        }
    }
}
