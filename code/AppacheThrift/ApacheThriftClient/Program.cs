using System;


using Thrift.Transport;
using Thrift.Protocol;
using storage;


namespace ApacheThriftClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello from Aache Thrift Client");
            int i = 5, j = 6;
            int port = 9000;

            try
            {
                TTransport transport = new TSocket("localhost", port);
                TProtocol protocol = new TBinaryProtocol(transport);
                StorageService.Client client = new StorageService.Client(protocol);

                transport.Open();

                client.ping();
                Console.WriteLine("ping()");

                int multiply = client.multiply(i, j);
                Console.WriteLine(i +"*" + j +"={0}", multiply);

                //        Work work = new Work();

                //        work.Op = Operation.DIVIDE;
                //        work.Num1 = 1;
                //        work.Num2 = 0;
                //        try
                //        {
                //            int quotient = client.calculate(1, work);
                //            Console.WriteLine("Whoa we can divide by 0");
                //        }
                //        catch (InvalidOperation io)
                //        {
                //            Console.WriteLine("Invalid operation: " + io.Why);
                //        }

                //        work.Op = Operation.SUBTRACT;
                //        work.Num1 = 15;
                //        work.Num2 = 10;
                //        try
                //        {
                //            int diff = client.calculate(1, work);
                //            Console.WriteLine("15-10={0}", diff);
                //        }
                //        catch (InvalidOperation io)
                //        {
                //            Console.WriteLine("Invalid operation: " + io.Why);
                //        }

                //        SharedStruct log = client.getStruct(1);
                //        Console.WriteLine("Check log: {0}", log.Value);

                //    }
                //    finally
                //    {
                //        transport.Close();
                //    }


            }
            catch (Exception x)
            {
                Console.WriteLine(x.StackTrace);
            }




        }
    }
}
    

