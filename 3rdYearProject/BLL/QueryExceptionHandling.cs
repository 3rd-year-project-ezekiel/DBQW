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

        


        // takes the given data and datatype, and verifies if they match, then makes sure that the output format is right
        // varchar gets '' around the word | int gets tested 
        public string CheckDataTypeMatch(string givenDataType, string givenData)
        {
            string newData = "";
            switch (givenDataType.ToLower())
            {
                case "char": { } break;
                case "varchar":
                    {
                        newData = "'" + givenData + "'";
                    } break;
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
                    } break;
                case "money": { } break;
                case "time": { } break;
                case "date": { } break;
                default:
                    break;
            }
            return newData;
        }

        #region To do List

        // == JP == \\
        // Main form
        // tussen switch query en combo gives you an option if you want to switch 
        //- if no selected show the previous options
        // make sure that table names on the table form cant have spaces in them

        // Datatype checking 
        // table creation when column selected check if the data types are the same.


        // == Jan == \\
        // Data type checking all 
        //  = tab - values, where, Set, Having, Procedures.  make sure that the right datatype is filled in
        // create custom exceptions for certian events


        // == Both Reseach == \\
        // exception catcher but must not stop program. for everything
        //  -- for access dinied when creating database
        //  -- for when the querie is wrong somwhere
        // check if query will run or not run (using SQL built in function)



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
