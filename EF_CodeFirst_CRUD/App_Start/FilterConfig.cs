﻿using System.Web;
using System.Web.Mvc;

namespace EF_CodeFirst_CRUD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
