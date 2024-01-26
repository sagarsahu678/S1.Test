using System;
using System.Data.SqlTypes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms_Projectfirst
{

    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            
        }
        private void text_Value1_TextChanged(object sender, EventArgs e)
        {

        }
        private void text_Value2_TextChanged(object sender, EventArgs e)
        {

        }
        private void lab_Action_Click(object sender, EventArgs e)
        {

        }

        private void text_Answer_TextChanged(object sender, EventArgs e)
        {

        }
        double C;
        public void Action(string sign)
        {
            double A, B;
            A = Convert.ToDouble(text_Value1.Text);
            
            B = Convert.ToDouble(text_Value2.Text);

            if (sign == "+")
            {
                C = A + B;
            }
            if (sign == "-")
            {
                C = A - B;
            }
            if (sign == "*")
            {
                C = A * B;
            }
            if(sign == "/")
            {
                C = A / B;
            }
            if (sign == "%")
            {
                C = A % B;
            }
        }
        private void btn_Addition_Click(object sender, EventArgs e)
        {
            lab_Action.Text = "+";
            Action("+");
            btn_Answer.Visible = true;

        }
    
        private void btn_Substraction_Click(object sender, EventArgs e)
        {
            lab_Action.Text = "-";
            Action("-");
        }
        private void btn_Multiplication_Click(object sender, EventArgs e)
        {

            lab_Action.Text = "*";
            Action("*");
        }
        private void btn_Division_Click(object sender, EventArgs e)
        {
            lab_Action.Text = "/";
            Action("/");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            text_Answer.Text = C.ToString();

            double A, B;
            A = Convert.ToDouble(text_Value1.Text);

            B = Convert.ToDouble(text_Value2.Text);

            if (comboBox2.SelectedIndex==1)
            {
               
                lab_Action.Text = "+";
                Action("+");
                C = A + B;  
            }

            if (comboBox2.SelectedIndex==2)
            {
                lab_Action.Text = "-";
                Action("-");
                C = A - B;
            }

            if (comboBox2.SelectedIndex==3)
            {
                lab_Action.Text = "*";
                Action("*");
                C = A * B;
            }
            if (comboBox2.SelectedIndex==4)
            {
                lab_Action.Text = "/";
                Action("/");
                C = A / B;
            }

                   
                 
                
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            lab_Action.Text = "%";
            Action("%");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
    }
}
