using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_tinhcanchii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "Canh", "Tân", "Nhâm", "quí", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chiArr = { "Thân", "Tỵ", "Ngọ", "Mùi", "Dậu", "Tất", "Hợi", "Sữu", "Dần", "Mão", "Thìn", "Tuất", "Tý" };
            string giatritrave = canArr[Convert.ToInt32(txtNam.Text) % 10] + "" + chiArr[Convert.ToInt32(txtNam.Text) % 12];
        }
    }
}
