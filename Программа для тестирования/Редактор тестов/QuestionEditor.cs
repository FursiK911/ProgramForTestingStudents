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
    public partial class QuestionEditor : Form
    {
        TestModel test = new TestModel();
        int indexQuestion;
        string keyAnswer;
        public QuestionEditor()
        {
            InitializeComponent();
        }
        public QuestionEditor(TestModel test, int indexQuestion, string keyAnswer, bool trueAnswer)
        {
            InitializeComponent();
            this.test = test;
            this.indexQuestion = indexQuestion;
            this.keyAnswer = keyAnswer;
            textBox1.Text = this.keyAnswer;
            try
            {
                checkBox1.Checked = test.questions[indexQuestion].answers[keyAnswer];
                test.questions[indexQuestion].answers.Remove(keyAnswer);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка индекса выделенного ответа!");
                this.Close();
            }
            
        }

        private void QuestionEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            test.newAnswer = textBox1.Text;
            test.questions[indexQuestion].answers.Add(textBox1.Text,checkBox1.Checked);
        }
    }
}
