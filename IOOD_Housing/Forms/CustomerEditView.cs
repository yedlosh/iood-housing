using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IOOD_Housing.Forms
{
    public partial class CustomerEditView : Form
    {
        
        public CustomerEditView()
        {
            InitializeComponent();
            this.textBox1.Tag = false;
            this.textBox2.Tag = false;
            this.textBox3.Tag = false;
            this.btn_save.Enabled = false;
            this.textBox1.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBox2.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBox3.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBox4.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBox5.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            this.textBox6.Validating += new CancelEventHandler(textBoxEmpty_Validating);
        }

        void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }

        private void ValidateOK()
        {
            this.btn_save.Enabled = ((bool)(this.textBox1.Tag) &&
                                    (bool)(this.textBox2.Tag) &&
                                    (bool)(this.textBox3.Tag)&&
                                    (bool)(this.textBox4.Tag)&&
                                    (bool)(this.textBox5.Tag)&&
                                    (bool)(this.textBox6.Tag));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Presenters.saveButtonEvent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Presenters.cancelButtonEvent();
        }

    }
}
