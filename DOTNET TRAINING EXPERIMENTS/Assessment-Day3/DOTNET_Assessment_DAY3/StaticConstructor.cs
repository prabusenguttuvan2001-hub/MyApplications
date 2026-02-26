namespace DOTNET_Assessment_DAY3
{
    internal class StaticConstructor
    {
        public static int age;
        static StaticConstructor() {
            age = 18;
        }

    }

    public class Main2
    {
        //static void Main(string[] args)
        //{
        //    StaticConstructor instance = new StaticConstructor();
        //    Console.WriteLine(StaticConstructor.age);

        //    StaticConstructor.age = 21;

        //    StaticConstructor instance2 = new StaticConstructor();
        //    Console.WriteLine(StaticConstructor.age);

        //}
    }



}
