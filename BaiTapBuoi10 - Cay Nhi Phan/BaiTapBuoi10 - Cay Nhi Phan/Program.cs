using System.Collections.Generic;

namespace BaiTapBuoi10___Cay_Nhi_Phan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            Console.WriteLine("Them nhung gia tri vao cay: 50, 30, 70, 20, 40, 60, 80, 15, 45, 90, 65, 75, 88, 108, 49, 42, 2, 10, 1, 18, 19, 16");
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);
            bst.Insert(15);
            bst.Insert(45);
            bst.Insert(90);
            bst.Insert(65);
            bst.Insert(75);
            bst.Insert(88);
            bst.Insert(108);
            bst.Insert(49);
            bst.Insert(42);
            bst.Insert(2);
            bst.Insert(10);
            bst.Insert(1);
            bst.Insert(18);
            bst.Insert(19);
            bst.Insert(16);
            Console.WriteLine("\n\nDuyet tien tu");
            bst.InOrder();
            Console.WriteLine("\n\nDuyet trung tu");
            bst.PreOrder();
            Console.WriteLine("\n\nDuyet hau tu");
            bst.PostOrder();
            bst.Delete(70);
            Console.WriteLine("\n\nDuyet trung tu sau khi xoa gia tri 70");
            bst.InOrder();
            Console.ReadKey();
        }
    }
}
