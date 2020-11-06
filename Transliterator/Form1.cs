using System;
using System.Windows.Forms;

namespace Transliterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string result;
       

        private void button1_Click(object sender, EventArgs e)
        {
            string insertvalue;
            string outputvalue;

            insertvalue = this.inputField.Text;
            if (insertvalue != null & insertvalue.Length > 0)
            {
                outputvalue = Program.Transliteration.Front(insertvalue);
                outputField.Text = outputvalue;
            }
            else
            {
                MessageBox.Show("Field 'Text to Transliterate' is empty!", "Field is empty!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputField.Select();
            }
        }

        private void Transliterate_Enter(object sender, EventArgs e)
        {

        }

        private void italianRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (italianRButton.Checked == true & russianRButton.Checked == false)
            MessageBox.Show("Italian vocabulary is not found!", "Vocabulary is not found",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(outputField.Text != null & outputField.Text.Length > 0)
            Clipboard.SetText(outputField.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(copy_button, "Copy to Clipboard");

        }
    }
}
