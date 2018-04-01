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
        int index = 0;
        public TestEditor()
        {
            InitializeComponent();
            tmpQuestion.SaveQuestion = false;
            VisibleControlQuestions(false);
        }


        private void ClearTmpQuestion()
        {
            if (index + 1 > test.questions.Count)
            {
                tmpQuestion.answers.Clear();
                tmpQuestion.question = "";
                tmpQuestion.SaveQuestion = false;
                tmpQuestion.PointForQuestion = 1;
                tmpQuestion.TrueAswers = 1;
                checkedListBox1.Items.Clear();
                textBox4.Text = "";
            }
            else
            {
                tmpQuestion.question = test.questions[index].question;

                checkedListBox1.Items.Clear();
                tmpQuestion.answers = test.questions[index].answers;

                foreach (string s in tmpQuestion.answers.Keys)
                {
                    checkedListBox1.Items.Add(s);
                }

                for (int i = 0; i < tmpQuestion.answers.Count; i++)
                {
                    foreach (bool p in tmpQuestion.answers.Values)
                    {
                        checkedListBox1.SetItemChecked(i,p);
                    }
                }

                tmpQuestion.SaveQuestion = true;
                tmpQuestion.TrueAswers = test.questions[index].TrueAswers;
                PrintQuestion(index);
            }
        }

        private void PreviousQuestion(object sender, EventArgs e)
        {
            if (index >= 1)
            {
                SaveData();
                index--;
                ClearTmpQuestion();
            }
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            if (index < test.AmountQuestions - 1)
            {
                SaveData();
                index++;
                ClearTmpQuestion();
            }
        }

        private void PrintQuestion(int number)
        {
            int i = 0;
            textBox4.Text = test.questions[number].question;
            checkedListBox1.Items.Clear();

            foreach (string s in test.questions[number].answers.Keys)
            {
                checkedListBox1.Items.Add(s);
            }

            foreach (bool p in test.questions[number].answers.Values)
            {
                checkedListBox1.SetItemChecked(i++, p);
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            try
            {
                checkedListBox1.Items.Add("Новый ответ " + checkedListBox1.Items.Count);
                tmpQuestion.answers.Add(checkedListBox1.Items[checkedListBox1.Items.Count - 1].ToString(), false);
            }
            catch
            {
                MessageBox.Show("'Новый ответ "+ checkedListBox1.Items.Count + "' уже существует");
            }
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                tmpQuestion.answers.Remove(checkedListBox1.SelectedItem.ToString());
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
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

        private void SaveData()
        {
            tmpQuestion.question = textBox4.Text;
            tmpQuestion.answers.Clear();
            tmpQuestion.TrueAswers = 0;

            tmpQuestion.question = textBox4.Text;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    tmpQuestion.TrueAswers++;
                    tmpQuestion.answers.Add(checkedListBox1.Items[i].ToString(), true);
                }
                else
                    tmpQuestion.answers.Add(checkedListBox1.Items[i].ToString(), false);
            }

            if (tmpQuestion.SaveQuestion)
            {
                test.questions.RemoveAt(index);
                test.questions.Insert(index, tmpQuestion.Clone());
            }
            else
            {
                tmpQuestion.SaveQuestion = true;
                test.questions.Add(tmpQuestion.Clone());
            }
        }

        private void ClickSave(object sender, EventArgs e)
        {
            SaveData();
        }

        private void OpenQuestionEditor(object sender, EventArgs e)//Переделать
        {
            SaveData();
            try
            {
                string tmpAnswer = checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString();
                bool tmpCheckState = checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex);

                QuestionEditor edit = new QuestionEditor(test, index, tmpAnswer, tmpCheckState);
                edit.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите элемент");
            }

            PrintQuestion(index);
            SaveData();
        }

        private void TestModelMode(object sender, EventArgs e)
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
