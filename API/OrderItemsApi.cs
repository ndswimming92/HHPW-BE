using HHPW_BE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HHPW_BE.API
{
    public class OrderItemsApi
    {
        public static void Map(WebApplication app)
        {

            // Get All Order Items
            app.MapGet("/api/allOrderItems", (HHPWDbContext db) =>
            {
                return db.OrderItems.ToList();
            });

            // Get Single Order Item
            app.MapGet("/api/singleOrderItem/{id}", (HHPWDbContext db, int id) =>
            {
                var orderItemID = db.OrderItems.FirstOrDefault(c => c.Id == id);

                if (orderItemID == null)
                {
                    return Results.NotFound("Order Item Not Found.");
                }

                return Results.Ok(orderItemID);
            });

         

            // Update Order Item
            app.MapPut("/api/orderItems/{id}", (HHPWDbContext db, int id, OrderItem orderItem) =>
            {
                OrderItem orderItemToUpdate = db.OrderItems.SingleOrDefault(order => order.Id == id);

                if (orderItemToUpdate == null)
                {
                    return Results.NotFound();
                }

                orderItemToUpdate.Amount = orderItem.Amount;

                db.SaveChanges();
                return Results.NoContent();
            });

            // Add Items to Order
            app.MapPost("/api/orderItems", (HHPWDbContext db, OrderItem newOrderItem) =>
            {
                db.OrderItems.Add(newOrderItem);
                db.SaveChanges();
                return Results.Created($"/api/orderItems/{newOrderItem.Id}", newOrderItem);
            });

            // Delete an Order Item
            app.MapDelete("/api/deleteOrderItem/{id}", (HHPWDbContext db, int id) =>
            {
                OrderItem orderItemToDelete = db.OrderItems.SingleOrDefault(orderItemToDelete => orderItemToDelete.Id == id);
                if (orderItemToDelete == null)
                {
                    return Results.NotFound();
                }
                db.OrderItems.Remove(orderItemToDelete);
                db.SaveChanges();
                return Results.NoContent();
            });

            // Create a Order Item
            app.MapPost("/api/orderItem", (HHPWDbContext db, OrderItem newOrderItem) =>
            {
                db.OrderItems.Add(newOrderItem);
                db.SaveChanges();
                return Results.Created($"/api/orderItem/{newOrderItem.Id}", newOrderItem);
            });

        }
    }
}
