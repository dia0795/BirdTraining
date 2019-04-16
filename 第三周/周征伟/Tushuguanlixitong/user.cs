using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tushuguanlixitong
{
    class Student
    {
        public void user1()
        {
            int id;
            int password;
            Library library = new Library();
            Console.WriteLine("请输入你的学号及密码");
            id = int.Parse(Console.ReadLine());
            password = int.Parse(Console.ReadLine());
            if (id == 123 && password == 123)
            {
              
                Console.WriteLine("请输入要借书的名称。");
                string name1 = Console.ReadLine();
                var a = Library.list.Where(s => s.Name == name1).FirstOrDefault();
                if (a != null)
                {
                    Console.WriteLine("图书类编号：{0} 图书名称：{1} 图书类别: {2}", a.ID, a.Name, a.Category);
                    Console.WriteLine("你是否要借这本书。01是，02否");
                    int j = int.Parse(Console.ReadLine());
                    if(j == 01)
                    {
                        library.borrow(a.ID ,a.Name ,a.Category );
                        Console.WriteLine("借书成功！！");
                        library.Back();
                    }
                }
                else
                {
                    Console.WriteLine("为空");
                }
            }
            else
            {
                Console.WriteLine("你输入的账号或者密码有错误");
            }
        }
    }
    class Teacher :Student 
    {

    }
}
