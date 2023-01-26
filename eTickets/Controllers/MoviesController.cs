﻿using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public IActionResult Index()//public async Task<IActionResult> Index()
        {
            var allMovies = _service.GetAll(n => n.Cinema); //aici am facut sa fie mai generic asa
            return View(allMovies);
        }

        //GET: movies/details/id
        public IActionResult Details(int id)
        {
            var movieDetail = _service.GetMovieById(id);
            return View(movieDetail);
        }
    }
}
