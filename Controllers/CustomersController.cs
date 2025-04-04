using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PNE_Microservice_POC.Models;
using PNE_Microservice_POC.Services;

namespace PNE_Microservice_POC.Controllers
{
    public static class CustomersController
    {
        public static void RegisterCustomerEndpoints(this WebApplication app)
        {
            // Minimal API Endpoints
            app.MapGet("/customers", async (ICustomerService service) =>
            {
                return Results.Ok(await service.GetAllCustomersAsync());
            });

            app.MapGet("/customers/{id:int}", async (int id, ICustomerService service) =>
            {
                var customer = await service.GetCustomerByIdAsync(id);
                return customer != null ? Results.Ok(customer) : Results.NotFound();
            });

            app.MapPost("/customers", async (Customer customer, ICustomerService service) =>
            {
                await service.AddCustomerAsync(customer);
                return Results.Created($"/customers/{customer.Id}", customer);
            });

            app.MapPut("/customers/{id:int}", async (int id, Customer customer, ICustomerService service) =>
            {
                var existingCustomer = await service.GetCustomerByIdAsync(id);
                if (existingCustomer == null) return Results.NotFound();

                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.CompanyId = customer.CompanyId;
                existingCustomer.TenantId = customer.TenantId;
                existingCustomer.UpdatedOn = DateTime.UtcNow;

                await service.UpdateCustomerAsync(existingCustomer);
                return Results.NoContent();
            });

            app.MapDelete("/customers/{id:int}", async (int id, ICustomerService service) =>
            {
                var customer = await service.GetCustomerByIdAsync(id);
                if (customer == null) return Results.NotFound();

                await service.DeleteCustomerAsync(id);
                return Results.NoContent();
            });
        }
    }
}
