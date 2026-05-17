
// Amir Moeini Rad
// September 2025

// Main Concept: The Adapter Design Pattern

// In this pattern, we create an adapter class that allows
// incompatible interfaces or types to work together.

namespace AdapterDP
{

    // New Interface
    public interface INewPrinter
    {
        void Print(string message);
    }

    
    // Legacy class with a different method signature
    public class OldPrinter
    {
        public void PrintText(string text)
        {
            Console.WriteLine("Old Printer: " + text);
        }
    }


    // Adapter class that makes OldPrinter compatible with INewPrinter
    public class PrinterAdapter : INewPrinter
    {
        private readonly OldPrinter _oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string message)
        {
            Console.WriteLine("In Printer Adapter...");
            _oldPrinter.PrintText(message); // adapting the call
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The Adapter Design Pattern in C#.NET.");
            Console.WriteLine("-------------------------------------\n");
                        
            INewPrinter printer = new PrinterAdapter(new OldPrinter());

            // In fact, we are calling the OldPrinter's PrintText() method via the adapter's Print() method.                        
            // It seems that the new printer is backward compatible with the old printer.            
            printer.Print("Hello from Adapter Pattern!");
            
            Console.WriteLine("\nDone.");
        }
    }
}
