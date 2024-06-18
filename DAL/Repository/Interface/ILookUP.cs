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
    public interface ILookUP
    {

        List<GetLookkupSP_Result> GetLookup();
        ValueDataResponse<LookUp> AddUpdateLookup(LookUp lookup);


        ValueDataResponse<LookUp> Deletelookup(int id);


        List<GetCountrySP_Result> GetCountry();

        ValueDataResponse<CountryCurrency> AddUpdateCountry(CountryCurrency country);

        ValueDataResponse<CountryCurrency>  DeleteCountry(int id);


        //FOR states

        List<GetState_Result> GetState();

        ValueDataResponse<StateMaster> AddUpdateState(StateMaster state);

        ValueDataResponse<StateMaster> DeleteState(int id);


    }
}
