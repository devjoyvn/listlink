using System;
namespace ListLink
{
    public class SelectionSort
    {
        public static void sort(StudentListLink listLink, compare compareKey)
        {
            StudentNode currentOuter = listLink.HeadNode;
            while (currentOuter != null)
            {
                StudentNode min = currentOuter;
                StudentNode currentInner = currentOuter.Next;
                while (currentInner != null)
                {
                    if (currentInner.Data.Key.CompareTo(min.Data.Key) < 0)
                    {
                        min = currentInner;
                    }
                    // use pointer func
                    //if(compareKey(currentInner.Data.Key, min.Data.Key) < 0)
                    //{
                    //    min = currentInner;
                    //}
                    currentInner = currentInner.Next;
                }
                if (!Object.ReferenceEquals(min, currentOuter))
                {
                    Student temp = currentOuter.Data;
                    currentOuter.Data = min.Data;
                    min.Data = temp;
                }
                currentOuter = currentOuter.Next;
            }
        }

        public delegate int compare(int key, int target);
        public int compareKey(int key, int target) {
            if (key != target)
            {
                return key > target ? 1 : -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
