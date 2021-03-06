﻿using System;
using Gwen.Control;

namespace Gwen.UnitTest
{
	[UnitTest(Category = "Non-Interactive", Order = 105)]
	public class ImagePanel : GUnit
    {
        public ImagePanel(ControlBase parent)
            : base(parent){
            /* Normal */
            {
                Control.ImagePanel img = new Control.ImagePanel(this){
                    Margin = Margin.Five,
                    Dock = Dock.Top,
                    Size = new Size(100, 100),
                    ImageName = "gwen.png"
                };
            }
            

            /* Missing */
            {
                Control.ImagePanel img = new Control.ImagePanel(this){
                    Margin = Margin.Five,
                    Dock = Dock.Top,
                    Size = new Size(100, 100),
                    ImageName = "missingimage.png"
                };
            }

			/* Clicked */
			{
			    Control.ImagePanel img = new Control.ImagePanel(this){
			        Margin = Margin.Five,
			        Dock = Dock.Top,
			        Size = new Size(100, 100),
			        ImageName = "test16.png"
			    };
			    img.Clicked += Image_Clicked;
			}
        }

		void Image_Clicked(ControlBase control, EventArgs args) {
			UnitPrint("Image: Clicked");
		}
    }
}
