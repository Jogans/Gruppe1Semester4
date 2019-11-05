using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class GuldtandController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public GuldtandController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api
        [HttpGet]
        public async Task<ActionResult<List<guldtand>>> Get()
        {
            return await _dbContext.Guldtandhjemmesides.ToListAsync();
        }

        // GET api//5
        [HttpGet("{id}")]
        public async Task<ActionResult<guldtand>> Get(string id)
        {
            return await _dbContext.Guldtandhjemmesides.FindAsync(id);
        }

        // POST api
        [HttpPost]
        public async Task Post(guldtand model)
        {
            await _dbContext.AddAsync(model);

            await _dbContext.SaveChangesAsync();
        }

        // PUT api/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, guldtand model)
        {
            var exists = await _dbContext.Guldtandhjemmesides.AnyAsync(f => f.Id == id);
            if (!exists)
            {
                return NotFound();
            }

            _dbContext.Guldtandhjemmesides.Update(model);

            await _dbContext.SaveChangesAsync();

            return Ok();

        }

        // DELETE api/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var entity = await _dbContext.Guldtandhjemmesides.FindAsync(id);

            _dbContext.Guldtandhjemmesides.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}