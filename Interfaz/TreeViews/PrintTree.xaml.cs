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
    /// Lógica de interacción para PrintTree.xaml
    /// </summary>
    public partial class PrintTree : Window
    {
        public PrintTree(Tree tree)
        {
            InitializeComponent();

            tree.Search("0");
            tree.Print();
            txtPrinted.Text = tree.matriz;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
