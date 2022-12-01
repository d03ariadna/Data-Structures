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
using Graphs;

namespace Interfaz.GraphViews
{
    /// <summary>
    /// Lógica de interacción para PrintMat.xaml
    /// </summary>
    public partial class PrintMat : Window
    {
        public PrintMat(Graph graph)
        {
            InitializeComponent();
            graph.printMat();
            txtPrint.Text = graph.matrizS;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
