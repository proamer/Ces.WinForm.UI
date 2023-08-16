﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ces.WinForm.UI.CesComboBox
{
    public partial class CesComboBoxItem : UserControl
    {
        public CesComboBoxItem(
            CesSimpleComboBoxItem cesSimpleComboBoxItem,
            Ces.WinForm.UI.CesComboBox.CesComboBoxOptions options)
        {
            InitializeComponent();
            CesOptions = options;
            CesItem = cesSimpleComboBoxItem;
        }


        private CesSimpleComboBoxItem cesItem;
        public CesSimpleComboBoxItem CesItem
        {
            get { return this.cesItem; }
            set
            {
                cesItem = value;

                this.lblItemText.Text = value.Text;
                this.pbItemImage.Image = value.Image;

                // در صورتی که ویژگی نمایش تصویر فعال باشد
                // باری آیتم هایی که تصویر ندارند باید کنترل
                // عکس مخفی شود
                this.pbItemImage.Visible = CesOptions.ShowImage ? (value.Image != null) : false;
            }
        }


        private Ces.WinForm.UI.CesComboBox.CesComboBoxOptions cesOptions;
        public Ces.WinForm.UI.CesComboBox.CesComboBoxOptions CesOptions
        {
            get { return cesOptions; }
            set
            {
                cesOptions = value;

                this.Margin = new Padding(0, 0, 0, cesOptions.Margin);
                this.pbItemImage.Width = cesOptions.ImageWidth;
                this.Height = cesOptions.ItemHeight;
                this.Width = cesOptions.ItemWidth;

                this.pbItemImage.Visible = cesOptions.ShowImage;
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            if (cesOptions.ShowIndicator)
            {
                this.pnlIndicator.BackColor = Color.Orange;
            }
            else
            {
                this.BackColor = Color.Khaki;
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            if (cesOptions.ShowIndicator)
            {
                this.pnlIndicator.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }

    public class CesSimpleComboBoxItem
    {
        // تعیین مقدار متن جهت نمایش الزامی می باشد
        public CesSimpleComboBoxItem(string text, object? value = null, Image? image = null)
        {
            this.Text = text;
            this.Value = value;
            this.Image = image;
        }

        public string Text { get; set; }
        public object? Value { get; set; }
        public Image? Image { get; set; }
    }
}