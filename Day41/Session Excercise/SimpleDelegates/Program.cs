

namespace SimpleDelegates
{

    delegate void DPrintMessage(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            // CaseStudy2();
            //  CaseStudy3();

            DPrintMessage x; //can x point to Lambda
            x = (n) =>
            {
                Console.WriteLine($"lambda {n.ToUpper()}");
                Console.WriteLine($"lambda {n.ToLower()}");
            };
            x("Markonda");
        }

        private static void CaseStudy3()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            PrintWizard(delegate (string name)
            {
                Console.WriteLine($"Anonymous function in C# says hello to {name}");
            });


            PrintWizard((n) => Console.WriteLine($"Lambda function in C# says hello to {n}"));

        }


        static void PrintWizard(DPrintMessage fptrCallBack)
        {
            Console.WriteLine("Doint printing operations");
            Console.WriteLine("Operation Completed");
            fptrCallBack("CHAMP");
        }
        private static void CaseStudy2()
        {
            DPrintMessage x;
            x = PrintGoodBye;
            x += PrintGoodBye;//x.Add()
            x += PrintHello;//x.Add()

            x("RRD Champ");
        }

        private static void CaseStudy1()
        {
            DPrintMessage x;
            x = PrintHello;
            x("Sachin");
            x= PrintGoodBye;
            x("Akhilesh");
        }

        

        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void PrintGoodBye(string name)
        {
            Console.WriteLine($"GoodBye {name}");
        }

        void foo(string name)
        {
            
        }
    }
}
