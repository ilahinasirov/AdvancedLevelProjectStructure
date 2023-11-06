using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiMvc.Controllers
{
    public class ProductController : Controller
    {
        
        
            private IProductService _productService;

            public ProductController(IProductService productService)
            {
                _productService = productService;
            }
            public IActionResult Index1()
            {
                var result = _productService.GetList();
                if (result.Success)
                {
                    var productList = result.Data; // Assuming result.Data is a List<Product>
                    return View(productList);
                }

                // Handle the case when the service call is not successful
                // You can return an error view or take appropriate action.
                return BadRequest(result.Message);
            }



        //[HttpGet("getall")]
            public IActionResult GetList()
            {
                var result = _productService.GetList();
                if (result.Success)
                {

                    return View(result.Data);
                }

                return BadRequest(result.Message);
            }
            [HttpGet("getlistbycategory")]
            public IActionResult GetListByCategory(int categoryId)
            {
                var result = _productService.GetByCategoryId(categoryId);
                if (result.Success)
                {
                    return Ok(result.Data);
                }

                return BadRequest(result.Message);
            }
            [HttpGet("getbyid")]
            public IActionResult GetByid(int productId)
            {
                var result = _productService.GetByid(productId);
                if (result.Success)
                {
                    return Ok(result.Data);
                }

                return BadRequest(result.Message);
            }
            [HttpPost("add")]
            public IActionResult Add(Product product)
            {
                var result = _productService.Add(product);
                if (result.Success)
                {
                    return Ok(result.Message);
                }
                return BadRequest(result.Message);
            }

            [HttpPost("update")]
            public IActionResult Update(Product product)
            {
                var result = _productService.Update(product);
                if (result.Success)
                {
                    return Ok(result.Message);
                }
                return BadRequest(result.Message);
            }
            [HttpPost("delete")]
            public IActionResult Delete(Product product)
            {


                var result = _productService.Delete(product);
                if (result.Success)
                {
                    return Ok(result.Message);
                }
                return BadRequest(result.Message);
            }


        


        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
