using E_Spożywczak.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Spożywczak.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;
        private List<SelectListItem> _sortItemsList;

        public ProductsController(DatabaseContext context)
        {
            _context = context;

            _sortItemsList = new List<SelectListItem>();
            CreateSortItemsList();
        }

        public async Task<IActionResult> Index()
        {
            return await Filter(-1, "", "0");
        }

        public async Task<IActionResult> Filter(int categoryid, string searchbox, string sortby)
        {
            ViewBag.SearchBoxText = searchbox;

            SelectSortItem(_sortItemsList, sortby);
            ViewBag.SelectedSortItem = sortby;
            ViewBag.SortByList = _sortItemsList;

            ViewBag.SelectedProductCategory = categoryid;
            ViewBag.ProductCategories = _context.ProductCategory.ToList();

            List<Models.Product> products = await _context.Product.ToListAsync();

            if (searchbox != null && searchbox.Length > 0)
                products = products.Where(x => x.Name.Contains(searchbox)).ToList();

            if (categoryid >= 0 && categoryid <= _context.ProductCategory.Count())
                products = products.Where(x => x.ProductCategoryId == categoryid).ToList();

            products = SortProducts(products, sortby);
            return View("Index", products);
        }

        private void CreateSortItemsList()
        {
            _sortItemsList.Add(new SelectListItem { Text = "Sortuj po nazwie rosnąco", Value = "0" });
            _sortItemsList.Add(new SelectListItem { Text = "Sortuj po nazwie malejąco", Value = "1" });
            _sortItemsList.Add(new SelectListItem { Text = "Sortuj po cenie rosnąco", Value = "2" });
            _sortItemsList.Add(new SelectListItem { Text = "Sortuj po cenie malejąco", Value = "3" });
        }

        private void SelectSortItem(List<SelectListItem> sortItemsList, string sortBy)
        {
            foreach (SelectListItem item in sortItemsList)
            {
                if (item.Value == sortBy)
                    item.Selected = true;
                else
                    item.Selected = false;
            }
        }

        private List<Models.Product> SortProducts(List<Models.Product> products, string sortBy)
        {
            if (sortBy == "1")
                return products.OrderByDescending(x => x.Name).ToList();
            else if (sortBy == "2")
                return products.OrderBy(x => x.Price).ToList();
            else if (sortBy == "3")
                return products.OrderByDescending(x => x.Price).ToList();
            else
                return products.OrderBy(x => x.Name).ToList();
        }

        private async void CountRatingAverage(int? id)
        {

            var ratings = await _context.Rating
                                .Select(r => r).Where(r => id == r.ProductId).ToListAsync();
            int sum = 0;
            foreach(Models.Rating rate in ratings)
            {
                sum += rate.Rate/2;
            }
            double avgRating = sum / ratings.Count;
            ViewBag.AvgProductRating = avgRating;
            ViewBag.RatingsCount = ratings.Count;
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(a => a.ProductCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            ///// RATINGS

            var ratings = await _context.Rating
                                .Select(r => r).Where(r => id == r.ProductId).OrderByDescending(r => r.RatingDate).ToListAsync();
            int sum = 0;
            List<(double, string, DateTime)> rateAndComments = new List<(double, string, DateTime)>();
            foreach (Models.Rating rate in ratings)
            {
                sum += (rate.Rate / 2);
                rateAndComments.Add((rate.Rate/2, rate.Message, rate.RatingDate));
            }

            double avgRating = (double)sum / (double)ratings.Count;

            if(ratings.Count > 0)
                ViewBag.AvgProductRating = avgRating;
            else
            {
                ViewBag.AvgProductRating = 0;
            }
            ViewBag.RatingsCount = ratings.Count;
            ViewBag.RatesAndComments = rateAndComments;

            ////////////////////////////////////////

            if (product.Availability < 3)
                ViewData["Details availability"] = "Low";
            else
                ViewData["Details availability "] = "High";
            return View(product);
        }
    }
}
