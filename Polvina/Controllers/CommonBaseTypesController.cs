using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommonBaseType.Model;

namespace CommonBaseType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonBaseTypesController : ControllerBase
    {
        private readonly Contexts _context;

        public CommonBaseTypesController(Contexts context)
        {
            _context = context;
        }
       
        // GET: api/CommonBaseTypes
        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<TblCommonBaseType>>> GetTblCommonBaseTypes()
        {
            return await _context.TblCommonBaseTypes.ToListAsync();
        }

        // GET: api/CommonBaseTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCommonBaseType>> GetTblCommonBaseType(int id)
        {
            var tblCommonBaseType = await _context.TblCommonBaseTypes.FindAsync(id);

            if (tblCommonBaseType == null)
            {
                return NotFound();
            }

            return tblCommonBaseType;
        }

        // PUT: api/CommonBaseTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCommonBaseType(int id, TblCommonBaseType tblCommonBaseType)
        {
            if (id != tblCommonBaseType.CommonBaseTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblCommonBaseType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCommonBaseTypeExists(id))
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

        // POST: api/CommonBaseTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCommonBaseType>> PostTblCommonBaseType(TblCommonBaseType tblCommonBaseType)
        {
            _context.TblCommonBaseTypes.Add(tblCommonBaseType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCommonBaseType", new { id = tblCommonBaseType.CommonBaseTypeId }, tblCommonBaseType);
        }

        // DELETE: api/CommonBaseTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCommonBaseType>> DeleteTblCommonBaseType(int id)
        {
            var tblCommonBaseType = await _context.TblCommonBaseTypes.FindAsync(id);
            if (tblCommonBaseType == null)
            {
                return NotFound();
            }

            _context.TblCommonBaseTypes.Remove(tblCommonBaseType);
            await _context.SaveChangesAsync();

            return tblCommonBaseType;
        }

        private bool TblCommonBaseTypeExists(int id)
        {
            return _context.TblCommonBaseTypes.Any(e => e.CommonBaseTypeId == id);
        }
    }
}
