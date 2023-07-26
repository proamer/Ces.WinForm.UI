﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ces.WinForm.UI.CesButton
{
    public enum ColorTemplateEnum
    {
        None,
        Black,
        Dark,
        Gray,
        Green,
        Blue,
        Red,
        Orange,
        Yellow,
    }

    public class TemplateProperty
    {
        public Color TextColor { get; set; }
        public Color NormalColor { get; set; }
        public Color MouseOverColor { get; set; }
        public Color MouseDownColor { get; set; }
        public Color BorderColor { get; set; }
    }

    /// <summary>
    /// Title content can be text or image
    /// </summary>
    public enum CesButtonContentAlignmentEnum
    {
        Left,
        Center,
        Right,
    }
}