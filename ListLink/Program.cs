using System;

namespace ListLink
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentListLink studentListLink = new StudentListLink();
            studentListLink.insertEnd(new Student("hai", "dn", "c10", 3));
            studentListLink.insertEnd(new Student("trung", "hcm", "c10", 0));
            studentListLink.insert(new Student("dmm", "hihi", "dmm", 2), 0);
            //studentListLink.remove(1);
            SelectionSort.sort(studentListLink, new SelectionSort().compareKey);
            studentListLink.print();
        }
    }
}
