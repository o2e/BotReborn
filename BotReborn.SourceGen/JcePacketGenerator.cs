using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace BotReborn.SourceGen
{
    [Generator]
    class JcePacketGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // Register the attribute source
            context.RegisterForPostInitialization((i) => i.AddSource("AutoNotifyAttribute", attributeText));

            // Register a syntax receiver that will be created for each generation pass
            //context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }
    }
}
