using AutoMapper;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>();
            CreateMap<Category, DtoCategory>();
            CreateMap<CategorySalesFor1997, DtoCategorySalesFor1997>();
            CreateMap<CurrentProductList, DtoCurrentProductList>();
            CreateMap<Customer, DtoCustomer>();// ReverseMap();//reverse map sırası için onemli.yazarsak sırasını istediğii gibi yapabilirz. yoksa kaynak, hedef olmalı.
            CreateMap<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>();
            CreateMap<CustomerCustomerDemo, DtoCustomerCustomerDemo>();
            CreateMap<CustomerDemographic, DtoCustomerDemographic>();
            CreateMap<DtoEmployee, Employee>().ReverseMap();
            CreateMap<EmployeeTerritory, DtoEmployeeTerritory>();
            CreateMap<Invoice, DtoInvoice>();
            CreateMap<Order, DtoOrder>();
            CreateMap<OrderDetail, DtoOrderDetail>();
            CreateMap<OrderDetailsExtended, DtoOrderDetailsExtended>();
            CreateMap<OrdersQry, DtoOrdersQry>();
            CreateMap<OrderSubtotal, DtoOrderSubtotal>();
            CreateMap<Product, DtoProduct>();
            CreateMap<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>();
            CreateMap<ProductSalesFor1997, DtoProductSalesFor1997>();
            CreateMap<ProductsByCategory, DtoProductsByCategory>();
            CreateMap<QuarterlyOrder, DtoQuarterlyOrder>();
            CreateMap<Region, DtoRegion>();
            CreateMap<SalesByCategory, DtoSalesByCategory>();
            CreateMap<SalesTotalsByAmount, DtoSalesTotalsByAmount>();
            CreateMap<Shipper, DtoShipper>();
            CreateMap<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>();
            CreateMap<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>();
            CreateMap<Supplier, DtoSupplier>();
            CreateMap<Territory, DtoTerritory>();
            CreateMap<User, DtoUser>();
        }
    }
}

