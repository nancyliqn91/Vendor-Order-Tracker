using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}/update")]
    public ActionResult Update(int vendorId, int orderId,string orderTitle, string orderDescription, int orderPrice, int orderAmount)
    {
      Order order = Order.Find(orderId);
      order.Title = orderTitle;
      order.Description = orderDescription;
      order.Price = orderPrice;
      order.Amount = orderAmount;
      return RedirectToAction("Edit",new { vendorId = vendorId, orderId = orderId });
    }

  }
}