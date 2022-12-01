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
    /// Lógica de interacción para VertexFound.xaml
    /// </summary>
    public partial class VertexFound : Window
    {
        public VertexFound(Graph graph, Vertex v)
        {
            InitializeComponent();

            txtVertexF.Text = v.item;

            //Look for its links
            graph.printEdges(v);
            txtLinks.Text = graph.linksList;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
