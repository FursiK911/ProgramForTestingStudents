using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using TestEditor;
using System.IO;

namespace Program_For_Testing
{
    public partial class PassageOfTestingForm : Form
    {
        TestModel _test;
        Participant participant;
        QuestionModel tmpQuestion = new QuestionModel();
        ExcelService _exSave;
        int index = 0;
        public PassageOfTestingForm()
        {
            InitializeComponent();
        }

        public PassageOfTestingForm(TestModel t, Participant p)
        {
            InitializeComponent();
            _test = t;
            participant = p;
            _exSave = new ExcelService(p, t);
            FillListBox();
            _test.CreateWorkSpace();
        }

        private void FillListBox() 
        {
            for (int i = 0; i < _test.questions.Count; i++)
                lbox_question.Items.Add("Вопрос " + (i + 1));
            lbox_question.SelectedIndex = index;
        }

        /// <summary>
        /// Вывод текущего Question на форму
        /// </summary>
        private void WriteQuestion()
        {
            lb_question.Text = "Вопрос " + (index + 1);
            tb_question.Text = _test.questions[index].question;

            if (!_test.DefaultTest)
                lb_pointForAnswer.Text = "Баллов за вопрос: " + _test.DoFormat(_test.questions[index].PointForQuestion);
            else
                lb_pointForAnswer.Text = "Баллов за вопрос: " + _test.DoFormat(_test.DefaultPoint);


            clb_answers.Items.Clear();
            try
            {
                if (!participant.questions[index].SaveQuestion)
                {
                    foreach (string s in _test.questions[index].answers.Keys)
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
                foreach (string s in _test.questions[index].answers.Keys)
                {
                    clb_answers.Items.Add(s);
                }
            }
        }
        /// <summary>
        /// Сохранение текущего Question в List Question
        /// </summary>
        private void SaveResults()
        {
            tmpQuestion.answers.Clear();
            for (int i = 0; i < clb_answers.Items.Count; i++)
            {
                tmpQuestion.answers.Add(clb_answers.Items[i].ToString(), clb_answers.GetItemChecked(i));
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

        /// <summary>
        /// Вывод из List Question в текущий Question
        /// </summary>
        private void DataInQuestion()
        {
            tmpQuestion.answers.Clear();
            clb_answers.Items.Clear();
            try
            {
                if (!participant.questions[index].SaveQuestion)
                {
                    tmpQuestion.answers = _test.questions[index].CloneAnswers();
                    tmpQuestion.TrueAswers = _test.questions[index].TrueAswers;
                }
                else
                {
                    tmpQuestion.answers = participant.questions[index].CloneAnswers();
                    tmpQuestion.TrueAswers = participant.questions[index].TrueAswers;
                }
            }
            catch
            {
                tmpQuestion.answers = _test.questions[index].CloneAnswers();
                tmpQuestion.TrueAswers = _test.questions[index].TrueAswers;
            }
            finally
            {
                tmpQuestion.SaveQuestion = true;
            }
        }

        private void CalculatePoints()
        {
            participant.Points = 0;
            for (int i = 0; i < participant.questions.Count; i++)
            {
                participant.questions[i].TrueAswers = 0;
                foreach (string key in participant.questions[i].answers.Keys)
                {
                    if (participant.questions[i].answers[key] == _test.questions[i].answers[key] && _test.questions[i].answers[key] == true)
                        participant.questions[i].TrueAswers++;
                    else if (participant.questions[i].answers[key] == true && _test.questions[i].answers[key] == false)
                        participant.questions[i].TrueAswers--;
                }
            }

            
            for (int i = 0; i < participant.questions.Count; i++)
            {
                if (participant.questions[i].TrueAswers > _test.questions[i].TrueAswers || participant.questions[i].TrueAswers <= 0)
                    continue;

                else if (_test.questions[i].TrueAswers == participant.questions[i].TrueAswers)
                {
                    if (!_test.DefaultTest)
                        participant.Points += _test.questions[i].PointForQuestion;
                    else
                        participant.Points += _test.DefaultPoint;
                }

                else
                {
                    if (!_test.DefaultTest)
                        participant.Points += (_test.questions[i].PointForQuestion / _test.questions[i].TrueAswers) * participant.questions[i].TrueAswers;
                    else
                        participant.Points += (_test.DefaultPoint / _test.questions[i].TrueAswers) * participant.questions[i].TrueAswers;
                }
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
            if (index < _test.AmountQuestions - 1)
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
            CalculatePoints();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Testing of Students\\Results\\" + _test.AcademicDiscipline + ".xls";

            if (_exSave.ExcelIsPresent())
            {
                if (File.Exists(path))
                {
                    _exSave.OpenDocument(path);
                    _exSave.WriteData();
                    _exSave.SaveDocument();
                    _exSave.CloseDocument();
                }
                else
                {
                    _exSave.NewDocument();
                    _exSave.WriteData();
                    _exSave.SaveAsDocument(path);
                    _exSave.CloseDocument();
                }
            }
            MessageBox.Show("Тест завершен! Вы набрали " + participant.DoFormat(participant.Points) + " баллов");
            this.Close();
        }
    }
}
