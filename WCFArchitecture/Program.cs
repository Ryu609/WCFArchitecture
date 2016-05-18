using AdventureWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IProductService> channelFactory = new 
                ChannelFactory<IProductService>("ProductServiceEndpoint");

            IProductService proxy = channelFactory.CreateChannel();

            List<string> products = proxy.ListProducts();

            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
