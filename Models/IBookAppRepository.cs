using System;
using System.Linq;

namespace BookApp.Models
{
    public interface IBookAppRepository
    {
        IQueryable<Book> Books { get; }
    }
}
