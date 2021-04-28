using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhang.Blog.Domain.Configuration;
using Zhang.Blog.Domain.Shared;
using Zhang.Blog.Swagger.Filters;

namespace Zhang.Blog.Swagger
{
    public static class ZhangBlogSwaggerExtensions
    {
        /// <summary>
        /// 当前API版本，从appsettings.json获取
        /// </summary>
        private static readonly string version = $"v{AppSettings.ApiVersion}";

        /// <summary>
        /// Swagger描述信息
        /// </summary>
        private static readonly string description = @"<b>Blog</b>：<a target=""_blank"" href=""https://xxx.com"">https://xxx.com</a> <b>GitHub</b>：<a target=""_blank"" href=""https://github.com/zdw2018/Zhang.Blog/"">https://github.com/zdw2018/Zhang.Blog/</a> <b>Hangfire</b>：<a target=""_blank"" href=""/hangfire"">任务调度中心</a> <code>Powered by .NET Core 5.0 on Linux</code>";

        internal class SwaggerApiInfo
        {
            /// <summary>
            /// URL前缀
            /// </summary>
            public string UrlPrefix { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// <see cref="Microsoft.OpenApi.Models.OpenApiInfo"/>
            /// </summary>
            public OpenApiInfo OpenApiInfo { get; set; }
        }

        private static readonly List<SwaggerApiInfo> ApiInfos = new List<SwaggerApiInfo> {


        new SwaggerApiInfo
        {
             UrlPrefix=Grouping.GroupName_v1,
             Name="博客前台接口",
              OpenApiInfo=new OpenApiInfo
              {
                   Version=version,
                    Title="Zhang-博客前台接口",
                    Description=description
              }

        },
                  new SwaggerApiInfo
        {
             UrlPrefix=Grouping.GroupName_v2,
             Name="博客后台接口",
              OpenApiInfo=new OpenApiInfo
              {
                   Version=version,
                    Title="Zhang-博客后台接口",
                    Description=description
              }

        },
                       new SwaggerApiInfo
        {
             UrlPrefix=Grouping.GroupName_v3,
             Name="通用公共接口",
              OpenApiInfo=new OpenApiInfo
              {
                   Version=version,
                    Title="Zhang-通用公共接口",
                    Description=description
              }

        },

      new SwaggerApiInfo
        {
             UrlPrefix=Grouping.GroupName_v4,
             Name="JWT鉴权接口",
              OpenApiInfo=new OpenApiInfo
              {
                   Version=version,
                    Title="Zhang-JWT鉴权接口",
                    Description=description
              }

        },



        };
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(options =>
            {
                //options.SwaggerDoc("v1", new OpenApiInfo
                //{
                //    Version = "1.0.0",
                //    Title = "我的接口啊",
                //    Description = "接口描述"

                //});

                var security = new OpenApiSecurityScheme
                {
                    Description = "JWT模式授权，请输入 Bearer {Token} 进行身份验证",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                };
                options.AddSecurityDefinition("oauth2", security);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement { { security, new List<string>() } });
                options.OperationFilter<AddResponseHeadersFilter>();
                options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                options.OperationFilter<SecurityRequirementsOperationFilter>();

                ApiInfos.ForEach(x => { options.SwaggerDoc(x.UrlPrefix, x.OpenApiInfo); });
                // 应用Controller的API文档描述信息
                options.DocumentFilter<SwaggerDocumentFilter>();


                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Zhang.Blog.HttpApi.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Zhang.Blog.Domain.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Zhang.Blog.Application.Contracts.xml"));
            });
        }

        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            //app.UseSwaggerUI(options =>
            //{
            //    options.SwaggerEndpoint($"/swagger/v1/swagger.json", "默认接口");
            //});
            app.UseSwaggerUI(options =>
            {
                ApiInfos.ForEach(x => { options.SwaggerEndpoint($"/swagger/{x.UrlPrefix}/swagger.json", x.Name); });
                // 模型的默认扩展深度，设置为 -1 完全隐藏模型
                options.DefaultModelsExpandDepth(-1);
                // API文档仅展开标记
                options.DocExpansion(DocExpansion.List);
                // API前缀设置为空
                options.RoutePrefix = string.Empty;
                // API页面Title
                options.DocumentTitle = "😍接口文档 - Zhang⭐⭐⭐";
            });


        }
    }
}
