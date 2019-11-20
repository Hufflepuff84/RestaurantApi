using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using RestaurantApi.Infrastructure.Data;
using RestaurantApi.Core.Models;
using RestaurantApi.Core.Services;

namespace RestaurantApi.Infrastructure.Data
{

    public class RestaurantRepo : IRestaurantRepo
    {
        private readonly RestaurantContext _restaurantContext;

        public RestaurantRepo(RestaurantContext RestaurantContext)
        {
            _restaurantContext = RestaurantContext;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurantContext.Restaurants.ToList();

        }
        public Restaurant Get(int id)
        {
            return _restaurantContext.Restaurants.FirstOrDefault(b => b.Id == id);
        }
        public Restaurant Add(Restaurant restaurant)
        {
            _restaurantContext.Restaurants.Add(restaurant);
            _restaurantContext.SaveChanges();
            return restaurant;
        }
        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var currentRestaurant = _restaurantContext.Restaurants.FirstOrDefault(b => b.Id == updatedRestaurant.Id);
            if (currentRestaurant == null) return null;
            _restaurantContext.Entry(currentRestaurant).CurrentValues
                .SetValues(updatedRestaurant);
            _restaurantContext.Restaurants.Update(currentRestaurant);
            _restaurantContext.SaveChanges();
            return currentRestaurant;
        }
        public void Remove(Restaurant restaurant)
        {
            _restaurantContext.Restaurants.Remove(restaurant);
            _restaurantContext.SaveChanges();

        }

    }
}
