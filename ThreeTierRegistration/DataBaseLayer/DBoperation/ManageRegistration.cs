using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataBaseLayer.DBoperation
{
    public class ManageRegistration
    {
        public void AddReg(RegistrationModel RegModel)
        {
            using (var DB = new MYDBEntities())
            {
                Registration Reg = new Registration()
                {
                    Address = RegModel.Address,
                    City = RegModel.City,
                    Cno = RegModel.Cno,
                    DoB = RegModel.DoB,
                    FullName = RegModel.FullName,
                    Gender = RegModel.Gender,
                    
                };
                DB.Registrations.Add(Reg);
                DB.SaveChanges();
            }
        }
    }
}
