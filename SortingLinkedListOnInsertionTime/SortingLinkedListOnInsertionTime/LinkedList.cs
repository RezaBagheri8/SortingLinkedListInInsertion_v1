using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLinkedListOnInsertionTime
{
    public class LinkedList
    {
        public Node head;

        public void Insert(int value)
        {
            if (IsEmpty())
            {
                Node newItem = new Node();
                newItem.value = value;

                head = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;

                Node node = head;
                while(node != null)
                {
                    if(node.value < newItem.value && node.next == null)
                    {
                        node.next = newItem;
                    }
                    else if (node.value < newItem.value && node.next.value > newItem.value)
                    {
                        Node temp = node.next;
                        node.next = newItem;
                        newItem.next = temp;
                    }
                    else if(node.value > newItem.value && node == head)
                    {
                        newItem.next = head;
                        head = newItem;
                    }

                    node = node.next;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
