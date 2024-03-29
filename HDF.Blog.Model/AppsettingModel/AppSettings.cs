﻿using System.Collections.Generic;

namespace HDF.Blog.Model.AppsettingModel
{
    /// <summary>
    /// 系统设置映射实体 
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public Dictionary<string, string> ConnectionStrings { get; set; }

        /// <summary>
        /// Token配置
        /// </summary>
        public TokenConfig TokenConfig { get; set; }
        /// <summary>
        /// 跨域配置
        /// </summary>
        public CorsConfig CorsConfig { get; set; }

        /// <summary>
        /// 是否使用SPAd代理
        /// </summary>
        public SpaConfig SpaConfig { get; set; }


    }


}