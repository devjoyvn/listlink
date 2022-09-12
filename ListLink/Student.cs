using System;
namespace ListLink
{
    public class Student
    {
        private string name;
        private string address;
        private string myClass;
        private int key;

        public Student(){}
        public Student(string name, string address, string myClass, int key)
        {
            this.name = name;
            this.address = address;
            this.myClass = myClass;
            this.key = key;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string MyClass { get => myClass; set => myClass = value; }
        public int Key { get => key; set => key = value; }

        public int compareByName(String value) 
        {
            return compareString(this.name, value);
        }

        public int compareByAddress(string value)
        {
            return compareString(this.address, value);
        }

        public int compareByClass(string value)
        {
            return compareString(this.myClass, value);

        }

        public int compareByKey(int value) 
        {
            if (this.key != value)
            {
                return this.key > value ? 1 : -1;
            }
            return 0;
        }

        public int compareString(string value, string target)
        {
            int lenValue = value.Length;
            int lenTarget = value.Length;
            if(lenValue != lenTarget)
            {
                return lenValue > lenTarget ? 1 : -1;
            }
            else 
            {
                for (int i = 0; i < lenValue; i++)
                {
                    if (value[i] < target[i])
                    {
                        return -1;
                    }
                    else if(value[i] > target[i])
                    {
                        return 1;
                    }
                }
                return 0;
            }
        }

        public void print()
        {
            Console.WriteLine(this.key + " --- " + this.name + " --- " + this.address + " --- " + this.myClass);
        }
    }
}
