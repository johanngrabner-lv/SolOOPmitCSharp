using System;

namespace Fehlerbehandlung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\nWorld!\tCampus02\b");

            MyFileUtility fu = new MyFileUtility();
            try
            {
                fu.Open(@"u:\temp\test.txt");
            }
            catch(MyFileException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            //fu.Open("c:\\temp\\test.txt"); -- Escape-Sequenzen

        }
    }
}
