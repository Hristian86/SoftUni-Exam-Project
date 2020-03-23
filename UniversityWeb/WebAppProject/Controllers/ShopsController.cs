﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Db.Models;
using Microsoft.AspNetCore.Authorization;
using DataDomain.Data;

namespace WebAppProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ShopsController : Controller
    {
        private readonly MovieShopDBSEContext _context;

        public ShopsController(MovieShopDBSEContext context)
        {
            _context = context;
        }

        // GET: Shops
        public async Task<IActionResult> Index()
        {
            var movieShopDBSEContext = _context.Shops.Include(s => s.Books).Include(s => s.Movie).Include(s => s.User);

            return View(await movieShopDBSEContext.ToListAsync());
        }

        // GET: Shops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shops
                .Include(s => s.Books)
                .Include(s => s.Movie)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shops == null)
            {
                return NotFound();
            }

            return View(shops);
        }

        // GET: Shops/Create
        public IActionResult Create()
        {
            ViewData["BooksId"] = new SelectList(_context.Books, "Id", "Id");
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: Shops/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,MovieId,RentedTime,BooksId")] Shops shops)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shops);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BooksId"] = new SelectList(_context.Books, "Id", "Id", shops.BooksId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", shops.MovieId);
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", shops.UserId);
            return View(shops);
        }

        // GET: Shops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shops.FindAsync(id);
            if (shops == null)
            {
                return NotFound();
            }
            ViewData["BooksId"] = new SelectList(_context.Books, "Id", "Id", shops.BooksId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", shops.MovieId);
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", shops.UserId);
            return View(shops);
        }

        // POST: Shops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,MovieId,RentedTime,BooksId")] Shops shops)
        {
            if (id != shops.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shops);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopsExists(shops.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BooksId"] = new SelectList(_context.Books, "Id", "Id", shops.BooksId);
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", shops.MovieId);
            ViewData["UserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", shops.UserId);
            return View(shops);
        }

        // GET: Shops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shops = await _context.Shops
                .Include(s => s.Books)
                .Include(s => s.Movie)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shops == null)
            {
                return NotFound();
            }

            return View(shops);
        }

        // POST: Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shops = await _context.Shops.FindAsync(id);
            _context.Shops.Remove(shops);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopsExists(int id)
        {
            return _context.Shops.Any(e => e.Id == id);
        }
    }
}