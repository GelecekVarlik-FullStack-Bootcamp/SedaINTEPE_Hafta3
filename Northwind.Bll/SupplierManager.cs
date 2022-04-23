using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class SupplierManager : GenericManager<Supplier, DtoSupplier>,ISupplierService
    {     
        IQueryable<DtoSupplier> ISupplierService.GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}
