namespace WebApiTemplate.Services.Data
{
    using System;
    using System.Linq;
    using Models;
    using WebApiTemplate.Data;
    using WebApiTemplate.Services.Data.Contracts;
    using WebApiTemplate.Data.Contracts;

    public class SampleClassesService : ISampleClassesService
    {
        private readonly IRepository<SampleClass> samples;
        private readonly IRepository<User> users;

        public SampleClassesService(
            IRepository<SampleClass> samplesRepo,
            IRepository<User> usersRepo)
        {
            this.samples = samplesRepo;
            this.users = usersRepo;
        }

        public int Add(string name, string creator)
        {
            var currentUser = this.users
                .All()
                .FirstOrDefault(u => u.UserName == creator);

            if (currentUser == null)
            {
                throw new ArgumentException("Current user cannot be found!");
            }

            var newSample = new SampleClass
            {
                Name = name,
                User = currentUser
            };

            this.samples.Add(newSample);
            this.samples.SaveChanges();

            return newSample.SampleId;
        }

        public IQueryable<SampleClass> ById(string sampleName, string username)
        {
            return this.samples
                .All()
                .Where(pr =>
                    pr.Name == sampleName
                    &&  pr.User.UserName == username);
        }

        public IQueryable<SampleClass> All(int page = 1, int pageSize = 10)
        {
            return this.samples
                .All()
                .OrderBy(pr => pr.SampleId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }
    }
}
