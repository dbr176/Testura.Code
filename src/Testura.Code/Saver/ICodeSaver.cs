using Microsoft.CodeAnalysis.CSharp.Syntax;
#pragma warning disable 1591

namespace Testura.Code.Saver
{
    public interface ICodeSaver
    {
        /// <summary>
        /// Save generated code as a string.
        /// </summary>
        /// <param name="cu">Generated code.</param>
        /// <returns>Generated code as a string.</returns>
        string SaveCodeAsString(CompilationUnitSyntax cu);
    }
}