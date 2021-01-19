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
        private string _searchBoxText;
        private List<SelectListItem> _sortItemsList;
        private string _sortBy;
        private int _productCategoryId;

        public ProductsController(DatabaseContext context)
        {
            _context = context;

            _searchBoxText = "";
            _sortBy = "0";
            _productCategoryId = -1;

            _sortItemsList = new List<SelectListItem>();
            CreateSortItemsList();
            SelectSortItem(_sortItemsList, _sortBy);
        }

        public async Task<IActionResult> Index()
        {
            System.Diagnostics.Debug.WriteLine($"Index: {_productCategoryId}, {_searchBoxText}, {_sortBy}");
            ViewBag.SearchBoxText = _searchBoxText;

            SelectSortItem(_sortItemsList, _sortBy);
            ViewBag.SelectedSortItem = _sortBy;
            ViewBag.SortByList = _sortItemsList;

            ViewBag.SelectedProductCategory = _productCategoryId;
            ViewBag.ProductCategories = _context.ProductCategory.ToList();

            List<Models.Product> products = await _context.Product.ToListAsync();

            if (_searchBoxText != null && _searchBoxText.Length > 0)
                products = products.Where(x => x.Name.Contains(_searchBoxText)).ToList();

            if (_productCategoryId >= 0 && _productCategoryId <= _context.ProductCategory.Count())
                products = products.Where(x => x.ProductCategoryId == _productCategoryId).ToList();

            products = SortProducts(products, _sortBy);

            return View("Index", products);
        }

        public Task<IActionResult> Category(int id, string searchbox, string sortby)
        {
            _productCategoryId = id;
            _searchBoxText = searchbox;
            _sortBy = sortby;
            System.Diagnostics.Debug.WriteLine($"Category: {id}, {searchbox}, {sortby}");
            return Index();
        }

        public Task<IActionResult> Filter(int categoryid, string search_box, string sort_by)
        {
            _productCategoryId = categoryid;
            _searchBoxText = search_box;
            _sortBy = sort_by;
            System.Diagnostics.Debug.WriteLine($"Filter: {search_box}, {sort_by}");
            return Index();
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
    }
}
