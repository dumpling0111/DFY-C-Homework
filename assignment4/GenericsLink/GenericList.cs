using System;   
using System.Collections;   
using System.Xml.Linq;

namespace GenericsLink
{
    //链表节点
    public class Node<T>
    {
        public Node<T>? Next { get; set; }
        public T Data { get; set; }
        public Node(T t) 
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T> 
    {
        private Node<T>? head;
        private Node<T>? tail;

        public GenericList() 
        {
            tail = head = null;
        }
        public Node<T>? Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T>? n = head;
            if (n !=null)
            {
                for (n = head; n != null; n = n.Next)
                {
                    action(n.Data);
                }
            }
            else
            {
                throw new ArgumentNullException("链表不能为空！");
            }
        }

    }
}
