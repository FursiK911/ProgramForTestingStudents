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
        private TestModel _testModel;

        public TestModel TestModel;

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
            FillListBox();
        }

        private void FillListBox()
        {
            for (int i = 0; i < test.questions.Count; i++)
                lbox_question.Items.Add("Вопрос " + (i + 1));
            lbox_question.SelectedIndex = index;
        }

        private void WriteQuestion()
        {
            lb_question.Text = "Вопрос " + (index + 1);
            tb_question.Text = test.questions[index].question;

            if (!test.DefaultTest)//test.questions[index].PointForQuestion != 0)
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
                    int i = 0;
                    foreach (bool value in participant.questions[index].answers.Values)
                    {
                        clb_answers.SetItemChecked(i++, value);
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
                    tmpQuestion.answers = test.questions[index].CloneAnswers();
                    tmpQuestion.TrueAswers = test.questions[index].TrueAswers;
                }
                else
                {
                    tmpQuestion.answers = participant.questions[index].CloneAnswers();
                    tmpQuestion.TrueAswers = participant.questions[index].TrueAswers;
                }
            }
            catch
            {
                tmpQuestion.answers = test.questions[index].CloneAnswers();
                tmpQuestion.TrueAswers = test.questions[index].TrueAswers;
            }
            finally
            {
                tmpQuestion.SaveQuestion = true;
            }
        }

        private void bt_previouslyQuestion_Click(object sender, EventArgs e)
        {
            if (index >= 1)
            {
                SaveResults();
                index--;
                DataInQuestion();
                lbox_question.SelectedIndex = index;

            }
        }

        private void bt_nextQuestion_Click(object sender, EventArgs e)
        {
            if (index < test.AmountQuestions - 1)
            {
                SaveResults();
                index++;
                DataInQuestion();
                lbox_question.SelectedIndex = index;
            }
        }

        private void lbox_question_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbox_question.SelectedIndex;
            WriteQuestion();
        }

        private void bt_finish_Click(object sender, EventArgs e)
        {
            SaveResults();
            for (int i = 0; i < participant.questions.Count; i++)
            {
                participant.questions[i].TrueAswers = 0;
                foreach (string key in participant.questions[i].answers.Keys)
                {
                    if (participant.questions[i].answers[key] == test.questions[i].answers[key] && test.questions[i].answers[key] == true)
                        participant.questions[i].TrueAswers++;
                    else if (participant.questions[i].answers[key] == true && test.questions[i].answers[key] == false)
                        participant.questions[i].TrueAswers--;
                }
            }

            participant.Points = 0;
            for (int i = 0; i < participant.questions.Count; i++)
            {
                if (participant.questions[i].TrueAswers > test.questions[i].TrueAswers || participant.questions[i].TrueAswers <= 0)
                    continue;

                else if (test.questions[i].TrueAswers == participant.questions[i].TrueAswers)
                {
                    if (!test.DefaultTest)
                        participant.Points += test.questions[i].PointForQuestion;
                    else
                        participant.Points += test.DefaultPoint;
                }

                else
                {
                    if (!test.DefaultTest)
                        participant.Points += (test.questions[i].PointForQuestion / test.questions[i].TrueAswers) * participant.questions[i].TrueAswers;
                    else
                        participant.Points += (test.DefaultPoint / test.questions[i].TrueAswers) * participant.questions[i].TrueAswers;
                }
            }

            MessageBox.Show("Ваши баллы: " + participant.Points.ToString());
        }
    }
}
