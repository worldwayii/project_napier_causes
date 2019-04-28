using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace napier_cause.Models
{
    public class Cause
    {
       
        public int Id { get; set; }
        public string Description { get; set; }

        public string Topic { get; set; }

        public string Img_Path { get; set; }

        public int Created_By { get; set; }

        public DateTime? Created_Date { get; set; }

        public Signature SignatureModel { get; set; }
    }
}