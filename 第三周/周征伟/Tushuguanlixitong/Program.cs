using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tushuguanlixitong
{
    
    class Program
    {

        static void Main(string[] args)
        {
           Console.WriteLine("请输入你的身份代号（01学生/02老师/03管理员 )");
        
           int person = int.Parse(Console.ReadLine());
           if(person == 01)
            {
                Library library = new Library();
                Student student = new Student();
                student.user1();
    
            }
           else if(person == 02)
            {
                Teacher teacher = new Teacher();
                teacher.user1();
            }
           else if(person ==03)
            {
                Manager manager = new Manager();
                manager.user3();
            }
        }
    }
}
