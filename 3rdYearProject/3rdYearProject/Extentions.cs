using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3rdYearProject
{
    public static class Extentions
    {
        #region Sql Query Builder Algorithm
        // Query command is the type that is being added to the list, like USE DATABASE or UPDATE or ORDER BY
        // QueryData is the data that is sent through, like table name or all the entities
        public static List<string> SqlQueryBuilderAlgorithm(this List<string> theQueryList,string QueryCommand, string QueryData)
        {
            switch (QueryCommand)
            {
                case "USE DATABASE": // for when a database is selected
                    {
                        try
                        {
                            if (theQueryList.Count != 0)
                            {
                                theQueryList[0] = "USE DATABASE " + QueryData;
                            }
                        }
                        catch (Exception)
                        {
                            theQueryList = new List<string>();
                            theQueryList.Add("USE DATABASE " + QueryData);
                            theQueryList.Add("go");
                        }

                    }break;

                case "INSERT":
                    {
                        if (false)//"Procudure")
                        {

                        }
                        else
                        {
                            if (theQueryList.Count<3)
                            {
                                string[] queryInfo = QueryData.Split('#');
                                theQueryList.Add("INSERT INTO " + queryInfo[0]);
                            }
                            else
                            {
                                switch (theQueryList[2])// checks to see if there is somthing else like a delete of update
                                {
                                    case null:
                                        {

                                        }
                                        break;

                                    default:
                                        break;
                                }
                            }
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