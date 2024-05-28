using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;
using WebApiByKrisha.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiByKrisha.Repositories
{
    public class CollegeRepo : IRepository<College>
    {
        // Dependency Injection 

        CollegeDbContext _context = null;
        public CollegeRepo(CollegeDbContext context)
        {
            _context = context;
        }

        public void AddRecord(College model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Handle DbUpdateException
                // Check if the exception is due to a validation error
                if (ex.InnerException is DbUpdateException innerException && innerException.InnerException is Microsoft.Data.SqlClient.SqlException sqlException)
                {
                    // Check if it&#39;s a primary key violation error

                    if (sqlException.Number == 2627 || sqlException.Number == 2601)
                    {
                        // Primary key violation error
                        throw new Exception("; A record with the same ID already exists.");
                    }
                    else
                    {
                        // Other database constraint violation error
                        throw new Exception(" Database constraint violation: " +sqlException.Message);
                    }
                }
                   else
                {
                    // Other DbUpdateException
                    throw new Exception(" Error occurred while saving changes to the database.", ex);
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                throw new Exception(" Error occurred while saving changes to the database.", ex);
            }
        }

        public College DeleteRecord(College model)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<College> GetAllRecords()
        {
            throw new NotImplementedException();
        }
        public College GetSingleRecord(int id)
        {
            throw new NotImplementedException();
        }
        public College UpdateRecord(College model)
        {
            throw new NotImplementedException();
        }

        void IRepository<College>.DeleteRecord(College model)
        {
            throw new NotImplementedException();
        }

        List<College> IRepository<College>.GetAllRecords()
        {
            throw new NotImplementedException();
        }
    }
}
