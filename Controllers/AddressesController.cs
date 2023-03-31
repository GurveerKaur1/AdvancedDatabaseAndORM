using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvancedDatabaseAndORM.Data;
using AdvancedDatabaseAndORM.Models;
using AdvancedDatabaseAndORM.Models.ViewModel;

namespace AdvancedDatabaseAndORM.Controllers
{
    public class AddressesController : Controller
    {
        private readonly AdvancedDatabaseAndORMContext _context;

        public AddressesController(AdvancedDatabaseAndORMContext context)
        {
            _context = context;
        }

        // GET: Addresses
        public IActionResult Index()
        {
              return View("View",_context.Address.ToList());
        }

        public IActionResult View()
        {
           return View("Index");
        }

        public IActionResult CompareAddress()
        {
            
            
                CompareAdrressVM compare = new CompareAdrressVM(_context.Customer, _context.Address);
                return View(compare);
        }

        [HttpPost]
        public IActionResult CompareAddress(CompareAdrressVM vm) 
        {
            Address address = _context.Address.First(m => m.Id == Int32.Parse(vm.addressId1));
            Customer customer3 = _context.Customer.First(c => c.Id== Int32.Parse(vm.customerId1));

            return RedirectToAction("CompareAddress");
        }

        // GET: Addresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Address == null)
            {
                return NotFound();
            }

            var address = await _context.Address
                .FirstOrDefaultAsync(m => m.Id == id);
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // GET: Addresses/Create


        // POST: Addresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AddressLine1,AddressLine2,City,StateProvince,CountryRegion,PostalCode,rowguid,ModifiedDate")] Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Add(address);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(address);
        }

        // GET: Addresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Address == null)
            {
                return NotFound();
            }

            var address = await _context.Address.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }
            return View(address);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AddressLine1,AddressLine2,City,StateProvince,CountryRegion,PostalCode,rowguid,ModifiedDate")] Address address)
        {
            if (id != address.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(address);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressExists(address.Id))
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
            return View(address);
        }

        // GET: Addresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Address == null)
            {
                return NotFound();
            }

            var address = await _context.Address
                .FirstOrDefaultAsync(m => m.Id == id);
            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Address == null)
            {
                return Problem("Entity set 'AdvancedDatabaseAndORMContext.Address'  is null.");
            }
            var address = await _context.Address.FindAsync(id);
            if (address != null)
            {
                _context.Address.Remove(address);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressExists(int id)
        {
          return _context.Address.Any(e => e.Id == id);
        }
    }
}
