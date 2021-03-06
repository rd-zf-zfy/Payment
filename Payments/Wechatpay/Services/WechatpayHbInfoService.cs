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
    /// 查询红包记录服务
    /// </summary>
    public class WechatpayHbInfoService : WechatpayServiceBase<WechatpayHbInfoRequest>, IWechatpayHbInfoService
    {      
        /// <summary>
            /// 初始化微信App支付服务
            /// </summary>
            /// <param name="provider">微信支付配置提供器</param>
        public WechatpayHbInfoService(IWechatpayConfigProvider configProvider, IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory) : base(configProvider, httpClientFactory, loggerFactory)
        {

        }

        public Task<WechatpayResult<WechatpayHbInfoResponse>> Query(WechatpayHbInfoRequest request)
        {
            return Request<WechatpayHbInfoResponse>(request);
        }

        protected override string GetRequestUrl(WechatpayConfig config)
        {
            return config.GetGethbinfoUrl();
        }

        protected override void InitBuilder(WechatpayParameterBuilder builder, WechatpayHbInfoRequest param)
        {
            builder.Remove(WechatpayConst.AppId).Remove(WechatpayConst.SignType)
                     .Remove(WechatpayConst.SpbillCreateIp)
                                    .Add(WechatpayConst.WxAppid, Config.AppId).Add(WechatpayConst.ClientIp, Server.GetLanIp())
               .Add(WechatpayConst.MchBillNo, param.MchBillNo);
        }
    }
}
