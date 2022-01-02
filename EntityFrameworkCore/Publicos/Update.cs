using EntityFrameworkCore.Models;

namespace EntityFrameworkCore.Publicos
{
    public class Update
    {
        public Update(LetraModel model) 
        {
            using (var context = new LetraContext())
            {
                context.Letra.Update(model);
                context.SaveChanges();
            }
        }
    }
}
