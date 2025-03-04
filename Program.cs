//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Program
//{
//    internal class Program
//    {
//        public string Title;
//        public string Author;
//        public string ISBN;
//        public double Price;
//        public Program() { }
//        void DisplayBookInfo()
//        {
//            Console.WriteLine("\n Book Info is Displayed here : ");
//            Console.WriteLine($"\n Title : {Title} ");
//            Console.WriteLine($"\n Author : {Author} \n");
//            Console.WriteLine($"\n ISBN : {ISBN} \n");
//            Console.WriteLine($"\n Price : {Price} \n");
//        }
//        void ApplyDiscount(double percentage)
//        {
//            if (percentage < 0 || percentage > 100)
//            {
//                Console.WriteLine("Discount percentage isn’t between 0 and 100");
//                return;
//            }
//            double discountPrice = Price * (percentage / 100);
//            Price = Price - discountPrice;
//        }

//        static void Main(string[] args)
//        {
//            Program book1 = new Program();
//            book1.Title = "The Predator";
//            book1.Author = "Runyx";
//            book1.ISBN = "56789";
//            book1.Price = 750;
//            book1.DisplayBookInfo();

//            Console.WriteLine("After applying discount : ");

//            book1.ApplyDiscount(70);
//            book1.DisplayBookInfo();
//        }
//    }
//}
