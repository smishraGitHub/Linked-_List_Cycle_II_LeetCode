using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked__List_Cycle_II_LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int data)
        {
            val = data;
            next = null;
        }
    }
    public class LinkedList
    {
        ListNode root;

        public LinkedList()
        {
            root = null;
        }

        public void insertNode(int data)
        {
            ListNode newNode = new ListNode(data);
            if(root!=null)
            {
                newNode.next = root;
            }
            root = newNode;
        }

        public ListNode returnNode()
        {
            return this.root;
        }

        public void showList(ListNode root)
        {
            ListNode temp = root;

            while(temp !=null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }

        }

        public ListNode LinkedListCycle(ListNode root,int position)
        {

            if (root == null || root.next == null)
                return root;

            ListNode p = root;
            ListNode q = root;

            while(p.next !=null)
            {
                p = p.next;
            }

            while(position>0)
            {
                q = q.next;
                position--;
            }

            p.next = q;

            return root;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList ls = new LinkedList();
            ls.insertNode(3);
            ls.insertNode(2);
            ls.insertNode(0);
            ls.insertNode(-4);


            ListNode node = ls.returnNode();

            ls.showList(node);

            Console.WriteLine();

            ls.LinkedListCycle(node, 1);
            
            Console.ReadLine();
        }
    }
}
