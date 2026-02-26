using Microsoft.AspNetCore.Mvc;
using Sample_CRUD_for_Verisk.Entities;

namespace Sample_CRUD_for_Verisk.Services
{
    public interface IVendorService 
    {
        public Task<List<Vendor>> GetAllVendors();
        public Task<Vendor> GetVendorById(int id);
        public Task<Vendor> CreateVendor(Vendor vendor);
        public Task<bool> UpdateVendor(int id, Vendor vendor);
        public Task<bool> DeleteVendor(int id);
    }
}
