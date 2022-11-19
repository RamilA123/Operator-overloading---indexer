using Operator_overloading___Indexer___Reflection.Controller;
using Operator_overloading___Indexer___Reflection.Models;
using System;
using System.Collections.Generic;

namespace Operator_overloading___Indexer___Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            List<Library> libraries = new List<Library>();

            Library library1 = new Library();
            library1.Book1 = "A - Book";
            library1.Book2 = "B - Book";
            library1.Book3 = "C - Book";


            Library library2 = new Library();
            library2.Book1 = "D - Book";
            library2.Book2 = "E - Book";
            library2.Book3 = "F - Book";


            Library library3 = new Library();
            library3.Book1 = "G - Book";
            library3.Book2 = "H - Book";
            library3.Book3 = "I - Book";


            Library library4 = new Library();
            library4.Book1 = "K - Book";
            library4.Book2 = "M - Book";
            library4.Book3 = "N - Book";


            Library library5 = new Library();
            library5.Book1 = "L - Book";
            library5.Book2 = "T - Book";
            library5.Book3 = "S - Book";

            libraries.Add(library1);
            libraries.Add(library2);
            libraries.Add(library3);
            libraries.Add(library4);
            libraries.Add(library5);

            foreach (var item in libraries)
            {
                Console.WriteLine($"Book 1: {item.Book1}, Book 2: {item.Book2}, Book 3: {item.Book3}");
            }
            #endregion

            PersonController.GetPersonDatas();
        }
    }
}
