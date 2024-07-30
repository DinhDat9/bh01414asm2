using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LVname = txtname.Text;   
            string LVphone = txtphone.Text;
            string LVcustomerFile = cbbpeople.Text;
            string LVlastmonth = txtlast.Text;
            string LVthismonth = txtthis.Text;
            
            

          

            double sonuoc;
            double tien = 0;
            double thue = 0;
            double tongtien = 0;



            
            double last = double.Parse(txtlast.Text);
            double thiss = double.Parse(txtthis.Text);
            sonuoc = thiss - last;
            if (cbbpeople.SelectedIndex == -1 || txtname.Text == "" || txtphone.Text == ""
                || txtlast.Text == "" || txtthis.Text == "")
                
            {
                MessageBox.Show(
                    "mayf ngu vua thoi",
                    "Confirm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (cbbpeople.SelectedIndex == 0)
                {
                    if (sonuoc <= 10)
                    {
                        tien = sonuoc * 5.973;
                        thue = tien * 0.10;
                        tongtien = tien + thue;

                    }
                    else if (sonuoc <= 20)
                    {
                        tien = sonuoc * 5.973 + (sonuoc - 10) * 7.052;
                        thue = tien * 0.10;
                        tongtien = tien + thue;
                    }
                    else if (sonuoc <= 30)
                    {
                        tien = 10 * 5.973 + 10 * 7.052 + (sonuoc - 20) * 8.699;
                        thue = tien * 0.10;
                        tongtien = tien + thue;

                    }
                    else
                    {
                        tien = 10 * 5.973 + 10 * 7.052 + (sonuoc - 30) * 15.929;
                        thue = tien * 0.10;
                        tongtien = tien + thue;

                    }

                }
                if (cbbpeople.SelectedIndex == 1)
                {
                    tien = sonuoc * 9.955;
                    thue = tien * 0.10;
                    tongtien = tien + thue;


                }
                if (cbbpeople.SelectedIndex == 2)
                {
                    tien = sonuoc * 11.615;
                    thue = tien * 0.10;
                    tongtien = tien + thue;


                }
                if (cbbpeople.SelectedIndex == 3)
                {
                    tien = sonuoc * 22.068;
                    thue = tien * 0.10;
                    tongtien = tien + thue;

                }
                ListViewItem lv = new ListViewItem(LVname);
                lv.SubItems.Add(LVphone);
                lv.SubItems.Add(LVcustomerFile);
                lv.SubItems.Add(LVlastmonth);
                lv.SubItems.Add(LVthismonth);
                lv.SubItems.Add(sonuoc + "");
                lv.SubItems.Add(tongtien.ToString("N3") + " VND");
                listView1.Items.Add(lv);
                txtname.Text = "";
                txtphone.Text = "";
                cbbpeople.SelectedIndex = -1;
                txtlast.Text = "";
                txtthis.Text = "";

             
            }









        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btesc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btdetele_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) ;
            {
                listView1 .Items.Remove(listView1.SelectedItems[0]);
                
            }

        }

        private void btreset_Click(object sender, EventArgs e)
        {

        }

      

        private void btedit_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                txtname.Text = item.SubItems[0].Text;
                txtphone.Text = item.SubItems[1].Text;
                cbbpeople.SelectedIndex = -1;
                txtlast.Text = item.SubItems[3].Text;
                txtthis.Text = item.SubItems[4].Text;
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show(
                    "Bo xoa cai chon loai nguoi roi"

                    );

            }
        }
    }
}
