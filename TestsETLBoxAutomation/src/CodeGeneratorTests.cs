using ETLBoxAutomation.src.CodeGeneration;
using System;
using System.IO;
using Xunit;

namespace TestsETLBoxAutomation
{
    public class CodeGeneratorTests
    {
        [Fact]
        public void Test1()
        {
            string json = File.ReadAllText("res/CopyTablesNonGeneric.json");
            CodeGenerator cg = new CodeGenerator()
            {
                JsonDefinition = json

            };

            cg.Generate();
        }
    }
}
