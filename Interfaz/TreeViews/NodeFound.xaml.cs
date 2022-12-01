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
using Trees;

namespace Interfaz.TreeViews
{
    /// <summary>
    /// Lógica de interacción para NodeFound.xaml
    /// </summary>
    public partial class NodeFound : Window
    {
        
        public NodeFound(Tree tree, Node n)
        {
            InitializeComponent();

            txtNodeF.Text = n.data;

            if (n.parent == null)
            {
                txtParent.Text = "";
            }
            else
            {
                txtParent.Text = n.parent.data;
            }

            if (n.left == null)
            {
                txtLeft.Text = "";
            }
            else
            {
                txtLeft.Text = n.left.data;
            }

            if (n.right == null)
            {
                txtRight.Text = "";
            }
            else
            {
                txtRight.Text = n.right.data;
            }

            txtLevel.Text = tree.nodeLevel;

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
