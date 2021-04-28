using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhang.Blog.Application.HelloWorld.Ipml
{
    public class HelloWorldService : ZhangBlogApplicationServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hellow World";
        }
    }
}
