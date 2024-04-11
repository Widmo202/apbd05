using Tutorial4.Database;
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
            
            var animal = StaticData.animals.Find(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(animal);
    
            //process data
            //200 - ok
            // 201 - created
            // 400 - bad request
            // 404 - not found
        });

        //POST
        app.MapPost("/animals-minimalapi", (Animal animal) =>
        {


            StaticData.animals.Add(animal);
            return Results.Created("", animal);

        });
        
        app.MapPut("/animals/{id}", (int id, Animal animal) => 
        {
            var index = StaticData.animals.FindIndex(a => a.Id == id);
            if (index == -1)
            {
                return Results.NotFound();
            }
            StaticData.animals[index] = animal;
            return Results.Ok("Animal modified");
        });
        
        app.MapDelete("/animals/{id}", (int id) => 
        {
            var removed = StaticData.animals.RemoveAll(a => a.Id == id);
            if (removed>0)
            {
                return Results.Ok("Animal removed");
            }

            return Results.NotFound();
        });
        
        app.MapGet("/animals/{id}/visits", (int id) => 
        {
            var animal = StaticData.animals.Find(a => a.Id == id);
            if (animal == null)
            {
                return  Results.NotFound();
            }
            return Results.Ok(animal.Visits);
        });
        
        app.MapPost("/animals/{id}/visits", (int id, Visit visit) => 
        {
            var animal = StaticData.animals.Find(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound();
            }
            animal.Visits.Add(visit);
            return Results.Created("", visit);
        });
        
    }
}