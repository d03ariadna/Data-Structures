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
    /// Lógica de interacción para TraversingTree.xaml
    /// </summary>
    public partial class TraversingTree : Window
    {
        string InOrder;
        string PreOrder;
        string PostOrder;

        public TraversingTree(Tree tree)
        {
            InitializeComponent();

            tree.Search("0");
            InOrder = string.Join(" - ", tree.inO);
            PreOrder = string.Join(" - ", tree.preO);
            PostOrder = string.Join(" - ", tree.postO);

            txtInOrder.Text = InOrder;
            txtPreOrder.Text = PreOrder;
            txtPostOrder.Text = PostOrder;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
