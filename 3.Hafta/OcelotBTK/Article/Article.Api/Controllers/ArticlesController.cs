using Article.Api.Repositories;
using Article.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepositroy _articleRepository;

        public ArticlesController(IArticleRepositroy _articleRepository)
        {
            this._articleRepository = _articleRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_articleRepository.GetAll());//tüm makaleleri json dönecek

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var detailArticle = _articleRepository.Get(id);
            if (detailArticle is null)
            {
                return NotFound(); // ilgili detay kayıt bulunamadı
            }
            return Ok(detailArticle);//200 kodu döner select * from Article wher Id=id
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var silinecekArticle = _articleRepository.Delete(id);
            if (silinecekArticle == 0)
                return NotFound(); // 404
            return NoContent();
        }
    }
}
