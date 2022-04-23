using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System.Linq;


namespace Northwind.Bll
{
    public class InvoiceManager : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        public IQueryable<DtoInvoice> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}
