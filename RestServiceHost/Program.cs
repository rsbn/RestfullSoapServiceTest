using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RestServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost server = new ServiceHost(typeof(RestService.RestService)))
            {
                server.Open();
                Console.WriteLine("Serviço iniciado!");
                Console.WriteLine("Pressione [ENTER] para sair...");
                Console.ReadLine();
                server.Close();
            }
        }
    }
}
