using EntityFrameworkCore.Models;

namespace EntityFrameworkCore.Publicos
{
    public class Insert
    {
        public Insert(LetraModel model) 
        {
            using (var context = new LetraContext()) 
            {
                context.Letra.Add(model);
                context.SaveChanges();
            }
        }
    }
}
