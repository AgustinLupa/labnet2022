using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.TP8.API.Models
{
    public class Result
    {
        public Result()
        {
            successful = false;
            message = "";
        }

        public Result(string message)
        {
            this.message = message;
        }

        public Result(bool successful, string message, object response)
        {
            this.successful = successful;
            this.message = message;
            this.response = response;
        }

        public bool successful { get; set; }
        public string message { get; set; }
        public object response { get; set; }
    }
}