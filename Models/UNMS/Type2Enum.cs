/*
 * UCRMAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace webapi.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Type2Enum
    {
        ENUM_ADD, //TODO: Write general description for this method
        ENUM_REMOVE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Type2Enum
    /// </summary>
    public static class Type2EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "add", "remove" };

        /// <summary>
        /// Converts a Type2Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Type2Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Type2Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Type2Enum.ENUM_ADD:
                case Type2Enum.ENUM_REMOVE:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Type2Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Type2Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Type2Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Type2Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Type2Enum value</returns>
        public static Type2Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Type2Enum", value));

            return (Type2Enum) index;
        }
    }
} 