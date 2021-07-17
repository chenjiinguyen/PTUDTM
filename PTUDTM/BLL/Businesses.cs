using BLL.Business;
using DLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Businesses
    {
        public static BookBusiness book = new BookBusiness();

        public static AuthBusiness auth = new AuthBusiness();
    }
}
