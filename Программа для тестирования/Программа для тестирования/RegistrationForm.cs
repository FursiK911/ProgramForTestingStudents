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
using System.IO;
using System.Runtime.Serialization.Json;

namespace Программа_для_тестирования
{
    public partial class RegistrationForm : Form
    {
        List<TestModel> test = new List<TestModel>();
        Participant p = new Participant();
        int index = 0;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Tests\\";

            if (Directory.Exists(path))
            {
                string[] nameFiles = Directory.GetFiles(path);
                foreach (string file in nameFiles)
                {
                    FileStream fs = new FileStream(file, FileMode.Open);
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TestModel));
                    test.Add((TestModel)jsonFormatter.ReadObject(fs));

                    bool inList = false;
                    for (int i = 0; i < cb_discipline.Items.Count; i++)
                    {
                        if (test[index].AcademicDiscipline == cb_discipline.Items[i].ToString())
                        {
                            inList = true;
                            break;
                        }
                    }
                    if (!inList)
                        cb_discipline.Items.Add(test[index].AcademicDiscipline);
                    index++;
                }
            }
            else
            {
                MessageBox.Show("Указанного пути не существует!\n" + path);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
            => this.Close();

        private void cb_discipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_topic.Items.Clear();
            for (int i = 0; i < test.Count; i++)
                if (test[i].AcademicDiscipline == cb_discipline.SelectedItem.ToString())
                    cb_topic.Items.Add(test[i].Topic);
        }

        private void cb_topic_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < test.Count; i++)
                if (test[i].Topic == cb_topic.SelectedItem.ToString())
                    index = i;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            //if (tb_fullName.Text != "" && tb_specialty.Text != "" && tb_course.Text != "" && tb_group.Text != "" && cb_topic.SelectedItem != null)
            //{
            //    p.FullName = tb_fullName.Text;
            //    p.Specialty = tb_specialty.Text;
            //    p.Course = int.Parse(tb_course.Text);
            //    p.Group = tb_group.Text;
            this.Hide();
            PassageOfTestingForm testingForm = new PassageOfTestingForm(test[index], p);
            testingForm.ShowDialog();
            this.Close();
            //}
            //else
            //    MessageBox.Show("Введите недостающее поле!");
        }
    }
}
