using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Active_Site_Cloud_WebApplication.Models
{
    public class Repository:IRepository
    {
        
            private readonly AppDbContext _appDbContext;

           

            public Repository(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }

            

            

            

            

            
        }
}
