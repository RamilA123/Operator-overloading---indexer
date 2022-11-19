using Operator_overloading___Indexer___Reflection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_overloading___Indexer___Reflection.Services.Interfaces
{
    public interface IPersonService
    {
        public List<string> GetFullData(Predicate<Person> predicate);
    }
}
