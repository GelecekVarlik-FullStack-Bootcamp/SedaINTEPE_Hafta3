using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public class AlphabeticalListOfProductManager:GenericManager<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>, IAlphabeticalListOfProductService
    {

        IQueryable<DtoAlphabeticalListOfProduct> IAlphabeticalListOfProductService.GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
