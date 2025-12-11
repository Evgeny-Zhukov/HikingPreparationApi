using System.Data;

namespace Core.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public DateOnly BirthDay { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public bool IsActive { get; private set; }

        public User(
            string firstName,
            string lastName,
            string email,
            string passwordHash,
            DateOnly birthDay)
        {
            Id = Guid.NewGuid();
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));
            BirthDay = birthDay;
            CreatedAt = DateTime.UtcNow;
        }

        public void UpdateEmail(string newEmail)
        {
            Email = newEmail ?? throw new ArgumentNullException(newEmail);
        }

        public void UpdateLastName(string newLastName)
        {
            LastName = newLastName ?? throw new ArgumentNullException(newLastName);
        }
    }
}
