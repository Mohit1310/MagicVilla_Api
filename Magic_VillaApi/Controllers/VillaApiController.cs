using Magic_VillaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magic_VillaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaApiController : ControllerBase // Controller created
    {
        [HttpGet]
        public IEnumerable<Villa> GetVillas() // this is end point
        {
            return new List<Villa>
            {
                new Villa { Id = 1, Name = "Pool View" },
                new Villa { Id = 2,Name = "Beach View" }
            };
        }
    }
}
