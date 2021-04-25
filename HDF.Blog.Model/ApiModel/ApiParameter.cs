using System;

namespace HDF.Blog.Model.ApiModel
{

    public class ApiParameter<T>
    {
        public readonly DateTime Time = DateTime.Now;

        public T Parameter { get; set; }


        public ApiPageInfo Page { get; set; }
    }







}