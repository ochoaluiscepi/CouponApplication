using Mango.Services.CouponAPI.Models;
using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCoupon(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(Coupon coupon);
        Task<ResponseDto?> UpdateCouponsAsync(Coupon coupon);
        Task<ResponseDto?> DeleteCouponsAsync(int id);
    }
}
