using System;
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
                if (varType.Length > 4)
                {
                    varType = varType.Remove(4);
                }
            }
            else if (varType[0].ToString().ToLower() == "v")
            {
                if (varType.Length > 7)
                {
                    varType = varType.Remove(7);
                }
            }
            else if (varType[0].ToString().ToLower() == "n")
            {
                if (varType.Length > 5)
                {
                    varType = varType.Remove(5);
                }
            }
            if (colType.ToLower() == varType.ToLower())
            {
                compatible = "Yes";
            }
            return compatible;
        }

        

        #endregion


        #region To do List
        
        // == Pieter == \\
        // Data type checking all 
        //  check that all text boxes have a datatype checking
        //  check that all combo boxes and text boxes that are set or equal to somthing
       
        
        
        
        // == Jan == \\
        // create custom exceptions for certian events


        // rephrase
        /*
          == Group ==

- Data type checking
  + main(values, where, set)
  + database create( check if numbers)
  + table create(foreign key, test that the two columns have the same datatype)
         */
        #endregion

    }
}
