using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace napier_cause.Models
{
    public class Signature
    {
        public int Cause_id { get; set; }

        public int User_id { get; set; }

        public DateTime Signed_Date { get; set; }
    }
}