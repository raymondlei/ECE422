using System;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class FormMain : Form
    {
        private ProcessingUnit _processor;

        public FormMain()
        {
            InitializeComponent();
            this.Text = Properties.Resources.Title;
            tbDisplay.ReadOnly = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _processor = new ProcessingUnit();
            _processor.NewNumberEvent += _processingUnit_NewNumberEvent;
        }

        void _processingUnit_NewNumberEvent(object sender, EventArgs e)
        {
            string data = ((int)sender).ToString();
            this.Invoke(new EventHandler(DisplayText), new object[] { data });
        }

        private void FormSerialTx_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void DisplayText(object sender, EventArgs e)
        {
            tbDisplay.Text = (string)sender;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonDigit_click(string value)
        {
            _processor.HandleInput(value[0]);
        }

        private void ButtonOp_click(string op)
        {
            _processor.HandleInput(op[0]);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
            ButtonOp_click("c");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            ButtonOp_click("r");
        }

        #region Numbers
        private void btn0_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            ButtonDigit_click("9");
        } 
        #endregion

        #region Plus, Minus, Multiply, Divide
        private void btnPlus_Click(object sender, EventArgs e)
        {
            ButtonOp_click("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ButtonOp_click("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ButtonOp_click("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ButtonOp_click("/");
        } 
        #endregion

    }
}
