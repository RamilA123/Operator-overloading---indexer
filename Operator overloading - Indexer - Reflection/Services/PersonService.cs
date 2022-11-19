using Operator_overloading___Indexer___Reflection.Models;
using Operator_overloading___Indexer___Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_overloading___Indexer___Reflection.Services
{
    public class PersonService : IPersonService
    {
        public List<string> GetFullData(Predicate<Person> predicate)
        {
            var people = GetAllPeople();

            var result = people.FindAll(predicate);

            return GetPeopleDetails(result);
        }
           private List<Person> GetAllPeople()
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person();
            person1.Name = "Resul";
            person1.Surname = "Hesenov";
            person1.Address = "Xalqlar";
            person1.Salary = 400;

            Person person2 = new Person();
            person2.Name = "Novreste";
            person2.Surname = "Aslanzade";
            person2.Address = "Azadliq";
            person2.Salary = 700;

            Person person3 = new Person();
            person3.Name = "Resul";
            person3.Surname = "Hesenov";
            person3.Address = "Xalqlar";
            person3.Salary = 4000;

            Person person4 = new Person();
            person4.Name = "Qoshqar";
            person4.Surname = "Nerimanli";
            person4.Address = "Ehmedli";
            person4.Salary = 8000;

            Person person5 = new Person();
            person1.Name = "Lale";
            person1.Surname = "Quliyeva";
            person1.Address = "Nesimi";
            person1.Salary = 2000;

            Person person6 = new Person();
            person6.Name = "Gultac";
            person6.Surname = "Ceferova";
            person6.Address = "Tiblisi";
            person6.Salary = 10000;

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);

            return people;
        }

           private List<string> GetPeopleDetails(List<Person> people)
        {
            List<string> fulldatas = new List<string>();

            foreach (var item in people)
            {
                string data = $"{item.Name} - {item.Surname} - {item.Address}";
                fulldatas.Add(data);
            }
            return fulldatas;
        }
    }
}
