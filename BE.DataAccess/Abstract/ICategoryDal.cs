using BE.Entities.Concrete;
using BE.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        
    }
}
