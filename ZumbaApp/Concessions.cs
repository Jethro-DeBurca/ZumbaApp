using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZumbaApp.Login;

namespace ZumbaApp
{
    public partial class Concessions : UserControl
    {
        public static int concession = 0;

        public Concessions()
        {
            InitializeComponent();
        }

        public void Concessions_Load(object sender, EventArgs e)
        {
            lbl_ConAmount.Text = (concession + UserSession.CurrentUserConcessions).ToString();
            btn_BuyCon.Text = "Buy Concessions: \n Total Price: $" + (concession * 10);
        }

        public static class UserConBuyAmount
        {
            public static int ConBuyAmount { get; set; }
        }

        private void btn_PlusCon_Click(object sender, EventArgs e)
        {
            if ((concession + UserSession.CurrentUserConcessions) <= 9)
            {
                concession++;
                lbl_ConAmount.Text = (concession + UserSession.CurrentUserConcessions).ToString();
                btn_BuyCon.Text = "Buy Concessions: \n Total Price: $" + (concession * 10);
            } 
            else
            {
                MessageBox.Show("Sorry, you have the maximum concessions");
            }
        }

        private void btn_MinusCon_Click(object sender, EventArgs e)
        {
            if ((concession + UserSession.CurrentUserConcessions) >= (UserSession.CurrentUserConcessions + 1))
            {
                concession--;
                lbl_ConAmount.Text = (concession + UserSession.CurrentUserConcessions).ToString();
                btn_BuyCon.Text = "Buy Concessions: \n Total Price: $" + (concession * 10);
            }
            else
            {
                MessageBox.Show("Sorry, you have already paid for the remaining concessions");
            }
        }

        public void btn_BuyCon_Click(object sender, EventArgs e)
        {
            if ((concession + UserSession.CurrentUserConcessions) > UserSession.CurrentUserConcessions)
            {
                UserConBuyAmount.ConBuyAmount = concession + UserSession.CurrentUserConcessions;
                BankCard bankCard = new BankCard();
                bankCard.ShowDialog();

                concession = 0;
                btn_BuyCon.Text = "Buy Concessions: \n Total Price: $" + (concession * 10);

                this.Refresh();
            }
        }
    }
}
