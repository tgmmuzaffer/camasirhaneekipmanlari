﻿namespace Web.Models.Dtos
{
    public class PagedData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        public string RouteSegment { get; set; }
    }
}
