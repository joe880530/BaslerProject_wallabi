using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace basler_Connect
{
    public partial class Form1 : Form
    {
        //Label label_test;
        //Button btn_test;

        bool trigger_1 = false;

        public Form1()
        {
            InitializeComponent();
        }

        //public void initialize()
        //{
        //    label_test = new Label();
        //    btn_test = new Button();
        //}

        private void btn_test_Click(object sender, EventArgs e)
        {
            if (trigger_1)
            {
                label_test.Text = "누름";
                trigger_1 = false;
            }
            else
            {
                label_test.Text = "안 누름";
                trigger_1 = true;
            }


        }
    }
}
