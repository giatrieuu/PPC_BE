﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC.Service.ModelResponse.PersonTypeResponse
{
    public class MyPersonTypeResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public string SurveyId { get; set; }
        public Dictionary<string, int> Scores { get; set; }
    }
}
