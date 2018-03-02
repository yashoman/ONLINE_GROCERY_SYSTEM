using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS_Library.IRepository
{
    public interface IOrder_Detail_Repository:IGenericRepository<ORDER_LINE_ITEMS>,IDisposable
    {
    }
}
