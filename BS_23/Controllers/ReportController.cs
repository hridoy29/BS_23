using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using BS_23.Models;
using PagedList.Mvc;
using PagedList;
using System.Web.Script.Serialization;

namespace BS_23.Controllers
{
    public class ReportController : Controller
    {
        BSEntities db = new BSEntities();

        public ActionResult FeedbackReport(string search, int? page)
        {


            var post = db.BS_post_parent_t.Include(x => x.BS_comment_parent_t)
                .Where(x => x.BS_user_parent_t.UserName.StartsWith(search.Trim()) || search == null)
                .ToList().ToPagedList(page ?? 1, 2);
            return View(post);
           
        }
        

    }
}