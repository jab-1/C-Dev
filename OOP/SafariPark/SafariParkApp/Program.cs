using System;
namespace SafariParkApp;
class Program
{
    public static void Main(String[] args)
    {
        //Person jab = new Person("jab", "k", 23);
        //Console.WriteLine(jab.GetFullName());

        //Person jab2 = new Person("Jab2", "k2", 24);
        //Console.WriteLine(jab2.GetFullName());

        //Person jab3 = new Person("Jab3");
        //Console.WriteLine(jab3.GetFullName());
        //jab2.Age = 2;
        //Console.WriteLine(jab2.Age);

        //var pt3d = new Point3D(1, 2, 3)
        //DemoMethod(person, pt3d);

        //static void DemoMethod(Person p, Point3D pt)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}

        //Hunter j = new Hunter("Jab", "K", "Nikon") { Age = 23 };
        //Console.WriteLine(j.Shoot(j.GetFullName()));

        //var rec1 = new Rectangle(10, 10);
        //var rec2 = new Rectangle(11, 2);
        //var rec3 = new Rectangle(11, 2);

        //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
        //a.Ascend(500);
        //Console.WriteLine(a.Move(3));
        //Console.WriteLine(a);
        //a.Descend(200);
        //Console.WriteLine(a.Move());
        //a.Move();
        //Console.WriteLine(a);


        //List<Object> gameObjects = new List<Object>()
        //{
        //    new Person("Jab", "K"){Age = 23},
        //    new Airplane(400, 200, "Boeing"),
        //    new Vehicle (12,20),
        //    new Hunter("Hunter","Hunterman", "TheHunter")
        //};

        //foreach (var gameObj in gameObjects)
        //{
        //    Console.WriteLine(gameObj);
        //} 


        //Person yolanda = new Person("Yolanda", "Young");
        //SpartaWrite(yolanda);

        //var a = new Person("Jab", "K") { Age = 23 };
        //var b = new Hunter("Hunter", "K", "big gun");
        //SpartaWrite(a);
        //var c = (Person)b;
        //SpartaWrite(c)
        //var d = a as Hunter;
        //SpartaWrite(d);
        //IMoveable a = new Person("Jab", "K") { Age = 23 };
        //IMoveable b = new Vehicle(20, 30);
        //var e = new Person("Jab2.0", "K2") { Age = 300 };
        //var c = (IMoveable)a;
        //var d = (IMoveable)b;

        //List<IMoveable> moveables = new List<IMoveable>() {
        //    a,b
        //};

        //foreach (var i in moveables)
        //{
        //    Console.WriteLine(i.Move());
        //}

        List<IShootable> weapons = new List<IShootable>();

        IShootable laser = new LaserGun("ZapZap");
        IShootable water = new WaterPistol("Nerf");
        IShootable nikon = new Camera("Nikon");
        
        weapons.Add(laser);
        weapons.Add(water);
        weapons.Add(nikon);

        foreach (IShootable w in weapons)
        {
            Console.WriteLine(w.Shoot());
        }

        Hunter jab = new Hunter("jab", "k", laser);
        Hunter david = new Hunter("david", "c", nikon);
        Console.WriteLine(jab.Shoot());
        Console.WriteLine(david.Shoot());

    }



}
        //public static void SpartaWrite(Object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //if (obj is Hunter)
        //    {
        //    var hunterObj = (Hunter)obj;
        //    Console.WriteLine(hunterObj.Shoot());
        //}
        //}


    