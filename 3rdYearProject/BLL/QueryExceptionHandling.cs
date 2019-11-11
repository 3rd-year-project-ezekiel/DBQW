﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class QueryExceptionHandling
    {
        #region Methods
        // takes the given data and datatype, and verifies if they match, then makes sure that the output format is right
        // varchar gets '' around the word | int gets tested 
        public string CheckDataTypeMatch(string givenDataType, string givenData)
        {
            string newData = "";

            if (givenData[0] != '@')
            {
                switch (givenDataType.ToLower())
                {
                    case "char": { } break;
                    case "varchar":
                        {
                            newData = "'" + givenData + "'";
                        }
                        break;
                    case "text": { } break;
                    case "nchar": { } break;
                    case "int":
                        {
                            try
                            {
                                int test = int.Parse(givenData);
                                newData = givenData;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Please Enter a Number");
                            }
                        }
                        break;
                    case "money": { } break;
                    case "time": { } break;
                    case "date": { } break;
                    default:
                        break;
                }
            }
            else
            {
                return givenData; 
            }

            return newData;
        }

        public string CheckVariableCompatibility(string colType, string varType)
        {
            string compatible = "No";
            if (varType[0].ToString().ToLower() == "c")
            {
                varType = varType.Remove(4);
            }
            else if (varType[0].ToString().ToLower() == "v")
            {
                varType = varType.Remove(7);
            }
            else if (varType[0].ToString().ToLower() == "n")
            {
                varType = varType.Remove(5);
            }
            if (colType.ToLower() == varType.ToLower())
            {
                compatible = "Yes";
            }
            return compatible;
        }

        #endregion


        #region To do List

        // == JP == \\
        // == Main form ==
        //  - when a new thing is selected, while there is already data entered, a message box should display to inform the user that this action would cause that the query will reset
        //       - the messagebox should keep the previos selection if no is selected, and reset the query is yes is selected
        //       Examples
        //         = selecting a sqlQAuery type from the menu strip(Delete -> update)
        //         - unselecting stored procedure or views
        //         - selecting a new table, database or removing tables

        


        // == Pieter == \\
        // Data type checking all 
        //  check that all text boxes have a datatype checking
        //  check that all combo boxes and text boxes that are set or equal to somthing
       
        
        
        
        
        // create custom exceptions for certian events


        // rephrase
        /*
          == Group ==
- if switch between queries, give the option(yes or no) if no, needs to show previos option again
  + Database select
  + table
  + query
- Data type checking
  + main(values, where, set)
  + database create( check if numbers)
  + table create(foreign key, test that the two columns have the same datatype)
         */
        #endregion

    }
}
