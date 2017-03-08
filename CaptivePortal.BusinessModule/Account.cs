using CaptivePortal.DataAccessModule;
using CaptivePortal.DTO;
using FP.Radius;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptivePortal.BusinessModule
{
   public class Account
    {
        private RegisterDB objRegisterDB = new RegisterDB();
        string[] args;
        string code = "success";

        public string Register(RegisterDTO _accountDao)
        {
            try
            {
                objRegisterDB.CreateNewUser(_accountDao.UserName, _accountDao.UserPassword, _accountDao.Email);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return code;
        }

        public string Login(LoginDTO _loginDTO)
        {
               
            try
            {
                //objRegisterDB.LoginUser(_loginDTO.UserName,_loginDTO.UserPassword);
                var args = new string[4];
                args[0] = "192.168.1.3";
                args[1] = "testing123";
                args[2] = _loginDTO.UserName;
                args[3] = _loginDTO.UserPassword;
                if (args.Length != 4)
                {
                    Authenticate.ShowUsage();
                }

                try
                {
                    Authenticate.Authentication(args).Wait();
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }

            return null;
        }

    }
}
