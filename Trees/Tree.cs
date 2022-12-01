using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Tree
    {
        public Node? root = null;
        public int levels { get; set; }
        public int temp { get; set; }
        public int spaces;
        public bool flag;
        public bool confirm;
        public string matriz;
        public string nodeLevel;
        //public string[] nodeFound = new string[0];
        //public string found { get; set; }

        public Node found = null;

        public List<List<string>> levList = new List<List<string>>();
        public List<string> auxList = new List<string>();

        public List<string> preO = new List<string>();
        public List<string> inO = new List<string>();
        public List<string> postO = new List<string>();


    //Insert a new node in the tree
    public void Insert(Node n)
        {
            confirm = false;
            if (n.parent == null) {
                if(root == null)
                {
                    root = n;
                    //Console.WriteLine("Inserted!");
                    confirm = true;
                }
            }
            else if (n.parent.left == null)
        //This means we can insert the node in the LEFT
            {
                n.parent.left = n;
                //Console.WriteLine("Inserted!");
                confirm = true;
            }
            else if(n.parent.right == null)
        //This means we can insert the node in the RIGHT
            {
                n.parent.right = n;
                //Console.WriteLine("Inserted!");
                confirm = true;
            }
            else
        //This means the parent node is COMPLETE
            {
                //Console.WriteLine("The parent node in which you are trying to insert is already COMPLETE");
            }
        }

        public void Remove(Node n)
        {
            //This means we are trying to delete the root
            if (n.parent == null)
            {
                n.left.parent = null;
                n.right.parent = null;
                root = null;
            }
        //In case the node is a left child, we will delete it from its parent
            else if (n.parent.left.data == n.data)
            {
                n.parent.left = null;
                //Console.WriteLine("Removed");

        //In case the node is a right child, we will delete it from its parent
            }else if(n.parent.right.data == n.data)
            {
                n.parent.right = null;
                //Console.WriteLine("Removed");
            }

        }


        public Node Search(string item)
        {
            levels = 0;

            preO.Clear();
            inO.Clear();
            postO.Clear();

            //nodeFound.Clear();

            if (root == null)
            {
                Console.WriteLine("You don't have any Node in your Tree yet.");
                found = null;

            }
            else
            {
                temp = 1;
                flag = false;
                move(root, item);
                //Retornar string o lista de atribitos del nodo encontrado
            }
            return found;
        }


        //We use this method for many purposes:
        //Getting the number of levels
        //Create the 3 traversing lists
        private void move(Node n, string item)
        {
            if (temp > levels)
            {
                levels = temp;
            }
            preO.Add(n.data);
            if (n.data != item)
            {
                if(n.left != null)
                {
                    temp++;
                    n = n.left;
                    move(n, item);
                    n = n.parent;
                }
                inO.Add(n.data);

                if (n.right != null)
                {
                    temp++;
                    n = n.right;
                    move(n, item);
                    n = n.parent;
                }
                postO.Add(n.data);

                temp--;
                if(n.parent == null && !flag)
                {
                    //Console.WriteLine("Node not Found" + "\nLevels in your tree: "+levels);
                    found = null;
                    nodeLevel = "";
                }
                return;
            }
            else
            {
                //Console.WriteLine("Node " + n.data + " found \n-> Parent: " + n.parent.data + "\n-> Level: "+ (temp));
                //if(n.left!= null)
                //{
                //    Console.WriteLine("-> Left Child: " + n.left.data);
                //}
                //if (n.right != null)
                //{
                //    Console.WriteLine("-> Right Child: " + n.right.data);
                //}

                //Once the node has been found, we have to stop the algorithm to keep looking for it
                flag = true;

                found = n;
                nodeLevel = temp.ToString();
            }
        }


        public void Traverse(string type)
        {
            auxList.Clear();
            switch (type)
            {
                case "PRE-O":
                    auxList = preO;
                    Console.Write("PRE Order: ");
                    break;

                case "IN-O":
                    auxList = inO;
                    Console.Write("IN Order: ");
                    break;

                case "POST-O":
                    auxList = postO;
                    Console.Write("POST Order: ");
                    break;
            }

            for (int i = 0; i < auxList.Count; i++)
            {
                Console.Write(auxList[i] + " ");
            }
            Console.WriteLine("");
        }




        public void Print()
        {
            matriz = "";
            levList.Clear();
        //This loop is for creating the matriz in which we'll store the data that will be printed later
            for (int i = 0; i < levels; i++)
            {
                levList.Add(new List<string>());
            }
            if (root != null)
            {
                temp = 1;
                createM(root);
            }

        //After creating the matrix, we convert it into a string

            for(int i = 0; i < levels; i++)
            {
                for(int j = 0; j < levList[i].Count; j++)
                {
                    matriz += (levList[i][j]);
                }
                matriz += ("\n");
            }
        }
        private void createM(Node n)
        {
            bool flag2 = true;


            if(n.left != null)
            {
                temp++;
                n = n.left;
                createM(n);
                n = n.parent;

        //This means we don't have a left child BUT we have other childs in the same level
            }else if(temp < levels)
            {
                flag2 = false;
            }

            if(n.right != null)
            {
                temp++;
                n = n.right;
                createM(n);
                n = n.parent;
            }
        //This means the same as the previous case
            else if (temp < levels)
            {
                flag2 = false;
            }

        //In case there's a null node in a level that has other nodes, we print " "
            if (!flag2)
            {
                temp++;
                spaces = Convert.ToInt32(Math.Pow(2, levels) / Math.Pow(2, temp));
                spaces = (spaces * 2)+1;
                addS(spaces, temp);
                temp--;
            }

        //Here we calculate the number of spaces we'll add to each row
            spaces = Convert.ToInt32(Math.Pow(2, levels) / Math.Pow(2, temp));

        //Here we add the blanck spaces and the data to its correspondant row
            addS(spaces, temp);
            levList[temp-1].Add(n.data);
            addS(spaces, temp);

        //Then we reduce the temporal level and return;
            temp--;
            return;

        }

        //This method is for adding the necesary spaces in the visual tree representation
        private void addS(int s, int temp)
        {


            for(int i = 0; i < s; i++)
            {
                levList[temp - 1].Add(" ");
            }
        }

        
    }
    
}
