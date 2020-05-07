/*
 * UCRMAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace webapi.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum AttributeTypeEnum
    {
        CLIENT, //TODO: Write general description for this method
        INVOICE, //TODO: Write general description for this method
        PAYMENT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type AttributeTypeEnum
    /// </summary>
    public static class AttributeTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "client", "invoice","payment" };

        /// <summary>
        /// Converts a AttributeTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The AttributeTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(AttributeTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case AttributeTypeEnum.CLIENT:
                case AttributeTypeEnum.INVOICE:
                case AttributeTypeEnum.PAYMENT:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of AttributeTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of AttributeTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<AttributeTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into AttributeTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed AttributeTypeEnum value</returns>
        public static AttributeTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type AttributeTypeEnum", value));

            return (AttributeTypeEnum) index;
        }
    }
} 