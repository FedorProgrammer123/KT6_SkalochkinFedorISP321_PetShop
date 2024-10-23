using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace KT6_SkalochkinFedorISP321_PetShop.Classes
{
    public class Context:DbContext
    {
        private static Context _context;
        public static Context GetContext()
        {
            if (_context == null)
            {
                _context = new Context();
            }
            return _context;
        }
        public Context() : base("name=TradeEntities")
        {

        }
    }
}
