using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OGS_Library.IRepository;

namespace OGS_Library.Repository
{
    public class Order_Detail_Repository : GenericRepository<ORDER_LINE_ITEMS>, IOrder_Detail_Repository
    {
        private bool disposed = false;

        public Order_Detail_Repository(OGSEntities context) : base(context)
        {
        }

        #region Dispose Function

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (Context != null)
                        Context.Dispose();
                }
                disposed = true;
            }
        }

        #endregion

    }
}
