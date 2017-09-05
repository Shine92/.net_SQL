using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0905_Pick3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BtnNewItems_Click(object sender, EventArgs e) {
            Form2 frm2 = new Form2();
            DialogResult Items = frm2.ShowDialog();
            if (Items == DialogResult.OK) {
                //LotteryDataSet.Pick3Row dr = dsLottery.Pick3.NewPick3Row();
                //dr.Text = frm2.textBox1.Text;
                //dsLottery.Pick3.Rows.Add(dr);
                BtnNewItems.Text = frm2.textBox1.Text;
            }
        }
    }
}
