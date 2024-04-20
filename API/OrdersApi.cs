using Microsoft.EntityFrameworkCore;
using HHPW_BE.Models;
using System.Linq;

namespace HHPW_BE.API

{
    public class OrdersApi
    {
        public static void Map(WebApplication app)
        {

            // Create a Order
            app.MapPost("/api/createOrder", (HHPWDbContext db, Order newOrder) =>
            {
                db.Orders.Add(newOrder);
                db.SaveChanges();
                return Results.Created($"/api/orders/{newOrder.Id}", newOrder);
            });


            // Get Single Order
            app.MapGet("/api/getSingleOrder/{id}", (HHPWDbContext db, int id) =>
            {
                var orderID = db.Orders.FirstOrDefault(order => order.Id == id);

                if (orderID == null)
                {
                    return Results.NotFound("Order Not Found.");
                }

                return Results.Ok(orderID);
            });

            // Get All Orders
            app.MapGet("/api/allOrders", (HHPWDbContext db) =>
            {
                return db.Orders.ToList();
            });


            // Get Order by Id
            app.MapGet("/api/order/{id}", (HHPWDbContext db, int id) =>
            {
                var order = db.Orders.FirstOrDefault(order => order.Id == id);

                if (order == null)
                {
                    return Results.NotFound("Order was not found.");
                }

                return Results.Ok(order);
            });


            // Update Order
            app.MapPut("/api/orders/{id}", (HHPWDbContext db, int id, Order order) =>
            {
                Order orderToUpdate = db.Orders.SingleOrDefault(order => order.Id == id);

                if (orderToUpdate == null)
                {
                    return Results.NotFound();
                }

                orderToUpdate.Name = order.Name;
                orderToUpdate.Status = order.Status;
                orderToUpdate.Phone = order.Phone;
                orderToUpdate.Email = order.Email;
                orderToUpdate.OrderType = order.OrderType;
                orderToUpdate.Total = order.Total;
                orderToUpdate.Tip = order.Tip;
                orderToUpdate.Date = order.Date;

                db.SaveChanges();
                return Results.NoContent();
            });


            // Delete Order
            app.MapDelete("api/deleteOrder/{id}", (HHPWDbContext db, int id) =>
            {
                Order orderToDelete = db.Orders.FirstOrDefault(order => order.Id == id);
                if (orderToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Orders.Remove(orderToDelete);
                db.SaveChanges();
                return Results.Ok(db.Orders);
            });


           

        }
    }
}
