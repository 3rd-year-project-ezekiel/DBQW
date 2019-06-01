using System;
using System.Collections;
using System.Collections.Generic;

namespace BLL
{
    public static class Extensions
    {
        #region Sql Query Builder Algorithm

        public static List<string> SqlQueryBuilderAlgorithm(this List<string> theQueryList, string QueryData)
        {

        }

        #endregion

        #region Conversions

        #endregion

        #region MathExtentions
        public static int SwitchToPositive(this int number)
        {
            if (number < 0)
            {
                return number * -1;
            }
            return number;
        }

       
        #endregion








    }

}




