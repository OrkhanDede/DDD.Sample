using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Framework;

namespace Marketplace.Domain.ValueObjects
{
    public class ClassifiedAdText : Value<ClassifiedAdText>
    {
        public string _value { get; }

        internal ClassifiedAdText(string text) => _value = text;

        public static ClassifiedAdText FromString(string text) =>
            new ClassifiedAdText(text);

        public static implicit operator string(ClassifiedAdText text) =>
            text._value;
    }
}
