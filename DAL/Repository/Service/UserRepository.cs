using DAL.FabricDesign.edmx;
using DAL.Repository.Interface;
using DAL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Service
{
    public class UserRepository : IAspNetUsersRepository
    {
        Fabric_DesignEntities1 context = new Fabric_DesignEntities1();

        public ValueDataResponse<AspNetUser> CreateUser(AspNetUser user)
        {
            ValueDataResponse<AspNetUser> response = new ValueDataResponse<AspNetUser>();
            try
            {
                var existingUser = context.AspNetUsers.FirstOrDefault(a => a.Id == user.Id);


                if (existingUser == null)
                {
                    var obj = new AspNetUser()
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        AlternateMobileNumber = user.AlternateMobileNumber,
                        DepartmentId = user.DepartmentId,
                        Email = user.Email,
                        EmailConfirmed = true,
                        PasswordHash = user.PasswordHash,
                        SecurityStamp = user.SecurityStamp,
                        PhoneNumber = user.PhoneNumber,
                        PhoneNumberConfirmed = true,
                        TwoFactorEnabled = user.TwoFactorEnabled,
                        LockoutEndDateUtc = user.LockoutEndDateUtc > DateTime.MinValue ? user.LockoutEndDateUtc : (DateTime?)null,
                        AccessFailedCount = user.AccessFailedCount,
                        UserName = user.UserName,
                        IsActive = true,
                        ReportingManager = user.ReportingManager,
                        CreatedBy = user.Id,
                        UpdatedBy = user.Id,
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        FactoryId = user.FactoryId
                    };

                    context.AspNetUsers.Add(obj); // Corrected to add obj instead of user
                    context.SaveChanges();

                    response.IsSuccess = true;
                    response.EndUserMessage = "Data added successfully";
                }
                else
                {
                    existingUser.Id = user.Id;
                    existingUser.FirstName = user.FirstName;
                    existingUser.LastName = user.LastName;
                    existingUser.AlternateMobileNumber = user.AlternateMobileNumber;
                    existingUser.DepartmentId = user.DepartmentId;
                    existingUser.Email = user.Email;
                    existingUser.EmailConfirmed = user.EmailConfirmed;
                    existingUser.PasswordHash = user.PasswordHash;
                    existingUser.SecurityStamp = user.SecurityStamp;
                    existingUser.PhoneNumber = user.PhoneNumber;
                    existingUser.PhoneNumberConfirmed = user.PhoneNumberConfirmed;
                    existingUser.TwoFactorEnabled = user.TwoFactorEnabled;
                    existingUser.LockoutEndDateUtc = user.LockoutEndDateUtc;
                    existingUser.AccessFailedCount = user.AccessFailedCount;
                    existingUser.UserName = user.UserName;
                    existingUser.IsActive = user.IsActive;
                    existingUser.ReportingManager = user.ReportingManager;
                    existingUser.CreatedBy = existingUser.CreatedBy;
                    existingUser.UpdatedBy = user.UpdatedBy;
                    existingUser.CreatedDate = existingUser.CreatedDate;
                    existingUser.UpdatedDate = DateTime.Now;
                    existingUser.FactoryId = user.FactoryId;

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

        //public List<AspNetUser> GetAspNetUser()
        //{
        //   var result = context.AspNetUsers.ToList();
        //   return result;
        //}

        public List<SP_GetUsers_Result> GetUsersThroughSP()
        {

            var res = context.SP_GetUsers().ToList();
            return res;
        }


        public List<GetLookkupSP_Result> GetLookkupSP()
        {
            var res = context.GetLookkupSP().ToList();
            return res;
        }



        public ValueDataResponse<LookUp> AddUpdateLookup(LookUp lookup)
        {
            ValueDataResponse<LookUp> response = new ValueDataResponse<LookUp>();

            try
            {
                var res = context.LookUps.FirstOrDefault(s => s.Id == lookup.Id);

                if(res == null)
                {
                    var obj = new LookUp()
                    {
                        Id = lookup.Id,
                        LookUpId = lookup.LookUpId,
                        Name = lookup.Name,
                        Remarks = lookup.Remarks,
                        IsActive = lookup.IsActive,
                        CreatedByUserId = lookup.CreatedByUserId,
                        CreatedDate = lookup.CreatedDate,
                        UpdatedByUserId = lookup.UpdatedByUserId,
                        UpdatedDate = lookup.UpdatedDate,
                    };
                    context.LookUps.Add(obj);
                    context.SaveChanges();

                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Added successfully";
                }

                else
                {
                    res.LookUpId = lookup.LookUpId;
                    res.Name = lookup.Name;
                    res.Remarks = lookup.Remarks;
                    res.IsActive = lookup.IsActive;
                    res.UpdatedByUserId = lookup.UpdatedByUserId;
                    res.UpdatedDate = lookup.UpdatedDate;

                    context.SaveChanges();

                    response.IsSuccess = true;
                    response.EndUserMessage = "Data Updated successfully";

                }

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.EndUserMessage = "Data failed to Add or Update :" + ex;
            }

            return response;
        }


        public List<FactoryList> GetFactoryLists()
        {
            var res = context.FactoryLists.ToList();
            return res;
        }


        public List<TypeCdDmt> GetTypeCdDmt()
        {
            var res = context.TypeCdDmts.ToList();
            return res;
        }



        //public HttpResponseMessage DelPersonalInfo(string id)
        //{


        //    var existingCandidate = context.AspNetUsers.FirstOrDefault(s=>s.Id == id);

        //    try
        //    {
        //        if (existingCandidate != null)
        //        {
        //            existingCandidate.IsActive = false;
        //            existingCandidate.UpdatedDate = DateTime.Now;

        //            context.SaveChanges();

        //            return new HttpResponseMessage(HttpStatusCode.OK);
        //        }
        //        else
        //        {
        //            return new HttpResponseMessage(HttpStatusCode.NotFound);

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    }
        //}

        public ValueDataResponse<AspNetUser> Deleteuser(string id)
        {
            ValueDataResponse<AspNetUser> response = new ValueDataResponse<AspNetUser>();

            try
            {
                var res = context.AspNetUsers.Where( s => s.Id == id).FirstOrDefault();

                if(res != null)
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
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.EndUserMessage = "Data failed to delete:" + ex;
            }
            return response;
        }




    }
}
