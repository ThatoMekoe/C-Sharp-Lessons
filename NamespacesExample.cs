using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SAFA.KaizerChiefs.KaizerC.kMes();
            SAFA.Pirates.OPirates.pMes();
            Console.ReadKey();
        }
    }
}

namespace SAFA
{
    namespace KaizerChiefs
    {
        class KaizerC
        {
            public static void kMes()
            {
                Console.WriteLine("If you are reading this then Kaizer Chiefs is the best team in the world.");
            }
        }
    }
    namespace Pirates
    {
        class OPirates
        {
            public static void pMes()
            {
                Console.WriteLine("If you are reading this then I guess Pirates is a fairly good team.");
            }
        }
    }
}
