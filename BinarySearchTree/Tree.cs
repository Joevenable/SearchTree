using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node rootNode;

        public Tree()
        {
            rootNode = null;
        }
        
        public void AddNode(int value)
        {
            Node node = new Node(value);

            if (rootNode == null)
            {
                rootNode = node;
            }

            Node currentNode = rootNode;

            while (true)
            {
                if (currentNode.data1 > node.data1)
                {
                    if (currentNode.leftNode == null)
                    {
                        currentNode.leftNode = node;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }

                }
                
                else if (currentNode.data1 < node.data1)
                {
                    if (currentNode.rightNode == null)
                    {
                        currentNode.rightNode = node;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.rightNode;
                    }
                }

            }
        }
        public bool SearchNode(int value)
        {
            Node currentNode = rootNode;

            while (true)
            {
                if (currentNode.data1 > value)
                {
                    if (currentNode.leftNode == null)
                    {
                        return false;
                    }
                    else if (currentNode.data1 == value)
                    {
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.leftNode;
                    }

                }

                else if (currentNode.data1 < value)
                {
                    if (currentNode.rightNode == null)
                    {
                        return false;
                    }
                    else if (currentNode.data1 == value)
                    {
                        return true;
                    }
                    else
                    {
                        currentNode = currentNode.rightNode;
                    }
                }

            }
        }

    }
}
