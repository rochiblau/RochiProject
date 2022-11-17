using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id,int roleId,int PormissioId,EPolicy policy);

        Claim Update(Claim claim);
        
        Claim Delete(int id);

    }
}
