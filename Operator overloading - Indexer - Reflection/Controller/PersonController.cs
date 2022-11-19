using Operator_overloading___Indexer___Reflection.Services;
using Operator_overloading___Indexer___Reflection.Services.Interfaces;
using System;


namespace Operator_overloading___Indexer___Reflection.Controller
{
    public class PersonController
    {
        public static void GetPersonDatas()
        {

            IPersonService personservice = new PersonService();
            var result = personservice.GetFullData(m => m.Salary > 1000);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
