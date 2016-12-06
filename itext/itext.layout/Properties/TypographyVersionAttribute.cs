﻿using System;

namespace Versions.Attributes {
    [AttributeUsage(AttributeTargets.Assembly)]
    internal class TypographyVersionAttribute : Attribute {
        internal string TypographyVersion { get; }

        internal TypographyVersionAttribute(string typographyVersion) {
            this.TypographyVersion = typographyVersion;
        }
    }
}