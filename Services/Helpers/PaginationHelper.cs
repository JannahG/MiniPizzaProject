using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniPizzaProject.Services.Helpers
{
    public class PagedResult<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }

    public static class PaginationHelper
    {
        public static PagedResult<T> GetPaged<T>(IQueryable<T> source, PaginationParameters paginationParameters)
        {
            var totalCount = source.Count();
            var items = source.Skip((paginationParameters.PageNumber - 1) * paginationParameters.PageSize)
                .Take(paginationParameters.PageSize)
                .ToList();

            return new PagedResult<T>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = paginationParameters.PageNumber,
                PageSize = paginationParameters.PageSize
            };
        }
    }
}