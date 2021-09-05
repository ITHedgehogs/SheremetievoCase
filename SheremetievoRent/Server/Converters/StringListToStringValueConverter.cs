using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SheremetievoRent.Server.Converters
{
    public class StringListToStringValueConverter : ValueConverter<IEnumerable<string>, string>
    {
        public StringListToStringValueConverter()
            : base(list => ListToString(list),
                str => StringToList(str))
        {
        }

        public static string ListToString(IEnumerable<string> value)
        {
            var list = value.ToList();
            return !list.Any() ? null : string.Join(",", list);
        }

        public static IEnumerable<string> StringToList(string value) =>
            string.IsNullOrEmpty(value) ? null : value.Split(',');
    }
}