using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module10Project
{
    public partial class frmStarOfTheRadio : Form
    {
        public frmStarOfTheRadio()
        {
            InitializeComponent();
        }
        public bool validate()
        {
            int x;

            if (lftOp.Text == "" || rgtOp.Text == "")
            {
                lblMsg.Text = "Please enter a number in both fields.";
                return false;
            }

            else if (!Int32.TryParse(rgtOp.Text, out x))
            {
                lblMsg.Text = "No letters or decimals please, only whole numbers!";
                return false;
            }
            else if (!Int32.TryParse(lftOp.Text, out x))
            {
                lblMsg.Text = "No letters please, only whole numbers!";
                return false;
            }

            else
            {
                return true;
            }


        }
        public bool divide0()
        {
            if (Int32.Parse(lftOp.Text) == 0 || Int32.Parse(rgtOp.Text) == 0)
            {
                lblMsg.Text = "Please do not enter zero in either operand for this operation";
                return false;
            }
            else
                return true;
            }

        public string add(int x, int y)
        {
            string answer;

            if (chkVerbose.Checked == true)
            {
                answer = String.Format($"{x} + {y} = {x + y}");
                
            }
            else
            {
                answer = String.Format($"The answer is {x + y}");
            }
            return answer;
        }

        public string subtract(int x, int y)
        {
            string answer;

            if (chkVerbose.Checked == true)
            {
                answer = String.Format($"{x} - {y} = {x - y}");

            }
            else
            {
                answer = String.Format($"The answer is {x - y}");
            }
            return answer;
        }

        public string multi(int x, int y)
        {
            string answer;

            if (chkVerbose.Checked == true)
            {
                answer = String.Format($"{x} * {y} = {x * y}");

            }
            else
            {
                answer = String.Format($"The answer is {x * y}");
            }
            return answer;
        }

        public string div(int x, int y)
        {
            string answer;

            if (chkVerbose.Checked == true)
            {
                answer = String.Format($"{x} / {y} = {x / y}");

            }
            else 
            {
                answer = String.Format($"The answer is {x / y}");
            }
            return answer;
        }

        public string mod(int x, int y)
        {
            string answer;

            if (chkVerbose.Checked == true)
            {
                answer = String.Format($"{x} % {y} = {x % y}");

            }
            else
            {
                answer = String.Format($"The answer is {x % y}");
            }
            return answer;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            lftOp.Text = "";
            rgtOp.Text = "";
            lblMsg.Text = "";
            chkVerbose.Checked = true;
            radioAdd.Checked = true;
            lftOp.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lftOp_TextChanged(object sender, EventArgs e)
        {

        }

        private void rgtOp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string answer;

            validate();
            try
            {
                if (radioAdd.Checked == true)
                {
                    answer = add(Convert.ToInt32(lftOp.Text), Convert.ToInt32(rgtOp.Text));
                    lblMsg.Text = answer;
                }
                else if (radioSubtract.Checked == true)
                {
                    answer = subtract(Convert.ToInt32(lftOp.Text), Convert.ToInt32(rgtOp.Text));
                    lblMsg.Text = answer;
                }
                else if (radioMultiply.Checked == true)
                {
                    answer = multi(Convert.ToInt32(lftOp.Text), Convert.ToInt32(rgtOp.Text));
                    lblMsg.Text = answer;
                }
                else if (radioDivide.Checked == true)
                {
                    if (divide0())
                    { 
                        answer = div(Convert.ToInt32(lftOp.Text), Convert.ToInt32(rgtOp.Text));
                        lblMsg.Text = answer;
                    }
                }
                else if (radioMod.Checked == true)
                {
                    if (divide0())

                    {
                        answer = mod(Convert.ToInt32(lftOp.Text), Convert.ToInt32(rgtOp.Text));
                        lblMsg.Text = answer;
                    }
                }
            }
            catch(FormatException)
            {
                
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioSubtract_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMultiply_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDivide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkVerbose_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
