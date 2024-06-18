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
    public interface IStyleMasterRepository
    {

        List<GetStyleMasterData_Result> GetStyleMaster();

        List<LookUp> Getwithid(int id);
        List<TypeCdDmt> GetwithidTypecddmt(int id);

        ValueDataResponse<StyleMaster> Addupdatestylemaster(StyleMaster style);

        List<Getseasonwithid_Result> Getseasonwithid(int id);

        List<Getgarmenttypewithid_Result> Getgarmenttypewithid(int id);

        List<GetSampletypewithid_Result> GetSampletypewithid(int id);

        List<GetOrdertypewithid_Result> GetOrdertypewithid(int id);
        List<Garmentprocesswithid_Result> Garmentprocesswithid(int id);

        ValueDataResponse<StyleMaster> DeletStyleMaster(int id);


    }
}
