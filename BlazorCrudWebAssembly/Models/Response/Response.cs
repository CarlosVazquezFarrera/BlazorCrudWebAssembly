using System.Net;

namespace BlazorCrudWebAssembly.Models.Response
{
    public class Response<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }
    }
}
