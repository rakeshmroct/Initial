using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharp
{
    class NullableAPI
    {
#nullable enable
        [DisallowNull]
        public string? ReviewComment
        {
            get => _comment;
            set => _comment = value ?? throw new ArgumentNullException(nameof(value), "Cannot set to null");
        }
        string? _comment;
    }
}
