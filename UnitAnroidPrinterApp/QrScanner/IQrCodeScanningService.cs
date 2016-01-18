using System.Threading.Tasks;

namespace UnitAnroidPrinterApp.QrScanner
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}