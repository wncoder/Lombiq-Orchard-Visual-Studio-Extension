﻿namespace Lombiq.Vsix.Orchard.Services
{
    public class DefaultFieldNameFromDependencyGenerator : FieldNameFromDependencyGeneratorBase
    {
        public override double Priority => 1;


        public override bool CanGenerate(string dependency) => true;

        public override string Generate(string dependency, bool useShortName)
        {
            // Default implementation with the lowest priority that generates the field name by adding the underscore
            // and shortens it if required.
            if (dependency.Length < 2) return GetLowerInvariantStringWithUnderscore(dependency);

            var cleanedDependency = RemoveFirstLetterIfInterface(dependency);

            if (dependency.Length < 2) return GetLowerInvariantStringWithUnderscore(dependency);

            if (useShortName) return GetShortNameWithUnderscore(cleanedDependency);

            return GetStringWithUnderscore(GetCamelCased(cleanedDependency));
        }
    }
}
