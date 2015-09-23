using System;
using System.Collections.Generic;

namespace UnitAnroidPrinterApp
{
    [Serializable]
    public class PrinterEntryDB
    {
        public string ContractorStr { get; set; }
        public string ContractStr { get; set; }
        public string DeviceStr { get; set; }
        public string AddressStr { get; set; }
        public string DescrStr { get; set; }
        public string DeviceSerialNum { get; set; }
        public string DeviceId { get; set; }

        public PrinterEntryDB() { }

        public string GetFormatInformation()
        {
            List<string> information = new List<string>();
            information.Add(ContractorStr);
            information.Add(ContractStr);
            information.Add(DeviceStr);
            information.Add(AddressStr);
            information.Add(DeviceStr);
            information.Add(DeviceId.ToString());

            return string.Join("\n", information);
        }
    }
}