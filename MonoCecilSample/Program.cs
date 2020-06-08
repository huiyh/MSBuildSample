
using System;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace BlogSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // AssemblyDefinition assembiy = AssemblyDefinition.ReadAssembly(args[0]);
            AssemblyDefinition assembiy = AssemblyDefinition.ReadAssembly("C:\\Users\\huiyh\\source\\repos\\zpvip_2_0_0_im_sdk\\Wuba.ZPVIP\\bin\\x86\\Debug\\zcm.exe");

            AssemblyNameDefinition name = assembiy.Name;
            var nameName = name.Name;
            ModuleDefinition module = assembiy.MainModule;
            

            TypeDefinition type = new TypeDefinition("", "", Mono.Cecil.TypeAttributes.Class);
            InterfaceImplementation interfaceImplementation = new InterfaceImplementation(null);
            type.Interfaces.Add(interfaceImplementation);

            module.Types.Add(type);

            foreach (Mono.Cecil.TypeDefinition item in assembiy.MainModule.Types)
            {
                foreach (MethodDefinition method in item.Methods)
                {
                    if (method.Name.Equals("Main"))
                    {

                        //Instruction ins = method.Body.Instructions[0];
                        //var worker = method.Body.CilWorker;
                        //worker.InsertBefore(ins, worker.Create(OpCodes.Ldstr, "Method start…"));
                        //worker.InsertBefore(ins, worker.Create(OpCodes.Call,
                        //    assembiy.MainModule.Import(typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }))));
                        //ins = method.Body.Instructions[method.Body.Instructions.Count - 1];

                        //worker.InsertBefore(ins, worker.Create(OpCodes.Ldstr, "Method finish…"));
                        //worker.InsertBefore(ins, worker.Create(OpCodes.Call,
                        //    assembiy.MainModule.Import(typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }))));
                        break;
                    }
                }

            }

            AssemblyDefinition.CreateAssembly(name, "IL_" + args[0], ModuleKind.Dll);
            Console.Read();
        }
    }
}