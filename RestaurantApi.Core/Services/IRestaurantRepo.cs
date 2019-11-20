using System.Collections.Generic;
using RestaurantApi.Core.Models;

namespace RestaurantApi.Core.Services
{
    public interface IRestaurantRepo
    {
        Restaurant Add(Restaurant restaurant);
        Restaurant Get(int id);
        IEnumerable<Restaurant> GetAll();
        void Remove(Restaurant restaurant);
        Restaurant Update(Restaurant updatedRestaurant);
    }
}