using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Base
{
    //listeleme , yada tek tek vs geri dondurme işlemi(response) için nasıl cekmek istiyorsa eer object olmazsa sonuc hep tek gondurur list dondurmez mesela yani daha kompleks yapılar için generic olan dondureceğiz her seferinde tek tek yazmamak için generic te oluşturduk. 
    class Response:IResponse
    {
        public string Message { get; set; }//mesaj dondur
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }
    class Response<T> : IResponse<T>//personel dondurmek için mesela object olanı seceriz.
    {
        public string Message { get; set; }//mesaj dondur
        public int StatusCode { get; set; }//200 mü 500 mü vs httpler
        public T Data { get; set; }
    }

}
