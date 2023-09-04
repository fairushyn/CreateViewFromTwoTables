using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: entities/addA
        [HttpPost("addA")]
        public ActionResult<EntityA> AddEntityA(EntityA? entityA)
        {
            if (entityA == null)
            {
                return BadRequest("EntityA object is null");
            }

            _context.EntityAs.Add(entityA);
            _context.SaveChanges();

            return Ok(entityA);
        }

        // POST: entities/addB
        [HttpPost("addB")]
        public ActionResult<EntityB> AddEntityB(EntityB? entityB)
        {
            if (entityB == null)
            {
                return BadRequest("EntityB object is null");
            }

            _context.EntityBs.Add(entityB);
            _context.SaveChanges();

            return Ok(entityB);
        }
    }
}