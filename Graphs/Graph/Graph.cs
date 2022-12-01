using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Graph
    {
        public int i;
        public int weight;
        public Vertex tempV;
        public int FinalWeight;
        public string linksList;
        public string matrizS;
        public string travS;
        public string pathS;

        //List of nodes in the graph
        public List<Vertex> vertexs = new List<Vertex>();

        //Adjacency Matrix
        public List<List<int>> matriz = new List<List<int>>();

        //Traversing Lists
        public List<string> traversed = new List<string>();

        public List<string> path = new List<string>();

        public void InsertV(string item)
        {
            Vertex v = new Vertex();
            v.item = item;
            v.reff = vertexs.Count();
            vertexs.Add(v);
            addLineMat(v);
        }


        public void InsertEdge(Vertex v1, int price, Vertex v2)
        {
            //Vertex v1 = Search(item);
            //Vertex v2 = Search(item2);

            //Insert link in each vertex's dictionary
            v1.links[v2] = price;
            //v2.links[v1] = price;  -- Make it bidirectional

            //Insert the link values in the matrix
            matriz[v1.reff][v2.reff] = price;
            //matriz[v2.reff][v1.reff] = price;  -- Make it bidirectional
        }



        public void DeleteV(string item)
        {
            Vertex v = Search(item);


            //First we delete its possible links
            foreach (Vertex link in v.links.Keys)
            {
                matriz[v.reff][link.reff] = 0;
                link.links.Remove(v);
            }


            //Then we delete it from other vertices links
            foreach (Vertex i in vertexs)
            {
                if (i.links.Keys.Contains(v))
                {   
                    matriz[i.reff][v.reff] = 0;
                    i.links.Remove(v);
                }
            }
            v.item = "  ";
            v.links.Clear();
            //vertexs.Remove(v);
        }


        public void DeleteEdge(Vertex v1, Vertex v2)
        {
            //Vertex v1 = Search(item);
            //Vertex v2 = Search(item2);

            v1.links.Remove(v2);
            matriz[v1.reff][v2.reff] = 0;

            //v2.links.Remove(v1);
            //matriz[v2.reff][v1.reff] = 0;
        }


        private void addLineMat(Vertex v)
        {
            matriz.Add(new List<int>());

            for (i = 0; i < v.reff; i++)
            {
                matriz[i].Add(0);
                matriz[v.reff].Add(0);

            }

            matriz[v.reff].Add(0);

        }

        //private void deleteLineMat(Vertex v)
        //{
        //    for(int i=0; i < matriz.Count; i++)
        //    {
        //        matriz[(i)].Remove(v.reff);
        //    }
        //    matriz.Remove(matriz[v.reff]);
        //}


        public void printMat()
        {
            matrizS = "";

            //Console.Write("   ");
            matrizS += "   ";
            for (i = 0; i < vertexs.Count; i++)
            {
                matrizS += (vertexs[i].item + "  ");
            }

            for (i = 0; i < matriz.Count; i++)
            {
                matrizS += ("\n" + vertexs[i].item + " ");
                for (int j = 0; j < matriz[i].Count; j++)
                {
                    matrizS += (" " + matriz[i][j] + " ");
                }

            }
            matrizS += ("\n");

            
        }


        public void printEdges(Vertex v)
        {
            //Vertex v = Search(item);

            linksList = "";
            if (v.links.Count != 0)
            {
                //linksList += (v.item + " - Links: ");
                foreach (Vertex vE in v.links.Keys)
                {
                    linksList+= (v.item + "  -> " + vE.item + " - Price: " + v.links[vE] + "\n");
                }
            }
            else
            {
                linksList = "This vertex doesn't have \n any links yet";
            }
        }

        public void printTraversing(string type) //Returns a list
        {
            Vertex v = vertexs[0];
            travS = "";
            traversed.Clear();
            switch (type)
            {
                case "B":
                    breadthList(v, v);
                    break;

                case "D":
                    depthList(v);
                    break;

            }


            //Print list chosen
            foreach (var item in traversed)
            {
                travS += (item + " - ");
            }

        }

        private void breadthList(Vertex v, Vertex start)
        {
            if (traversed.Contains(v.item))
            {
                foreach (Vertex vT in v.links.Keys)
                {
                    breadthList(vT, start);
                }
                return;
            }
            else
            {
                traversed.Add(v.item);
                if (v.item == start.item)
                {
                    breadthList(start, start);
                }
                else
                {
                    return;
                }
            }
            while (traversed.Count < vertexs.Count)
            {
                breadthList(start, start);
            };
            return;
            
            
        }

        private void depthList(Vertex v)
        {
            if (v.links.Count != 0)
            {
                foreach (var vT in v.links.Keys)
                {
                    depthList(vT);
                }
            }
            if (traversed.Contains(v.item) == false)
            {
                traversed.Add(v.item);
            }
            return;
        }


        //From origin to destin

        //public void FindPath(string destin)
        //{
        //    Vertex v = Search("A");
        //    path.Add(v.item);
        //    //Console.WriteLine("loop");
        //    while (v.item != destin)
        //    {
        //        Console.WriteLine(v.item);
        //        weight = 100000;

        //        if (v.links.Count != 0)
        //        {
        //            foreach (var item in v.links)
        //            {
        //                if (item.Key.item == destin)
        //                {
        //                    tempV = item.Key;
        //                    weight = item.Value;
        //                    break;
        //                }
        //                else
        //                {
        //                    if (item.Value < weight)
        //                    {
        //                        weight = item.Value;
        //                        tempV = item.Key;
        //                    }
        //                }
        //            }
        //            path.Add(tempV.item);
        //            FinalWeight += weight;
        //            v = tempV;
        //        }

        //    }

        //    //Print the final path
        //    foreach (var i in path)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.Write("\nTotal weight = " + FinalWeight);
        //}



        //From destin to origin
        public void FindPath(string origin)
        {
            pathS = "";
            FinalWeight = 0;
            path.Clear();
            path.Add(origin);
            while (origin != "A")
            {
                weight = 1000;
                Vertex end = Search(origin);

                foreach (var v in vertexs)
                {
                    if (v.links.Keys.Contains(end))
                    {
                        //Console.WriteLine(v.item);
                        if (v.links[end] < weight)
                        {
                            weight = v.links[end];
                            tempV = v;
                        }
                        if (v.item == "A")
                        {
                            break;
                        }
                    }
                }
                //path.Add(tempV.item);
                //Console.WriteLine(tempV.item);
                path.Insert(0, tempV.item);
                FinalWeight += weight;
                origin = tempV.item;
            }

            //Print the final path
            foreach (var i in path)
            {
                pathS += (i + " ");
            }
            //Console.Write("\nTotal weight = " + FinalWeight);
        }




        public Vertex Search(string data)
        {
            i = -1;
            Vertex v = null;

            //do
            //{
            //    i++;
            //    v = vertexs[i];

            //} while (v.item != data);

            for (int i=0; i<vertexs.Count; i++)
            {
                if (vertexs[i].item == data)
                {
                    v = vertexs[i];
                    break;
                }
            }

            return v;
        }

    }

    
}
