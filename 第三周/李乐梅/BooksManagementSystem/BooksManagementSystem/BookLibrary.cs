using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class BookLibrary
    {
       public List<BookFather> list = new List<BookFather>();
        //流动库中原有书籍
       public void Books()
       {
           list.Add(new BookFather(Guid.NewGuid().ToString(), 50, "天文学"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 50, "星空"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 40, "火山"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 40, "湖泊"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 60, "机械工程"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 60, "机械设计"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 45, "理想国"));
           list.Add(new BookFather(Guid.NewGuid().ToString(), 45, "形而上学"));
       }
        //流动库中可借阅的书籍
        public void ShowBook()
        {
            foreach (var item in list)
            {
                Console.WriteLine("流动库中有{0}。",item.Name);
            }
        }
        //采购书籍
        public void BuyBooks(string strType, string Name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Astronomy": list.Add(new BookFather(Guid.NewGuid().ToString(),50, Name));
                        break;
                    case "Geography": list.Add(new BookFather(Guid.NewGuid().ToString(), 40, Name));
                        break;
                    case "Enginery": list.Add(new BookFather(Guid.NewGuid().ToString(), 60, Name));
                        break;
                    case "Philosophy": list.Add(new BookFather(Guid.NewGuid().ToString(), 45, Name));
                        break;
                }
            }
        }
        //销毁或丢失书籍
        public void RemoveBook(string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].ID==id)
                {
                    list.RemoveAt(i);
                }

            }
            
        }
        //书籍已借阅
        public BookFather[] BookBorrow(string Name, int count)
        {
            BookFather[] BF = new BookFather[count];
            int j = 0;
                    for (int i = 0; i < count; i++)
                    {
                        foreach (var item in list)
                        {
                            if (item.Name == Name)
                            {
                                j++;
                                if (j != 0)
                                {
                                    BF[i] = item;
                                    Console.WriteLine("{0}已被借阅，它的ID为{1}，此书暂不能借出！", BF[0].Name, BF[0].ID);
                                    break;
                                }
                            }
                        }
                    }
                    if (j == 0) Console.WriteLine("您所查询的书籍不存在！");       
           return BF;
        }
    }
}
