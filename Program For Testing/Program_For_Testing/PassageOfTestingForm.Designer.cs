namespace Program_For_Testing
{
    partial class PassageOfTestingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassageOfTestingForm));
            this.tb_question = new System.Windows.Forms.TextBox();
            this.lb_question = new System.Windows.Forms.Label();
            this.lb_answers = new System.Windows.Forms.Label();
            this.clb_answers = new System.Windows.Forms.CheckedListBox();
            this.lbox_question = new System.Windows.Forms.ListBox();
            this.bt_previouslyQuestion = new System.Windows.Forms.Button();
            this.bt_nextQuestion = new System.Windows.Forms.Button();
            this.lb_pointForAnswer = new System.Windows.Forms.Label();
            this.bt_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_question
            // 
            this.tb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_question.Location = new System.Drawing.Point(12, 26);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_question.Size = new System.Drawing.Size(638, 113);
            this.tb_question.TabIndex = 0;
            // 
            // lb_question
            // 
            this.lb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_question.AutoSize = true;
            this.lb_question.Location = new System.Drawing.Point(12, 9);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(44, 13);
            this.lb_question.TabIndex = 1;
            this.lb_question.Text = "Вопрос";
            // 
            // lb_answers
            // 
            this.lb_answers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_answers.AutoSize = true;
            this.lb_answers.Location = new System.Drawing.Point(12, 168);
            this.lb_answers.Name = "lb_answers";
            this.lb_answers.Size = new System.Drawing.Size(45, 13);
            this.lb_answers.TabIndex = 3;
            this.lb_answers.Text = "Ответы";
            // 
            // clb_answers
            // 
            this.clb_answers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clb_answers.FormattingEnabled = true;
            this.clb_answers.Location = new System.Drawing.Point(12, 184);
            this.clb_answers.Name = "clb_answers";
            this.clb_answers.Size = new System.Drawing.Size(400, 214);
            this.clb_answers.TabIndex = 4;
            // 
            // lbox_question
            // 
            this.lbox_question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_question.FormattingEnabled = true;
            this.lbox_question.Location = new System.Drawing.Point(679, 26);
            this.lbox_question.Name = "lbox_question";
            this.lbox_question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbox_question.Size = new System.Drawing.Size(149, 368);
            this.lbox_question.TabIndex = 5;
            this.lbox_question.SelectedIndexChanged += new System.EventHandler(this.lbox_question_SelectedIndexChanged);
            // 
            // bt_previouslyQuestion
            // 
            this.bt_previouslyQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_previouslyQuestion.Image = ((System.Drawing.Image)(resources.GetObject("bt_previouslyQuestion.Image")));
            this.bt_previouslyQuestion.Location = new System.Drawing.Point(433, 184);
            this.bt_previouslyQuestion.Name = "bt_previouslyQuestion";
            this.bt_previouslyQuestion.Size = new System.Drawing.Size(109, 76);
            this.bt_previouslyQuestion.TabIndex = 6;
            this.bt_previouslyQuestion.UseVisualStyleBackColor = true;
            this.bt_previouslyQuestion.Click += new System.EventHandler(this.bt_previouslyQuestion_Click);
            // 
            // bt_nextQuestion
            // 
            this.bt_nextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_nextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("bt_nextQuestion.Image")));
            this.bt_nextQuestion.Location = new System.Drawing.Point(548, 184);
            this.bt_nextQuestion.Name = "bt_nextQuestion";
            this.bt_nextQuestion.Size = new System.Drawing.Size(109, 76);
            this.bt_nextQuestion.TabIndex = 7;
            this.bt_nextQuestion.UseVisualStyleBackColor = true;
            this.bt_nextQuestion.Click += new System.EventHandler(this.bt_nextQuestion_Click);
            // 
            // lb_pointForAnswer
            // 
            this.lb_pointForAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pointForAnswer.AutoSize = true;
            this.lb_pointForAnswer.Location = new System.Drawing.Point(272, 168);
            this.lb_pointForAnswer.Name = "lb_pointForAnswer";
            this.lb_pointForAnswer.Size = new System.Drawing.Size(94, 13);
            this.lb_pointForAnswer.TabIndex = 8;
            this.lb_pointForAnswer.Text = "Баллы за вопрос";
            // 
            // bt_finish
            // 
            this.bt_finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_finish.Image = ((System.Drawing.Image)(resources.GetObject("bt_finish.Image")));
            this.bt_finish.Location = new System.Drawing.Point(433, 313);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(224, 85);
            this.bt_finish.TabIndex = 9;
            this.bt_finish.Text = "Завершить тест";
            this.bt_finish.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_finish.UseVisualStyleBackColor = true;
            this.bt_finish.Click += new System.EventHandler(this.bt_finish_Click);
            // 
            // PassageOfTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 416);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.lb_pointForAnswer);
            this.Controls.Add(this.bt_nextQuestion);
            this.Controls.Add(this.bt_previouslyQuestion);
            this.Controls.Add(this.lbox_question);
            this.Controls.Add(this.clb_answers);
            this.Controls.Add(this.lb_answers);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.tb_question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 377);
            this.Name = "PassageOfTestingForm";
            this.Text = "Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.Label lb_answers;
        private System.Windows.Forms.CheckedListBox clb_answers;
        private System.Windows.Forms.ListBox lbox_question;
        private System.Windows.Forms.Button bt_previouslyQuestion;
        private System.Windows.Forms.Button bt_nextQuestion;
        private System.Windows.Forms.Label lb_pointForAnswer;
        private System.Windows.Forms.Button bt_finish;
    }
}