using Business.Concrete;
using Entities.Concrete;
using System.Globalization;

Person person1 = new Person();
person1.FirstName = "Ramazan";
person1.LastName = "Kalin";
person1.DateOfBirthYear = 2002;
person1.NationalIdentity = 12345678910;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

