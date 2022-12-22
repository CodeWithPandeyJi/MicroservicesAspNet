﻿using Discount.Grpc.Protos;
using System;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoServiceClient;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoServiceClient)
        {
            _discountProtoServiceClient = discountProtoServiceClient ?? throw new ArgumentNullException(nameof(discountProtoServiceClient));
            
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };

            var discount = await _discountProtoServiceClient.GetDiscountAsync(discountRequest);
            return discount;
        }


        

    }
}
