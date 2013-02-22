using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDCX
{
    public static class Credit
    {
        /// <summary>
        /// Creates the dsiPDCX XML required for a Credit Swiped Sale
        /// </summary>
        /// <param name="amount">Purchase price (with 2 place decimal – eg. 29.95)</param>
        /// <param name="invoiceNumber">Invoice number – sequential receipt number, check number, or other unique transaction identifier.</param>
        /// <param name="operatorID">Operator (clerk, server, etc.) associated with the Transaction.</param>
        /// <returns></returns>
        public static StringBuilder SwipedSaleXML(string amount, string invoiceNumber, string operatorID)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<?xml version=\"" + "1.0\"?>");
            builder.Append("<TStream>");
            builder.Append("<Transaction>");
            builder.Append("<MerchantID>" + TerminalID.GetConfig() + "</MerchantID>");
            builder.Append("<OperatorID>" + operatorID + "</OperatorID>");
            builder.Append("<TranType>Credit</TranType>");
            builder.Append("<TranCode>" + TranCode.SALE + "</TranCode>");
            builder.Append("<SecureDevice>" + SecureDevice.GetConfig() + "</SecureDevice>");
            builder.Append("<ComPort>" + ComPort.GetConfig() + "</ComPort>");
            builder.Append("<InvoiceNo>" + invoiceNumber + "</InvoiceNo>");
            builder.Append("<RefNo>" + invoiceNumber + "</RefNo>");
            builder.Append("<Account>");
            builder.Append("<AcctNo>Prompt</AcctNo>");
            //builder.Append("<AcctNo>SecureDevice</AcctNo>");
            builder.Append("</Account>");
            builder.Append("<Amount>");
            builder.Append("<Purchase>" + amount + "</Purchase>");
            builder.Append("</Amount>");
            builder.Append("</Transaction>");
            builder.Append("</TStream>");
            return builder;
        }
    }
}
