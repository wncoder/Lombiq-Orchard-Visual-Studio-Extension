﻿namespace Lombiq.Vsix.Orchard.Services
{
    /// <summary>
    /// Service for generating a private field name from a dependency after injecting it.
    /// </summary>
    public interface IFieldNameFromDependencyGenerator
    {
        /// <summary>
        /// Priority number used to decide which implementation needs to run first.
        /// </summary>
        double Priority { get; }


        /// <summary>
        /// Determines if the field name can be generated from the given dependency.
        /// </summary>
        /// <param name="dependency">Name of the dependency that has been injected to the constructor.</param>
        /// <returns>Returns <c>true</c> if the field name can be generated from the given dependency.</returns>
        bool CanGenerate(string dependency);

        /// <summary>
        /// Generates the field name from the given dependency. It can be generated using the normal form 
        /// (e.g. _contentManager) or the short form (e.g. _wca).
        /// </summary>
        /// <param name="dependency">Name of the dependency that has been injected to the constructor.</param>
        /// <param name="useShortName">Indicates whether the field name needs to be generated using the short form.</param>
        /// <returns>Name of the field generated from the dependency.</returns>
        string Generate(string dependency, bool useShortName);
    }
}
