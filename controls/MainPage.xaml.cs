using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace controls
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public long fechaActual;
        public DateTime fecha;

        public MainPage()
        {
            this.InitializeComponent();
            SetMinDate();
            SetSelectedDate();
        }
        /// <summary>
        /// Este método se encarga de poner el datepicker con el valor del día de hoy
        /// </summary>


        private void SetSelectedDate()
        {
            fecha = DateTime.Now;
            fechaActual = fecha.Ticks; //Pasar de date a long
            calendarioEntrada.Date = new DateTime(fechaActual);

        }
        /// <summary>
        /// El siguiente método establece que el usuario solo podrá seleccionar 
        /// fechas superiores a la fecha actual 
        /// </summary>
        private void SetMinDate()
        {
            fecha = DateTime.Now;
            fechaActual = fecha.Ticks; //Obtener la fecha de un date time a long
            calendarioEntrada.Date = new DateTime(fechaActual);
            calendarioEntrada.MinDate = new DateTime(fechaActual);
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            if (Yes.IsChecked == true)
            {
                texto.Text = "Yes";
            }
            if (No.IsChecked == true)
            {
                texto.Text = "No";
            }
            if (Maybe.IsChecked == true)
            {
                texto.Text = "Maybe";
            }
        }
    }
}

