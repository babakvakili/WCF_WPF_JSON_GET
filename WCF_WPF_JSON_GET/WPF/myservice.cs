using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WPF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
       ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MyService : IMyService
    {
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "json")]
        public void GetJson()
        {
        }
    }
}
