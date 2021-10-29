using System;
using System.Threading;
using System.Web;

namespace Bts.Models
{
    public partial class BtsDbContext
    {
        [ThreadStatic]
        private static BtsDbContext _current = null;

        public static BtsDbContext Current
        {
            get
            {
                BtsDbContext db = null;
                if (HttpContext.Current == null)
                {
                    if (_current == null) _current = new BtsDbContext();
                    db = _current;
                }
                else
                {
                    db = HttpContext.Current.Items["db"] as BtsDbContext;
                    if (db == null)
                    {
                        db = new BtsDbContext();
                        HttpContext.Current.Items["db"] = db;
                    }
                }
                return db;
            }
        }
    }
}