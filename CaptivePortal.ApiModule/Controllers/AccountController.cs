using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CaptivePortal.BusinessModule;
using CaptivePortal.DTO;
using FP.Radius;
using System.Web.Http.Cors;

namespace CaptivePortal.ApiModule.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {   
        private Account _account = new Account();
        string code = "Success";

        [HttpPost]
        [Route("Register")]
        public HttpResponseMessage Register(RegisterDTO _registerDto)
        {
            try
            {

                _account.Register(_registerDto);

                return new HttpResponseMessage
                {
                    Content = new StringContent(code)
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        [HttpPost]
        [Route("Login")]
        public HttpResponseMessage Login(LoginDTO _loginDto)
        {
            try
            {

                _account.Login(_loginDto);

                return new HttpResponseMessage()
                {
                    Content = new StringContent("success")
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
