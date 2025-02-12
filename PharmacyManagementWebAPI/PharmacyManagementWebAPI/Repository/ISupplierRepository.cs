﻿using PharmacyManagementWebAPI.Models;

namespace PharmacyManagementWebAPI.Repository
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAllSuppliers();

        Task<int> AddSupplier(Supplier supplier);
        Task UpdateSupplier(int id, Supplier supplier);

        Task DeleteSupplier(int id);
    }
}
