using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample_CRUD_for_Verisk.Context;
using Sample_CRUD_for_Verisk.Entities;

namespace Sample_CRUD_for_Verisk.Services
{
    public class VendorService : IVendorService
    {
        private readonly ApplicationDbContext _context;

        public VendorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Vendor>> GetAllVendors()
        {
            return await _context.Vendors.ToListAsync();

        }

        public async Task<Vendor> GetVendorById(int id)
        {
            var vendor = await _context.Vendors.FindAsync(id);
            return vendor;
        }

        public async Task<Vendor> CreateVendor(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            await _context.SaveChangesAsync();

            return vendor;
           
        }

        public async Task<bool> UpdateVendor(int id, Vendor vendor)
        {
            var Oldvendor = await _context.Vendors.FindAsync(id);
            if (Oldvendor != null)
            {
                Oldvendor.Name = vendor.Name;
                Oldvendor.Email = vendor.Email;
                Oldvendor.PhoneNumber = vendor.PhoneNumber;
            }
            else
                return false;

            return true;
        }

        public async  Task<bool> DeleteVendor(int id)
        {
            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor != null)
            {
                _context.Remove(vendor);
                await _context.SaveChangesAsync();
                return true;
            }
            else return false;
           
        }

        
    }
}
