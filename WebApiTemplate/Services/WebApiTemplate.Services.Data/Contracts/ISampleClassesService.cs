namespace WebApiTemplate.Services.Data.Contracts
{
    using System.Linq;
    using Models;

    public interface ISampleClassesService
    {
        IQueryable<SampleClass> All(int page = 1, int pageSize = 10);

        int Add(string name, string creator);

        IQueryable<SampleClass> ById(string projectName, string username);
    }
}
