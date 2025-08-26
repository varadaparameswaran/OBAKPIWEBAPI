using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OBAKPIWEBAPI.DTOs
{
    public class DateRangeRequest : IValidatableObject
    {
        private DateTime _fromDate;
        private DateTime _toDate;

        [Required(ErrorMessage = "FromDate is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime FromDate
        {
            get => _fromDate;
            set => _fromDate = value.Date; // Normalize to 00:00:00
        }

        [Required(ErrorMessage = "ToDate is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format")]
        public DateTime ToDate
        {
            get => _toDate;
            set => _toDate = value.Date.AddDays(1).AddTicks(-1); // Normalize to 23:59:59.999
        }

        public void Deconstruct(out DateTime fromDate, out DateTime toDate)
        {
            fromDate = FromDate;
            toDate = ToDate;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FromDate > ToDate)
            {
                yield return new ValidationResult(
                    "FromDate must be before or equal to ToDate",
                    new[] { nameof(FromDate), nameof(ToDate) });
            }

            if (FromDate > DateTime.Today)
            {
                yield return new ValidationResult(
                    "FromDate cannot be in the future",
                    new[] { nameof(FromDate) });
            }
        }
    }
}