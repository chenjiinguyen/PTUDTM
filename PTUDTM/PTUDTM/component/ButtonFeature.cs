﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM.component
{
    public partial class ButtonFeature : UserControl
    {
        public ButtonFeature()
        {
            InitializeComponent();
        }

        public void LoadImage(Image img)
        {
            image.Image = img;
        }
            
    }
}
