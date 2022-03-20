using System.Net.Http;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class ReferanceRepo : BaseRepo<Referance>, IReferanceRepo
    {
        public ReferanceRepo(IHttpClientFactory clientFactory):base(clientFactory)
        { 

        }
    }
}
