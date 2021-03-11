﻿using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Framework;

namespace Marketplace.Domain.ValueObjects
{
    public class UserId:Value<UserId>
    {
        private readonly Guid _value;

        public UserId(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(
                    nameof(value), "User id cannot be empty");
            _value = value;
        }
    }
}
