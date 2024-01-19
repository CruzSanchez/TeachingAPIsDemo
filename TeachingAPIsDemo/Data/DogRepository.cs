using TeachingAPIsDemo.Models;
using static TeachingAPIsDemo.Data.DogDatabase;

internal class DogRepository
{
    internal static Dog UpdateDog(int id, Dog updatedDog)
    {
        var dogToUpdate = Dogs.Where(x => x.Id == id).FirstOrDefault();

        dogToUpdate.Name = updatedDog.Name;
        dogToUpdate.Owner = updatedDog.Owner;
        dogToUpdate.Breed = updatedDog.Breed;
        dogToUpdate.Friends = updatedDog.Friends;

        ReplaceDogInList(dogToUpdate);

        return dogToUpdate;
    }

    private static void ReplaceDogInList(Dog dog)
    {
        var index = Dogs.IndexOf(dog);

        Dogs.RemoveAt(index);
        Dogs.Insert(index, dog);
    }
}
