/*
 * UCRMAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;



namespace webapi.Models
{
    public enum PeriodEnum
    {
        ENUM_1 = 1, //TODO: Write general description for this method
        ENUM_3 = 3, //TODO: Write general description for this method
        ENUM_6 = 6, //TODO: Write general description for this method
        ENUM_12 = 12, //TODO: Write general description for this method
        ENUM_24 = 24, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PeriodEnum
    /// </summary>
    public static class PeriodEnumHelper
    {
        /// <summary>
        /// Convert a list of PeriodEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of PeriodEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<PeriodEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 