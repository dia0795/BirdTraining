using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
   public class Management
    {

       BookLibrary bl;
       //向流动库中添加书籍
       public void AddBook()
       {
           bl.BuyBooks("Astronomy", "天文学", 2);
           bl.BuyBooks("Astronomy", "星空", 2);
           bl.BuyBooks("Geography", "火山", 2);
           bl.BuyBooks("Geography", "湖泊", 2);
           bl.BuyBooks("Enginery", "机械工程", 2);
           bl.BuyBooks("Enginery", "机械设计", 2);
           bl.BuyBooks("Philosophy", "理想国", 2);
           bl.BuyBooks("Philosophy", "形而上学", 2);
       }
       public void SetLibrary(BookLibrary bl)
       {
           this.bl = bl;
       }
       //书籍已还


       public void ShowBook()
       {
           bl.ShowBook();
       }
    }
}
