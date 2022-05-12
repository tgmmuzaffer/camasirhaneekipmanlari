using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class IndustryRepo : BaseRepo<IndustryDto>, IIndustryRepo
    {
        public IndustryRepo(IHttpClientFactory clientFactory) : base(clientFactory)
        {
        }
    }
}
