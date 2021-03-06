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
       public Order o = new Order();


        public OrdersController(ECommerceContext context)
        {
            _context = context;
        }
        [Route("GetUserAdd")]
        [HttpGet]
        public async Task<ActionResult> GetUserAdd(int uid)
        {
            var orderI = _context.UserAddresses.Where(o => o.Id == uid).ToList();
            var addInfo = orderI.LastOrDefault();

            return Ok(addInfo);
        }
        [Route("GetOrderItems")]
        [HttpGet]
        public async Task<ActionResult> GetOrderItems(int oid)
        {
            var orderI = _context.OrderItems.Where(o => o.OrderId == oid).ToList();
          
            return Ok(orderI);
        }

        [Route("GetById")]
        [HttpGet]
        public async Task<ActionResult> GetById(int id)
        {
            var orderI = _context.Orders.Where(o => o.UserId == id).ToList();
            var orderInfo = orderI.LastOrDefault();

            return Ok(orderInfo);
        }

        [Route("getOrders")]
        public List<Order>getOrder()
        {
            return _context.Orders.ToList();

        }
        [Route("OrderItems")]
        public List<OrderItem> getOrderItems()
        {
            return _context.OrderItems.ToList();

        }
     

        [HttpPost]
        public async Task<IActionResult> placeOrder([Bind("Id,UserId,AddressLine1,AddressLine2,City,PostalCode,Country,Mobile,MailId,ContactPerson")] UserAddress address)
        {
           int userId = 1000;
            try
            {
               // Order orderInfo;
                var cart = await _context.Carts.Where(o => o.UserId == userId).ToListAsync();
                float total = (float)(from c in cart where c.UserId == userId select c).Sum(x => x.SubTotal).Value;
                if (cart != null)
                {
                    Order order = new Order();
                    order.UserId = address.UserId;
                    order.TotalAmount = Math.Round(total, 2);
                    order.PaymentType = "COD";
                    order.OrderStatus = "placed";
                    order.OrderedOn = DateTime.Now;
                    order.DeliveryDate = DateTime.Now.AddDays(7);
                    _context.Add(order);
                    await _context.SaveChangesAsync();

                    var orderI = _context.Orders.Where(o => o.UserId == userId).ToList();
                  var  orderInfo = orderI.LastOrDefault();

                    foreach (var c in cart)
                    {

                        OrderItem oi = new OrderItem();
                        oi.OrderId = orderInfo.OrderId;
                        oi.ProductId = c.ProductId;
                        oi.ProductName = c.ProductName;
                        oi.Product = _context.Products.Where(p => p.ProductId == c.ProductId).FirstOrDefault();
                        oi.SubTotal = c.SubTotal;
                        oi.Quantity = c.Quantity;
                        _context.Add(oi);
                        await _context.SaveChangesAsync();

                    }
                    address.UserId = 1000;
                    _context.Add(address);
                    await _context.SaveChangesAsync();

                    var add = _context.UserAddresses.Where(o => o.UserId == userId).ToList();
                    var oneAdd = add.LastOrDefault();
                    orderInfo.DeliveryAddress = oneAdd.Id;
                    _context.SaveChanges();

                    if (cart != null)
                    {
                        _context.Carts.RemoveRange(cart);
                        _context.SaveChanges();
                        //  return Ok(orderInfo.OrderId);

                    }



                    return Ok(orderInfo.OrderId.ToString());
                }
                else
                {
                    return Ok("Fail");
                }
            }
            catch(Exception e)
            {
                return Ok("Fail");
            }
            }


    }
}
