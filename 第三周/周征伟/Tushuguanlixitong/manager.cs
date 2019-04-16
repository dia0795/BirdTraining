using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tushuguanlixitong
{
    class Manager
    {
       public void user3()
        {

            int id;
            int password;
            Console.WriteLine("请输入你的学号及密码");
            id = int.Parse(Console.ReadLine());
            password = int.Parse(Console.ReadLine());
            if (id == 123 && password == 123)
            {
                Console.WriteLine("请输入那你要进行操作的编号（购买01，销毁/丢失02，借出03）：");
                int i = int.Parse(Console.ReadLine());
                if (i == 01)
                {
                    Console.WriteLine("请输入买进书的编号和本数。");
                    int id1 =int.Parse ( Console.ReadLine());
                    int index = int.Parse(Console.ReadLine());
                    Library library = new Library();
                    library.buy(id1,index);
                    library.Back();
                }
                else if (i == 02)
                {
                    Console.WriteLine("请输入你要销毁书的编号和本数");;
                    int id2 = int.Parse(Console.ReadLine());
                    int index = int.Parse(Console.ReadLine());
                    Library library = new Library();
                    library.destory(id2 , index);
                    library.Back();
                }
                else if (i == 03)
                {
                    Console.WriteLine("所有已经借出书信息的信息如下：");
                    Library library = new Library();
                    library.lend();
                    library.Back();
                }
            }
        }
    }
}
