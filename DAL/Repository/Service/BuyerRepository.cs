using DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.FabricDesign.edmx;
using DAL.Responses;
namespace DAL.Repository.Service
{
    public class BuyerRepository :IBuyer
    {
        Fabric_DesignEntities1 context = new Fabric_DesignEntities1();


        public List<GetBuyer_Result> GetBuyerList()
        {
            
                var result = context.GetBuyer().ToList();
                return result;
        }

        public ValueDataResponse<Buyer> AddupdateBuyer(Buyer buyer)
        {
            ValueDataResponse<Buyer> response = new ValueDataResponse<Buyer>();

            try
            {
                var existingdata = context.Buyers.FirstOrDefault(s => s.Id == buyer.Id);

                if (existingdata == null)
                {
                    var obj = new Buyer()
                    {

                       BuyerName = buyer.BuyerName,
                       Countryid = buyer.Countryid,
                       CreatedBy = buyer.CreatedBy,
                       UpdatedBy= buyer.UpdatedBy,
                       CreatedDate = DateTime.Now,
                       IsActive = true,
                       UpdatedDate = DateTime.Now,
                       BuyingHouseId = buyer.BuyingHouseId,
                       CommissionTypeId = buyer.CommissionTypeId,
                       CommissionPercentage = buyer.CommissionPercentage,



                    };
                    context.Buyers.Add(obj);
                    context.SaveChanges();
                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Add successfully";
                }
                else
                {

                    existingdata.BuyerName = buyer.BuyerName;
                    existingdata.Countryid = buyer.Countryid;
                    existingdata.CreatedBy = existingdata.CreatedBy;
                    existingdata.UpdatedBy = buyer.UpdatedBy;
                    existingdata.CreatedDate = existingdata.CreatedDate;
                    existingdata.IsActive = true;
                    existingdata.UpdatedDate = DateTime.Now;
                    existingdata.BuyingHouseId = buyer.BuyingHouseId;
                    existingdata.CommissionTypeId = buyer.CommissionTypeId;
                    existingdata.CommissionPercentage = buyer.CommissionPercentage;
                    context.SaveChanges();
                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Updated successfully";
                }

            }

            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.EndUserMessage = "Data failed add or update successfully:" + ex;
            }
            return response;
        }


        public ValueDataResponse<Buyer> DeleteBuyer(int id)
        {
            ValueDataResponse<Buyer> response = new ValueDataResponse<Buyer>();

            try
            {
                var res = context.Buyers.Where(s => s.Id == id).FirstOrDefault();

                if (res != null)
                {
                    res.IsActive = false;
                    res.UpdatedDate = DateTime.Now;

                    context.SaveChanges();

                    response.IsSuccess = true;
                    response.EndUserMessage = "Data deleted successfully";
                }
                else
                {

                    response.IsSuccess = false;
                    response.EndUserMessage = "User Not Found";
                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.EndUserMessage = "Data failed to delete:" + ex;
            }
            return response;
        }


    }
}
