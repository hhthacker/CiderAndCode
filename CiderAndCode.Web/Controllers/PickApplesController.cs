using System.Net;
using System.Net.Http;
using System.Web.Http;
using CiderAndCode.Web.DataModels;
using CiderAndCode.Web.ViewModels;

namespace CiderAndCode.Web.Controllers
{
    [RoutePrefix("api/PickApples")]
    public class PickApplesController : ApiController
    {
        [Route(""), HttpPost]
        public HttpResponseMessage PullApplesOffTree(ApplesPickedRequest request)
        {
            var db = new AppDbContext();

            var newBushel = new Bushel
            {
                Quantity = request.NumberOfBushels,
                User = db.Users.Find(request.UserId),
                Type = request.Type,
                Ripe = false
            };

            db.Bushels.Add(newBushel);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created, newBushel);
        }

    }
}
