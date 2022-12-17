using Discount.API.Entities;
using System.Threading.Tasks;

namespace Discount.API.Repositories
{
    public interface IDiscountRepository
    {
        public Task<Coupon> GetDiscount(string productName);
        public Task<bool> CreateDiscount(Coupon coupon);
        public Task<bool> UpdateDiscount(Coupon coupon);
        public Task<bool> DeleteDiscount(string productName);
    }
}
