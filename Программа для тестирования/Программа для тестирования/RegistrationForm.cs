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
    public partial class Form1 : Form
    {
        List <TestModel> test = new List<TestModel>();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nameFiles;
            FolderBrowserDialog fpd = new FolderBrowserDialog();
            if (fpd.ShowDialog() == DialogResult.OK)
            {
                nameFiles = Directory.GetFiles(fpd.SelectedPath);
                foreach (string file in nameFiles)
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TestModel));

                        test[index++] = (TestModel)jsonFormatter.ReadObject(fs);
                    }
                }
            }
        }
    }
}
