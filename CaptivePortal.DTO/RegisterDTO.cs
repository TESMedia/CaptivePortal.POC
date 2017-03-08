using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptivePortal.DTO
{
   public  class RegisterDTO
    {
        public string HostIP { get; set; }

        public string HostPassword { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string Email { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
