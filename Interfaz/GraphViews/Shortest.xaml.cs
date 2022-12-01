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
    /// Lógica de interacción para Shortest.xaml
    /// </summary>
    public partial class Shortest : Window
    {
        public Graph graphL = new Graph();
        public Shortest(Graph graph)
        {
            InitializeComponent();

            graphL = graph;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnShortest_Click(object sender, RoutedEventArgs e)
        {
            graphL.FindPath(txtDestin.Text);

            txtPath.Text = graphL.pathS;
            txtPrice.Text = graphL.FinalWeight.ToString();
        }
    }
}
