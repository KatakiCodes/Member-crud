using CleanArch.Domain.Enums;
using CleanArch.Domain.Validation;
using System.Text.RegularExpressions;

namespace CleanArch.Domain.Entities
{
    public sealed class Member : Entity, IEquatable<Member>
    {
        public Member(string firstName, string lastName, EGender gender, string email, bool isActive)
        {
            ValidateDomain(firstName, lastName, gender,email,isActive);
        }
        public Member(int id, string firstName, string lastName, EGender gender, string email, bool isActive)
        {
            DomainValidation.When(id < 0, "Invalid Id value");
            base.Id = id;
            ValidateDomain(firstName, lastName, gender, email, isActive);
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public EGender Gender { get; private set; }
        public string Email { get; private set; }
        public bool IsActive { get; private set; }

        public bool Equals(Member? other)
        {
            if(other is null) 
                return false;
            return (other.Id == this.Id && other.FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase));
        }

        private void ValidateDomain(string firstName, string lastName, EGender gender, string email, bool isActive)
        {
            DomainValidation.When(string.IsNullOrEmpty(firstName), "The first name cannot be null or empty");
            DomainValidation.When((firstName.Length < 3), "The first name must contain at the least 3 characters");
            DomainValidation.When(string.IsNullOrEmpty(lastName), "The last name cannot be null or empty!");
            DomainValidation.When(string.IsNullOrEmpty(gender.ToString()), "The gender cannot be null or empty!");
            DomainValidation.When(!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"), "Insert a valid email!");

            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            IsActive = isActive;
        }
        
    }
}
