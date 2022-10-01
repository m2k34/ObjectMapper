using InterfaceVariance.Context;
using InterfaceVariance.Models;
using InterfaceVariance.Objects;
using System.Reflection;

namespace InterfaceVariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new BorrowingToken() { BookName="abc"};
       
            ParamObject[] arg = new ParamObject[] { new ParamObject(typeof(string), "bookName", "joseph")};
          

            using(var context = new BorrowingTokenContext())
            {
                var repo = new SQLRepository(context);
               
                var val = repo.Read(new ParamObject(typeof(int), "id", 6));    

                repo.Update(val, arg);
                Console.WriteLine(repo.Read(new ParamObject(typeof(int), "id", 6)).BookName); 
            }
            

        }
    }
}