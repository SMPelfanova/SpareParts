using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SP.Repo.Contracts;
using SP.Service;
using SpareParts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        IUnitOfWork unitOfWork;
        IManufacturerService manufacturerService;
        public ManufacturersController(IUnitOfWork _unitOfWork, IManufacturerService _manufacturerService)
        {
            unitOfWork = _unitOfWork;
            manufacturerService = _manufacturerService;

        }

        [HttpGet]
        [Route("GetManufacturers")]
        public IActionResult GetManufacturers()
        {
            try
            {
                var manufacturers = unitOfWork.PartManufacturer.GetAll();
                if (manufacturers == null)
                {
                    return NotFound();
                }
                return Ok(manufacturers);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetManufacturerPart/{partId}")]
        public IActionResult GetManufacturerPart(int partId)
        {
            try
            {
                var part = unitOfWork.Parts.GetPartById(partId);
                var manufacturers = manufacturerService.GetManufacturersPart(part.CurrentManufacturerId);
               
                if (manufacturers == null)
                {
                    return NotFound();
                }
                else
                {
                    List<Manufacturer> model = new List<Manufacturer>();
                    foreach(var item in manufacturers)
                    {
                        model.Add(new Manufacturer { ManufacId =item.ManufacId, SelectedYN = item.SelectedYN, Name = item.Name });
                    }
                    return Ok(model);

                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getManufacturerById/{manufId}")]
        public IActionResult getManufacturerById(int manufId)
        {
            try
            {
                var manufacturer = manufacturerService.GetManufacturerById(manufId);

                if (manufacturer == null)
                {
                    return NotFound();
                }
                else
                {
                    Manufacturer model = new Manufacturer {
                        ManufacId = manufacturer.ManufacId,
                        SelectedYN = manufacturer.SelectedYN,
                        Name = manufacturer.Name
                    };
                 
                    return Ok(model);

                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
