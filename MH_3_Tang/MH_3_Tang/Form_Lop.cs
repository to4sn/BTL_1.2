using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace MH_3_Tang
{
    public partial class Form_Lop : Form
    {
        public Form_Lop()
        {
            InitializeComponent();
        }

        BUS_Lop Lop = new BUS_Lop();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Lop.Load();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Lop ob = new Lop(txt_maLop.Text, txt_tenLop.Text);
            Lop.Insert(ob);
        }
    }
}
