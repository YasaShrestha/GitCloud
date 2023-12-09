using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClientCurrencyConverter.ServiceReference1;

namespace WcfClientCurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            // Ener arguments from console.
            Console.Write("Enter the GBP to convert into Indian, Nepalese, Pakistani and Srilankan currency : ");
            double gbp = Convert.ToDouble(Console.ReadLine());
            
            // Call the Add service operation.
            double inrValue = client.ConvertToInr(gbp);
            Console.WriteLine("\nIndian value is:{0} ", inrValue);

            double nprValue = client.ConvertToNpr(gbp);
            Console.WriteLine("\nNepalese rupees value is:{0} ", nprValue);

            double pkrValue = client.ConvertToPkr(gbp);
            Console.WriteLine("\nPakistani value is:{0} ", pkrValue);

            double slValue = client.ConvertToSl(gbp);
            Console.WriteLine("\nSrilankan value is:{0} ", slValue);

            Console.WriteLine("\nPress <ENTER> to terminate client.");
            Console.ReadLine();


            //Closing the client releases all communication resources.
            client.Close();

        }
    }
}
