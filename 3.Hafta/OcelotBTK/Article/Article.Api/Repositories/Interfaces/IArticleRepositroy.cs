namespace Article.Api.Repositories.Interfaces
{
    public interface IArticleRepositroy
    {
        List<Models.Article> GetAll();
        Models.Article? Get(int id);
        int Delete(int id);
    }
}
