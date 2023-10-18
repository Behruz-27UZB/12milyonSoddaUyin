using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12milyon
{
    public class Person : IEquatable<Person>
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public int CarId { get; set; }

        public bool Equals(Person person)
        {

            // Taqqoslanayotgan obyektlarni null yoki null emasligini tekshirish
            if (Object.ReferenceEquals(person, null))
            {
                return false;
            }

            // Taqqoslanayotgan obyektlar aynan bitta ma'lumotning havolasimi yoki yo'qligini tekshirish
            if (Object.ReferenceEquals(this, person)) return true;

            // Taqqoslanayotgan obyektlarning barcha xususiyat (property)lari bir xil ekanligini tekshirish
            return FirstName.Equals(person.FirstName);
        }

        /* Agar Equals() metodi biror tekshirilayotgan juftlik true qiymat qaytarsa, 
        GetHashCode() metodi ham  bu juftlik uchun bir xil Code qaytarishi kerak: */

        public override int GetHashCode()
        {

            // Name xususiyatining qiymati null bo'lmasa, uning hesh-kodini olish
            int hashProductName = FirstName == null ? 0 : FirstName.GetHashCode();

            int hashLastNameCode = LastName == null ? 0 : LastName.GetHashCode();



            // Talabaning hesh-kodini hisoblash
            return hashProductName ^ hashLastNameCode;
        }
    }
}

