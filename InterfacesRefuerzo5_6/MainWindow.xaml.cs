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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InterfacesRefuerzo5_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Button button = new Button();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for(int x = 0; x < 4; x++)
            {
                Grid1.RowDefinitions.Add(new RowDefinition());
            }
            for (int y = 0; y < 4; y++)
            {
                Grid1.ColumnDefinitions.Add(new ColumnDefinition());
            }
            button.Name = "btn_1";
            button.Content = 1;
            button.Background = Brushes.GreenYellow;
            button.Click += btn_Click;
            Grid1.Children.Add(button);
            Grid.SetRow(button, 0);
            Grid.SetColumn(button, 0);
        }
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn =  (Button)sender;
            int cont = 0;
            //cada boton esta relacionado a este evento

            Button button1 = new Button();
            int control = (int)btn.Content;
            button1.Content = control+1;
            button1.Background = Brushes.GreenYellow;
            button1.Click += btn_Click;
            Grid1.Children.Add(button1);
            if (Grid.GetColumn(btn) == 3)
            {
                Grid.SetRow(button1, Grid.GetRow(btn) + 1);
                Grid.SetColumn(button1,0);

            }
            else
            {
                Grid.SetRow(button1, Grid.GetRow(btn));
                Grid.SetColumn(button1, Grid.GetColumn(btn)+1);
            }
            if ((int)button1.Content == 17)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Grid completado, desea crear otro?", "Alerta", MessageBoxButton.YesNo);
                
                if (result == MessageBoxResult.Yes)
                {
                    Window1 w1 = new Window1();
                    w1.Show();
                }
                else if (result == MessageBoxResult.No)
                {
                    Environment.Exit(0);
                }
            }




        }
    }
}
