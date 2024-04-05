using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        // Minimal API
        //GET
        app.MapGet("/animals-minimalapi{id}", (int id) =>
        {

            if (id!= 1)
            {
                return Results.NotFound();
            }
    
            //process data
            return Results.Ok(); //200 - ok
            // 201 - created
            // 400 - bad request
            // 404 - not found
        });

        //POST
        app.MapPost("/animals-minimalapi", (Animal animal) =>
        {
    
    
            //StaticData.animals.Add()
            return Results.Created("", animal);

        });
    }
}