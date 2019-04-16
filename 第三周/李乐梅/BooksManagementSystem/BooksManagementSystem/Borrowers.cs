
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BooksManagementSystem
{
    public class Borrowers
    {
        public void BorrowerPeople(BookLibrary bl)
        {
            //登陆
            Console.WriteLine("请输入您的学号/工号：");
            string number = @"^5901114\d{3}$";  
            while(true)
            {
                string num = Console.ReadLine();
                bool mybool=Regex.IsMatch(num.Trim(),number);
                if(!mybool)
                {
                    Console.WriteLine("学号/工号输入错误！");
                    continue;
                }
                break; 
            }
            Console.WriteLine("请输入您的姓名：");
            string myName = Console.ReadLine();
            Console.WriteLine("登陆成功！");
            //查询书籍
            Console.WriteLine("请输入您想要查询的书籍名称：");
            string BookName = Console.ReadLine();
            int i = 0;
            i = bl.list.Where(p => p.Name.Contains(BookName)).Count();
            Console.WriteLine("您所查询的书籍{0}还有{1}本，",BookName,i);
        }
        //借书
        public void Borrow(BookLibrary bl)
        {
            Console.WriteLine("请输入您需要借阅的书籍：");
            string Name = Console.ReadLine();
            Console.WriteLine("请输入您需要借阅书籍的数量：");
            int count = Convert.ToInt32(Console.ReadLine());
            BookFather[] BF = bl.BookBorrow(Name, count);
        }
        //还书
        public void Return(BookLibrary bl)
        {
            Console.WriteLine("请输入您需要还书的ID：");
            string id = Console.ReadLine();
            foreach (var item in bl.list)
            {
                if(item.ID==id)
                    Console.WriteLine("{0}已被还，书的编号为{1}",item.Name,item.ID);
            }
        }
    }  
}
