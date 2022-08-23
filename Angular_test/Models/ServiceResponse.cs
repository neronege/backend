using Angular_test.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Angular_test.Controllers
{
    public class ServiceResponse<T> : BaseResponse
    {
        [JsonProperty]
        public T Entity { get; set; }

        [JsonProperty]
        public List<T> Entities { get; set; } //T değişken olarak yerine ne gelirse onu temsil ediyor
                                              //product gelirse prodcut category gelirse.... gibi

        public ServiceResponse()
        {
            Errors = new List<string>();
            Entities = new List<T>();
        }
    }
}
