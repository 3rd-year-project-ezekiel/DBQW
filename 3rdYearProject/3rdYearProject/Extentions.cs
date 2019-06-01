using System;
using System.Collections;
using System.Collections.Generic;

namespace _3rdYearProject
{
    public static class Extentions
    {
        #region Sql Query Builder Algorithm
        // Query command is the type that is being added to the list, like USE DATABASE or UPDATE or ORDER BY
        // QueryData is the data that is sent through, like table name or all the entities
        public static List<string> SqlQueryBuilderAlgorithm(this List<string> theQueryList,string QueryCommand, string QueryData)
        {
            switch (QueryData)
            {
                case "USE DATABASE":
                    {
                        if (theQueryList.Count == 0)
                        {
                            theQueryList.Add("USE DATABASE " + QueryData);
                        }
                        else
                        {

                            theQueryList[0] = "USE DATABASE " + QueryData;
                        }

                    }break;

                default:
                    break;
            }



            return theQueryList;
        }

        #endregion

        #region Conversions

        #endregion

    }
}