using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tushuguanlixitong
{
    

    delegate void push();
    public class Library
    {
       
        int i = 100;
        
        public static List<Books> list = new List<Books>();
        public static List<Books> list1 = new List<Books>();
        public static List<Count> list2 = new List<Count>();
        public static List<Count> list3 = new List<Count>();
        public static List<Count> list4 = new List<Count>();
        public static List<Count> list5 = new List<Count>();
        public Library()
        {
            list.Add(new Books(01, "图书1", "文学"));
            list.Add(new Books(02, "图书2", "地理"));
            list.Add(new Books(03, "图书3", "科教"));
            list.Add(new Books(04, "图书4", "历史"));
        }

        public void buy(int id1 ,int index)
        {
            var p = list.Where(s => s.ID  == id1 ).FirstOrDefault();
            if (p != null)
            {

                if (p.ID == 1)
                {
                    list2.Add(new Count(p.ID  ,index  ));
                    Console.WriteLine("编号为{0}的图书已经入库", p.ID);
                }
                else if (p.ID == 2)
                {
                    list3.Add(new Count(p.ID , index));
                    Console.WriteLine("编号为{0}的图书已经入库", p.ID);
                }
                else if (p.ID == 3)
                {
                    list4.Add(new Count(p.ID , index));
                    Console.WriteLine("编号为{0}的图书已经入库", p.ID);
                }
                else if (p.ID == 4)
                {
                    list5.Add(new Count(p.ID , index));
                    Console.WriteLine("编号为{0}的图书已经入库", p.ID); 
                }
            }
        }
        public void destory(int id2, int index)
        {
            var p = list.Where(s => s.ID == id2).FirstOrDefault();
            if (p != null)
            {
                if (p.ID == 1)
                {
                    var q = list2.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    int count = q.count - index;
                    list2.RemoveAt(0);
                    list2.Add(new Count(p.ID, count));
                    var w = list2.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    Console.WriteLine("图书编号为{0}的数销毁后还剩余{1}本", id2, w.count);
                }
                else if (p.ID == 2)
                {
                    var q = list3.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    int count = q.count - index;
                    list3.RemoveAt(0);
                    list3.Add(new Count(p.ID, count));
                    var w = list3.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    Console.WriteLine("图书编号为{0}的数销毁后还剩余{1}本", id2, w.count);
                }
                else if (p.ID == 3)
                {
                    var q = list4.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    int count = q.count - index;
                    list4.RemoveAt(0);
                    list4.Add(new Count(p.ID, count));
                    var w = list4.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    Console.WriteLine("图书编号为{0}的数销毁后还剩余{1}本", id2, w.count);
                }
                else if (p.ID == 4)
                {
                    var q = list4.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    int count = q.count - index;
                    list4.RemoveAt(0);
                    list4.Add(new Count(p.ID, count));
                    var w = list4.Where(s => s.Bookid == p.ID).FirstOrDefault();
                    Console.WriteLine("图书编号为{0}的数销毁后还剩余{1}本", id2, w.count);
                }
            }
        }
        public void Back()
        {
            Console.WriteLine("请选择：关闭系统（01）/返回登录页面（02）");
            int k = int.Parse(Console.ReadLine());
            if (k == 01)
            {

            }
            else if (k == 02)
            {
                Console.WriteLine("请输入你的身份代号（01学生/02老师/03管理员 )");
                Library list = new Library();
                int person = int.Parse(Console.ReadLine());
                if (person == 01)
                {
                    Student student = new Student();
                    student.user1();

                }
                else if (person == 02)
                {
                    Teacher teacher = new Teacher();
                    teacher.user1();
                }
                else if (person == 03)
                {
                    Manager manager = new Manager();
                    manager.user3();
                }
            }
        }
        public void borrow(int index, string name, string category)
        {
            list1.Add(new Books(index, name, category));
        }
        public void lend()
        {
            foreach (Books books in list1)
            {
                Console.WriteLine("图书类别编号：{0},图书名称：{1},图书类别：{2}", books.ID, books.Name, books.Category);
            }
        }
        public void Count( int index)
        {
            int[] count = new int[] { 0, 0, 0, 0 };
            switch ( index)
            {
                case 1: count[0]++; break;
            }
        }
            

    }  
}
