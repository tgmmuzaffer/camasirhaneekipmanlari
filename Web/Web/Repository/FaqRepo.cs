using System.Net.Http;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class FaqRepo : BaseRepo<Faq>, IFaqRepo
    {
        public FaqRepo(IHttpClientFactory clientFactory): base(clientFactory)
        {

        }
    }
}
