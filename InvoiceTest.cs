using System;

namespace Mausbach_Project3
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            string invoiceNumber = "  Invoice A8008";
            Console.WriteLine();
            Console.WriteLine();
            MausbachHeading.getHeading("Assignment 3"); //insert heading

            Console.WriteLine();
            //create invoice objects
            Invoice invoice1 = new Invoice("1234", "Hammer", 2112, 14.95M);
            Invoice invoice2 = new Invoice("5678", "PaintBrush", -5, 9.99M);
            Invoice invoice3 = new Invoice("901A", "Screwdriver", 10, -10.10M);

            //display invoice information
            Console.WriteLine($"{invoiceNumber} Information");
            Console.WriteLine($"  Invoice Item\t\t1\t\t2\t\t3\n  Part Number:\t\t{invoice1.partNumber}\t\t{invoice2.partNumber}\t\t{invoice3.partNumber}");
            Console.WriteLine($"  Description:\t\t{invoice1.partDescription}\t\t{invoice2.partDescription}\t{invoice3.partDescription}");
            Console.WriteLine($"  Quantity:\t\t  {invoice1.quantity}\t\t     {invoice2.quantity}\t\t    {invoice3.quantity}");
            Console.WriteLine($"  Price Each ($):\t {invoice1.pricePerItem}\t\t  {invoice2.pricePerItem}\t\t  {invoice3.pricePerItem}");
            Console.WriteLine();
            Console.WriteLine($"  Subtotal Amount:    {invoice1.GetInvoiceAmount(invoice1.quantity, invoice1.pricePerItem)}\t\t  {invoice2.GetInvoiceAmount(invoice2.quantity, invoice2.pricePerItem)}\t\t  {invoice3.GetInvoiceAmount(invoice3.quantity, invoice3.pricePerItem)}");
            Console.WriteLine();
            Console.WriteLine($"  Total Amount:\t     ${invoice1.GetInvoiceAmount(invoice1.quantity, invoice1.pricePerItem) + invoice2.GetInvoiceAmount(invoice2.quantity, invoice2.pricePerItem) + invoice3.GetInvoiceAmount(invoice3.quantity, invoice3.pricePerItem)}");

            //changes to values
            invoice1.partNumber = ("001234");
            invoice1.partDescription = ("Ball Hammer");
            invoice1.quantity = 222;

            invoice2.quantity = 144;
            invoice2.partDescription = ("Paint Brush");
            invoice2.pricePerItem = 3.99M;

            invoice3.pricePerItem = 3.33M;

            Console.WriteLine();
            //display update section
            Console.WriteLine("  ----- Update ----------");
            Console.WriteLine();
            Console.WriteLine($"  Updating{invoiceNumber} With Corrections by William Bowers");
            Console.WriteLine();
            Console.WriteLine("\t\t    Correct To");
            Console.WriteLine($"  Item 1:\n    Part Number\t    {invoice1.partNumber}\n    Description\t    {invoice1.partDescription}\n    Quantity\t    {invoice1.quantity}");
            Console.WriteLine($"  Item 2:\n    Quantity\t    {invoice2.quantity}\n    Description\t    {invoice2.partDescription}\n    Price Each\t    {invoice2.pricePerItem}");
            Console.WriteLine($"  Item 3:\n    Price Each\t    {invoice3.pricePerItem}");
            Console.WriteLine();
            //display reprint section
            Console.WriteLine("  ----- Reprint ----------");
            Console.WriteLine();
            Console.WriteLine($"{invoiceNumber} Information");
            Console.WriteLine($"  Invoice Item\t\t1\t\t2\t\t3\n  Part Number:\t\t{invoice1.partNumber}\t\t{invoice2.partNumber}\t\t{invoice3.partNumber}");
            Console.WriteLine($"  Description:\t\t{invoice1.partDescription}\t{invoice2.partDescription}\t{invoice3.partDescription}");
            Console.WriteLine($"  Quantity:\t\t   {invoice1.quantity}\t\t   {invoice2.quantity}\t\t    {invoice3.quantity}");
            Console.WriteLine($"  Price Each ($):\t {invoice1.pricePerItem}\t\t  {invoice2.pricePerItem}\t\t  {invoice3.pricePerItem}");
            Console.WriteLine();
            Console.WriteLine($"  Subtotal Amount:    {invoice1.GetInvoiceAmount(invoice1.quantity, invoice1.pricePerItem)}\t\t  {invoice2.GetInvoiceAmount(invoice2.quantity, invoice2.pricePerItem)}\t\t  {invoice3.GetInvoiceAmount(invoice3.quantity, invoice3.pricePerItem)}");
            Console.WriteLine();
            Console.WriteLine($"  Total Amount:\t     ${invoice1.GetInvoiceAmount(invoice1.quantity, invoice1.pricePerItem) + invoice2.GetInvoiceAmount(invoice2.quantity, invoice2.pricePerItem) + invoice3.GetInvoiceAmount(invoice3.quantity, invoice3.pricePerItem)}");
            
            MausbachHeading.getClosing(); //insert closing
        }
    }
}
