﻿using Northwind.Bll;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;


namespace Northwind.Interface
{
    public class SalesTotalsByAmountManager : GenericManager<SalesTotalsByAmount, DtoSalesTotalsByAmount>, ISalesTotalsByAmountService
    {
        public IQueryable<DtoSalesTotalsByAmount> GetTotalReport()
        {
            throw new System.NotImplementedException();
        }
    }
}
