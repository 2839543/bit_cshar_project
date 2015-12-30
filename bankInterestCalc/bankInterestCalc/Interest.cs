using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankInterestCalc
{
    public partial class Interest : Form
    {
        string type;
        string cunqi;
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        double lixi;

        public Interest()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double _balance = 0;
            getLixi();
            if (lixi <= 0 )
            {
                MessageBox.Show("没有该组合！");
                return;
            }
            switch (cmb_cunqi.Text)
            {
                default:
                    break;
                case "3个月":
                    _balance = Convert.ToDouble(l_balance.Text) * (1 + lixi/4/100);
                    break;
                case "半年":
                    cunqi = "month6";
                    _balance = Convert.ToDouble(l_balance.Text) * (1 + lixi/2/100);
                    break;
                case "1年":
                _balance     = Convert.ToDouble(l_balance.Text) * (1+ lixi/100);
                    break;
                case "2年": 
                    _balance = Convert.ToDouble(l_balance.Text) * (1 + lixi*2/100);
                    break;
                case "3年": 
                    _balance = Convert.ToDouble(l_balance.Text) * (1 + lixi * 3/100);
                    break;
                case "5年": 
                    _balance = Convert.ToDouble(l_balance.Text) * (1 + lixi * 5 /100 );
                    break;
            }

            tbx_zonge.Text = _balance.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_cunqi.Text){
                default :
                    break; 
                case "3个月":
                    cunqi = "month3";
                    break;
                    case "半年": 
                    cunqi = "month6";
                    break;
                    case "1年":
                    cunqi = "year1";
                    break;
                    case "2年":
                    cunqi = "year2";
                    break;
                      case "3年":
                    cunqi = "year3";
                    break;
                      case "5年":
                    cunqi = "year5";
                    break;
            }
            getLixi();
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_type.Text)
            {
                default:
                    break;
                case "活期":
                    type = "huoqi";
                    break;
                case "整存整取":
                    type = "zczq";
                    break;
                case "整存零取":
                    type = "linghuo";
                    break;
                case "零存整取":
                    type = "linghuo";
                    break;
                 
            }
            getLixi();
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
             date =    dtp_date.Value.ToString("yyyy-MM-dd");

             getLixi();
         }

        private void getLixi() {
            if (type != null && !String.IsNullOrWhiteSpace(cunqi))
            {
                lixi = Interest_table.GetLixi(date, type, cunqi);
                cmb_lilv.Text = lixi.ToString();
            }
        }

        private void recalc_Click(object sender, EventArgs e)
        {
            cleanAll();
        }

        private void cleanAll()
        {
            cmb_cunqi.Text = String.Empty;
            cmb_type.Text = String.Empty;
            l_balance.Text = String.Empty;
            cmb_lilv.Text = String.Empty;
            tbx_zonge.Text = String.Empty;

            type = String.Empty;
            cunqi = String.Empty;
            lixi = 0;
        }
    }
}
