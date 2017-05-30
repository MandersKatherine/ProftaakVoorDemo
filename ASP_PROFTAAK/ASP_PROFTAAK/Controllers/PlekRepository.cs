﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_PROFTAAK.App_DAL;
using ASP_PROFTAAK.Models;

namespace ASP_PROFTAAK.Controllers
{
    public class PlekRepository
    {
        private IPlekContext context;

        public PlekRepository(IPlekContext context)
        {
            this.context = context;
        }

        public List<Plek> GetAll()
        {
            return context.GetAll();
        }

        public bool DeletePlek(int id)
        {
            return context.DeletePlek(id);
        }

        public Plek InsertPlek(Plek plek)
        {
            return context.InsertPlek(plek);
        }

        public bool UpdatePlek(Plek plek)
        {
            return context.UpdatePlek(plek);
        }
    }
}