using Trees;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree tree = new Tree();
        List<string> listO = new List<string>();

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

        Node n4 = new Node();
        n4.data = "4";
        n4.parent = n2;
        tree.Insert(n4);

        Node n5 = new Node();
        n5.data = "5";
        n5.parent = n2;
        tree.Insert(n5);

        Node n6 = new Node();
        n6.data = "6";
        n6.parent = n3;
        tree.Insert(n6);

        Node n7 = new Node();
        n7.data = "7";
        n7.parent = n3;
        tree.Insert(n7);

        Node n8 = new Node();
        n8.data = "8";
        n8.parent = n4;
        tree.Insert(n8);

        Node n9 = new Node();
        n9.data = "9";
        n9.parent = n6;
        tree.Insert(n9);

        Node n10 = new Node();
        n10.data = "10";
        n10.parent = n7;
        tree.Insert(n10);

        Node n11 = new Node();
        n11.data = "11";
        n11.parent = n4;

        tree.Search("0");
        tree.Print();

        //Methods
        tree.Traverse("IN-O");
        tree.Traverse("POST-O");
        tree.Traverse("PRE-O");

        tree.Remove(n3);
        tree.Insert(n11);
        tree.Search("4");

        Node n12 = new Node();
        n12.data = "12";
        n12.parent = n8;
        tree.Insert(n12);
        tree.Search("0");

        tree.Print();
        

        
    }
}