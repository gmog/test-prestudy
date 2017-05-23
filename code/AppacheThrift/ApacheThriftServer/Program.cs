using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Thrift.Server;
using Thrift.Transport;
using storage;

namespace ApacheThriftServer
{
    class Program
    {
        static void Main(string[] args)
        {

            int port = 9091;

            try
            {
                StorageServiceHandler handler = new StorageServiceHandler();
                StorageService.Processor processor = new StorageService.Processor(handler);
                TServerTransport serverTransport = new TServerSocket(port);
                TServer server = new TSimpleServer(processor, serverTransport);

                // Use this for a multithreaded server
                // server = new TThreadPoolServer(processor, serverTransport);

                Console.WriteLine("Starting the server at port " + port);

                server.Serve();

               
            }
            catch (Exception x)
            {
                Console.WriteLine(x.StackTrace);
            }
            Console.WriteLine("done.");
        }



        }
    }

