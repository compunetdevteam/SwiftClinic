namespace SwiftClinic.Services
{
    public static class RemitaConfigParams
    {
        public const string MERCHANTID = "2266665151";
        //public const string SERVICETYPEID = "4430731";
        public const string SERVICETYPE = "4430731";




        public const string APIKEY = "591873";
        public const string GATEWAYURL = "https://login.remita.net/remita/ecomm/init.reg";
        public const string CHECKSTATUSURL = "https://login.remita.net/remita/ecomm";
    }

    public class RemitaRePostVm
    {
        public string merchantId { get; set; }
        public string hash { get; set; }
        public string rrr { get; set; }
        public string responseurl { get; set; }
    }
}