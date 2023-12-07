using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repository;
using Object;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace eStore.Controllers
{
    public class MembersController : Controller
    {

        private readonly IMemberRepository memberRepo;
        public MembersController()
        {
            memberRepo = new MemberRepository();
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            string account = HttpContext.Session.GetString("account");

            if (account.IsNullOrEmpty())
            {
                ViewData["Message"] = "Incorrect email and password";
                return RedirectToAction("Index", "Login");
            }

            return memberRepo.GetAllMembers() != null ? 
                          View(memberRepo.GetAllMembers()) :
                          Problem("Entity set 'SmdbContext.Members'  is null.");
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || memberRepo.GetAllMembers() == null)
            {
                return NotFound();
            }

            var member = memberRepo.GetAllMembers()
                .FirstOrDefault(m => m.MemberId == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberId,Email,CompanyName,City,Country,Password")] Member member)
        {
            if (ModelState.IsValid)
            {
                memberRepo.InsertMember(member);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || memberRepo.GetAllMembers()== null)
            {
                return NotFound();
            }

            var member = memberRepo.GetMember(id.Value);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberId,Email,CompanyName,City,Country,Password")] Member member)
        {
            if (id != member.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    memberRepo.UpdateMember(member);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.MemberId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || memberRepo.GetAllMembers() == null)
            {
                return NotFound();
            }

            var member = memberRepo.GetMember(id.Value);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (memberRepo.GetAllMembers() == null)
            {
                return Problem("Entity set 'SmdbContext.Members'  is null.");
            }
            var member = memberRepo.GetMember(id);
            if (member != null)
            {
                memberRepo.DeleteMember(id);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
          return (memberRepo.GetAllMembers()?.Any(e => e.MemberId == id)).GetValueOrDefault();
        }
    }
}
