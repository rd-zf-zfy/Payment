﻿using Microsoft.Extensions.Logging;
using Payments.Core.Response;
using Payments.Util;
using Payments.Wechatpay.Abstractions;
using Payments.Wechatpay.Configs;
using Payments.Wechatpay.Parameters;
using Payments.Wechatpay.Parameters.Requests;
using Payments.Wechatpay.Parameters.Response;
using Payments.Wechatpay.Results;
using Payments.Wechatpay.Services.Base;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Payments.Wechatpay.Services
{

    /// <summary>
    /// 微信Native支付服务
    /// </summary>
    public class WechatpayNativePayService : WechatpayServiceBase, IWechatpayNativePayService
    {
        /// <summary>
        /// 初始化微信App支付服务
        /// </summary>
        /// <param name="provider">微信支付配置提供器</param>
        public WechatpayNativePayService(IWechatpayConfigProvider configProvider, IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory) : base(configProvider, httpClientFactory, loggerFactory)
        {
        }

        /// <summary>
        /// 支付
        /// </summary>
        /// <param name="request">支付参数</param>
        public Task<WechatpayResult<WechatpayNativePayResponse>> PayAsync(WechatpayNativePayRequest request)
        {
            return base.PayAsync<WechatpayNativePayResponse>(request);
        }



        /// <summary>
        /// 获取交易类型
        /// </summary>
        protected override string GetTradeType()
        {
            return "NATIVE";
        }

    
    }
}
