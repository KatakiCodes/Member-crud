using CleanArch.Domain.Validation;

namespace CleanArch.Domain.Entities
{
    public sealed class Member : Entity
    {
        public Member(string firstName, string lastName, string gender, string email, string isActive)
        {
            ValidateDomain(firstName, lastName, gender,email,isActive);
        }
        public Member(int id, string firstName, string lastName, string gender, string email, string isActive)
        {
            DomainValidation.When(id < 0, "Invalid Id value");
            base.Id = id;
            ValidateDomain(firstName, lastName, gender, email, isActive);
        }

        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Gender { get; private set; }
        public string? Email { get; private set; }
        public string? IsActive { get; private set; }

        private void ValidateDomain(string firstName, string lastName, string gender, string email, string isActive)
        {
            DomainValidation.When((string.IsNullOrEmpty(firstName) || firstName.Length < 3), "Insert a valid name!");
            DomainValidation.When(string.IsNullOrEmpty(firstName), "Insert a valid last name!");
            DomainValidation.When(string.IsNullOrEmpty(gender), "Insert a valid gender!");
            DomainValidation.When((string.IsNullOrEmpty(gender) || !gender.Contains('@')), "Insert a valid email!");
            DomainValidation.When(isActive is null, "Insert an activity!");

            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            IsActive = isActive;
        }
    }
}
