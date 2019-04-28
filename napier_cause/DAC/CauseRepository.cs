using napier_cause.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace napier_cause.DAC
{
    public class CauseRepository
    {
        public List<Cause> GetCauses()
        {
            CauseDBContext causeDBContext = new CauseDBContext();
            return causeDBContext.Causes.ToList();
        }
    }
}