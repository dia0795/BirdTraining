using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlibraryManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.login();
            Console.Write("按任意键退出");
            Console.ReadKey();
        }
    }            
}
