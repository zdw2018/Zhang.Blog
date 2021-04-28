﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhang.Blog.ToolKits.Paged
{
    public interface IPagedList<T> : IListResult<T>, IHasTotalCount
    {
    }
}
