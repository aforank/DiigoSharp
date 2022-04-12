using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiigoSharp.ApiClient
{
    public interface IDiigoClient
    {
        public Task<BookmarksCollection> GetBookmarks(SearchParameters parameters);

        public Task<SaveBookmarkResponse> SaveBookmark(Bookmark bookmark);
    }
}
