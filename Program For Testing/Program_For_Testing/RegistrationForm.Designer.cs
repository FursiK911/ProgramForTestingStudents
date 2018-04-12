namespace Program_For_Testing
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.tb_fullName = new System.Windows.Forms.TextBox();
            this.lb_fullName = new System.Windows.Forms.Label();
            this.lb_specialty = new System.Windows.Forms.Label();
            this.tb_specialty = new System.Windows.Forms.TextBox();
            this.lb_course = new System.Windows.Forms.Label();
            this.tb_course = new System.Windows.Forms.TextBox();
            this.lb_group = new System.Windows.Forms.Label();
            this.tb_group = new System.Windows.Forms.TextBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.cb_discipline = new System.Windows.Forms.ComboBox();
            this.lb_discipline = new System.Windows.Forms.Label();
            this.lb_topic = new System.Windows.Forms.Label();
            this.cb_topic = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_fullName
            // 
            this.tb_fullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_fullName.Location = new System.Drawing.Point(12, 26);
            this.tb_fullName.Name = "tb_fullName";
            this.tb_fullName.Size = new System.Drawing.Size(169, 20);
            this.tb_fullName.TabIndex = 0;
            // 
            // lb_fullName
            // 
            this.lb_fullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_fullName.AutoSize = true;
            this.lb_fullName.Location = new System.Drawing.Point(9, 10);
            this.lb_fullName.Name = "lb_fullName";
            this.lb_fullName.Size = new System.Drawing.Size(34, 13);
            this.lb_fullName.TabIndex = 1;
            this.lb_fullName.Text = "ФИО";
            // 
            // lb_specialty
            // 
            this.lb_specialty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_specialty.AutoSize = true;
            this.lb_specialty.Location = new System.Drawing.Point(9, 57);
            this.lb_specialty.Name = "lb_specialty";
            this.lb_specialty.Size = new System.Drawing.Size(85, 13);
            this.lb_specialty.TabIndex = 3;
            this.lb_specialty.Text = "Специальность";
            // 
            // tb_specialty
            // 
            this.tb_specialty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_specialty.Location = new System.Drawing.Point(12, 73);
            this.tb_specialty.Name = "tb_specialty";
            this.tb_specialty.Size = new System.Drawing.Size(169, 20);
            this.tb_specialty.TabIndex = 2;
            // 
            // lb_course
            // 
            this.lb_course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_course.AutoSize = true;
            this.lb_course.Location = new System.Drawing.Point(9, 104);
            this.lb_course.Name = "lb_course";
            this.lb_course.Size = new System.Drawing.Size(31, 13);
            this.lb_course.TabIndex = 5;
            this.lb_course.Text = "Курс";
            // 
            // tb_course
            // 
            this.tb_course.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_course.Location = new System.Drawing.Point(12, 120);
            this.tb_course.Name = "tb_course";
            this.tb_course.Size = new System.Drawing.Size(169, 20);
            this.tb_course.TabIndex = 4;
            // 
            // lb_group
            // 
            this.lb_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_group.AutoSize = true;
            this.lb_group.Location = new System.Drawing.Point(9, 150);
            this.lb_group.Name = "lb_group";
            this.lb_group.Size = new System.Drawing.Size(42, 13);
            this.lb_group.TabIndex = 7;
            this.lb_group.Text = "Группа";
            // 
            // tb_group
            // 
            this.tb_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_group.Location = new System.Drawing.Point(12, 166);
            this.tb_group.Name = "tb_group";
            this.tb_group.Size = new System.Drawing.Size(169, 20);
            this.tb_group.TabIndex = 6;
            // 
            // bt_start
            // 
            this.bt_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_start.Location = new System.Drawing.Point(12, 231);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(128, 53);
            this.bt_start.TabIndex = 8;
            this.bt_start.Text = "Начать тестирование";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.Location = new System.Drawing.Point(263, 231);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(128, 53);
            this.bt_cancel.TabIndex = 9;
            this.bt_cancel.Text = "Отменить";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // cb_discipline
            // 
            this.cb_discipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_discipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_discipline.FormattingEnabled = true;
            this.cb_discipline.Location = new System.Drawing.Point(231, 25);
            this.cb_discipline.Name = "cb_discipline";
            this.cb_discipline.Size = new System.Drawing.Size(160, 21);
            this.cb_discipline.TabIndex = 10;
            this.cb_discipline.SelectedIndexChanged += new System.EventHandler(this.cb_discipline_SelectedIndexChanged);
            // 
            // lb_discipline
            // 
            this.lb_discipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_discipline.AutoSize = true;
            this.lb_discipline.Location = new System.Drawing.Point(228, 9);
            this.lb_discipline.Name = "lb_discipline";
            this.lb_discipline.Size = new System.Drawing.Size(113, 13);
            this.lb_discipline.TabIndex = 11;
            this.lb_discipline.Text = "Учебная дисциплина";
            // 
            // lb_topic
            // 
            this.lb_topic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_topic.AutoSize = true;
            this.lb_topic.Location = new System.Drawing.Point(228, 57);
            this.lb_topic.Name = "lb_topic";
            this.lb_topic.Size = new System.Drawing.Size(34, 13);
            this.lb_topic.TabIndex = 13;
            this.lb_topic.Text = "Тема";
            // 
            // cb_topic
            // 
            this.cb_topic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_topic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_topic.FormattingEnabled = true;
            this.cb_topic.Location = new System.Drawing.Point(231, 73);
            this.cb_topic.Name = "cb_topic";
            this.cb_topic.Size = new System.Drawing.Size(160, 21);
            this.cb_topic.TabIndex = 12;
            this.cb_topic.SelectedIndexChanged += new System.EventHandler(this.cb_topic_SelectedIndexChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 296);
            this.Controls.Add(this.lb_topic);
            this.Controls.Add(this.cb_topic);
            this.Controls.Add(this.lb_discipline);
            this.Controls.Add(this.cb_discipline);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_group);
            this.Controls.Add(this.tb_group);
            this.Controls.Add(this.lb_course);
            this.Controls.Add(this.tb_course);
            this.Controls.Add(this.lb_specialty);
            this.Controls.Add(this.tb_specialty);
            this.Controls.Add(this.lb_fullName);
            this.Controls.Add(this.tb_fullName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 334);
            this.MinimumSize = new System.Drawing.Size(419, 334);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fullName;
        private System.Windows.Forms.Label lb_fullName;
        private System.Windows.Forms.Label lb_specialty;
        private System.Windows.Forms.TextBox tb_specialty;
        private System.Windows.Forms.Label lb_course;
        private System.Windows.Forms.TextBox tb_course;
        private System.Windows.Forms.Label lb_group;
        private System.Windows.Forms.TextBox tb_group;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.ComboBox cb_discipline;
        private System.Windows.Forms.Label lb_discipline;
        private System.Windows.Forms.Label lb_topic;
        private System.Windows.Forms.ComboBox cb_topic;
    }
}

