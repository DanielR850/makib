using PIA_PROGRAMACIONWEB.Models;

namespace PIA_PROGRAMACIONWEB.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
