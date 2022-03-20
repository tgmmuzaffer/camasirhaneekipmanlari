﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class ContactRepo : BaseRepo<Contact>, IContactRepo
    {
        public ContactRepo(IHttpClientFactory clientFactory):base(clientFactory)
        {

        }
    }
}