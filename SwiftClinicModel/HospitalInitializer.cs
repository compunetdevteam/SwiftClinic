using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinghamWebApp.Models
{
    public class HospitalInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
        }
    }
}
