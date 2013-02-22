using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace PDCX
{
    public static class Initialize
    {
        public static StringBuilder GenerateXML(string terminalID, string comPort)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<?xml version=\"" + "1.0\"?>");
            builder.Append("<TStream>");
            builder.Append("<Admin>");
            builder.Append("<MerchantID>" + terminalID + "</MerchantID>");
            builder.Append("<TranType>SecureDeviceInit</TranType>");
            builder.Append("<TranCode>" + TranCode.SECURE_DEVICE_INIT + " </TranCode>");
            builder.Append("<TranType>" + TranType.SETUP + " </TranType>");
            builder.Append("<PadType>" + PadType.GetConfig() + " </PadType>");
            builder.Append("<SecureDevice>" + SecureDevice.GetConfig() + "</SecureDevice>");
            builder.Append("<ComPort>" + ComPort.GetConfig() + "</ComPort>");
            builder.Append("</Admin>");
            builder.Append("</TStream>");
            return builder;
        }
    }
}
