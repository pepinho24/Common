namespace WebApiTemplate.Data.Contracts
{
    using System.Data.Entity;
    using WebApiTemplate.Models;
    using System.Data.Entity.Infrastructure;

    public interface IWebApiTemplateDbContext
    {
      
        IDbSet<SampleClass> SampleClasses { get; set; }
        
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}