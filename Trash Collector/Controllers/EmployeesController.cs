﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trash_Collector.Data;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Employees
        public async Task<IActionResult> Index(string filterDay)
        {
            ////Finding the id of the currently logged in employee, and holding it in a variable.
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            //If the user is new, redirects to Create page, so they can get an IdentityUserID
            var employeeLoggedIn = _context.Employee.Where(e => e.IdentityUserID == userId).SingleOrDefault();
            if(employeeLoggedIn == null)
            {
                return RedirectToAction("Create");
            }

            //Finding the zipcode that matched the employee's zipcode to a list of employees in that zipcode.
            var customerInZipCode = _context.Customer.Where(c => c.ZipCode == employeeLoggedIn.ZipCode).ToList();
            if (filterDay == null)
            {
                var today = DateTime.Now.DayOfWeek.ToString();
                var todaysCustomersInZip = customerInZipCode.Where(c => c.PickupDay == today).ToList();
                return View(todaysCustomersInZip);
            }
            else
            {               
                //Matching the customer pickup day to the current day              
                var todaysCustomersInZip = customerInZipCode.Where(c => c.PickupDay == filterDay).ToList();
                return View(todaysCustomersInZip);
            }

            //Check if customer has suspended service
            //var customersWithService = todaysCustomersInZip.Where(c => c.StartDateEndOfPickups >= today)

            //Check if customer has extra pickup day
            //var extraPickup = _context.Customer.Where(c => c.ExtraPickup == today).SingleOrDefault();
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //Finds the customer for the details page, and puts in a variable.
            var customerToConvert = _context.Customer.Where(c => c.Id == id).SingleOrDefault();
           
            //Stores the address in a variable
            string customerAddress = customerToConvert.Address;

            //Replaced the spaces in the address to '+' so geocode can take it in.
            string fixedAddress = customerAddress.Replace(" ", "+");
               
            //Sets up httpClient, and inputs address into geocode API
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://maps.googleapis.com/maps/api/geocode/json?address= + {fixedAddress} + &key={KeysAPI.mapsKey}");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject(json);
                var details = JObject.Parse(json);

                //Stores lat/lng data to the specific cutomer object
                double latitude = (double)details.SelectToken("results[0].geometry.bounds.northeast.lat");
                double longitude = (double)details.SelectToken("results[0].geometry.bounds.northeast.lng");
                customerToConvert.Latitude = latitude;
                customerToConvert.Longitude = longitude;
                _context.Update(customerToConvert);
                _context.SaveChanges();
            }

            //Customer object is the same as above, with different variable names.  
            //Kept seperate in case anything needs change.
            //This displays the view.
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,ZipCode,IdentityUserID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                
                if (employee.Id == 0)
                {
                    employee.IdentityUserID = userId;
                    _context.Add(employee);
                    _context.SaveChanges();
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);          
        }
        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Customer customer)//[Bind("Id,FirstName,LastName,ZipCode")] Can add back later
        {
            if (id != customer.Id)
            {
                return NotFound();
            }          
            if (ModelState.IsValid)
            {               
                try
                {
                    if(customer.TrashCollected == true)
                    {
                        customer.MoneyOwed = 20;
                    }
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(customer.Id))
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
            return View(customer);
        }
        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
                
