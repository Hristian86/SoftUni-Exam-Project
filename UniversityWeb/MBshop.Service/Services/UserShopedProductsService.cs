﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBshop.Service.interfaces;
using MBshop.Service.OutputModels;
using MBshop.Data.Data;

namespace MBshop.Service.Services
{
    public class UserShopedProductsService : IUserShopedProductsService
    {
        private readonly MovieShopDBSEContext db;

        public UserShopedProductsService(MovieShopDBSEContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Current logged user purchased movies
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<OutputMovies> PersonalMovies(string userId)
        {
            var display = ConvertMovie(userId);
            return display;
        }

        /// <summary>
        /// Current logged user purchased books
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<OutputBooks> PersonalBooks(string userId)
        {
            var toBeDisplayed = ConvertBooks(userId);
            return toBeDisplayed;
        }

        private List<OutputBooks> ConvertBooks(string userId)
        {
            var disp = new List<OutputBooks>();

            //getting personal collection of books for current user
            var userBooks = this.db.Shops
                .Where(x => x.UserId == userId)
                .Select(x => x.Books)
                .ToList();

            //mapping to output model
            foreach (var itemBook in userBooks)
            {
                if (itemBook != null)
                {

                    OutputBooks book = new OutputBooks
                    {
                        Id = itemBook.Id,
                        Title = itemBook.Title,
                        Author = itemBook.Author,
                        Genre = itemBook.Genre,
                        Picture = itemBook.Picture,
                        Discount = itemBook.Discount,
                        price = itemBook.price,
                        RealeseDate = itemBook.RealeseDate,
                        
                        //new properties
                        Raiting = itemBook.Raiting,
                        Description = itemBook.Description,
                        LinkForProductContentWhenPurchase = itemBook.LinkForProductContentWhenPurchase
                    };
                    disp.Add(book);
                }

            }

            return disp;
        }

        private List<OutputMovies> ConvertMovie(string userId)
        {
            var displays = new List<OutputMovies>();

            //getting personal collection of movies for current user
            var userMovis = this.db.Shops
                .Where(x => x.UserId == userId)
                .Select(x => x.Movie)
                .ToList();

            foreach (var itemMovie in userMovis)
            {
                if (itemMovie != null)
                {

                    //mapping to output model
                    OutputMovies movie = new OutputMovies
                    {
                        Id = itemMovie.Id,
                        Title = itemMovie.Title,
                        Director = itemMovie.Director,
                        Genre = itemMovie.Genre,
                        Picture = itemMovie.Picture,
                        Discount = itemMovie.Discount,
                        price = itemMovie.price,
                        RealeaseDate = itemMovie.RealeaseDate,
                        ShopsMovieId = itemMovie.ShopsMovieId,
                        LinkForPurchasedContend = itemMovie.LinkForProductContentWhenPurchase,

                        //new properties
                        Rate = itemMovie.Rate,
                        Actors = itemMovie.Actors,
                        Raiting = itemMovie.Raiting,
                        Description = itemMovie.Description
                    };

                    displays.Add(movie);
                }
            }

            return displays;
        }
    }
}