using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample_CRUD_for_Verisk.Entities;
using Sample_CRUD_for_Verisk.Services;

namespace Sample_CRUD_for_Verisk.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        [Authorize(Roles ="admin")]
        [HttpGet]
         public async Task<ActionResult<List<Vendor>>> GetAll()
        {
            var Vendors = await _vendorService.GetAllVendors();
            if (Vendors == null)
            {
                return NotFound();
            }
            return Ok(Vendors);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetVendorById(int id)
        {
            var Vendor = await _vendorService.GetVendorById(id);
            if (Vendor == null)
            {
                return NotFound();
            }
            return Ok(Vendor);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<Vendor>> AddVendor(Vendor vendor)
        {
            var vendorResult =  _vendorService.CreateVendor(vendor);
            if (vendorResult == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateVendor(int id, Vendor vendor)
        {
            if (await _vendorService.UpdateVendor(id, vendor))
            {
                return Ok();
            }
            else
                return BadRequest();

        }
    }
}
