using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Industry_4._0.Data;
using Industry_4._0.Models;
using Microsoft.AspNetCore.Authorization;

namespace Industry_4._0.Controllers
{
    public class feedbacksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public feedbacksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: feedbacks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Feedback.ToListAsync());
        }

        // GET: feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var feedback = await _context.Feedback
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // GET: feedbacks/Create
        [Authorize(Roles = "Manager, RegisteredUser")]
        public IActionResult Create()
        {
            Feedback df = new Feedback();
            df.Date = DateTime.Now;
            df.UserName = User.Identity.Name;
            df.Agree = 0;
            df.Disagree = 0;
            df.StarRating = 0;
            return View(df);
        }

        // POST: feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager, RegisteredUser")]

        public async Task<IActionResult> Create([Bind("Id,Date,UserName,Heading,CompanyOrganisation,Feedback,StarRating,Agree,Disagree")] Feedback POST )

        {
            if (ModelState.IsValid)
            {
                _context.Add(POST);
                await _context.SaveChangesAsync();
                return RedirectToAction("companiesandorganisations", "Home");
            }
            return View(POST);

        }


        private bool FeedbackExists(int id)
        {
            throw new NotImplementedException();
        }

        

        // GET: feedbacks/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }
            return View(feedback);
        }

        // POST: feedbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,UserName,Heading,CompanyOrganisation,Feedback,StarRating,Agree,Disagree")] Feedback POST)
        {
            if (id != POST.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(POST);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackExists(POST.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("companiesandorganisations", "Home");
            }
            return View(POST);
        }

        // GET: feedbacks/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedback
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // POST: feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var POST = await _context.Feedback.FindAsync(id);
            _context.Feedback.Remove(POST);
            await _context.SaveChangesAsync();
            return RedirectToAction("companiesandorganisations", "Home");
        }

        private bool Feedback(int id)
        {
            return _context.Feedback.Any(e => e.Id == id);
        }



        public async Task<IActionResult> IncreaseAgree(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    feedback.Agree++;

                    _context.Update(feedback);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackExists(feedback.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("companiesandorganisations", "Home");
            }
            return RedirectToAction("companiesandorganisations", "Home");
        }
        public async Task<IActionResult> IncreaseDisagree(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    feedback.Disagree++;

                    _context.Update(feedback);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackExists(feedback.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("companiesandorganisations", "Home");
            }
            return RedirectToAction("companiesandorganisations", "Home");
        }
    }
}
