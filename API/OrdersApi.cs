using HHPW_BE.Models;
using Microsoft.EntityFrameworkCore;
namespace HHPW_BE.API
{
    public class OrdersApi
    {
        public static void Map(WebApplication app)
        {

            // Get All Orders
            app.MapPost("/orders", (HHPWDbContext db, Order newOrder) =>
            {
                try
                {
                    db.Orders.Add(newOrder);
                    db.SaveChanges();
                    return Results.Created($"/api/reservations/{newOrder.Id}", newOrder);
                }
                catch (DbUpdateException)
                {
                    return Results.BadRequest("Invalid data submitted");
                }
            });


            // Get All Orders
            app.MapGet("/orders", (HHPWDbContext db) =>
            {
                return db.Orders
                         .Include(order => order.Items)
                         .ThenInclude(orderItem => orderItem.Item);
            });


            // Get Orders by Id
            app.MapGet("/orders/{id}", (HHPWDbContext db, int id) =>
            {
                return db.Orders
                         .Include(order => order.Items)
                         .ThenInclude(orderItem => orderItem.Item)
                         .SingleOrDefault(order => order.Id == id);
            });


            // Update Orders
            app.MapPut("/orders/{id}", (HHPWDbContext db, int id, Order updatedOrder) =>
            {
                Order orderToUpdate = db.Orders.FirstOrDefault(o => o.Id == id);
                if (orderToUpdate == null)
                {
                    return Results.NotFound();
                }

                if (updatedOrder.Name != null)
                {
                    orderToUpdate.Name = updatedOrder.Name;
                }

                if (updatedOrder.Status != orderToUpdate.Status)
                {
                    orderToUpdate.Status = updatedOrder.Status;
                }

                if (updatedOrder.Phone != null)
                {
                    orderToUpdate.Phone = updatedOrder.Phone;
                }

                if (updatedOrder.Email != null)
                {
                    orderToUpdate.Email = updatedOrder.Email;
                }

                if (updatedOrder.OrderType != null)
                {
                    orderToUpdate.OrderType = updatedOrder.OrderType;
                }

                if (updatedOrder.PaymentType != null)
                {
                    orderToUpdate.PaymentType = updatedOrder.PaymentType;
                }

                if (updatedOrder.Tip != null)
                {
                    orderToUpdate.Tip = updatedOrder.Tip;
                }

                db.SaveChanges();
                return Results.NoContent();
            });


            // Delete Orders
            app.MapDelete("/orders/{id}", (HHPWDbContext db, int id) =>
            {
                Order orderToDelete = db.Orders.FirstOrDefault(o => o.Id == id);
                if (orderToDelete == null)
                {
                    return Results.NotFound();
                }
                db.Orders.Remove(orderToDelete);
                return Results.Ok(db.Orders);
            });

        }
    }
}
