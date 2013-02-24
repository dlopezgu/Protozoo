using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Protozoo.Ui.Presentadores;

namespace Protozoo.Desktop
{
    /// <summary>
    /// Lógica de interacción para Window1Content.xaml
    /// </summary>
    public partial class Window1Content : UserControl
    {
        public Window1Content()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModel)DataContext).ProcessViewRequest();
        }
    }
}
