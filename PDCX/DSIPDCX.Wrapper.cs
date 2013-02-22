using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSIPDCXLib;

namespace PDCX
{
    public sealed class DSIPDCXWrapper
    {
        private static volatile DSIPDCXWrapper instance;
        private static object syncRoot = new Object();
        public string EndPoint { get; set; }
        public DSIPDCXLib.DsiPDCX Class { get; set; }
        
        private bool _debug;

        public bool Debug
        {
            get
            {
                return _debug;
            }
            set
            {
                _debug = value;
                if (_debug)
                {
                    EndPoint = @"x1.mercurydev.net;x2.mercurydev.net";
                }
                else
                {
                    EndPoint = @"x1.mercurypay.com;b2.backuppay.com";
                }
            }
        }

        private DSIPDCXWrapper()
        {
            //This should be read from a ConfigFile
            //Default Processing EndPoint is Production
            Debug = true;
            Class = new DSIPDCXLib.DsiPDCX();
            Class.ServerIPConfig(EndPoint, (short)ProcessControl.NoDialogBoxes);
            Class.SetConnectTimeout(10);
            Class.SetResponseTimeout(60);
            //Class.ProcessTransaction(Initialize.GenerateXML(), (short)ProcessControl.NoDialogBoxes, string.Empty, string.Empty);

            string response2 = Class.ProcessTransaction(Credit.SwipedSaleXML("10.33", "1235", "5555").ToString(), (short)ProcessControl.NoDialogBoxes, string.Empty, string.Empty);

        }

        public static DSIPDCXWrapper Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DSIPDCXWrapper();
                    }
                }
                return instance;
            }
        }
    }
}
