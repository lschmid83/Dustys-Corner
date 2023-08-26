namespace DustysCorner.MVC.Models
{
    public class ErrorViewModel : BaseViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Path { get; set; }

        public string Error { get; set; }
    }
}