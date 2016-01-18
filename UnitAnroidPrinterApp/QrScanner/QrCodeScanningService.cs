using System.Threading.Tasks;
using ZXing.Mobile;

namespace UnitAnroidPrinterApp.QrScanner
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public MobileBarcodeScanner mScanner { get; } = new MobileBarcodeScanner();

        public async Task<string> ScanAsync()
        {
            var scanResults = await mScanner.Scan();
            return scanResults != null ? scanResults.Text : string.Empty;
        }
    }
}