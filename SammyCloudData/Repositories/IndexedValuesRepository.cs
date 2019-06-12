using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SammyCloudData.Contexts;
using SammyCloudData.Entities;

namespace SammyCloudData.DAL
{
    public class IndexedValuesRepository
    {
        public static Result<List<IndexedValue>> Get()
        {
            Result<List<IndexedValue>> result = new Result<List<IndexedValue>>();
            try
            {
                using (var context = new SammyCloudContext())
                {
                    List<IndexedValue> values = context.IndexedValues.ToList();
                    result.Success = true;
                    result.Message = "OK";
                    result.Data = values;
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
        }

        public static Result<IndexedValue> Get(int id)
        {
            Result<IndexedValue> result = new Result<IndexedValue>();
            try
            {
                using (var context = new SammyCloudContext())
                {
                    IndexedValue value = context.IndexedValues.Where(x => x.ID == id).FirstOrDefault();
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
        }


    }
}
