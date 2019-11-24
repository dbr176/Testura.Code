using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Testura.Code.Saver
{
    /// <summary>
    /// Provides the functionality to save code to file or string.
    /// </summary>
    public class CodeSaver : ICodeSaver
    {

        /// <summary>
        /// Save generated code as a string.
        /// </summary>
        /// <param name="cu">Generated code.</param>
        /// <returns>Generated code as a string.</returns>
        public string SaveCodeAsString(CompilationUnitSyntax cu)
        {
            if (cu == null)
            {
                throw new ArgumentNullException(nameof(cu));
            }

            return cu.NormalizeWhitespace().ToFullString();
        }
    }
}
