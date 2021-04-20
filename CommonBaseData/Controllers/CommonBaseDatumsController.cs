using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommonBaseData.Model;

namespace CommonBaseData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonBaseDatumsController : ControllerBase
    {
        private readonly Contexts _context;

        public CommonBaseDatumsController(Contexts context)
        {
            _context = context;
        }

        // GET: api/CommonBaseDatums
        [HttpGet]
        public IEnumerable<TblCommonBaseDatum> GetTblCommonBaseData()
        {
            var query = _context.TblCommonBaseData.ToList();
            return query;
        }

        // GET: api/CommonBaseDatums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCommonBaseDatum>> GetTblCommonBaseDatum(int id)
        {
            var tblCommonBaseDatum = await _context.TblCommonBaseData.FindAsync(id);

            if (tblCommonBaseDatum == null)
            {
                return NotFound();
            }

            return tblCommonBaseDatum;
        }

        // PUT: api/CommonBaseDatums/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCommonBaseDatum(int id, TblCommonBaseDatum tblCommonBaseDatum)
        {
            if (id != tblCommonBaseDatum.CommonBaseDataId)
            {
                return BadRequest();
            }

            _context.Entry(tblCommonBaseDatum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCommonBaseDatumExists(id))
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

        // POST: api/CommonBaseDatums
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCommonBaseDatum>> PostTblCommonBaseDatum(TblCommonBaseDatum tblCommonBaseDatum)
        {
            _context.TblCommonBaseData.Add(tblCommonBaseDatum);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblCommonBaseDatumExists(tblCommonBaseDatum.CommonBaseDataId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblCommonBaseDatum", new { id = tblCommonBaseDatum.CommonBaseDataId }, tblCommonBaseDatum);
        }

        // DELETE: api/CommonBaseDatums/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCommonBaseDatum>> DeleteTblCommonBaseDatum(int id)
        {
            var tblCommonBaseDatum = await _context.TblCommonBaseData.FindAsync(id);
            if (tblCommonBaseDatum == null)
            {
                return NotFound();
            }

            _context.TblCommonBaseData.Remove(tblCommonBaseDatum);
            await _context.SaveChangesAsync();

            return tblCommonBaseDatum;
        }

        private bool TblCommonBaseDatumExists(int id)
        {
            return _context.TblCommonBaseData.Any(e => e.CommonBaseDataId == id);
        }
    }
}
