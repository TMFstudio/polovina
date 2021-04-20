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
    public class BaseTypeController : ControllerBase
    {
        // private const string V = "این کد وجو دارد";
        private IBaseTypeRepository _baseTyperepository;
        public BaseTypeController(IBaseTypeRepository baseTypeRepository)
        {
            _baseTyperepository = baseTypeRepository;
        }




        // GET: api/<BaseTypeController>
        [HttpGet]
        public IEnumerable<TblCommonBaseType> ws_loadBaseType()
        {
            return _baseTyperepository.ws_loadBaseType();
        }




        // GET api/<BaseTypeController>/5
        [HttpGet("{id:int}")]
        public async Task<IActionResult> ws_loadBaseType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var baseType = await _baseTyperepository.ws_loadBaseTypeById(id);

            if (baseType == null)
            {
                return NotFound();
            }

            return Ok(baseType);
        }


        // GET api/<BaseTypeController>/name
        [HttpGet("{name}")]
        public async Task<IActionResult> ws_loadBaseType([FromBody] string code)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var baseType = await _baseTyperepository.ws_loadBaseTypeByTitle(code);

            if (baseType == null)
            {
                return NotFound();
            }

            return Ok(baseType);
        }



        // POST api/<BaseTypeController>
        [HttpPost]
        public async Task<IActionResult> ws_CreateBaseType([FromBody] TblCommonBaseType tblCommonBaseType)
        {

            var type = _baseTyperepository.IsExistscode(tblCommonBaseType.BaseTypeTitle);
            var code = _baseTyperepository.IsExistscode(tblCommonBaseType.BaseTypeCode);


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (type != null)
            {
                return BadRequest("این عنوان وجود دارد");
            }
            if (code != null)
            {
                return BadRequest("این کد وجود دارد");
            }
            await _baseTyperepository.ws_CreateBaseType(tblCommonBaseType);

            return CreatedAtAction("GetTblCommonBaseType", new { id = tblCommonBaseType.CommonBaseTypeId }, tblCommonBaseType);
        }




        // PUT api/<BaseTypeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> ws_UpdateBaseType([FromRoute] int id, [FromBody] TblCommonBaseType tblCommonBaseType)
        {
            var title = _baseTyperepository.IsExistscode(tblCommonBaseType.BaseTypeTitle);
            var code = _baseTyperepository.IsExistscode(tblCommonBaseType.BaseTypeCode);


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCommonBaseType.CommonBaseTypeId)
            {
                return BadRequest();
            }
            if (title != null)
            {
                return BadRequest("این عنوان وجود دارد");
            }
            if (code != null)
            {
                return BadRequest("این کد وجود دارد");
            }


            await _baseTyperepository.ws_UpdateBaseType(tblCommonBaseType);



            return NoContent();
        }




        // DELETE api/<BaseTypeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> ws_DeleteBaseType([FromRoute] int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var baseType = await _baseTyperepository.ws_loadBaseTypeById(id);
            if (baseType == null)
            {
                return NotFound();
            }

            if (baseType != null)
            {

            }

            await _baseTyperepository.ws_DeleteBaseType(id);

            return Ok(baseType);
        }
    }
}
