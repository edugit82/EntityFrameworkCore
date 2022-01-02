using EntityFrameworkCore.Models;

namespace EntityFrameworkCore.Publicos
{
    public class Remove
    {
        public Remove(LetraModel model) 
        {
            using (var context = new LetraContext())
            {
                context.Letra.Remove(model);
                context.SaveChanges();
            }
        }
    }
}
