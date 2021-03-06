﻿using System.Collections.Generic;

namespace Diacritics.AccentMappings
{
    public class RussianAccentsMapping : IAccentMapping
    {
        private static readonly IDictionary<char, char> MappingDictionary = new Dictionary<char, char>
        {
            { 'ё', 'e' },
            { 'й', 'и' }
        };

        public IDictionary<char, char> Mapping { get { return MappingDictionary; } }
    }
}