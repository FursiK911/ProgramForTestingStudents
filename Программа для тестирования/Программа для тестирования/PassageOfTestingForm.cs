using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Редактор_тестов;

namespace Программа_для_тестирования
{
    public partial class PassageOfTestingForm : Form
    {
        TestModel test;
        Participant participant;
        QuestionModel tmpQuestion = new QuestionModel();
        int index = 0;
        public PassageOfTestingForm()
        {
            InitializeComponent();
        }

        public PassageOfTestingForm(TestModel t, Participant p)
        {
            InitializeComponent();
            test = t;
            participant = p;
            PrintQuestion();
            for (int i = 0; i < test.questions.Count; i++)
                lbox_question.Items.Add("Вопрос " + (i+1));
        }

        private void PrintQuestion()
        {
            lb_question.Text = "Вопрос " + (index + 1);
            tb_question.Text = test.questions[index].question;
            if (test.questions[index].PointForQuestion != 0)
                lb_pointForAnswer.Text = test.questions[index].PointForQuestion.ToString();
            else
                lb_pointForAnswer.Text = test.DefaultPoint.ToString();


            clb_answers.Items.Clear();
            try
            {
                if (!participant.questions[index].SaveQuestion)
                {
                    foreach (string s in test.questions[index].answers.Keys)
                    {
                        clb_answers.Items.Add(s);
                    }
                }
                else
                {
                    foreach (string s in participant.questions[index].answers.Keys)
                    {
                        clb_answers.Items.Add(s);
                    }
                    for (int i = 0; i < clb_answers.Items.Count; i++)
                    {
                        foreach (bool value in participant.questions[index].answers.Values)
                        {
                            clb_answers.SetItemChecked(i,value);
                        }
                    }
                }
            }
            catch
            {
                foreach (string s in test.questions[index].answers.Keys)
                {
                    clb_answers.Items.Add(s);
                }
            }
        }

        private void SaveResults()
        {
            tmpQuestion.answers.Clear();
            for (int i = 0; i < clb_answers.Items.Count; i++)
            {
                tmpQuestion.answers.Add(clb_answers.Items[i].ToString(),clb_answers.GetItemChecked(i));
            }
            try
            {
                if (participant.questions[index].SaveQuestion)
                {
                    participant.questions.RemoveAt(index);
                    participant.questions.Insert(index, tmpQuestion.Clone());
                }
                else
                {
                    participant.questions.Add(tmpQuestion.Clone());
                    participant.questions[index].SaveQuestion = true;
                }
            }
            catch
            {
                participant.questions.Add(tmpQuestion.Clone());
                participant.questions[index].SaveQuestion = true;
            }
        }

        private void DataInQuestion()
        {
            tmpQuestion.answers.Clear();
            clb_answers.Items.Clear();
            try
            {
                if (!participant.questions[index].SaveQuestion)
                {
                    tmpQuestion.answers = test.questions[index].answers;
                    tmpQuestion.TrueAswers = test.questions[index].TrueAswers;
                }
                else
                {
                    tmpQuestion.answers = participant.questions[index].answers;
                    tmpQuestion.TrueAswers = participant.questions[index].TrueAswers;
                }
            }
            catch
            {
                tmpQuestion.answers = test.questions[index].answers;
                tmpQuestion.TrueAswers = test.questions[index].TrueAswers;
            }
            finally
            {
                tmpQuestion.SaveQuestion = true;
                PrintQuestion();
            }
        }

        private void bt_previouslyQuestion_Click(object sender, EventArgs e)
        {
            if (index >= 1)
            {
                SaveResults();
                index--;
                lbox_question.SelectedIndex = index;
                DataInQuestion();
            }
        }

        private void bt_nextQuestion_Click(object sender, EventArgs e)
        {
            if (index < test.AmountQuestions - 1)
            {
                SaveResults();
                index++;
                lbox_question.SelectedIndex = index;
                DataInQuestion();
            }
        }

        private void lbox_question_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbox_question.SelectedIndex;
            PrintQuestion();
        }
    }
}
