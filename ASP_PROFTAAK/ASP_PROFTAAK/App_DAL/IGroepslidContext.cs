﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_PROFTAAK.Models;

namespace ASP_PROFTAAK.App_DAL
{
    public interface IGroepslidContext
    {
       List<Groepslid> getGroepsledenByReserveringId(int id);


    }
}