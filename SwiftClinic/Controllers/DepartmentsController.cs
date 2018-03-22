using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SwiftClinic.Models;
using SwiftClinicModels;

namespace SwiftClinic.Controllers
{
    public class DepartmentsController : Controller
    {
        private SwiftClinicDbContext db = new SwiftClinicDbContext();

        // GET: Departments
        public async Task<ActionResult> Index()
        {
            return View(await db.Departments.ToListAsync());
        }

        // GET: Departments/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = await db.Departments.FindAsync(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
            
        }

        /// <summary>
        /// datatable code, server side
        /// </summary>
        /// <returns></returns>

        public ActionResult GetData()
        {
            string draw, search;
            int pageSize, skip, totalRecord;

             draw = Request
                        .Form
                        .GetValues("draw")
                        .FirstOrDefault();
            var start = Request
                        .Form
                        .GetValues("start")
                        .FirstOrDefault();

            var length = Request
                         .Form
                         .GetValues("length")
                         .FirstOrDefault();

            //Get sort column value
            var sortColumn = Request
                             .Form
                             .GetValues("columns["
                             + Request.Form.GetValues("order[0][column]")
                             .FirstOrDefault() + "][name]")
                             .FirstOrDefault();


            var sortColumnDir = Request
                                .Form.GetValues("order[0][dir]")
                                 .FirstOrDefault();
            search = Request
                         .Form
                         .GetValues("search[value]")
                         .FirstOrDefault();
        pageSize = length != null ? Convert.ToInt32(length) : 0;
            skip = start != null ? Convert.ToInt32(start) : 0;
           totalRecord = 0;

          //  DataTableInputs(out draw, out search, out pageSize, out skip, out totalRecord);

            //below code is to get the exact properties to return to the view
            //if not an error will be genereated
            var v = db.Departments.Select(x => new {
                x.DepartmentCode,
                x.DepartmentName,
                x.Description
     
            }).ToList();

            // Verification.
            if (!string.IsNullOrEmpty(search.Trim()) && !string.IsNullOrWhiteSpace(search.Trim()))
            {
                // Apply search   
                // v = v.OrderBy(sortColumn + ""+sortColumnDir);
                v = v.Where(p => p.DepartmentCode.ToString().ToLower().Contains(search.ToLower())
                                // ||
                                //p.LastName.ToString().ToLower().Contains(search.ToLower())
                                ||
                                p.Description.ToString().ToLower().Contains(search.ToLower())
                                ||
                                p.DepartmentName.ToString().ToLower().Contains(search.ToLower())).ToList();
            }


            totalRecord = v.Count();
            var data = v.Skip(skip).Take(pageSize).ToList();
            return Json(
                new
                {
                    draw = draw,
                    recordsFiltered = totalRecord,
                    recordsTotal = totalRecord,
                    data = data
                },
               JsonRequestBehavior.AllowGet
                );

        }

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DepartmentId,DepartmentCode,DepartmentName,Description")] Department department)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(department);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: Departments/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = await db.Departments.FindAsync(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DepartmentId,DepartmentCode,DepartmentName,Description")] Department department)
        {
            if (ModelState.IsValid)
            {
                db.Entry(department).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        // GET: Departments/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = await db.Departments.FindAsync(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Department department = await db.Departments.FindAsync(id);
            db.Departments.Remove(department);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
