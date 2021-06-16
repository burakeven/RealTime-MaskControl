using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        bool CheckPerson(Person person);
        List<Person> GetList(); //Bu neden var anlamadım, çözücem. One min.
    }
}
