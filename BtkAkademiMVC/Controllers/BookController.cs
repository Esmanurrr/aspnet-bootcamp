using BtkAkademiMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Text;

namespace BtkAkademiMVC.Controllers
{
    public class BookController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Book> bookList = new List<Book>();
            using (var httpClient = new HttpClient())
            {
                using(var response = await httpClient.GetAsync("https://localhost:7258/api/Books"))
                {
                    var gelenStirng = await response.Content.ReadAsStringAsync();
                    bookList = JsonConvert.DeserializeObject<List<Book>>(gelenStirng);
                }
            }
                return View(bookList);
        }

        public async Task<IActionResult> GetDetails(int id)
        {
            Book bookDetail = new Book();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7258/api/Books"+id))
                {
                    var gelenString = await response.Content.ReadAsStringAsync();
                    bookDetail = JsonConvert.DeserializeObject<Book>(gelenString);
                }
            }
                return View(bookDetail);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            Book newBook = new Book();
            using (var httpClient = new HttpClient())
            {
                StringContent serializedBook = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:7258/api/Books",serializedBook))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                    newBook = JsonConvert.DeserializeObject<Book>(gelenString);
                }
            }
                return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update()
        {
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id)
        {
            Book bookJson = new Book() ;
            using (var httpClient = new HttpClient())
            {
                StringContent bookContent = new StringContent(JsonConvert.SerializeObject(bookJson), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:7258/api/Books"+id, bookContent))
                {
                    string gelenString = await response.Content.ReadAsStringAsync();
                    bookJson = JsonConvert.DeserializeObject<Book>(gelenString);
                }

            }
            return RedirectToAction("Index");
        }


    }
}
