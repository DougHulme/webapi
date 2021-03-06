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
    public enum QuoteItemTypeEnum
    {
        SERVICE, //Service
        FEE, //Fee
        PRODUCT, //Product
        SURCHARGE, //Service surcharge
        OTHER, //Other
    }

    /// <summary>
    /// Helper for the enum type QuoteItemTypeEnum
    /// </summary>
    public static class QuoteItemTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "service", "fee", "product", "surcharge", "other" };

        /// <summary>
        /// Converts a QuoteItemTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The QuoteItemTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(QuoteItemTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case QuoteItemTypeEnum.SERVICE:
                case QuoteItemTypeEnum.FEE:
                case QuoteItemTypeEnum.PRODUCT:
                case QuoteItemTypeEnum.SURCHARGE:
                case QuoteItemTypeEnum.OTHER:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of QuoteItemTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of QuoteItemTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<QuoteItemTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into QuoteItemTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed QuoteItemTypeEnum value</returns>
        public static QuoteItemTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type QuoteItemTypeEnum", value));

            return (QuoteItemTypeEnum) index;
        }
    }
} 