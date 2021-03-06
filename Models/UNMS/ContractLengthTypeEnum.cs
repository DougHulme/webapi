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
    public enum ContractLengthTypeEnum
    {
        ENUM_1 = 1, //Open end contract
        ENUM_2 = 2, //Close end contract
    }

    /// <summary>
    /// Helper for the enum type ContractLengthTypeEnum
    /// </summary>
    public static class ContractLengthTypeEnumHelper
    {
        /// <summary>
        /// Convert a list of ContractLengthTypeEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of ContractLengthTypeEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<ContractLengthTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 