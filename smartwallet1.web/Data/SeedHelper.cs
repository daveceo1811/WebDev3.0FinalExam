using WalletPlusInc.web.Data.Entities;

namespace WalletPlusInc.web.Data
{
    public class    SeedHelper
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            //Check if the database is populated
            if (!context.Customers.Any())
            {
                //Create Sample Data
                context.Customers.Add(new Customer
                {
                    FirstName = "David",
                    LastName = "Johnson",
                    MiddleName  = "Ceo",
                    Country = "Nigeria",
                    State  = "Lagos",
                    City = "Surulere",
                    BirthDate = DateTime.Now.AddYears(-2),
                    Gender = Gender.Male,
                    Status = MaritalStatus.single,
                   
                });

                
                await context.SaveChangesAsync();
            }

           

            
        }
    }
}

