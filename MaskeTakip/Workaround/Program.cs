using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {



            //Diziler / Arrays




            Person person1 = new Person();
            person1.FirstName = "FURKAN";
            person1.LastName = "OĞUZ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 1234567;


            Person person2 = new Person();
            person2.FirstName = "Kader";
            person2.LastName = "EMİR";
            person2.DateOfBirthYear = 1985;
            person2.NationalIdentity = 102686;


            //MyList


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //resharper




    }
}