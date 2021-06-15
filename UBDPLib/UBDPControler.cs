using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace UBDPLib
{
    public class UBDPControler
    {
        //EOSIO_ChainAPI_1_0_0 Chain = new();
        public string GetMyAccount()
        {
            WebClient client = new();
            try
            {
                var result = client.UploadString(
                    "https://api.eosflare.io/v1/eosflare/get_account"
                    , "{\"account\":\"i2cfccxs4mkt\"}"
                    );
                if (result != null)
                {
                    return result;
                    //var response = JToken.Parse(result);
                }
                else return String.Empty;
            }
            catch (Exception ex)
            {
                //handle error
                if (System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debugger.Break();
                throw new ApplicationException("error in code", ex);
            }


        }
    }
}
