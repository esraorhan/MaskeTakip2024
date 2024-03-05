using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //interface metot imzasını barındırabilirsin .
        //interfaceler bağımlılığı çözmenin teknikleri 
        //sonarqube kalite kod uygulması
        //if demek bağımlılık demektir. çok fazla kullanılması taraftarı değildir.
        //interface = birbirinin alternatifi olan sistemlerin farklı implemantasyon yapmalarını sağalar.
        //yabancı ve vatandaş olan kurallarını ayrı yazabilirz.
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
