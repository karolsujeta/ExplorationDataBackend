using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EksploracjaDanych.Controllers
{
    [ApiController]
    public class DataExplorationController : ControllerBase
    {
        private readonly ILogger<DataExplorationController> _logger;

        public DataExplorationController(ILogger<DataExplorationController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("dataExploration/upload")]
        public IEnumerable<DataModel> UploadFile([FromForm] IFormFile file)
        {
            var records = new List<DataModel>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.RegisterClassMap<DataModelCsvMap>();
                csv.Configuration.Delimiter = ";";
                csv.Configuration.IgnoreBlankLines = true;
                records = csv.GetRecords<DataModel>().ToList();
            }

            return records;
        }

        [HttpPost]
        [Route("dataExploration/average")]
        public float Average([FromBody] IEnumerable<float> data)
        {
            return data.Average();            
        }
    }
}
