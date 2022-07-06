using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrdersAPI.Models;

namespace OrdersAPI.Controllers
{
    public class UserAddressesController : Controller
    {
        private readonly ECommerceContext _context;

        public UserAddressesController(ECommerceContext context)
        {
            _context = context;
        }

        // GET: UserAddresses
        public async Task<IActionResult> Index()
        {
            var eCommerceContext = _context.UserAddresses.Include(u => u.User);
            return View(await eCommerceContext.ToListAsync());
        }

        // GET: UserAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAddress = await _context.UserAddresses
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userAddress == null)
            {
                return NotFound();
            }

            return View(userAddress);
        }

        // GET: UserAddresses/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName");
            return View();
        }

        // POST: UserAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AddressLine1,AddressLine2,City,PostalCode,Country,Mobile,MailId,ContactPerson")] UserAddress userAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", userAddress.UserId);
            return View(userAddress);
        }

        // GET: UserAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAddress = await _context.UserAddresses.FindAsync(id);
            if (userAddress == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", userAddress.UserId);
            return View(userAddress);
        }

        // POST: UserAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,AddressLine1,AddressLine2,City,PostalCode,Country,Mobile,MailId,ContactPerson")] UserAddress userAddress)
        {
            if (id != userAddress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserAddressExists(userAddress.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", userAddress.UserId);
            return View(userAddress);
        }

        // GET: UserAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAddress = await _context.UserAddresses
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userAddress == null)
            {
                return NotFound();
            }

            return View(userAddress);
        }

        // POST: UserAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userAddress = await _context.UserAddresses.FindAsync(id);
            _context.UserAddresses.Remove(userAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserAddressExists(int id)
        {
            return _context.UserAddresses.Any(e => e.Id == id);
        }
    }
}
