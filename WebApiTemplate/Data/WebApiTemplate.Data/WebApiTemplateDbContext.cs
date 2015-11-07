namespace WebApiTemplate.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class WebApiTemplateDbContext : IdentityDbContext<User>
    {
        public WebApiTemplateDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static WebApiTemplateDbContext Create()
        {
            return new WebApiTemplateDbContext();
        }
    }
}
