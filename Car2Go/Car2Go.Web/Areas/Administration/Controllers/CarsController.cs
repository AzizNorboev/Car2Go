﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car2Go.Data;
using Car2Go.Data.Common.Repositories;
using Car2Go.Data.Models;

namespace Car2Go.Web.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class CarsController : AdministrationController
    {
        private readonly IDeletableEntityRepository<Car> dataRepository;

        public CarsController(IDeletableEntityRepository<Car> dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        // GET: Administration/Cars
        public async Task<IActionResult> Index()
        {
            return this.View(await this.dataRepository.AllWithDeleted().ToListAsync());
        }

        // GET: Administration/Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = await this.dataRepository.All()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // GET: Administration/Cars/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InUse,Model,Description,Year,Speed,Image,GearType,PricePerDay,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Car car)
        {
            if (this.ModelState.IsValid)
            {
                await this.dataRepository.AddAsync(car);
                await this.dataRepository.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }
            await this.dataRepository.AddAsync(car);
            await this.dataRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));

            // this.ViewData["LocationId"] = this.dataRepository.All().Select(b => new SelectListItem
            // {
            //    Text = b.Location.Name,
            // }).ToList();
            return this.View(car);
        }

        // GET: Administration/Cars/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = this.dataRepository.All().FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // POST: Administration/Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InUse,Model,Description,Year,Speed,Image,GearType,PricePerDay,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Car car)
        {
            if (id != car.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.dataRepository.Update(car);
                    await this.dataRepository.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.CarExists(car.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(car);
        }

        // GET: Administration/Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var car = await this.dataRepository.All()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return this.NotFound();
            }

            return this.View(car);
        }

        // POST: Administration/Cars/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = this.dataRepository.All().FirstOrDefault(x => x.Id == id);
            this.dataRepository.Delete(car);
            await this.dataRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool CarExists(int id)
        {
            return this.dataRepository.All().Any(e => e.Id == id);
        }
    }
}