using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codebbed.Models
{
    [Serializable]
    public class Result
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}