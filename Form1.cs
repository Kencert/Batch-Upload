using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BatchUploader : Form
    {
        public BatchUploader()
        {
            InitializeComponent();

        }
        public ProgressBar progress = new ProgressBar();
        public OpenFileDialog openFD = new OpenFileDialog();
        Program main = new Program();

       
        private void button1_Click(object sender, EventArgs e)
        {
            //txtURL.Text = "Hello World";
            openFD.Title = "Open Data File ";
            openFD.InitialDirectory = @"C:\Users\Kenedy Cheruiyot\Desktop";
            openFD.FileName = "";

            openFD.ShowDialog(); 
            txtURL.Text = openFD.FileName.ToString();
            btn_finish.Enabled = true;


        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (txtURL.Text != "")
            {
                if (radioCust.Checked)
                {
                    main.sendCustomer(txtURL.Text);

                  //  MessageBox.Show("Customers data successfully uploaded..!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (radioPay.Checked)
                {
                    main.sendPayment(txtURL.Text);
                   // MessageBox.Show( "Payment Inserted Successfully!!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else if (radioVen.Checked)
                {
                    main.sendVendor(txtURL.Text);
                  //  MessageBox.Show("Vendors data successfully uploaded..!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                
                MessageBox.Show("Please make sure you have a file loaded..!!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
