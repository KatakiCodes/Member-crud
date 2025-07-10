using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities
{
    public sealed class Member : Entity
    {
        public Member(string firstName, string lastName, string gender, string email, bool isActive)
        {
            ValidateDomain(firstName, lastName, gender,email,isActive);
        }
        public Member(int id, string firstName, string lastName, string gender, string email, bool isActive)
        {
            DomainValidation.When(id < 0, "Invalid Id value");
            base.Id = id;
            ValidateDomain(firstName, lastName, gender, email, isActive);
        }

        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Gender { get; private set; }
        public string? Email { get; private set; }
        public bool IsActive { get; private set; }

        private void ValidateDomain(string firstName, string lastName, string gender, string email, bool isActive)
        {
            DomainValidation.When(string.IsNullOrEmpty(firstName), "The first name cannot be null or empty");
            DomainValidation.When((firstName.Length < 3), "The first name must contains over 3 characters");
            DomainValidation.When(string.IsNullOrEmpty(lastName), "The last name cannot be null or empty!");
            DomainValidation.When(string.IsNullOrEmpty(gender), "The gender cannot be null or empty!");
            DomainValidation.When((string.IsNullOrEmpty(email) || !email.Contains('@')), "Insert a valid email!");

            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            IsActive = isActive;
        }
    }
}
