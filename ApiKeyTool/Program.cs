using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiKeyTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入密码明文:");
            var inputString = Console.ReadLine();
            var password = TuJia.Framework.Utility.Encrypt.Md5Hash(inputString);
            Console.WriteLine(password);
            System.Diagnostics.Trace.WriteLine(password);
            Console.ReadLine();
        }
    }
}
