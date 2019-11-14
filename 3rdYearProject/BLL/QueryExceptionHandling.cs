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

            switch (givenDataType.ToLower())
            {
                case "char": { newData = "'" + givenData + "'"; } break;
                case "varchar": { newData = "'" + givenData + "'"; } break;
                case "text": { newData = "'" + givenData + "'"; } break;
                case "nchar": { newData = "'" + givenData + "'"; } break;
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
                case "money":
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
                    } break;
                case "time": { newData = "'" + givenData + "'"; } break;
                case "date": { newData = "'" + givenData + "'"; } break;
                default:
                    break;
            }

            return newData;
        }

        public bool CheckVariableCompatibility(string colType, string varType)
        {
            bool compatible = false;
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
                compatible = true;
            }
            return compatible;
        }
        
        #endregion
        
    }
}
