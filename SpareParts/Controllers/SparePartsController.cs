using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP.Data.Models;
using SP.Repo.Contracts;
using SP.Service;
using SpareParts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manufacturer = SpareParts.Models.Manufacturer;

namespace SpareParts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparePartsController : ControllerBase
    {
        IPartService partService;
        public SparePartsController(IPartService _partService)
        {
            partService = _partService;         
        }

        [HttpGet]
        [Route("GetParts")]
        public async Task<IActionResult> GetParts()
        {
            try
            {
                var parts = await partService.GetAllPartsAsync();

                if (parts == null)
                {
                    return NotFound();
                }
                return Ok(parts);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

      
        [HttpGet]
        [Route("GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            try
            {
                var brands = await partService.GetAllBrands();
                if(brands == null)
                {
                    return NotFound();
                }
                return Ok(brands);
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }        

        [HttpPost]
        [Route("Create")]
        public async Task<bool> Create([FromBody] SP.Data.Models.Part part)
        {
            bool success = await partService.InsertPart(part);
          
            return success; 
        }

        [HttpGet]
        [Route("Details/{id}")]
        public SP.Data.Models.Part Details(int id)
        {
            return partService.GetPartById(id);
        }

        [HttpPut]
        [Route("Edit/{id}")]
        public async Task<bool> Edit(int id, [FromBody] SP.Data.Models.Part part)
        {
            bool success = await partService.UpdatePart(part);

            return success;
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public bool Delete(int id)
        {
            bool successYN = partService.RemovePart(id);

            return successYN;
        }

    }
}
