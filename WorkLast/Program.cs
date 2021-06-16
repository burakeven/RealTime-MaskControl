using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.NationalityId = 37666030270;
            person1.FirstName = "Burak";
            person1.LastName = "Even";
            person1.DateOfBirthYear = 1999;

            //Kişi tanımlaması tamamlandı.

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }
    }
}
