using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationPass
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("请输入待加密数据信息（请输入英文语句，如 hello,world! 译成密码：Lipps,asvph! :");
            string str = Console.ReadLine();

            str=    str.Trim();


            System.Console.WriteLine("转换加密后的信息如下 :");
            
            char [] chStr = str.ToCharArray();
            foreach(char ch in chStr){
                 char  _ch =ch ;
                //System.Console.WriteLine("this is ch :" + ch);
                // 小写字母  大写字母
                if(ch>='a'&&ch<='z' )   {
                    if (ch >= 'w')
                    {
                        _ch = Convert.ToChar(Convert.ToByte(ch) - 26 + 4);
                    }
                    else {
                        _ch = Convert.ToChar(Convert.ToByte(ch) + 4);
                    }
                   
                } 
                 if(    ch>='A'&&ch<='Z' )  {
                     if (ch >= 'W')
                     {
                         _ch = Convert.ToChar(Convert.ToByte(ch) - 26 + 4);
                     }
                     else
                     {
                         _ch =  Convert.ToChar  ( Convert.ToByte(ch) + 4);
                     }
                  
                } 
                System.Console.Write(_ch);
            }

             str = Console.ReadLine();
        }
    }
}
