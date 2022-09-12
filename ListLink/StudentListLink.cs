using System;
namespace ListLink
{
    public class StudentListLink
    {
        private StudentNode headNode;
        private int size = 0;

        public int Size { get => size; set => size = value; }
        public StudentNode HeadNode { get => headNode; set => headNode = value; }

        public StudentListLink()
        {
            headNode = null;
        }

        public void insertFirst(Student student)
        {
            StudentNode tmp = new StudentNode();
            tmp.Data = student;
            tmp.Next = headNode;
            headNode = tmp;
            size++;
        }

        public void insertEnd(Student student)
        {
            StudentNode newNode = new StudentNode();
            newNode.Data = student;
            newNode.Next = null;
            if(headNode == null)
            {
                headNode = newNode;
            }
            else
            {
                StudentNode current = headNode;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
        }

        public void insert(Student student, int pos)
        {
            if(pos < 0 || pos > size)
            {
                throw new ArgumentException("Position not allow");
            }
            StudentNode newNode = new StudentNode();
            newNode.Data = student;
            newNode.Next = null;
            StudentNode current = headNode;
            if (pos == 0)
            {
                this.insertFirst(student);
                return;
            }
            while(pos - 1 > 0)
            {
                current = current.Next;
                pos--;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            size++;
        }

        public bool remove(int pos)
        {
            if (pos < 0 || pos > size)
            {
                return false;
            }

            StudentNode current = headNode;
            if (pos == 0)
            {
                headNode = current.Next;
            }
            else 
            {
                int i = 0;
                while (i < pos - 1)
                {
                    current = current.Next;
                    i++;
                }
            }
            current.Next = current.Next.Next;
            size--;
            return true;
        }

        public StudentNode getNode(int pos) 
        {
            if (pos < 0 || pos > size)
            {
                return null;
            }
            int i = 0;
            StudentNode current = headNode;
            while (i < pos) {
                current = current.Next;
                i++;
            }
            return current;
        }

        public void destroy()
        {
            headNode = null;
            size = 0;
        }

        public void print() {
            StudentNode node = headNode;
            while(node.Next != null)
            {
                node.Data.print();
                node = node.Next;
            }
            node.Data.print();
        }


    }
}
