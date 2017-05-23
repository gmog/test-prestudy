using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using storage;

namespace ApacheThriftServer
{
    class StorageServiceHandler:StorageService.Iface
    {


        private Dictionary<int, StoragePoint> storagePointDict;

        public StorageServiceHandler()
        {
            storagePointDict = new Dictionary<int, StoragePoint>();
            storagePointDict.Add(1, new StoragePoint { StorageId = 1, Name = "S1", Description = "Storage Point 1", Value = "1000" });
            storagePointDict.Add(2, new StoragePoint { StorageId = 2, Name = "S2", Description = "Storage Point 2", Value = "2000" });
            storagePointDict.Add(3, new StoragePoint { StorageId = 3, Name = "S3", Description = "Storage Point 3", Value = "3000" });
        }



       public string ping()
        {

            return "This is ping()...";


        }
        public List<StoragePoint> storagePoints()
        {

            List<StoragePoint> points = new List<StoragePoint>();

            foreach (StoragePoint sp in storagePointDict.Values)
                points.Add(sp);

            return points;
        }
        public string read(int id)
        {

            StoragePoint sp = storagePointDict[id];

            if (sp != null)
                sp.ToString();


            return id + " was not found!";

        }
        public string write(int id, string @value)
        {

            storagePointDict.Add(id, new StoragePoint {Value=value });

            return "Current size of the dictionary: " + storagePointDict.Count;

        }
        public int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public void close()
        {

        }

       


    }
}
