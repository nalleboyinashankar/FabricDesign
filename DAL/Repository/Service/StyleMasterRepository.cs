using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.FabricDesign.edmx;
using DAL.Repository.Interface;
using DAL.Responses;

namespace DAL.Repository.Service
{
    public class StyleMasterRepository : IStyleMasterRepository
    {
        Fabric_DesignEntities1 context = new Fabric_DesignEntities1();


        public List<GetStyleMasterData_Result> GetStyleMaster()
        {
            var res = context.GetStyleMasterData().ToList();
            return res;
        }


        public List<LookUp> Getwithid(int id)
        {
            var res = context.LookUps.Where(x => x.LookUpId == id).ToList();
            return res;
        }


        public List<TypeCdDmt> GetwithidTypecddmt(int id)
        {
            var res = context.TypeCdDmts.Where(x => x.ClassTypeId == id).ToList();
            return res;
        }


        public ValueDataResponse<StyleMaster> Addupdatestylemaster(StyleMaster style)
        {
            ValueDataResponse<StyleMaster> response = new ValueDataResponse<StyleMaster>();

            try
            {
                if (style == null)
                {
                    throw new ArgumentNullException(nameof(style), "The provided stylemaster object is null.");
                }

                var buyerExists = context.Buyers.Any(b => b.Id == style.BuyerId);
                if (!buyerExists)
                {
                    throw new ArgumentException("The provided BuyerId does not exist in the Buyer table.");
                }

                Console.WriteLine($"Incoming style BuyerStyleNumber: {style.BuyerStyleNumber}");

                var existingStyleMaster = context.StyleMasters.FirstOrDefault(s => s.Id == style.Id);

                if (existingStyleMaster == null)
                {
                    Console.WriteLine("No existing style found. Proceeding to add a new one.");

                    var obj = new StyleMaster()
                    {
                        BuyerStyleNumber = style.BuyerStyleNumber,
                        MarchantId = "user.0.3.2.1",
                        BuyerId = style.BuyerId,
                        SeasonTypeId = style.SeasonTypeId,
                        GarmentTypeId = style.GarmentTypeId,
                        SampleTypeId = style.SampleTypeId,
                        TechPackName = style.TechPackName,
                        Description = style.Description,
                        FileName = style.FileName,
                        FileLocation = style.FileLocation,
                        FileExtension = style.FileExtension,
                        NumberofPcs = style.NumberofPcs,
                        SampleSubmissionDate = style.SampleSubmissionDate,
                        ExpectedOrderQty = style.ExpectedOrderQty,
                        ExpectedOrderDate = style.ExpectedOrderDate,
                        IsActive = true,
                        CreatedBy = style.CreatedBy,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = style.UpdatedBy,
                        TechPackSampleReceivedDate = style.TechPackSampleReceivedDate,
                        OrderTypeId = style.OrderTypeId,
                        SamplingStatusId = style.SamplingStatusId,
                        FabricManagerId = style.FabricManagerId,
                        GarmentProcessId = style.GarmentProcessId,
                        CostingVersionId = style.CostingVersionId,
                        NoOfSamplesSentToBuyer = style.NoOfSamplesSentToBuyer,
                        NoOfSamplesPaidFor = style.NoOfSamplesPaidFor,
                        CostPerSample = style.CostPerSample,
                        UpdatedDate = DateTime.Now
                    };

                    context.StyleMasters.Add(obj);
                    context.SaveChanges();

                    response.IsSuccess = true;
                    response.EndUserMessage = "Data added successfully";
                }
                else
                {
                    existingStyleMaster.Id = style.Id;
                    existingStyleMaster.BuyerStyleNumber = style.BuyerStyleNumber; 
                    existingStyleMaster.MarchantId = style.MarchantId;
                    existingStyleMaster.BuyerId = style.BuyerId;
                    existingStyleMaster.SeasonTypeId = style.SeasonTypeId;
                    existingStyleMaster.GarmentTypeId = style.GarmentTypeId;
                    existingStyleMaster.SampleTypeId = style.SampleTypeId;
                    existingStyleMaster.TechPackName = style.TechPackName;
                    existingStyleMaster.Description = style.Description;
                    existingStyleMaster.FileName = style.FileName;
                    existingStyleMaster.FileLocation = style.FileLocation;
                    existingStyleMaster.FileExtension = style.FileExtension;
                    existingStyleMaster.NumberofPcs = style.NumberofPcs;
                    existingStyleMaster.SampleSubmissionDate = style.SampleSubmissionDate;
                    existingStyleMaster.ExpectedOrderQty = style.ExpectedOrderQty;
                    existingStyleMaster.ExpectedOrderDate = style.ExpectedOrderDate;
                    existingStyleMaster.IsActive = true;
                    existingStyleMaster.UpdatedBy = style.UpdatedBy;
                    existingStyleMaster.TechPackSampleReceivedDate = style.TechPackSampleReceivedDate;
                    existingStyleMaster.OrderTypeId = style.OrderTypeId;
                    existingStyleMaster.SamplingStatusId = style.SamplingStatusId;
                    existingStyleMaster.FabricManagerId = style.FabricManagerId;
                    existingStyleMaster.GarmentProcessId = style.GarmentProcessId;
                    existingStyleMaster.CostingVersionId = style.CostingVersionId;
                    existingStyleMaster.NoOfSamplesSentToBuyer = style.NoOfSamplesSentToBuyer;
                    existingStyleMaster.NoOfSamplesPaidFor = style.NoOfSamplesPaidFor;
                    existingStyleMaster.CostPerSample = style.CostPerSample;
                    existingStyleMaster.UpdatedDate = DateTime.Now;

                    context.SaveChanges();

                    response.IsSuccess = true;
                    response.EndUserMessage = "Data updated successfully";
                }
            }
            catch (Exception ex)
            {
                // Add logging here if necessary
                response.IsSuccess = false;
                response.EndUserMessage = "Data failed to add or update successfully: " + ex.Message;
            }

            return response;
        }

        public List<Getseasonwithid_Result> Getseasonwithid(int id)
        {
            var res = context.Getseasonwithid(id).Where(s => s.SeasonTypeId == id).ToList();
            return res;
        }

        public  List<Getgarmenttypewithid_Result> Getgarmenttypewithid(int id)
        {
            var res = context.Getgarmenttypewithid(id).Where(s=>s.GarmentTypeId == id).ToList();
            return res;

        }
         public  List<Garmentprocesswithid_Result> Garmentprocesswithid(int id)
         {
            var res = context.Garmentprocesswithid(id).Where(s => s.GarmentProcessId == id).ToList();
            return res;
         }



        public List<GetSampletypewithid_Result> GetSampletypewithid(int id)
        {
            var res = context.GetSampletypewithid(id).Where(s => s.SampleTypeId == id).ToList();
            return res;
        }

        public List<GetOrdertypewithid_Result> GetOrdertypewithid(int id)
        {
            var res = context.GetOrdertypewithid(id).Where(s => s.OrderTypeId == id).ToList();
            return res;
        }

        public ValueDataResponse<StyleMaster> DeletStyleMaster(int id)
        {
            ValueDataResponse<StyleMaster> response = new ValueDataResponse<StyleMaster>();

            try
            {
                var res = context.StyleMasters.Where(s=>s.Id == id).FirstOrDefault();

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





