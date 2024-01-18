using Microsoft.AspNetCore.Mvc;
using TeachingAPIsDemo.Data;
using TeachingAPIsDemo.Models;
using static TeachingAPIsDemo.Data.BookDatabase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

DogDatabase.BringForthTheDogs();
BringForthTheBooks();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

#region Books
app.MapGet("/books", () =>
{
    return TypedResults.Ok(Books);
});

app.MapGet("/book/{id}", (int id) =>
{
    if (id < 0)
    {
        return Results.NotFound(id);
    }

    return TypedResults.Ok(Books.Where(x => x.Id == id).FirstOrDefault());
});

app.MapGet("/book/random", () =>
{
    Random rng = new Random();

    var randomIndex = rng.Next(Books.Count);

    return TypedResults.Ok(Books[randomIndex]);
});

app.MapPut("/book/{id}", (int id, [FromBody] Book book) =>
{
    if (0 > id)
        return Results.NotFound(id);

    if (book is null)
        return Results.BadRequest(book);

    var bookToUpdate = Books.Where(x => x.Id == id).FirstOrDefault();

    var index = Books.IndexOf(bookToUpdate);
    Books[index] = book;

    return TypedResults.Ok(book);
});
#endregion

#region Dogs
app.MapGet("/dogs", () =>
{
    return TypedResults.Ok(DogDatabase.Dogs);
});

app.MapGet("/dog/{id}", (int id) =>
{
    if (id < 0)
    {
        return Results.NotFound(id);
    }

    return TypedResults.Ok(DogDatabase.Dogs.Where(x => x.Id == id).FirstOrDefault());
});

app.MapGet("/dog/random", () =>
{
    Random rng = new Random();
    var randomIndex = rng.Next(DogDatabase.Dogs.Count);
    return TypedResults.Ok(DogDatabase.Dogs[randomIndex]);
});


#endregion

app.Run();
