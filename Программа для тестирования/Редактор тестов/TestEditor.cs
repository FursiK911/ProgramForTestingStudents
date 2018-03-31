using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Редактор_тестов
{
    public partial class TestEditor : Form
    {
        TestModel test = new TestModel();
        QuestionModel tmpQuestion = new QuestionModel();
        public TestEditor()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            checkedListBox1.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Новый ответ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedItem != null)
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "" && int.Parse(textBox3.Text) != 0)
                {
                    VisibleControlQuestions(true);
                    test.AmountQuestions = int.Parse(textBox3.Text);
                }
                else
                    VisibleControlQuestions(false);
            }
            catch(FormatException)
            {

            }
        }
        private void VisibleControlQuestions(bool isVisible)
        {
            label1.Visible = isVisible;
            label2.Visible = isVisible;
            label6.Visible = isVisible;
            label7.Visible = isVisible;
            checkedListBox1.Visible = isVisible;
            textBox4.Visible = isVisible;
            button1.Visible = isVisible;
            button2.Visible = isVisible;
            button3.Visible = isVisible;
            button4.Visible = isVisible;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            test.AcademicDiscipline = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            test.Topic = textBox2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
