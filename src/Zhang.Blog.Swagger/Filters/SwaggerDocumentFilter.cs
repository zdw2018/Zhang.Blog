﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace Zhang.Blog.Swagger.Filters
{
    public class SwaggerDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var tags = new List<OpenApiTag>
           {
               new OpenApiTag
               {
                   Name="Bolg",
                   Description="个人博客相关接口",
                   ExternalDocs=new OpenApiExternalDocs{  Description="包含：文章/标签/分类/友链"}
               },

               new OpenApiTag
               {
                   Name="HelloWorld",
                   Description="通用公共接口",
                   ExternalDocs=new OpenApiExternalDocs{  Description="这里是一些通用公共接口"}
                },
                new OpenApiTag {
                Name = "Auth",
                Description = "JWT模式认证授权",
                ExternalDocs = new OpenApiExternalDocs { Description = "JSON Web Token" }
}             
           };
            // 按照Name升序排序
            swaggerDoc.Tags = tags.OrderBy(x => x.Name).ToList();
        }
    }
}
