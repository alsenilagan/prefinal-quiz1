﻿using System.Web;
using System.Web.Mvc;

namespace PreFinalQuiz1_IlaganAM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
