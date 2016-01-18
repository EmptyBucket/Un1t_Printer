using System.Threading.Tasks;
using ZXing.Mobile;

namespace UnitAnroidPrinterApp.QrScanner
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner();
            var scanResults = await scanner.Scan();

            return scanResults.Text;
        }
    }
}