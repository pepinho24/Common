namespace WebApiTemplate.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;
    using Contracts;

    public class WebApiTemplateDbContext : IdentityDbContext<User>, IWebApiTemplateDbContext
    {
        public WebApiTemplateDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<SampleClass> SampleClasses{ get; set; }

        public static WebApiTemplateDbContext Create()
        {
            return new WebApiTemplateDbContext();
        }
    }
}
