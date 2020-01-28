﻿using AppForRestaurant.Core;
using System.Linq;
using System.Collections.Generic;

namespace AppForRestaurant.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Dejan Pizza", Location = "Grbavica", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Milica Tahitos bar", Location = "Liman 3", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Marko Indian delicious", Location = "Adice", Cuisine = CuisineType.Indian }
            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
