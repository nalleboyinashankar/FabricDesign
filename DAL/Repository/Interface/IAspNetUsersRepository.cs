using DAL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL.FabricDesign.edmx;
using System.Net.Http;

namespace DAL.Repository.Interface
{
    public interface IAspNetUsersRepository
    {
        ValueDataResponse<AspNetUser> CreateUser(AspNetUser user);


        List<SP_GetUsers_Result> GetUsersThroughSP();

        List<GetLookkupSP_Result> GetLookkupSP();

        ValueDataResponse<LookUp> AddUpdateLookup(LookUp lookup);

        List<FactoryList> GetFactoryLists();
        List<TypeCdDmt> GetTypeCdDmt();


        ValueDataResponse<AspNetUser> Deleteuser(string  id);




    }
}
