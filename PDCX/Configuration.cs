using System.Configuration;

namespace PDCX
{
    public static class TerminalID
    {
        public static string GetConfig()
        {
            string value = string.Empty;
            value = ConfigurationManager.AppSettings["TerminalID"].ToString();
            return value;
        }
    }

    public static class TranCode
    {
        public const string SECURE_DEVICE_INIT = "SecureDeviceInit";
        public const string SALE = "Sale";
    }

    public static class TranType
    {
        public const string SETUP = "Setup";
        public const string CREDIT = "Credit";
    }

    public static class PadType
    {
        public static string GetConfig()
        {
            string value = string.Empty;
            value = ConfigurationManager.AppSettings["PadType"].ToString();
            return value;
        }
    }

    public static class SecureDevice
    {
        public static string GetConfig()
        {
            string value = string.Empty;
            value = ConfigurationManager.AppSettings["SecureDevice"].ToString();
            return value;
        }
    }

    public static class ComPort
    {
        public static string GetConfig()
        {
            string value = string.Empty;
            value = ConfigurationManager.AppSettings["ComPort"].ToString();
            return value;
        }
    }
}