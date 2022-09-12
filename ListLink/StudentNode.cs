using System;
namespace ListLink
{
    public class StudentNode
    {
        private Student data;
        private StudentNode next;
        public StudentNode(){}
        public StudentNode(Student student)
        {
            this.data = student;
            this.next = null;
        }

        public Student Data { get => data; set => data = value; }
        public StudentNode Next { get => next; set => next = value; }
    }
}
