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
        int index = 0;
        public TestEditor()
        {
            InitializeComponent();
            VisibleControlQuestions(false);
        }

        private void PreviousQuestion(object sender, EventArgs e)
        {
            if (index >= 1) 
                index--;
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            if (index <= test.AmountQuestions) 
                index++;
        }

        private void AddItem(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Новый ответ");
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedItem != null)
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void CheckCountQuestions(object sender, EventArgs e)
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
            button5.Visible = isVisible;
            button6.Visible = isVisible;
            button7.Visible = isVisible;
        }

        private void CheckDiscipline(object sender, EventArgs e)
        {
            test.AcademicDiscipline = textBox1.Text;
        }

        private void CheckTopic(object sender, EventArgs e)
        {
            test.Topic = textBox2.Text;
        }

        private void SaveQuestion(object sender, EventArgs e)
        {
            if (test.questions[index].SaveQuestion)
            {
                test.questions[index].answers.Clear();
            }

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                test.questions[index].answers.Add(checkedListBox1.Items[i].ToString(), checkedListBox1.GetItemChecked(i));
                if (checkedListBox1.GetItemChecked(i))
                    test.questions[index].TrueAswers++;

            }
            test.questions[index].question = textBox4.Text;
            test.questions[index].SaveQuestion = true;
        }

        private void OpenQuestionEditor(object sender, EventArgs e)
        {
            QuestionEditor edit = new QuestionEditor(test, index, checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString(), checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex));
            edit.ShowDialog();
        }

        private void TestMode(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                test.DefaultTest = false;
                label8.Text = "Балл за вопрос по умолчанию";
            }
            else
            {
                test.DefaultTest = true;
                label8.Text = "Максимальное количество баллов";
            }
        }
    }
}
