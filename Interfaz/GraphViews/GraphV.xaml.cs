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
    /// Lógica de interacción para GraphV.xaml
    /// </summary>
    public partial class GraphV : Window
    {
        public Graph graph = new Graph();
        public GraphV()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var main = new MainWindow();
            main.Show();

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Vertex v = graph.Search(txtVertex.Text);
            if(v == null)
            {
                graph.InsertV(txtVertex.Text);
                MessageBox.Show("Inserted!");
            }
            else
            {
                MessageBox.Show("There is an existing vertex with this data");
            }
            
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            Vertex v = graph.Search(txtVertex.Text);
            if (v != null)
            {
                graph.DeleteV(txtVertex.Text);
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("There is any vertex with this data");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Vertex v = new Vertex();
            v = graph.Search(txtVertex.Text);

            if(v == null)
            {
                MessageBox.Show("Vertex not Found");
            }
            else
            {
                MessageBox.Show("Vertex found" + v.item);
                var vertexF = new VertexFound(graph, v);
                vertexF.Owner = this;
                vertexF.Show();
            }
        }

        private void btnInsertE_Click(object sender, RoutedEventArgs e)
        {
            Vertex v1 = graph.Search(txtVertex.Text);
            Vertex v2 = graph.Search(txtLink.Text);

            if(v1 != null && v2 != null)
            {
                graph.InsertEdge(v1, int.Parse(txtPrice.Text) , v2);
                MessageBox.Show("Edge Inserted!");
            }
            else
            {
                MessageBox.Show("One of the vertices you try to link doesn't exist");
            }
            
        }

        private void btnRemoveE_Click(object sender, RoutedEventArgs e)
        {
            Vertex v1 = graph.Search(txtVertex.Text);
            Vertex v2 = graph.Search(txtLink.Text);

            if (v1 != null && v2 != null)
            {
                graph.DeleteEdge(v1 , v2);
                MessageBox.Show("Edge Deleted!");
            }
            else
            {
                MessageBox.Show("One of the vertices in the edge you try to delete doesn't exist");
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var printM = new PrintMat(graph);
            printM.Owner = this;
            printM.Show();
        }

        private void btnTraverse_Click(object sender, RoutedEventArgs e)
        {
            var traverseG = new TraversingGraph(graph);
            traverseG.Owner = this;
            traverseG.Show();
        }

        private void btnShortest_Click(object sender, RoutedEventArgs e)
        {
            var shortest = new Shortest(graph);
            shortest.Owner = this;
            shortest.Show();
        }
    }
}
