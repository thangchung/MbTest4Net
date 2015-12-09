using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;
using MbTest4Net.Exception;
using MbTest4Net.Model;

namespace MbTest4Net.Extensions
{
    public static class ModelExtensions
    {
        public static void SetValue<TModel>(this TModel model, Expression<Func<TModel, object>> property, object value)
            where TModel : ModelBase
        {
            PropertyInfo propertyInfo;

            var body = property.Body as MemberExpression;
            if (body != null)
            {
                propertyInfo = body.Member as PropertyInfo;
            }
            else
            {
                propertyInfo = ((MemberExpression) ((UnaryExpression) property.Body).Operand).Member as PropertyInfo;
            }

            if (propertyInfo == null)
            {
                throw new NullMbTest4NetException("Cannot find property information.");
            }

            propertyInfo.SetValue(model, value, null);
        }

        public static void IsValid<TModel>(this TModel model)
            where TModel : ModelBase
        {
            var results = new List<ValidationResult>();
            var success = Validator.TryValidateObject(model, new ValidationContext(model, null, null), results, true);
            if (!success)
            {
                throw new RuleMbTest4NetException(results);
            }   
        }
    }
}