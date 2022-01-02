using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Models;

namespace EntityFrameworkCore.Publicos
{
    public class Select
    {
        public List<LetraModel> retorno;
        
        public Select(Expression<Func<LetraModel,bool>> predicate) 
        {
            this.retorno = new List<LetraModel>();

            using (var context = new LetraContext())
            {
                this.retorno = context.Letra.Where(predicate).ToList();
            }
        }        
    }
}
