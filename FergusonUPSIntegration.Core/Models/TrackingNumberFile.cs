﻿using CsvHelper.Configuration.Attributes;

namespace FergusonUPSIntegration.Core.Models
{
    public class TrackingNumberFile
    {
        [Name("trackingNum")]
        public string TrackingNumber { get; set; }
    }
}
