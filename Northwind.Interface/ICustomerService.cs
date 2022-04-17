using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface ICustomerService:IGenericService<Customer,DtoCustomer>
    {
        //orneğin boyle bir method verdik modele,ortak olamayn ozellik
        IQueryable<DtoCustomer> GetTotalReport();
    }
}
