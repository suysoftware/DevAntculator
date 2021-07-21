using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TezAPPV2.SqlOperations;

using TezAPPV2.Model;
namespace TezAPPV2.Forms
{
    public partial class FormBaseControl : Form
    {
        public FormBaseControl()
        {
            InitializeComponent();
        }
        
        Postman _message = new Postman();

        GetOrderData _getOrderData = new GetOrderData();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
            private void FormBaseControl_Load(object sender, EventArgs e)
        {
            dtgBaseControl.DataSource = _getOrderData.GetOrder();
            //ColumnVisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_message.Getmessagestodikimevi(bcmaildenemetxt.Text);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_message.Getmessagestobirlikler(karamsjtxt.Text, havamsjtxt.Text, denizmsjtxt.Text);
        }
    }
}
