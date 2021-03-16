using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

namespace ConsoleAppRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var regras = File.ReadAllText("Regras.json");

            var workflowRules = new List<WorkflowRules>()
            {
                new WorkflowRules()
            };

            var expandoObject = new ExpandoObjectConverter();
            var exp = new ExpandoObject();

            var rulesEngine = new RulesEngine.RulesEngine();
        }
    }
}
