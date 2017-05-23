namespace java storage
namespace py storage
namespace csharp storage


struct StoragePoint {
  1: int storageId=0,
  2: string name,
  3: optional string description,
  4: optional string value,
}





// We can use typedef to get pretty names for the types we are using
typedef i32 int 

service StorageService
{
		string ping(),
		list<StoragePoint> storagePoints(),
		string read(1:int id),
		string write(1: int id, 2: string value),
        int multiply(1:int n1, 2:int n2),
		void close(),
}


