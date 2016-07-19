using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DemoMVC5.Modules
{
    public class TimingModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
            context.EndRequest += context_EndRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            if (IsHtml())
            {
                var sw = new Stopwatch();
                HttpContext.Current.Items["sw"] = sw;
                sw.Start();
            }
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            if (IsHtml())
            {
                var sw = (Stopwatch)HttpContext.Current.Items["sw"];
                sw.Stop();
                var msg = string.Format("Esta reqiosoção demorou {0} milisegundos para ser executada... E sua url é {1}", 
                    sw.ElapsedMilliseconds, 
                    HttpContext.Current.Request.Url);
                HttpContext.Current.Response.Write(msg);
            }
        }

        private bool IsHtml() {
            return HttpContext.Current.Response.ContentType == "text/html";
        }
    }
}