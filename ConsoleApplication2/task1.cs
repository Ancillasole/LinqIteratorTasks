using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Book
    {
        public string Author;
        public int  Year;
    }
    class task1
    {
        //task 1.2
        List<Book> books = new List<Book>
        {
            new Book { Author = "Glasha"},
            new Book { Author = "Glasha"},
            new Book { Author = "Tanya"}
        };
        public static int CountUniqueLatters(IEnumerable<string> words)
        {
            return words.SelectMany(w => w).Distinct().Count();
        }
        //task 1.3
        public static IEnumerable<int> SortNumbers(IEnumerable<int> array)
        {
            return array.OrderBy(el => el / 10).ThenByDescending(el => el % 10);
        }
        //task 1.4
        public static IEnumerable  GetAuthorsBookCount(List<Book> source)
        {
            return source.GroupBy(b => b.Author).Select(g => new { Author = g.Key, Count = g.Count()});
        }
    }
}
