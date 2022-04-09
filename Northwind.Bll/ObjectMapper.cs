using AutoMapper;
using Northwind.Entity.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    internal class ObjectMapper //sadece Bll de olsun.Kalıtım vermeyeceğim için protected , nesen turetme yontemi ile yaptığımız için internal kullanırız
    {
        //Lazy sadece iihtiyacımız oldugunda gel demek.
        static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(()=> //bu işaret (=>) oyleki demek
          {
              var config = new MapperConfiguration(cfg =>
                {
                    //Birden cok mappingprofile varsa altına ekleriz
                    cfg.AddProfile<MappingProfile>();//Add profile mappingteki mappingprofile demek
                });
              return config.CreateMapper();

          } 
        );
        public static IMapper Mapper => lazy.Value;

    }
}
