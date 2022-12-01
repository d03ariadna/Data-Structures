using Interfaz.TreeViews;
using Interfaz.GraphViews;
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

namespace Interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnTrees_Click(object sender, RoutedEventArgs e)
        {
            var treesV = new TreeV();
            treesV.Owner = this;
            treesV.Show();
        }

        private void btnGraphs_Click(object sender, RoutedEventArgs e)
        {
            var graphV = new GraphV();
            graphV.Owner = this;
            graphV.Show();
        }
    }
}
