﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_lib
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      mTextBox.Text = "desserts";
    }

    public IStringReverser? StringReverser { get; set; }

    private void mButtonReverse_Click(object sender, EventArgs e)
    {
      if (StringReverser != null)
      {
        mTextBox.Text = StringReverser.Reverse(mTextBox.Text);
      }
    }
  }
}
