using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiqianbaiji
{
    class Program
    { 
       

        static void Main(string[] args)
        {
            Program pro = new Program();
            
            Start: //开始提示计算的循环入口

            System.Console.WriteLine("用循环语句写百钱百鸡问题程序。公鸡5元一只，母鸡3元一只，小鸡1元三只，问100元钱可买公鸡、母鸡、小鸡各多少只？请输入要计算的金额比如100，输入100 按回车");
             
            String inputParam = System.Console.ReadLine();
            try
            {
                pro.calc(Convert.ToInt32(inputParam));
            }
            catch
            {
                System.Console.WriteLine("请输入整数 比如 128 ");
                goto Start;

            }
        }

        private void calc(int total ) {
            int c_gj;
            int c_mj;
            int c_xj;
            // 计算以全是公鸡开始遍历
               // c_gj  =  total / Gongji.num;
            int count = 0;
            for ( c_gj = 0; c_gj <= total / Gongji.price; c_gj++)
                {
                   int gj_total = total - c_gj * Gongji.price;

                   for ( c_mj = 0; c_mj <= gj_total / Muji.price;c_mj ++ )
                   {
                      int mj_total = gj_total -  c_mj * Muji.price;

                       int tmp = mj_total / Xiaoji.price;
                       c_xj = tmp ;

                       count++;
                       System.Console.WriteLine("组合"+count +"->公鸡="+c_gj + " 母鸡="+c_mj+ " 小鸡="+c_xj*3);
                   }
                }

            System.Console.ReadLine();
           
        }

       public  struct Gongji
        {
           public  static int num = 1;
           public static int price = 5;
        }

        struct Muji
        {
            public static int num = 1;
            public static int price = 3;
        }

        struct Xiaoji
        {
            public static int num = 3;
            public static int price = 1;
        }

    }
     
}
