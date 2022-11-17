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
using BLL;
namespace main
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClasificacionBLL cbll = new ClasificacionBLL();
        TareasBLL tbll = new TareasBLL();
        public MainWindow()
        {
            InitializeComponent();
            ListClasificacion.ItemsSource = cbll.GetAll();
            ListTarea.ItemsSource = tbll.GetAll();
            
        }

        private void BtnNuevaClasificacion_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtClasificacion.Text;

            //Validaciones de entrada 

            cbll.Add(nombre);

            MessageBox.Show("Clasificación creada", " Nueva clasificación", MessageBoxButton.OK, MessageBoxImage.Information);
            txtClasificacion.Text = string.Empty;

            ListClasificacion.ItemsSource = null;
            ListClasificacion.ItemsSource = cbll.GetAll();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Titulo = TxtTitulo.Text;
            string Detalle = TxtDetalle.Text;
            DateTime FechaVenc = (DateTime)Fecha.SelectedDate;

            tbll.Add(Titulo, Detalle, FechaVenc);

            MessageBox.Show("Tarea creada", " Nueva tarea", MessageBoxButton.OK, MessageBoxImage.Information);
            TxtTitulo.Text = string.Empty;
            TxtDetalle.Text = string.Empty;


            ListTarea.ItemsSource = null;
            ListTarea.ItemsSource = tbll.GetAll();
        }
    }
}
