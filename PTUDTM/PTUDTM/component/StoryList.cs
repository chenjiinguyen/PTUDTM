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
    public partial class StoryList : UserControl
    {
        public StoryList()
        {
            InitializeComponent();
        }

        public void LoadImage(string url)
        {
            picturePoster.LoadAsync(url);
        }
    }
}
