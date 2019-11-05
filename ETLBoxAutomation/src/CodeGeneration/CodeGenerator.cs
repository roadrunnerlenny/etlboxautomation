using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.CodeDom;
using System.IO;
using System.CodeDom.Compiler;

namespace ETLBoxAutomation.src.CodeGeneration
{
    public class CodeGenerator
    {
        public string JsonDefinition { get; set; }
        public string GeneratedCode { get; set; }
        public JObject JsonObject {get;set;}
        public void Generate()
        {
            var json = JObject.Parse(JsonDefinition);

            var variables = json.SelectToken("Variables");

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();


            using (var writer = new StreamWriter("res/test.txt", false, Encoding.UTF8))
            {
                CodeNamespace ns = new CodeNamespace("ETLBoxAutomation");
                ns.Imports.Add(new CodeNamespaceImport("System"));
                ns.Imports.Add(new CodeNamespaceImport("ALE.ETLBox"));
                codeProvider.GenerateCodeFromNamespace(ns, writer, new CodeGeneratorOptions());
                CodeVariableDeclarationStatement cd_var = new CodeVariableDeclarationStatement("int", "test");
                codeProvider.GenerateCodeFromStatement(cd_var, writer, new CodeGeneratorOptions());
            }
            //var x = codeProvider.GenerateCodeFromStatement(cd_var,);
            //codeProvider.
        }

    }
}
