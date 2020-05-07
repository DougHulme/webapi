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
    public enum RefundMethodEnum
    {
        ENUM_1 = 1, //Check
        ENUM_2 = 2, //Cash
        ENUM_3 = 3, //Bank transfer
        ENUM_4 = 4, //PayPal
        ENUM_5 = 5, //PayPal credit card
        ENUM_6 = 6, //Stripe credit card
        ENUM_7 = 7, //Stripe subscription (credit card)
        ENUM_8 = 8, //PayPal subscription
        ENUM_9 = 9, //Authorize.Net credit card
        ENUM_12 = 12, //IPPay
        ENUM_99 = 99, //Custom
    }

    /// <summary>
    /// Helper for the enum type RefundMethodEnum
    /// </summary>
    public static class RefundMethodEnumHelper
    {
        /// <summary>
        /// Convert a list of RefundMethodEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of RefundMethodEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<RefundMethodEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 