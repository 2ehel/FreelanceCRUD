using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registry_API.Data;

namespace Registry_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentController : ControllerBase
    {

        private readonly APIDB _context;

        public TalentController(APIDB context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task <ActionResult<List<Talent>>> GetTalent()
        {
            return Ok(await _context.Talents.ToListAsync());
        }

        [HttpGet("{id}")]

        public ActionResult <Talent> GetTalent(int id)
        {
            var talent = _context.Talents.Find(id);
            if (talent == null)
            {
                return NotFound();
            }

            return talent;
        }

        [HttpPost]

        public async Task<ActionResult<List<Talent>>> Create(Talent talent)
        {

            _context.Talents.Add(talent);

            await _context.SaveChangesAsync();

            return Ok(talent);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult> Update(int id, Talent talent)
        {
            if (id != talent.Id)
                return BadRequest();

            _context.Entry(talent).State = EntityState.Modified;
            await _context.SaveChangesAsync();  

            return Ok(talent);
        }

        [HttpDelete("{id}")]

        public async Task< IActionResult> Delete(int id)
        {
            var talent = await _context.Talents.FindAsync(id);
            if(talent == null)
            {
                return NotFound("Sorry, you enter wrong talent id");
            }
            _context.Talents.Remove(talent);
            await _context.SaveChangesAsync();

            return Ok(talent);
        }

    }
}
