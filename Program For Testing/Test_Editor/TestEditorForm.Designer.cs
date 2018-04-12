namespace TestEditor
{
    partial class TestEditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestEditorForm));
            this.bt_previousQuestion = new System.Windows.Forms.Button();
            this.bt_nextQuestion = new System.Windows.Forms.Button();
            this.lb_previousQuestion = new System.Windows.Forms.Label();
            this.lb_nextQuestion = new System.Windows.Forms.Label();
            this.tb_academicDiscipline = new System.Windows.Forms.TextBox();
            this.lb_academicDiscipline = new System.Windows.Forms.Label();
            this.lb_topic = new System.Windows.Forms.Label();
            this.tb_topic = new System.Windows.Forms.TextBox();
            this.lb_amountQuestions = new System.Windows.Forms.Label();
            this.tb_amountQuestions = new System.Windows.Forms.TextBox();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.lb_questions = new System.Windows.Forms.Label();
            this.lb_answers = new System.Windows.Forms.Label();
            this.bt_addAnwer = new System.Windows.Forms.Button();
            this.bt_deleteAnswer = new System.Windows.Forms.Button();
            this.bt_editAnswer = new System.Windows.Forms.Button();
            this.lb_points = new System.Windows.Forms.Label();
            this.tb_points = new System.Windows.Forms.TextBox();
            this.cb_defaultTest = new System.Windows.Forms.CheckBox();
            this.clb_answers = new System.Windows.Forms.CheckedListBox();
            this.lb_pointForQuestion = new System.Windows.Forms.Label();
            this.tb_pointForQuestion = new System.Windows.Forms.TextBox();
            this.ts_manageTest = new System.Windows.Forms.ToolStrip();
            this.tsb_create = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ts_manageTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_previousQuestion
            // 
            this.bt_previousQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_previousQuestion.Image = ((System.Drawing.Image)(resources.GetObject("bt_previousQuestion.Image")));
            this.bt_previousQuestion.Location = new System.Drawing.Point(457, 390);
            this.bt_previousQuestion.Name = "bt_previousQuestion";
            this.bt_previousQuestion.Size = new System.Drawing.Size(118, 57);
            this.bt_previousQuestion.TabIndex = 1;
            this.bt_previousQuestion.UseVisualStyleBackColor = true;
            this.bt_previousQuestion.Click += new System.EventHandler(this.bt_previousQuestion_Click);
            // 
            // bt_nextQuestion
            // 
            this.bt_nextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_nextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("bt_nextQuestion.Image")));
            this.bt_nextQuestion.Location = new System.Drawing.Point(581, 390);
            this.bt_nextQuestion.Name = "bt_nextQuestion";
            this.bt_nextQuestion.Size = new System.Drawing.Size(118, 57);
            this.bt_nextQuestion.TabIndex = 2;
            this.bt_nextQuestion.UseVisualStyleBackColor = true;
            this.bt_nextQuestion.Click += new System.EventHandler(this.bt_nextQuestion_Click);
            // 
            // lb_previousQuestion
            // 
            this.lb_previousQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_previousQuestion.AutoSize = true;
            this.lb_previousQuestion.Location = new System.Drawing.Point(454, 374);
            this.lb_previousQuestion.Name = "lb_previousQuestion";
            this.lb_previousQuestion.Size = new System.Drawing.Size(112, 13);
            this.lb_previousQuestion.TabIndex = 3;
            this.lb_previousQuestion.Text = "Предыдущий вопрос";
            // 
            // lb_nextQuestion
            // 
            this.lb_nextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nextQuestion.AutoSize = true;
            this.lb_nextQuestion.Location = new System.Drawing.Point(578, 374);
            this.lb_nextQuestion.Name = "lb_nextQuestion";
            this.lb_nextQuestion.Size = new System.Drawing.Size(105, 13);
            this.lb_nextQuestion.TabIndex = 4;
            this.lb_nextQuestion.Text = "Следующий вопрос";
            // 
            // tb_academicDiscipline
            // 
            this.tb_academicDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_academicDiscipline.Location = new System.Drawing.Point(12, 47);
            this.tb_academicDiscipline.Name = "tb_academicDiscipline";
            this.tb_academicDiscipline.Size = new System.Drawing.Size(162, 20);
            this.tb_academicDiscipline.TabIndex = 6;
            this.tb_academicDiscipline.TextChanged += new System.EventHandler(this.tb_academicDiscipline_TextChanged);
            // 
            // lb_academicDiscipline
            // 
            this.lb_academicDiscipline.AutoSize = true;
            this.lb_academicDiscipline.Location = new System.Drawing.Point(9, 31);
            this.lb_academicDiscipline.Name = "lb_academicDiscipline";
            this.lb_academicDiscipline.Size = new System.Drawing.Size(113, 13);
            this.lb_academicDiscipline.TabIndex = 7;
            this.lb_academicDiscipline.Text = "Учебная дисциплина";
            // 
            // lb_topic
            // 
            this.lb_topic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_topic.AutoSize = true;
            this.lb_topic.Location = new System.Drawing.Point(194, 31);
            this.lb_topic.Name = "lb_topic";
            this.lb_topic.Size = new System.Drawing.Size(34, 13);
            this.lb_topic.TabIndex = 9;
            this.lb_topic.Text = "Тема";
            // 
            // tb_topic
            // 
            this.tb_topic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_topic.Location = new System.Drawing.Point(197, 47);
            this.tb_topic.MaximumSize = new System.Drawing.Size(220, 20);
            this.tb_topic.Name = "tb_topic";
            this.tb_topic.Size = new System.Drawing.Size(192, 20);
            this.tb_topic.TabIndex = 8;
            this.tb_topic.TextChanged += new System.EventHandler(this.tb_topic_TextChanged);
            // 
            // lb_amountQuestions
            // 
            this.lb_amountQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_amountQuestions.AutoSize = true;
            this.lb_amountQuestions.Location = new System.Drawing.Point(406, 31);
            this.lb_amountQuestions.Name = "lb_amountQuestions";
            this.lb_amountQuestions.Size = new System.Drawing.Size(86, 13);
            this.lb_amountQuestions.TabIndex = 11;
            this.lb_amountQuestions.Text = "Кл-во вопросов";
            // 
            // tb_amountQuestions
            // 
            this.tb_amountQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_amountQuestions.Location = new System.Drawing.Point(409, 47);
            this.tb_amountQuestions.Name = "tb_amountQuestions";
            this.tb_amountQuestions.Size = new System.Drawing.Size(83, 20);
            this.tb_amountQuestions.TabIndex = 10;
            this.tb_amountQuestions.TextChanged += new System.EventHandler(this.tb_amountQuestions_TextChanged);
            // 
            // tb_question
            // 
            this.tb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_question.Location = new System.Drawing.Point(12, 106);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(687, 64);
            this.tb_question.TabIndex = 13;
            // 
            // lb_questions
            // 
            this.lb_questions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_questions.AutoSize = true;
            this.lb_questions.Location = new System.Drawing.Point(9, 90);
            this.lb_questions.Name = "lb_questions";
            this.lb_questions.Size = new System.Drawing.Size(44, 13);
            this.lb_questions.TabIndex = 14;
            this.lb_questions.Text = "Вопрос";
            // 
            // lb_answers
            // 
            this.lb_answers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_answers.AutoSize = true;
            this.lb_answers.Location = new System.Drawing.Point(9, 173);
            this.lb_answers.Name = "lb_answers";
            this.lb_answers.Size = new System.Drawing.Size(100, 13);
            this.lb_answers.TabIndex = 15;
            this.lb_answers.Text = "Варианты ответов";
            // 
            // bt_addAnwer
            // 
            this.bt_addAnwer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addAnwer.Location = new System.Drawing.Point(457, 189);
            this.bt_addAnwer.MaximumSize = new System.Drawing.Size(254, 39);
            this.bt_addAnwer.MinimumSize = new System.Drawing.Size(254, 39);
            this.bt_addAnwer.Name = "bt_addAnwer";
            this.bt_addAnwer.Size = new System.Drawing.Size(254, 39);
            this.bt_addAnwer.TabIndex = 20;
            this.bt_addAnwer.Text = "Добавить вариант ответа";
            this.bt_addAnwer.UseVisualStyleBackColor = true;
            this.bt_addAnwer.Click += new System.EventHandler(this.bt_addAnwer_Click);
            // 
            // bt_deleteAnswer
            // 
            this.bt_deleteAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deleteAnswer.Location = new System.Drawing.Point(457, 279);
            this.bt_deleteAnswer.MaximumSize = new System.Drawing.Size(254, 39);
            this.bt_deleteAnswer.MinimumSize = new System.Drawing.Size(254, 39);
            this.bt_deleteAnswer.Name = "bt_deleteAnswer";
            this.bt_deleteAnswer.Size = new System.Drawing.Size(254, 39);
            this.bt_deleteAnswer.TabIndex = 21;
            this.bt_deleteAnswer.Text = "Удалить вариант ответа";
            this.bt_deleteAnswer.UseVisualStyleBackColor = true;
            this.bt_deleteAnswer.Click += new System.EventHandler(this.bt_deleteAnswer_Click);
            // 
            // bt_editAnswer
            // 
            this.bt_editAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_editAnswer.Location = new System.Drawing.Point(457, 234);
            this.bt_editAnswer.MaximumSize = new System.Drawing.Size(254, 39);
            this.bt_editAnswer.MinimumSize = new System.Drawing.Size(254, 39);
            this.bt_editAnswer.Name = "bt_editAnswer";
            this.bt_editAnswer.Size = new System.Drawing.Size(254, 39);
            this.bt_editAnswer.TabIndex = 24;
            this.bt_editAnswer.Text = "Изменить вариант ответа";
            this.bt_editAnswer.UseVisualStyleBackColor = true;
            this.bt_editAnswer.Click += new System.EventHandler(this.bt_editAnswer_Click);
            // 
            // lb_points
            // 
            this.lb_points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_points.AutoSize = true;
            this.lb_points.Location = new System.Drawing.Point(499, 31);
            this.lb_points.Name = "lb_points";
            this.lb_points.Size = new System.Drawing.Size(184, 13);
            this.lb_points.TabIndex = 26;
            this.lb_points.Text = "Максимальное количество баллов";
            // 
            // tb_points
            // 
            this.tb_points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_points.Location = new System.Drawing.Point(502, 47);
            this.tb_points.Name = "tb_points";
            this.tb_points.Size = new System.Drawing.Size(83, 20);
            this.tb_points.TabIndex = 25;
            this.tb_points.TextChanged += new System.EventHandler(this.tb_points_TextChanged);
            // 
            // cb_defaultTest
            // 
            this.cb_defaultTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_defaultTest.AutoSize = true;
            this.cb_defaultTest.Location = new System.Drawing.Point(591, 47);
            this.cb_defaultTest.Name = "cb_defaultTest";
            this.cb_defaultTest.Size = new System.Drawing.Size(121, 43);
            this.cb_defaultTest.TabIndex = 27;
            this.cb_defaultTest.Text = "Указывать баллы \r\nдля каждого \r\nвопроса";
            this.cb_defaultTest.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_defaultTest.UseVisualStyleBackColor = true;
            this.cb_defaultTest.CheckedChanged += new System.EventHandler(this.cb_defaultTest_CheckedChanged);
            // 
            // clb_answers
            // 
            this.clb_answers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_answers.FormattingEnabled = true;
            this.clb_answers.Location = new System.Drawing.Point(12, 189);
            this.clb_answers.Name = "clb_answers";
            this.clb_answers.ScrollAlwaysVisible = true;
            this.clb_answers.Size = new System.Drawing.Size(439, 259);
            this.clb_answers.TabIndex = 28;
            // 
            // lb_pointForQuestion
            // 
            this.lb_pointForQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pointForQuestion.AutoSize = true;
            this.lb_pointForQuestion.Location = new System.Drawing.Point(457, 340);
            this.lb_pointForQuestion.Name = "lb_pointForQuestion";
            this.lb_pointForQuestion.Size = new System.Drawing.Size(89, 13);
            this.lb_pointForQuestion.TabIndex = 30;
            this.lb_pointForQuestion.Text = "Балл за вопрос:";
            // 
            // tb_pointForQuestion
            // 
            this.tb_pointForQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pointForQuestion.Location = new System.Drawing.Point(552, 337);
            this.tb_pointForQuestion.Name = "tb_pointForQuestion";
            this.tb_pointForQuestion.Size = new System.Drawing.Size(131, 20);
            this.tb_pointForQuestion.TabIndex = 31;
            this.tb_pointForQuestion.TextChanged += new System.EventHandler(this.tb_pointForQuestion_TextChanged);
            // 
            // ts_manageTest
            // 
            this.ts_manageTest.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_manageTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_create,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6});
            this.ts_manageTest.Location = new System.Drawing.Point(0, 0);
            this.ts_manageTest.Name = "ts_manageTest";
            this.ts_manageTest.Size = new System.Drawing.Size(711, 25);
            this.ts_manageTest.TabIndex = 32;
            this.ts_manageTest.Text = "toolStrip1";
            // 
            // tsb_create
            // 
            this.tsb_create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_create.Image = ((System.Drawing.Image)(resources.GetObject("tsb_create.Image")));
            this.tsb_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_create.Name = "tsb_create";
            this.tsb_create.Size = new System.Drawing.Size(23, 22);
            this.tsb_create.Text = "Открыть";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // TestEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 459);
            this.Controls.Add(this.ts_manageTest);
            this.Controls.Add(this.tb_pointForQuestion);
            this.Controls.Add(this.lb_pointForQuestion);
            this.Controls.Add(this.clb_answers);
            this.Controls.Add(this.cb_defaultTest);
            this.Controls.Add(this.lb_points);
            this.Controls.Add(this.tb_points);
            this.Controls.Add(this.bt_editAnswer);
            this.Controls.Add(this.bt_deleteAnswer);
            this.Controls.Add(this.bt_addAnwer);
            this.Controls.Add(this.lb_answers);
            this.Controls.Add(this.lb_questions);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.lb_amountQuestions);
            this.Controls.Add(this.tb_amountQuestions);
            this.Controls.Add(this.lb_topic);
            this.Controls.Add(this.tb_topic);
            this.Controls.Add(this.lb_academicDiscipline);
            this.Controls.Add(this.tb_academicDiscipline);
            this.Controls.Add(this.lb_nextQuestion);
            this.Controls.Add(this.lb_previousQuestion);
            this.Controls.Add(this.bt_nextQuestion);
            this.Controls.Add(this.bt_previousQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(727, 497);
            this.Name = "TestEditorForm";
            this.Text = "Редактор тестов";
            this.ts_manageTest.ResumeLayout(false);
            this.ts_manageTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_previousQuestion;
        private System.Windows.Forms.Button bt_nextQuestion;
        private System.Windows.Forms.Label lb_previousQuestion;
        private System.Windows.Forms.Label lb_nextQuestion;
        private System.Windows.Forms.TextBox tb_academicDiscipline;
        private System.Windows.Forms.Label lb_academicDiscipline;
        private System.Windows.Forms.Label lb_topic;
        private System.Windows.Forms.TextBox tb_topic;
        private System.Windows.Forms.Label lb_amountQuestions;
        private System.Windows.Forms.TextBox tb_amountQuestions;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label lb_questions;
        private System.Windows.Forms.Label lb_answers;
        private System.Windows.Forms.Button bt_addAnwer;
        private System.Windows.Forms.Button bt_deleteAnswer;
        private System.Windows.Forms.Button bt_editAnswer;
        private System.Windows.Forms.Label lb_points;
        private System.Windows.Forms.TextBox tb_points;
        private System.Windows.Forms.CheckBox cb_defaultTest;
        private System.Windows.Forms.CheckedListBox clb_answers;
        private System.Windows.Forms.Label lb_pointForQuestion;
        private System.Windows.Forms.TextBox tb_pointForQuestion;
        private System.Windows.Forms.ToolStrip ts_manageTest;
        private System.Windows.Forms.ToolStripButton tsb_create;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}

