using System;
using System.Collections.Generic;
using System.Text;

namespace Zhang.Blog.Domain.Shared
{
    public class ZhangBlogDbConsts
    {
        public static class DbTableName
        {
            public const string Posts = "Posts";

            public const string Categories = "Categories";

            public const string Tags = "Tags";

            public const string PostTags = "Post_Tags";

            public const string Friendlinks = "Friendlinks";
        }
    }
}
