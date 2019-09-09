﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();

            var viewModel = new RandomMovieViewModel()
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult NewMovie()
        {
            var movie = new Movie()
            {
                DateAdded = DateTime.Now
            };

            return View(movie);
        }

        public ActionResult Save(Movie movie)
        {
            _context.Movies.Add(movie);

            _context.SaveChanges();

            return RedirectToAction("Index","Movies");
        }

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var _selectedMovie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return View(_selectedMovie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Random(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //contraints - min, max, minlength, maxlength, int, float, etc.
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}