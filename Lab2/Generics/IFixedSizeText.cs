﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IFixedSizeText
    {
        public int TextLength { get; }

        public string ToFixedString();
        abstract IFixedSizeText CreateFromFixedText(string text);
    }
}
