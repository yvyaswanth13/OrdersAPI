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

    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ECommerceContext _context;

        public OrdersController(ECommerceContext context)
        {
            _context = context;
        }
       
        [HttpPost]
        public async Task<IActionResult> placeOrder([Bind("Id,UserId,AddressLine1,AddressLine2,City,PostalCode,Country,Mobile,MailId,ContactPerson")] UserAddress address)
        {
           int userId = 1000;
            try
            {
                var cart = await _context.Carts.Where(o => o.UserId == userId).ToListAsync();
                int total = (from c in cart where c.UserId == userId select c).Sum(x => x.SubTotal).Value;

                Order order = new Order();
                order.UserId =1000;
                order.TotalAmount = total;
                order.PaymentType = "COD";

                _context.Add(order);
                     await _context.SaveChangesAsync();

                var orderInfo =  _context.Orders.Where(o => o.UserId == userId).FirstOrDefault();
                foreach (var c in cart)
                {

                    OrderItem oi = new OrderItem();
                    oi.OrderId = orderInfo.OrderId;
                    oi.ProductId = c.ProductId;
                    oi.Product = _context.Products.Where(p => p.ProductId == c.ProductId).FirstOrDefault();
                    oi.SubTotal = c.SubTotal;
                    oi.Quantity = c.Quantity;
                    _context.Add(oi);
                    await _context.SaveChangesAsync();

                }
                address.UserId = 1000;
                _context.Add(address);
                await _context.SaveChangesAsync();

                if (cart != null)
                {
                    _context.Carts.RemoveRange(cart);
                    _context.SaveChanges();
                    return Ok();

                }



                return Ok();
            }
            catch(Exception e)
            {
                return Ok();
            }
            }
        //// GET: Orders
        //public async Task<IActionResult> Index()
        //{
        //    var eCommerceContext = _context.Orders.Include(o => o.Offer).Include(o => o.User);
        //    return View(await eCommerceContext.ToListAsync());
        //}

        //// GET: Orders/Details/5
        //public async Task<IActionResult> Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var order = await _context.Orders
        //        .Include(o => o.Offer)
        //        .Include(o => o.User)
        //        .FirstOrDefaultAsync(m => m.OrderId == id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(order);
        //}

        //// GET: Orders/Create
        //public IActionResult Create()
        //{
        //    ViewData["OfferId"] = new SelectList(_context.Offers, "OfferId", "OfferId");
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName");
        //    return View();
        //}

        //// POST: Orders/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("OrderId,UserId,DistinctItems,TotalAmount,PaymentType,PaymentId,OfferId,OrderedOn,IsCancelled,DeliveryDate,OrderStatus")] Order order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(order);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["OfferId"] = new SelectList(_context.Offers, "OfferId", "OfferId", order.OfferId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", order.UserId);
        //    return View(order);
        //}

        //// GET: Orders/Edit/5
        //public async Task<IActionResult> Edit(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var order = await _context.Orders.FindAsync(id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["OfferId"] = new SelectList(_context.Offers, "OfferId", "OfferId", order.OfferId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", order.UserId);
        //    return View(order);
        //}

        //// POST: Orders/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(long id, [Bind("OrderId,UserId,DistinctItems,TotalAmount,PaymentType,PaymentId,OfferId,OrderedOn,IsCancelled,DeliveryDate,OrderStatus")] Order order)
        //{
        //    if (id != order.OrderId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(order);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!OrderExists(order.OrderId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["OfferId"] = new SelectList(_context.Offers, "OfferId", "OfferId", order.OfferId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", order.UserId);
        //    return View(order);
        //}

        //// GET: Orders/Delete/5
        //public async Task<IActionResult> Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var order = await _context.Orders
        //        .Include(o => o.Offer)
        //        .Include(o => o.User)
        //        .FirstOrDefaultAsync(m => m.OrderId == id);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(order);
        //}

        //// POST: Orders/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(long id)
        //{
        //    var order = await _context.Orders.FindAsync(id);
        //    _context.Orders.Remove(order);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool OrderExists(long id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
