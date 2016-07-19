using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVC.Validators
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidaPar : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (int)value % 2 == 0;
        }
    }
}