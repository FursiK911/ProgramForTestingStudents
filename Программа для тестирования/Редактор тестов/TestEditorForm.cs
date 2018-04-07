using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Редактор_тестов
{
    public partial class TestEditorForm : Form
    {
        TestModel test = new TestModel();
        QuestionModel tmpQuestion = new QuestionModel();
        int index = 0;
        public TestEditorForm()
        {
            InitializeComponent();
            tmpQuestion.SaveQuestion = false;
            VisibleControlQuestions(false);
            lb_pointForQuestion.Visible = false;
            tb_pointForQuestion.Visible = false;
        }


        private void DataInQuestion()
        {
            if (index + 1 > test.questions.Count)
            {
                tmpQuestion.answers.Clear();
                tmpQuestion.question = "";
                tmpQuestion.SaveQuestion = false;
                tmpQuestion.PointForQuestion = 0;
                tmpQuestion.TrueAswers = 0;
                clb_answers.Items.Clear();
                tb_question.Text = "";
                tb_pointForQuestion.Text = "";
            }
            else
            {
                tmpQuestion.question = test.questions[index].question;

                clb_answers.Items.Clear();
                tmpQuestion.answers = test.questions[index].answers;

                foreach (string s in tmpQuestion.answers.Keys)
                {
                    clb_answers.Items.Add(s);
                }

                for (int i = 0; i < test.questions[index].answers.Count; i++)
                {
                    clb_answers.SetItemChecked(i, test.questions[index].answers[clb_answers.Items[i].ToString()]);
                }

                tmpQuestion.SaveQuestion = true;
                tmpQuestion.TrueAswers = test.questions[index].TrueAswers;
                tmpQuestion.PointForQuestion = test.questions[index].PointForQuestion;
                tb_pointForQuestion.Text = tmpQuestion.PointForQuestion.ToString();
                PrintQuestion();
            }
        }

        private void PrintQuestion()
        {
            tb_academicDiscipline.Text = test.AcademicDiscipline;
            tb_topic.Text = test.Topic;
            tb_amountQuestions.Text = test.AmountQuestions.ToString();
            tb_question.Text = test.questions[index].question;
            cb_defaultTest.Checked = !test.DefaultTest;
            tb_points.Text = test.MaxPoints.ToString();
            clb_answers.Items.Clear();

            foreach (string s in test.questions[index].answers.Keys)
            {
                clb_answers.Items.Add(s);
            }

            for (int i = 0; i < test.questions[index].answers.Count; i++)
            {
                clb_answers.SetItemChecked(i, test.questions[index].answers[clb_answers.Items[i].ToString()]);
            }
        }

        private void VisibleControlQuestions(bool isVisible)
        {
            lb_previousQuestion.Visible = isVisible;
            lb_nextQuestion.Visible = isVisible;
            lb_questions.Visible = isVisible;
            lb_answers.Visible = isVisible;
            clb_answers.Visible = isVisible;
            tb_question.Visible = isVisible;
            bt_previousQuestion.Visible = isVisible;
            bt_nextQuestion.Visible = isVisible;
            bt_addAnwer.Visible = isVisible;
            bt_deleteAnswer.Visible = isVisible;
            bt_editAnswer.Visible = isVisible;
            if (!test.DefaultTest)
            {
                lb_pointForQuestion.Visible = true;
                tb_pointForQuestion.Visible = true;
            }
            else
            {
                lb_pointForQuestion.Visible = false;
                tb_pointForQuestion.Visible = false;
            }
        }

        private void SaveData()
        {
            tmpQuestion.question = tb_question.Text;
            tmpQuestion.answers.Clear();
            tmpQuestion.TrueAswers = 0;

            tmpQuestion.question = tb_question.Text;
            for (int i = 0; i < clb_answers.Items.Count; i++)
            {
                if (clb_answers.GetItemChecked(i))
                {
                    tmpQuestion.TrueAswers++;
                    tmpQuestion.answers.Add(clb_answers.Items[i].ToString(), true);
                }
                else
                    tmpQuestion.answers.Add(clb_answers.Items[i].ToString(), false);
            }

            if (!test.DefaultTest)
                tmpQuestion.PointForQuestion = double.Parse(tb_pointForQuestion.Text);
            else
                tmpQuestion.PointForQuestion = 0;

            CalculatePoints();

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
        
        private void Exit()
        {
            string message = "Cохранить этот тест?";
            string caption = "Выход";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                SaveData();
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TestModel));
                SaveFileDialog spd = new SaveFileDialog();
                if (spd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(spd.FileName + ".json", FileMode.Create))
                    {
                        jsonFormatter.WriteObject(fs, test);
                    }
                }
                this.Close();
            }

            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void CalculatePoints()
        {
            try
            {
                if (!test.DefaultTest)
                {
                    test.DefaultPoint = double.Parse(tb_points.Text);
                    tb_pointForQuestion.Text = test.DefaultPoint.ToString();
                }
                else
                {
                    test.MaxPoints = double.Parse(tb_points.Text);
                    test.DefaultPoint = test.MaxPoints / test.AmountQuestions;
                }
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные!");
                tb_points.Text = "";
            }
        }

        private void ClearAllControl()
        {
            tb_academicDiscipline.Text = "";
            tb_topic.Text = "";
            tb_amountQuestions.Text = "";
            tb_question.Text = "";
            tb_points.Text = "";
            tb_pointForQuestion.Text = "";
            clb_answers.Items.Clear();
            cb_defaultTest.Checked = false;
            index = 0;
        }

        private void tb_academicDiscipline_TextChanged(object sender, EventArgs e)
        {
            test.AcademicDiscipline = tb_academicDiscipline.Text;
        }

        private void tb_topic_TextChanged(object sender, EventArgs e)
        {
            test.Topic = tb_topic.Text;
        }

        private void tb_amountQuestions_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_amountQuestions.Text != "" && int.Parse(tb_amountQuestions.Text) != 0)
                {
                    VisibleControlQuestions(true);
                    test.AmountQuestions = int.Parse(tb_amountQuestions.Text);
                }
                else
                    VisibleControlQuestions(false);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные!");
                tb_amountQuestions.Text = "";
            }
        }

        private void tb_points_TextChanged(object sender, EventArgs e)
        {
            CalculatePoints();
        }

        private void cb_defaultTest_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_defaultTest.Checked)
            {
                lb_pointForQuestion.Visible = true;
                tb_pointForQuestion.Visible = true;
                tb_points.Text = "";
                test.DefaultTest = false;
                lb_points.Text = "Балл за вопрос по умолчанию";
            }
            else
            {
                lb_pointForQuestion.Visible = false;
                tb_pointForQuestion.Visible = false;
                tb_points.Text = "";
                test.DefaultTest = true;
                lb_points.Text = "Максимальное количество баллов";
            }
        }

        private void bt_addAnwer_Click(object sender, EventArgs e)
        {
            try
            {
                clb_answers.Items.Add("Новый ответ " + clb_answers.Items.Count);
                tmpQuestion.answers.Add(clb_answers.Items[clb_answers.Items.Count - 1].ToString(), false);
            }
            catch
            {
                MessageBox.Show("'Новый ответ " + clb_answers.Items.Count + "' уже существует");
            }
            SaveData();
        }

        private void bt_editAnswer_Click(object sender, EventArgs e)
        {
            SaveData();
            try
            {
                string tmpAnswer = clb_answers.Items[clb_answers.SelectedIndex].ToString();
                bool tmpCheckState = clb_answers.GetItemChecked(clb_answers.SelectedIndex);

                QuestionEditorForm edit = new QuestionEditorForm(test, index, tmpAnswer, tmpCheckState);
                edit.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Выберите элемент!");
            }

            PrintQuestion();
            SaveData();
        }

        private void bt_deleteAnswer_Click(object sender, EventArgs e)
        {
            if (clb_answers.SelectedItem != null)
            {
                tmpQuestion.answers.Remove(clb_answers.SelectedItem.ToString());
                clb_answers.Items.RemoveAt(clb_answers.SelectedIndex);
            }
            SaveData();
        }

        private void tb_pointForQuestion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_pointForQuestion.Text != null && tb_pointForQuestion.Text != "0")
                    tmpQuestion.PointForQuestion = double.Parse(tb_pointForQuestion.Text);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные!");
                tb_pointForQuestion.Text = "";
            }
        }

        private void bt_previousQuestion_Click(object sender, EventArgs e)
        {
            SaveData();
            if (tmpQuestion.TrueAswers != 0)
            {
                if (index >= 1)
                {

                    index--;
                    DataInQuestion();
                }
            }
            else
            {
                MessageBox.Show("Должен присутствовать хотя бы один правильный ответ!");
            }
        }

        private void bt_nextQuestion_Click(object sender, EventArgs e)
        {
            SaveData();
            if (tmpQuestion.TrueAswers != 0)
            {
                if (index < test.AmountQuestions - 1)
                {
                    index++;
                    DataInQuestion();
                }
            }
            else
            {
                MessageBox.Show("Должен присутствовать хотя бы один правильный ответ!");
            }
        }

        private void ms_create_Click(object sender, EventArgs e)
        {
            string message = "Вы собираетесь создать новый тест. Сохранить старый?";
            string caption = "Сохранить?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                ms_saveAs_Click(sender, e);
                test = new TestModel();
                tmpQuestion = new QuestionModel();
                ClearAllControl();
            }

            else if (result == DialogResult.No)
            {
                test = new TestModel();
                tmpQuestion = new QuestionModel();
                ClearAllControl();
            }
        }

        private void ms_open_Click(object sender, EventArgs e)
        {
            index = 0;
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "Test files (*.test)|*.test|All files (*.*)|*.*";
            opd.FilterIndex = 1;
            opd.RestoreDirectory = true;
            if (opd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(opd.FileName, FileMode.Open))
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TestModel));

                    test = (TestModel)jsonFormatter.ReadObject(fs);
                    test.Path = opd.SafeFileName;

                    DataInQuestion();
                }
            }
        }

        private void ms_save_Click(object sender, EventArgs e)
        {
            SaveData();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TestModel));

            string path;
            if (test.Path == "")
            {
                path = test.AcademicDiscipline + "." + test.Topic + ".test";
                test.Path = path;
            }
            else
                path = test.Path;

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, test);
            } 
        }

        private void ms_saveAs_Click(object sender, EventArgs e)
        {
            SaveData();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TestModel));
            SaveFileDialog spd = new SaveFileDialog();
            if (spd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(spd.FileName + ".test", FileMode.Create))
                {
                    jsonFormatter.WriteObject(fs, test);
                }
            }
        }

        private void ms_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
