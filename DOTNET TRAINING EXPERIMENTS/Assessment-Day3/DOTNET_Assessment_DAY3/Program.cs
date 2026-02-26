using DOTNET_Assessment_DAY3.Implementations;
using static DOTNET_Assessment_DAY3.Implementations.ChefImplementation;
public class Person1
{

    public string Name { get; set; }
   public Person1(string name)
    {
        Name = name;
    }
}

public class Person2
{
    public string Name { get; set; }
    public Person2(string name) 
    {
        Name = name;
    }
}

public class MainClass
{
    //static void Main(string[] args)
    //{
    //    var p1 = new Person1("Prabu");


    //    var p2 = new Person2(p1);

    //    Console.WriteLine(p1.Name); 


    //}
   

    static void Main(string[] args)
    {
        //    CallBackCustomer number;

        //    var chef = new ChefImplementation();

        //    number = chef.CallTable1;
        //    //Console.WriteLine(chef.FoodDeliver(number));


        //    //Multi-cast delegates

        //    number += chef.CallTable2;
        //    number += chef.CallTable3;
        //    number += chef.CallTable4;
        //    Console.WriteLine(chef.FoodDeliver(number));


        //    //Func<int, int, int, int> add = (a, b,c) => a + b;
        //    //Console.WriteLine(add(3, 4, 8));
        string s1 = "hello";
        string s2 = "hello";

        Console.WriteLine("s1 " + s1.GetHashCode());
        Console.WriteLine("s2 " + s2.GetHashCode());

        Person1 p1 = new Person1("Prabu");
        
    }


}

