using System;
using Mini_CStructor.Website.Models;

namespace Mini_CStructor.Website.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
