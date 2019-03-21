using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LotteryDraw();
            //return;
            #region Entrance
            Console.WriteLine("*************九九乘法表*************");
            NineNine();
            Console.WriteLine("*************九九乘法口诀*************");
            NineNinePlus();
            Console.WriteLine("*************for循环算阶乘*************");
            ForFact();
            Console.WriteLine("*************递归算阶乘*************");
            RecFact();
            Console.WriteLine("*************计算器*************");
            Calc();
            Console.WriteLine("*************冒泡排序过程演示*************");
            Bubble();
            #endregion
        }

        #region 九九乘法表
        static void NineNine()
        {
            for (int s = 1; s <= 9; s++)
            {
                for (int f = 1; f <= s; f++)
                {
                    Console.Write($"{f}*{s}={(f * s).ToString().PadRight(2)} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        #endregion
        #region 九九乘法口诀
        static void NineNinePlus()
        {
            for (int s = 1; s <= 9; s++)
            {
                for (int f = 1; f <= s; f++)
                {
                    CNPrase(f, s, f * s);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static string[] CNNum = { "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };
        static void CNPrase(int numF, int numS, int Prod)
        {
            if (Prod >= 10)
            {
                string strProd = "";
                strProd += CNNum[Prod / 10 - 1];
                strProd += "十";
                if (Prod % 10 != 0)
                {
                    strProd += CNNum[Prod % 10 - 1];
                }

                Console.Write($"{CNNum[numF - 1]}{CNNum[numS - 1]}{strProd} ".PadRight(6));
            }
            else
            {
                Console.Write($"{CNNum[numF - 1]}{CNNum[numS - 1]}得{CNNum[Prod - 1]} ".PadRight(6));
            }
        }
        #endregion
        #region For循环实现阶乘
        static void ForFact()
        {
            while (true)
            {
                Console.WriteLine("请输入需要计算的阶乘数字：");
                string strInput = Console.ReadLine();
                if (strInput.Trim().ToUpper() == "X")
                {
                    break;
                }
                int intInput = 1;
                if (int.TryParse(strInput, out intInput))
                {
                    if (intInput < 1)
                    {
                        Console.WriteLine("输入的数字必须是大于1的整数");
                        continue;
                    }
                    Int64 result = 1;
                    for (var i = 1; i <= intInput; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine($"计算结果是：{result}");
                }
                else
                {
                    Console.WriteLine("请输入数字");
                    continue;
                }
            }
        }
        #endregion
        #region 递归阶乘
        static void RecFact()//递归阶乘
        {
            while (true)
            {
                Console.WriteLine("请输入需要计算的阶乘数字：");
                string strInput = Console.ReadLine();
                if (strInput.Trim().ToUpper() == "X")
                {
                    break;
                }
                int intInput = 1;
                if (int.TryParse(strInput, out intInput))
                {
                    if (intInput < 1)
                    {
                        Console.WriteLine("输入的数字必须是大于1的整数");
                        continue;
                    }
                    Console.WriteLine($"计算结果是：{factorial(intInput)}");
                }
                else
                {
                    Console.WriteLine("请输入数字");
                    continue;
                }
            }
        }
        static Int64 factorial(int num)
        {
            if (num == 1) return 1;
            return num * factorial(num - 1);
        }
        #endregion
        #region 计算器
        static void Calc()
        {
            while (true)
            {
                decimal operNumber1 = 0;
                decimal operNumber2 = 0;
                string oper = "";
                while (true)
                {
                    Console.WriteLine("请输入第一个操作数：");
                    string operStr1 = Console.ReadLine();
                    if (operStr1.Trim().ToUpper() == "X")
                    {
                        return;
                    }
                    if (!decimal.TryParse(operStr1, out operNumber1))
                    {
                        Console.WriteLine("输入非数字");
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("请输入第二个操作数：");
                    string operStr2 = Console.ReadLine();
                    if (operStr2.Trim().ToUpper() == "X")
                    {
                        return;
                    }
                    if (!decimal.TryParse(operStr2, out operNumber2))
                    {
                        Console.WriteLine("输入非数字");
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    string opers = "+-*/";
                    Console.WriteLine("请输入运算符(+-*/)：");
                    oper = Console.ReadLine();
                    if (oper.Trim().ToUpper() == "X")
                    {
                        return;
                    }
                    if (!opers.Contains(oper) || oper.Length != 1)
                    {
                        Console.WriteLine("非法运算符");
                        continue;
                    }
                    break;
                }
                switch (oper)
                {
                    case "+":
                        Console.WriteLine($"{operNumber1}{oper}{operNumber2}={operNumber1 + operNumber2}");
                        break;
                    case "-":
                        Console.WriteLine($"{operNumber1}{oper}{operNumber2}={operNumber1 - operNumber2}");
                        break;
                    case "*":
                        Console.WriteLine($"{operNumber1}{oper}{operNumber2}={operNumber1 * operNumber2}");
                        break;
                    case "/":
                        try
                        {
                            Console.WriteLine($"{operNumber1}{oper}{operNumber2}={operNumber1 / operNumber2}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("除数不能为零");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region 冒泡算法
        static void Bubble()
        {
            int temp = 0;
            int[] arr = new int[20];
            for (var k = 0; k < arr.Length; k++)
            {
                arr[k] = k + 1;
            }
            arr = SortRandom(arr);
            #region 该段与排序无关
            Console.WriteLine("排序前的数组：");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion
            for (int i = 0; i < arr.Length - 1; i++)
            {
                #region 将大的数字移到数组的arr.Length-1-i
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                    Console.Clear();
                    foreach (int item in arr)
                    {
                        Console.ResetColor();

                        if (item == arr[j] || item == arr[j + 1])
                        {
                            Console.BackgroundColor = ConsoleColor.Gray; //设置背景色
                            //Console.ForegroundColor = ConsoleColor.Blue; //设置前景色，即字体颜色
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White; //设置背景色
                        }
                        for (int f = 0; f < item; f++)
                        {
                            Console.Write("  ");
                        }
                        Console.ResetColor();
                        Console.WriteLine($"  {item}");
                    }
                    Console.WriteLine();
                    Thread.Sleep(200);
                }
                Thread.Sleep(1000);
                #endregion
            }
            Console.WriteLine("排序完成！");
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            Console.WriteLine("按任意键退出程序...");
            Console.ReadKey();
        }
        #endregion
        #region 乱序
        public static int[] SortRandom(int[] collection)
        {
            Random rand = new Random();
            for (int i = collection.Length - 1; i > 0; i--)
            {
                int p = rand.Next(i);
                var temp = collection[p];
                collection[p] = collection[i];
                collection[i] = temp;
            }
            return collection;
        }
        #endregion
        #region 抽奖
        static void LotteryDraw()
        {
            List<string> Buddies = new List<string>() {
                "白峰云",
                "高海旺",
                "胡彬",
                "江朋",
                "李乐梅",
                "刘佩",
                "舒能",
                "钟伟",
                "周征伟",
                "彭福城"
        };
            List<string> Left = Buddies;
            Console.ReadLine();

            Random rd = new Random();
            while (true)
            {
                if (Left.Count == 0)
                {
                    Console.WriteLine("没有待抽取的池");
                    break;
                }
                int index1 = rd.Next(Left.Count);
                Console.WriteLine(Left[index1]);
                Left.Remove(Buddies[index1]);
                string next = Console.ReadLine();
                if (next.Trim().ToUpper() != "N")
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
        #endregion
    }
}
