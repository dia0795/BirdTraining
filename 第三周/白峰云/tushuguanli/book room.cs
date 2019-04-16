using System.Collections.Generic;

namespace tushuguanli
{
    public class Bookroom
    {
        public static List<Book> newbooklist = new List<Book>();
        public Bookroom()
        {
            newbooklist.Add(new Book("001", "西游记", "文学"));
            newbooklist.Add(new Book("002", "水浒传", "文学"));
            newbooklist.Add(new Book("003", "C#入门", "教育"));
            newbooklist.Add(new Book("004", "三国演义", "教育"));
        }
    }
}
