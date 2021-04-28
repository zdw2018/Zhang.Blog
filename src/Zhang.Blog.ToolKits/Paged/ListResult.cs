using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhang.Blog.ToolKits.Paged
{
    public class ListResult<T> : IListResult<T>
    {
        public ListResult()
        {

        }
        public ListResult(IReadOnlyList<T> item)
        {
            Item = item;
        }
        IReadOnlyList<T> item;
        public IReadOnlyList<T> Item
        {
            get => item ?? (item = new List<T>());
            set => item = value;
        }
    }
}
