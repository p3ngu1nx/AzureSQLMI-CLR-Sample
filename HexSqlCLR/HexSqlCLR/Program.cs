using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexSqlCLR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new GetAssemblyBits().Run(args[0]));
        }
    }
}
