using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;

namespace BotReborn.SourceGen
{
    [Generator]
    class JcePacketGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            
        }
        public void Initialize(GeneratorInitializationContext context) => throw new NotImplementedException();
    }
}
