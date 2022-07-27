﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;


        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                {
                    Console.WriteLine("LinkedList is empty");
                    return;
                }
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;

        }
        internal Node InsertAtParticularPosition(int PreviousData, Node Newdata)
        {
            Node temp = this.head;
            while (temp != null)
            {
                while (temp.data == PreviousData)
                {
                    Node newnode = temp.next;
                    temp.next = Newdata;
                    temp.next.next = newnode;
                    break;
                }
                temp = temp.next;
            }
            return head;
        }
        internal Node RemovaAtParticularNode(int DeleteNode)
        {
            Node temp = this.head;
            while (temp != null)
            {
                while (temp.next.data == DeleteNode)
                {
                    temp.next = temp.next.next;
                    return head;
                }
                temp = temp.next;
            }
            return head;
        }
    }
    }

