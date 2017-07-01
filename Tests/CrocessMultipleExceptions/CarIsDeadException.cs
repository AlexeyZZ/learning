using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{

    [Serializable]
    public class CarIsDeadException : Exception
    {
        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base(message) { }
        public CarIsDeadException(string message, Exception inner) : base(message, inner) { }
        protected CarIsDeadException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        //properties
        private string messageDetails = string.Empty;
        public DateTime ErroTtimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException(string message, DateTime date, string errormessage)
        {
            messageDetails = message;
            ErroTtimeStamp = date;
            CauseOfError = errormessage;
        }
    }


}
