namespace CleanArchitecture.Infrastracture.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _context;

        public IQueryable<User> Users => _context.Set<User>();

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            var retrieved = _context.Users.FirstOrDefault(u=> u.Id == user.Id);

            if (retrieved != null)
            {
                retrieved.Name = user.Name;
                retrieved.Email = user.Email;
                retrieved.Role = user.Role;
                retrieved.Password = user.Password;
                retrieved.Borrowings = user.Borrowings;
            }
            else
            {
                _context.Users.Add(user);
            }

            _context.SaveChanges();
        }
    }
}
