using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudTest.Models
{
    public class ResponseModel : BaseResponseModel
    {
        public Object respData { get; set; }
    }
    public class ResponseEncryptModel : BaseResponseModel
    {
        public Object respData { get; set; }
        public string token { get; set; }
    }
  /*  public class ResponseModelWithToken : BaseResponseModelWithToken
    {
        public Object respData { get; set; }
    }*/
    public class MobileResponseModelWithToken : BaseMobileResponseModelWithToken
    {
        public Object respData { get; set; }
    }

    public class CheckNullForModelResponse
    {
        public bool IsNotNull { get; set; }
        public string respDescription { get; set; }

    }

}
