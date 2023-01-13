using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int itemsPerPage, int totalitems, int totalPages)
        {
            CurrentPage = currentPage;
            ItemsPerPage = itemsPerPage;
            Totalitems = totalitems;
            TotalPages = totalPages;
        }

        public int CurrentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public int Totalitems { get; set; }

        public int TotalPages { get; set; }
    }
}
