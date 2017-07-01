using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    //class CarIsDeadException:ApplicationException
    //{
    //    private string messageDetails = string.Empty;
    //    public DateTime ErroTtimeStamp { get; set; }
    //    public string CauseOfError { get; set; }

    //    //ctors
    //    public CarIsDeadException() { }
    //    public CarIsDeadException(string message,DateTime date,string errormessage)
    //    {
    //        messageDetails = message;
    //        ErroTtimeStamp = date;
    //        CauseOfError = errormessage;
    //    }
    //    // redifine 'Exception.Message'
    //    public override string Message { get {return string.Format($"Car Error Message is:{messageDetails}"); } }
    //}
    // adding 'Serializable' attribute
    [Serializable]
    class CarIsDeadException:ApplicationException
    {
        //default ctor
        public CarIsDeadException() { }
        // ctor with 'Messsage' from base
        public CarIsDeadException(string message) : base(message) { }
        //ctor for inner exceptions
        public CarIsDeadException(string message,System.Exception inner):base(message,inner) { }
        // for serialization
        protected CarIsDeadException (System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context):base(info, context) { }

        //properties
        private string messageDetails = string.Empty;
        public DateTime ErroTtimeStamp { get; set; }
        public string CauseOfError { get; set; }
    }
}

