﻿using Payments.Util.Validations;
using System.ComponentModel.DataAnnotations;

namespace Payments.Wechatpay.Parameters.Requests
{
    /// <summary>
    /// 查询红包记录服务
    /// </summary>
    public class WechatpayHbInfoRequest : Validation, IWechatpayRequest, IValidation
    {
        /// <summary>
        /// 商户订单号 
        /// </summary>
        [Required]
        [MaxLength(28)]
        public virtual string MchBillNo { get; set; }


    }
}
