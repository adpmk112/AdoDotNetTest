using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crudTest.Models
{
    public class BaseResponseModel
    {
        public string respCode { get; set; }
        public string respDescription { get; set; }
    }

    public class BaseResponseModelWithData
    {
        public string respCode { get; set; }
        public string respDescription { get; set; }
        public Object respData { get; set; }
    }

 /*   public class BaseResponseModelWithToken
    {
        public string respCode { get; set; }
        public string respDescription { get; set; }
        public string token { get; set; }
        public string loginUserName { get; set; }
        public long loginId { get; set; }
        public List<MenuModel> MenuList { get; set; }
    }*/
    public class BaseMobileResponseModelWithToken
    {
        public string respCode { get; set; }
        public string respDescription { get; set; }
        public string token { get; set; }

    }
    public class RequestModel
    {
        public string encodedString { get; set; }
    }

}
