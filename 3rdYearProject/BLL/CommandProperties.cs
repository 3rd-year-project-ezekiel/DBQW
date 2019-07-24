using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class CommandProperties
    {
        #region Fields
        private string type;
        private string data;
        #endregion

        #region Constructor
        public CommandProperties()
        {

        }
        public CommandProperties(string type, string data)
        {
            this.Type = type;
            this.Data = data;
        }
        #endregion

        #region Properties
        public string Type { get => type; set => type = value; }
        public string Data { get => data; set => data = value; }
        #endregion
    }
}
