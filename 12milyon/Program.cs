
Console.WriteLine("---- KARTA NOMINI TOP ----");
Console.WriteLine("Siz uyindasiz sizga 3 ta imkon bor 1 ta imkonda topsayz sizga 12.000.00 beriladi 2 taga topsayz 8.000.000" +
    " 3 taga topsayz 4.000.000 sum yutasiz imkonyatingiz tugasa yutqazasiz" +
    " Karta nomlari: Olma, Qarg'a, Chillik, G'ish");
Random son = new Random();
int KartaTuri = son.Next(4);
string kartaNomi = "";
if (KartaTuri == 1)
{
    kartaNomi = "Olma";
}
else if (KartaTuri == 2)
{
    kartaNomi = "G'ish";
}
else if (KartaTuri == 3)
{
    kartaNomi = "Chillik";
}
else
{
    kartaNomi = "Qarg'a";
}
int b = 0;
int a = 0;
for (int i = 1;i<=3;i++) 
{
    if(b == 0)
    {
        Console.WriteLine("Sizning mablag'ingiz 12.000.000");
    }
    else if (b == 1)
    {
        Console.WriteLine("Sizning mablag'ingiz 8.000.000");
    }
    if (b == 2)
    {
        Console.WriteLine("Sizning mablag'ingiz 4.000.000");
    }
    b++;
    Console.Write("Karta nomini kiriting : ");
    string nomi = Console.ReadLine();
    if (kartaNomi == nomi)
    {
        Console.WriteLine("Tabriklayman siz yutdingiz");
        i = 3;
    }
    else
    {
        Console.WriteLine("Topolmadingiz ");
        a++;
    }
}
switch (a)
{
    case 0:
        Console.WriteLine("Siz 12.000.000 yutdingiz"); break;
    case 1:
        Console.WriteLine("Siz 8.000.000 yutdingiz"); break;
    case 2:
        Console.WriteLine("Siz 4.000.000 yutdingiz"); break;
    case 3:
        Console.WriteLine("Siz 0 sum yutdingiz"); break;
}

/*List<Person> person = new List<Person>()
 {
     new Person()
     {
         Id = 1,
         FirstName = "Dadaxon",
         LastName = "Sharofiddinov",
         Age = 15,
         Email = "pragramist07@gmail.com",
         CarId = 1
     },
     new Person()
     {
         Id = 2,
         FirstName = "Jamshid",
         LastName = "Majidov",
         Age = 18,
         Email = "jamshidmajidov05@gmail.com",
         CarId = 2
     },
     new Person()
     {
         Id = 3,
         FirstName = "Temur",
         LastName = "Rahmatov",
         Age = 14,
         Email = "temur14@gmail.com",
         CarId = 3
     },
     new Person()
     {
         Id = 4,
         FirstName = "Temur",
         LastName = "Rahmatov",
         Age = 16,
         Email = "oybekaudi@gmail.com",
         CarId = 4
     },
         new Person()
     {
         Id = 5,
         FirstName = "Behruz",
         LastName = "Bahromov",
         Age = 15,
         Email ="behruz22@gmail.com",
         CarId = 5
     }
 };
List<Car> car = new List<Car>()
 {
     new Car()
     {
         Id = 1,
         Marka = "Supra",
         CarName = "Tayotta",
         Color = "Qaymoq svit"
     },
     new Car()
     {
         Id = 2,
         Marka = "M4",
         CarName = "BMW",
         Color = "yashil"
     },
     new Car()
     {
         Id = 4,
         Marka = "Gelik",
         CarName = "Mersedes",
         Color = "qora"
     },
     new Car()
     {
         Id = 5,
         Marka = "A8",
         CarName = "Audi",
         Color = "oq"
     },
     new Car()
     {
         Id = 3,
         Marka = "Huragan",
         CarName = "Lambargeni",
         Color = "kulirang"
     }
 };
if(car.)*/
