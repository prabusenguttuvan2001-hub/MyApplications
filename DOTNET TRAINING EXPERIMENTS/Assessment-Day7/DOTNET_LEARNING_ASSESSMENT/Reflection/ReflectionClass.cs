using DOTNET_LEARNING_ASSESSMENT.LearningTasks;
using System.Reflection;

namespace DOTNET_LEARNING_ASSESSMENT.Reflection
{
    internal class ReflectionClass
    {
      
       //static void Main(string[] args)
       // {
       //     //Type t = typeof(string);

       //     //Console.WriteLine(t.Name);
       //     //Console.WriteLine(t.Namespace);

       //     //Type t = typeof(string);

       //     //foreach (var method in t.GetMethods())
       //     //{
       //     //    Console.WriteLine(method.Name);
       //     //}



       //     //Assembly assembly = Assembly.GetExecutingAssembly();
       //     //Console.WriteLine(assembly.FullName);

       //     //Type t = typeof(DateTime);

       //     //foreach (var ctor in t.GetConstructors())
       //     //{
       //     //    Console.WriteLine(ctor);
       //     //}

       //     //PropertyInfo prop = typeof(Person).GetProperty("Name");

       //     //Person p = new Person { Name = "Prabu" };
       //     //Console.WriteLine(prop.GetValue(p)); // Prabu

       // }

    }
    record Person
    {
        public string Name { get; init; }
    }

}
