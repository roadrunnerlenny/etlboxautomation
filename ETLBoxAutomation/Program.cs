using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace ETLBoxAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();


            var compilerParams = new CompilerParameters();
            compilerParams.GenerateExecutable = true;
            compilerParams.GenerateInMemory = true;
            compilerParams.OutputAssembly = "Output";
            //string code = File.ReadAllText("./HelloWorld.txt");

            //var icc = codeProvider.CompileAssemblyFromFile(compilerParams, "./HelloWorld.txt");
            */
            var compiler = new Compiler();
            var runner = new Runner();

            compiler.CompileIntoExe("./HelloWorld.txt");
            //var compilecode = compiler.Compile("./HelloWorld.txt");
            //runner.Execute(compilecode, new[] { "test" });


        }



    }
}
