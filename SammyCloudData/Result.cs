using System;
using System.Collections.Generic;
using System.Text;

namespace SammyCloudData
{
    public class Result<T> where T: class
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Result()
        {
            Success = false;
        }

        public Result(T data)
        {
            Success = true;
            Data = data;
            Message = "OK";
        }

        public Result(Exception ex)
        {
            Message = ex.ToString();
            Success = false;
        }
    }
}
