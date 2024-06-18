using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL.FabricDesign.edmx;
using DAL.Responses;
namespace DAL.Repository.Interface
{
    public interface IBuyer
    {
        List<GetBuyer_Result> GetBuyerList();

        ValueDataResponse<Buyer> AddupdateBuyer(Buyer buyer);

        ValueDataResponse<Buyer> DeleteBuyer(int id);

    }
}
