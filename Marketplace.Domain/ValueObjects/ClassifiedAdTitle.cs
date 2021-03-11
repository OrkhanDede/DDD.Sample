﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Marketplace.Framework;

namespace Marketplace.Domain.ValueObjects
{
    public class ClassifiedAdTitle:Value<ClassifiedAdTitle>
    {
        public static ClassifiedAdTitle FromString(string title) =>
            new ClassifiedAdTitle(title);
        private readonly string _value;
        private ClassifiedAdTitle(string value)
        {
            if (value.Length > 100)
                throw new ArgumentOutOfRangeException(
                    "Title cannot be longer that 100 characters",
                    nameof(value));
            _value = value;
        }
        public static ClassifiedAdTitle FromHtml(string htmlTitle)
        {
            var supportedTagsReplaced = htmlTitle
                .Replace("<i>", "*")
                .Replace("</i>", "*")
                .Replace("<b>", "**")
                .Replace("</b>", "**");

            var value = Regex.Replace(supportedTagsReplaced, "<.*?>", string.Empty);
            CheckValidity(value);

            return new ClassifiedAdTitle(value);
        }
        private static void CheckValidity(string value)
        {
            if (value.Length > 100)
                throw new ArgumentOutOfRangeException(
                    "Title cannot be longer that 100 characters",
                    nameof(value));
        }
    }
}
