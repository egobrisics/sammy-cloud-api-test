using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SammyCloudData.Contexts;
using SammyCloudData.Entities;

namespace SammyCloudData.DAL
{
    public interface IPatientRepository
    {

        Task<Result<Patient>> Get(int id, int accountId);


    }
    public class PatientRepository : IPatientRepository
    {
        public async Task<Result<Patient>> Get(int id, int accountId)
        {
            return await Task.Run(() =>
            {
                Result<Patient> result = new Result<Patient>();
                try
                {
                    using (SammyCloudContext context = new SammyCloudContext())
                    {
                        Patient value = context.Patients.Where(x => x.Id == id && x.AccountId == accountId).FirstOrDefault();
                        result.Success = true;
                        result.Message = "OK";
                        result.Data = value;
                        return result;
                    }
                }
                catch (Exception e)
                {
                    result.Message = e.ToString();
                    result.Success = false;
                    result.Data = null;
                    return result;
                }
            });

        }
    }
}
