using System.Net.Http;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class BlogRepo: BaseRepo<Blog>, IBlogRepo
    {
        public BlogRepo(IHttpClientFactory clientFactory):base(clientFactory)
        {

        }
    }
}
