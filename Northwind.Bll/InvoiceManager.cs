using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public IQueryable<DtoInvoice> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}
