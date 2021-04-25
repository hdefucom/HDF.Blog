using System;

namespace HDF.Blog.Model.ApiModel
{
    public class ApiResult<T>
    {
        public readonly DateTime Time = DateTime.Now;
        public string Code { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public ApiPageInfo Page { get; set; }
        public int TotalCount { get; set; }
    }

    public class ApiResult
    {
        public static ApiResult<T> Success<T>(T data)
            => new ApiResult<T>() { Success = true, Data = data };

        public static ApiResult<T> Success<T>(T data,int totalCount )
            => new ApiResult<T>() { Success = true, Data = data,TotalCount = totalCount };

        public static ApiResult<T> Fail<T>(Exception exception)
            => new ApiResult<T>() { Success = false, Message = exception.Message };

        public static ApiResult<T> Fail<T>(string message)
            => new ApiResult<T>() { Success = false, Message = message };



    }




}