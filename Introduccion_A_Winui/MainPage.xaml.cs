using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Introduccion_A_Winui
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested +=  irAtras; //xaml controls gallery

        }

        private void irAtras(object sender ,BackRequestedEventArgs a )
        {
            if (frInicio.BackStack.Any()) frInicio.GoBack();
        }

        private void cargarMonstruos(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(MonsterPage));
        }

        private void cargarFauna(object sender, RoutedEventArgs e)
        {
            frInicio.Navigate(typeof(Fauna));
        }

        private void cargarInicio(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));//boton de inicio si lo ponemos como los otros se cargara en cadena la pagina
                
        }
    }
}
