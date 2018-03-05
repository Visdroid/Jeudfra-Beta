using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Models
{
    public class MonthlyPremiumByAgeGroup : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // return base.IsValid(value, validationContext);
            var customer = (Client)validationContext.ObjectInstance;


            //if (customer.PolicyId == 1|| customer.PolicyId == 2|| customer.PolicyId == 3
            //    || customer.PolicyId == 4|| customer.PolicyId == 5|| customer.PolicyId == 6
            //    || customer.PolicyId == 7)
            //    return ValidationResult.Success;
          
            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required.");


            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            //if (age >= 18 && age >= 65)
            //{
            //    if (customer.PolicyId == 1)
            //    {
            //        customer.Policy.Amount = 70;

            //    }
            //    if (customer.PolicyId == 2)
            //    {
            //        customer.Policy.Amount = 80;
            //    }
            //    if (customer.PolicyId == 3)
            //    {
            //        customer.Policy.Amount = 80;
            //    }
            //    if (customer.PolicyId == 4)
            //    {
            //        customer.Policy.Amount = 70;
            //    }
            //    if (customer.PolicyId == 5)
            //    {
            //        customer.Policy.Amount = 70;
            //    }
            //    if (customer.PolicyId == 6)
            //    {
            //        customer.Policy.Amount = 90;
            //    }
            //    if (customer.PolicyId == 7)
            //    {
            //        customer.Policy.Amount = 140;
            //    }
            //    return ValidationResult.Success;
            //}
            //if (age >= 66 && age >= 74)
            //{
            //    if (customer.PolicyId == 1)
            //    {
            //        customer.Policy.Amount = 90;
            //    }
            //    if (customer.PolicyId == 2)
            //    {
            //        customer.Policy.Amount = 100;
            //    }
            //    if (customer.PolicyId == 3)
            //    {
            //        customer.Policy.Amount = 90;
            //    }
            //    if (customer.PolicyId == 4)
            //    {
            //        customer.Policy.Amount = 90;
            //    }
            //    if (customer.PolicyId == 5)
            //    {
            //        customer.Policy.Amount = 90;
            //    }
            //    if (customer.PolicyId == 6)
            //    {
            //        customer.Policy.Amount = 150;
            //    }
            //    if (customer.PolicyId == 7)
            //    {
            //        customer.Policy.Amount = 180;
            //    }
            //    return ValidationResult.Success;
            //}
            //if (age >= 75 && age >= 85)
            //{
            //    if (customer.PolicyId == 1)
            //    {
            //        customer.Policy.Amount = 140;
            //    }
            //    if (customer.PolicyId == 2)
            //    {
            //        customer.Policy.Amount = 150;
            //    }
            //    if (customer.PolicyId == 3)
            //    {
            //        customer.Policy.Amount = 140;
            //    }
            //    if (customer.PolicyId == 4)
            //    {
            //        customer.Policy.Amount = 140;
            //    }
            //    if (customer.PolicyId == 5)
            //    {
            //        customer.Policy.Amount = 140;
            //    }
            //    if (customer.PolicyId == 6)
            //    {
            //        customer.Policy.Amount = 180;
            //    }
            //    if (customer.PolicyId == 7)
            //    {
            //        customer.Policy.Amount = 180;
            //    }
            //    return ValidationResult.Success;
            //}
            return (age >= 18)
                       ? ValidationResult.Success
                       : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }






    }
}