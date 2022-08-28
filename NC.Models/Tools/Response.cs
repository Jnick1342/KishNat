using Newtonsoft.Json;
using System;

namespace NC.Models.Tools
{
    public class Response
    {
        public Response()
        {

        }

        public Response(Exception exp)
        {
            Exception = exp;
        }

        [JsonIgnore]
        public Exception Exception { get; private set; }
        public string ErrorMessage => Exception?.Message;
        public bool Success => string.IsNullOrEmpty(ErrorMessage);
    }

    public class Response<T> : Response
    {


        public Response()
        {

        }

        public Response(Exception exp) : base(exp)
        {

        }

        public Response(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
