﻿// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Newtonsoft.Json;

namespace EInfrastructure.Core.AspNetCore.Api
{
    /// <summary>
    /// 异常响应信息
    /// </summary>
    public class ApiErrResult
    {
        /// <summary>
        /// 异常响应信息
        /// </summary>
        public ApiErrResult()
        {
        }

        /// <summary>
        /// 异常响应信息
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="msg">错误信息</param>
        public ApiErrResult(int code, string msg, object extend = null)
        {
            this.Msg = msg;
            this.Code = code;
            this.Extend = extend;
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty(PropertyName = "msg")]
        public virtual string Msg { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public virtual int Code { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty(PropertyName = "extend",DefaultValueHandling = DefaultValueHandling.Ignore)]
        public virtual object Extend { get; set; }
    }
}