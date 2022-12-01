using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Trees;

namespace Interfaz.TreeViews
{
    /// <summary>
    /// Lógica de interacción para TreeV.xaml
    /// </summary>
    public partial class TreeV : Window
    {
        public Tree tree = new Tree();
        public List<string> listO = new List<string>();
        public TreeV()
        {
            InitializeComponent();


            Node n1 = new Node();
            n1.data = "1";
            n1.parent = null;
            tree.Insert(n1);

            Node n2 = new Node();
            n2.data = "2";
            n2.parent = n1;
            tree.Insert(n2);

            Node n3 = new Node();
            n3.data = "3";
            n3.parent = n1;
            tree.Insert(n3);


        }


        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Node n = new Node();
            n.data = txtNode.Text;
            n.parent = tree.Search(txtParent.Text);
            tree.Insert(n);

            if (tree.confirm)
            {
                MessageBox.Show("Inserted!");
            }
            else
            {
                MessageBox.Show("Couldn't insert the node. Please choose a different parent");
            }
        }


        public void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Node n = new Node();
            n = tree.Search(txtNode.Text);
            //If the node was not found
            if (n == null)
            {
                MessageBox.Show("Node NOT Found");
            }
            //If the node was found
            else
            {
                MessageBox.Show("Node found");

                var foundV = new NodeFound(tree, n);
                foundV.Owner = this;
                foundV.Show();
            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Node n = new Node();
            n = tree.Search(txtNode.Text);
            if (n == null)
            {
                MessageBox.Show("Node NOT Found");
            }
            else
            {
                tree.Remove(n);
                MessageBox.Show("Removed");
            }
        }

        private void btnTraverse_Click(object sender, RoutedEventArgs e)
        {
            var traverseV = new TraversingTree(tree);
            traverseV.Owner = this;
            traverseV.Show();
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            var printTreeV = new PrintTree(tree);
            printTreeV.Owner = this;
            printTreeV.Show();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            var main = new MainWindow();
            main.Show();
        }
    }
}
