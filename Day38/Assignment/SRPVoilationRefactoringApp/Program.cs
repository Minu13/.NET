using SRPVoilationRefactoringApp.Model;

namespace SRPVoilationRefactoringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice", 100, .50);
            PrintInvoice(invoice);
        }

        private static void PrintInvoice(Invoice invoice)
        {
            double tax = invoice.CalculateTax();
            double discount = invoice.CalculateDiscount();
            double finalCost = invoice.FinalCost();

            string template = $"Id: {invoice.Id} " +
                $", description: {invoice.Description}" +
                $" cost is: {invoice.Cost}" +
                $" tax amt is: {tax}" +
                $" discount amt is: {discount}" +
                $" Final cost is: {finalCost}";
            Console.WriteLine(template);
        }
    }
}
