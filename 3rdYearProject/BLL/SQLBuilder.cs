using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class SQLBuilder
    {
        #region fields
        private List<string> sqlBuilderLIst;
        #endregion

        #region constructor
        public SQLBuilder()
        { sqlBuilderLIst = new List<string>(); }

        #endregion

        #region Methods
        public List<string> InsertDatabase(string dataBaseName)
        {
            if (sqlBuilderLIst.Count == 0)
            { sqlBuilderLIst.Add("USE " + dataBaseName); sqlBuilderLIst.Add("GO"); }
            else
            if (sqlBuilderLIst.Count > 0)
            {
                    sqlBuilderLIst.Clear();
                    sqlBuilderLIst.Add("USE " + dataBaseName);
                    sqlBuilderLIst.Add("GO");
            }
            return sqlBuilderLIst;
        }

        #endregion
    }


}
