using Microsoft.AspNetCore.Mvc;
using TeachingAPIsDemo.Data;
using TeachingAPIsDemo.Models;
using static TeachingAPIsDemo.Data.BookDatabase;
using static TeachingAPIsDemo.Data.DogDatabase;

#region Setup
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

BringForthTheDogs();
BringForthTheBooks();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
#endregion

#region Books
app.MapGet("/books", () =>
{
    return TypedResults.Ok(Books);
});

app.MapGet("/book/{id}", (int id) =>
{
    if (!Books.Exists(x => x.Id == id))
        return Results.NotFound(id);

    return TypedResults.Ok(Books.Where(x => x.Id == id).FirstOrDefault());
});

app.MapGet("/book/random", () =>
{
    Random rng = new Random();

    var randomIndex = rng.Next(Books.Count);

    return TypedResults.Ok(Books[randomIndex]);
});

app.MapPost("/book", ([FromBody] Book book) =>
{
    if (book == null)
        return Results.BadRequest();

    book.Id = Books.Last().Id + 1;
    Books.Add(book);

    return TypedResults.Ok(book);
});

app.MapPut("/book/{id}", (int id, [FromBody] Book book) =>
{
    if (book is null)
        return Results.BadRequest(book);

    if (!Books.Exists(x => x.Id == id))
        return Results.NotFound(id);

    var updatedBook = BookRepository.UpdateBook(id, book);

    return TypedResults.Ok(updatedBook);
});

app.MapDelete("/book/{id}", (int id) =>
{
    if (!Books.Exists(x => x.Id == id))
        return Results.NotFound(id);

    Books.Remove(Books.Where(x => x.Id == id).FirstOrDefault());

    return TypedResults.NoContent();
});
#endregion

#region Dogs
app.MapGet("/dogs", () =>
{
    return TypedResults.Ok(Dogs);
});

app.MapGet("/dog/{id}", (int id) =>
{
    if (!Dogs.Exists(x => x.Id == id))
        return Results.NotFound(id);

    return TypedResults.Ok(Dogs.Where(x => x.Id == id).FirstOrDefault());
});

app.MapGet("/dog/random", () =>
{
    Random rng = new Random();
    var randomIndex = rng.Next(Dogs.Count);

    return TypedResults.Ok(Dogs[randomIndex]);
});

app.MapPost("/dog", ([FromBody] Dog dog) =>
{
    if (dog == null)
        return Results.BadRequest();

    dog.Id = Dogs.Last().Id + 1;
    Dogs.Add(dog);

    return TypedResults.Ok(dog);
});

app.MapPut("/dog/{id}", (int id, [FromBody] Dog dog) =>
{
    if (dog is null)
        return Results.BadRequest(dog);

    if (!Dogs.Exists(x => x.Id == id))
        return Results.NotFound(id);

    var updatedDog = DogRepository.UpdateDog(id, dog);

    return TypedResults.Ok(updatedDog);
});

app.MapDelete("/dog/{id}", (int id) =>
{
    if (!Dogs.Exists(x => x.Id == id))
        return Results.NotFound(id);

    Dogs.Remove(Dogs.Where(x => x.Id == id).FirstOrDefault());

    return TypedResults.NoContent();
});
#endregion

app.Run();