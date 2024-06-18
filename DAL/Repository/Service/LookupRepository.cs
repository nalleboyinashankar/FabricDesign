using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL.FabricDesign.edmx;
using DAL.Repository.Interface;
using DAL.Responses;

namespace DAL.Repository.Service
{
    public class LookupRepository : ILookUP
    {
        Fabric_DesignEntities1 context = new Fabric_DesignEntities1();

        public ValueDataResponse<LookUp> AddUpdateLookup(LookUp lookup)
        {
            ValueDataResponse<LookUp> response = new ValueDataResponse<LookUp>();

            try
            {
                var existingdata = context.LookUps.FirstOrDefault(s => s.Id == lookup.Id);

                if (existingdata == null)
                {
                    var obj = new LookUp()
                    {

                        Id = lookup.Id,
                        LookUpId = lookup.LookUpId,
                        Name = lookup.Name,
                        Remarks = lookup.Remarks,
                        IsActive =true,
                        CreatedByUserId = lookup.CreatedByUserId,
                        CreatedDate = DateTime.Now,
                        UpdatedByUserId = lookup.UpdatedByUserId,
                        UpdatedDate = DateTime.Now

                    };
                    context.LookUps.Add(obj);
                    context.SaveChanges();
                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Add successfully";
                }
                else
                {
                    existingdata.LookUpId = lookup.Id;
                    existingdata.Name = lookup.Name;
                    existingdata.Remarks = lookup.Remarks;
                    existingdata.IsActive = lookup.IsActive;
                    existingdata.CreatedByUserId = lookup.CreatedByUserId;
                    existingdata.CreatedDate = existingdata.CreatedDate;
                    existingdata.UpdatedByUserId = lookup.UpdatedByUserId;
                    existingdata.UpdatedDate = DateTime.Now;

                    context.SaveChanges();
                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Updated successfully";
                }

            }

            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.EndUserMessage = "Data failed add or update successfully:" + ex;
            }
            return response;

        }

     


        public List<GetLookkupSP_Result> GetLookup()
        {
            var result = context.GetLookkupSP().ToList();
            return result;  
        }



        public ValueDataResponse<LookUp> Deletelookup(int id)
        {
            ValueDataResponse<LookUp> response = new ValueDataResponse<LookUp>();

            try
            {
                var res = context.LookUps.Where(s => s.Id == id).FirstOrDefault();

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


        //for country table

        public List<GetCountrySP_Result> GetCountry()
        {
            var result = context.GetCountrySP().ToList();
            return result;
        }

        public ValueDataResponse<CountryCurrency> AddUpdateCountry(CountryCurrency country)
        {
            ValueDataResponse<CountryCurrency> response = new ValueDataResponse<CountryCurrency>();

            try
            {
                var existingdata = context.CountryCurrencies.FirstOrDefault(s => s.CountryId == country.CountryId);

                if (existingdata == null)
                {
                    var obj = new CountryCurrency()
                    {

                        CountryName = country.CountryName,
                        CountryCode = country.CountryCode,
                        CurrencyType = country.CurrencyType,
                        ConversionRate = country.ConversionRate,
                        IsActive =true,
                        CreatedByUserId = country.CreatedByUserId,
                        CreatedDate = DateTime.Now,
                        UpdatedByUserId = country.UpdatedByUserId,
                        UpdatedDate = DateTime.Now,

                    };
                    context.CountryCurrencies.Add(obj);
                    context.SaveChanges();
                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Add successfully";
                }
                else
                {
                    existingdata.CountryId = country.CountryId;
                    existingdata.CountryName = country.CountryName;
                    existingdata.CountryCode = country.CountryCode;

                    existingdata.CurrencyType = country.CurrencyType;
                    existingdata.ConversionRate = country.ConversionRate;
                    existingdata.IsActive = country.IsActive;
                    existingdata.CreatedByUserId = country.CreatedByUserId;
                    existingdata.CreatedDate = existingdata.CreatedDate;
                    existingdata.UpdatedByUserId = country.UpdatedByUserId;
                    existingdata.UpdatedDate = DateTime.Now;

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


       public  ValueDataResponse<CountryCurrency> DeleteCountry(int id)
        {
            ValueDataResponse<CountryCurrency> response = new ValueDataResponse<CountryCurrency>();

            try
            {
                var res = context.CountryCurrencies.Where(s => s.CountryId == id).FirstOrDefault();

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


        //for states


        public List<GetState_Result> GetState() 
        { 
            var result = context.GetState().ToList();
            return result;
        }


        public ValueDataResponse<StateMaster> AddUpdateState(StateMaster state)
        {
            ValueDataResponse<StateMaster> response = new ValueDataResponse<StateMaster>();

            try
            {
                var existingdata = context.StateMasters.FirstOrDefault(s => s.Id == state.Id);

                if (existingdata == null)
                {
                    var obj = new StateMaster()
                    {

                      CountryId = state.CountryId,
                      State = state.State,
                      IsActive = true,
                      CreatedByUserId = state.CreatedByUserId,
                      CreatedDate = DateTime.Now,
                      UpdatedByUserId = state.UpdatedByUserId,
                      UpdatedDate = DateTime.Now,
                        IGST = state.IGST,
                        SGST = state.SGST,
                        CGST = state.CGST,
                        Statecode = state.Statecode,

                    };
                    context.StateMasters.Add(obj);
                    context.SaveChanges();
                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Add successfully";
                }
                else
                {
                    existingdata.CountryId = state.CountryId;
                    existingdata.State = state.State;
                    existingdata.IsActive = state.IsActive;

                    existingdata.CreatedByUserId = existingdata.CreatedByUserId;
                    existingdata.CreatedDate = existingdata.CreatedDate;
                    existingdata.IsActive = state.IsActive;
                    existingdata.CreatedByUserId = state.CreatedByUserId;
                    existingdata.CreatedDate = existingdata.CreatedDate;
                    existingdata.UpdatedByUserId = state.UpdatedByUserId;
                    existingdata.UpdatedDate = DateTime.Now;

                    existingdata.IGST = state.IGST;
                    existingdata.SGST = state.SGST;
                    existingdata.CGST = state.CGST;
                    existingdata.Statecode = state.Statecode;

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

        public ValueDataResponse<StateMaster> DeleteState(int id)
        {

            ValueDataResponse<StateMaster> response = new ValueDataResponse<StateMaster>();

            try
            {
                var res = context.StateMasters.Where(s => s.Id == id).FirstOrDefault();

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
