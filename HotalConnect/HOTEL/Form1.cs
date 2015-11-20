using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotalConnect;

namespace HOTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            coreHotalConnect chObj = new coreHotalConnect();
            tb_name.Text = chObj.getInformation(tb_hID.Text).ToString();
            tb_type.Text = chObj.getRoomType(tb_hID.Text).ToString();
            tb_price.Text = chObj.getPrice(tb_hID.Text).ToString();
            tb_Allot.Text = chObj.getAllotment(tb_hID.Text).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coreHotalConnect chObj = new coreHotalConnect();
            tb_Allot.Text = chObj.getBooking(tb_hID.Text, int.Parse(tb_amount.Text)).ToString();
            lb_result.Text = chObj.showStatus(tb_hID.Text, int.Parse(tb_amount.Text)).ToString();
        }

        private void lb_result_Click(object sender, EventArgs e)
        {

        }
    }
}
