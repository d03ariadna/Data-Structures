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
    /// Lógica de interacción para TraversingGraph.xaml
    /// </summary>
    public partial class TraversingGraph : Window
    {
        public string depth;
        public string breadth;
        public TraversingGraph(Graph graph)
        {
            InitializeComponent();

            graph.printTraversing("D");
            depth = graph.travS;

            graph.printTraversing("B");
            breadth = graph.travS;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDepht_Click(object sender, RoutedEventArgs e)
        {
            txtTraverse.Text = depth;
        }

        private void btnBreadth_Click(object sender, RoutedEventArgs e)
        {
            txtTraverse.Text = breadth;
        }
    }
}
