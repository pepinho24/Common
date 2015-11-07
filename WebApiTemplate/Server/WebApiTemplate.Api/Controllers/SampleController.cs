namespace WebApiTemplate.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    //using System.Web.Http.Cors;
    //using AutoMapper.QueryableExtensions;
    using Services.Data.Contracts;

    public class SamplesController : ApiController
    {
        private readonly ISampleClassesService samples;

        public SamplesController(ISampleClassesService samplesService)
        {
            this.samples = samplesService;
        }

     //   [EnableCors("*", "*", "*")]
        public IHttpActionResult Get()
        {
            var result = this.samples
                .All()
                .ToList();

            return this.Ok(result);
        }

        [Authorize]
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.BadRequest("Project name cannot be null or empty.");
            }

            var result = this.samples
                .ById(id, this.User.Identity.Name)
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        //[Authorize]
        //public IHttpActionResult Post(SaveProjectRequestModel model)
        //{
        //    if (!this.ModelState.IsValid)
        //    {
        //        return this.BadRequest(this.ModelState);
        //    }

        //    var createdProjectId = this.projects.Add(
        //        model.Name,
        //        model.Description,
        //        this.User.Identity.Name,
        //        model.Private);

        //    return this.Ok(createdProjectId);
        //}

        //[Route("api/projects/all")]
        //public IHttpActionResult Get(int page, int pageSize = GlobalConstants.DefaultPageSize)
        //{
        //    var result = this.projects
        //        .All(page, pageSize)
        //        .ProjectTo<SoftwareProjectDetailsResponseModel>()
        //        .ToList();

        //    return this.Ok(result);
        //}
    }
}
