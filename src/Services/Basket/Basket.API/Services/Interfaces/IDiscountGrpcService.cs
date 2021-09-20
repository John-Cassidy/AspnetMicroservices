using Discount.Grpc.Protos;
using System.Threading.Tasks;

namespace Basket.API.Services.Interfaces {
    public interface IDiscountGrpcService {
        Task<CouponModel> GetDiscount(string productName);
    }
}
