using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saraja;
using Saraja.Models;
using Saraja.Repository.IRepository;

namespace Saraja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LegalEntityController : ControllerBase
    {
        private readonly SarajaContext _context;
        private readonly ILegalEntityRepository legalEntityRepository;

        public LegalEntityController(SarajaContext context, ILegalEntityRepository legalEntityRepository)
        {
            _context = context;
            this.legalEntityRepository = legalEntityRepository;
        }

        // GET: api/LegalEntity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LegalEntity>>> GetLegalEntity_1()
        {
            return await _context.LegalEntity_1.ToListAsync();
        }

        // GET: api/LegalEntity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LegalEntity>> GetLegalEntity(int id)
        {
            var legalEntity = await legalEntityRepository.GetLegalEntityByID(id);

            if (legalEntity == null)
            {
                return NotFound();
            }

            return legalEntity;
        }

        // PUT: api/LegalEntity/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLegalEntity(int id, LegalEntity legalEntity)
        {
            if (id != legalEntity.Id)
            {
                return BadRequest();
            }

            _context.Entry(legalEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LegalEntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LegalEntity
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LegalEntity>> PostLegalEntity(LegalEntity legalEntity)
        {
            _context.LegalEntity_1.Add(legalEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLegalEntity", new { id = legalEntity.Id }, legalEntity);
        }

        // DELETE: api/LegalEntity/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LegalEntity>> DeleteLegalEntity(int id)
        {
            var legalEntity = await _context.LegalEntity_1.FindAsync(id);
            if (legalEntity == null)
            {
                return NotFound();
            }

            _context.LegalEntity_1.Remove(legalEntity);
            await _context.SaveChangesAsync();

            return legalEntity;
        }

        private bool LegalEntityExists(int id)
        {
            return _context.LegalEntity_1.Any(e => e.Id == id);
        }
    }
}
