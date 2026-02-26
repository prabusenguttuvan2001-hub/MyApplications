using DOTNET_Assessment1.Models;


namespace DOTNET_Assessment1.Interfaces
{
    public  interface IPersonEvaluator
    {
        Tier Evaluate(Person person);
    }
}
