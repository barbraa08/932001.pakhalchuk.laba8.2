namespace WindowsFormsApp8
{
    partial class Form1
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
            this.btAnswer = new System.Windows.Forms.Button();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.lbAnswer2 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbQuestion2 = new System.Windows.Forms.TextBox();
            this.lb8_1 = new System.Windows.Forms.Label();
            this.lb8_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAnswer
            // 
            this.btAnswer.Location = new System.Drawing.Point(142, 168);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(97, 45);
            this.btAnswer.TabIndex = 0;
            this.btAnswer.Text = "Answer";
            this.btAnswer.UseVisualStyleBackColor = true;
            this.btAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAnswer2
            // 
            this.btAnswer2.Location = new System.Drawing.Point(705, 168);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(96, 44);
            this.btAnswer2.TabIndex = 1;
            this.btAnswer2.Text = "Answer";
            this.btAnswer2.UseVisualStyleBackColor = true;
            this.btAnswer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(147, 227);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer.TabIndex = 2;
            // 
            // lbAnswer2
            // 
            this.lbAnswer2.AutoSize = true;
            this.lbAnswer2.Location = new System.Drawing.Point(727, 227);
            this.lbAnswer2.Name = "lbAnswer2";
            this.lbAnswer2.Size = new System.Drawing.Size(0, 20);
            this.lbAnswer2.TabIndex = 3;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(99, 73);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(199, 71);
            this.tbQuestion.TabIndex = 4;
            // 
            // tbQuestion2
            // 
            this.tbQuestion2.Location = new System.Drawing.Point(654, 73);
            this.tbQuestion2.Multiline = true;
            this.tbQuestion2.Name = "tbQuestion2";
            this.tbQuestion2.Size = new System.Drawing.Size(203, 71);
            this.tbQuestion2.TabIndex = 5;
            // 
            // lb8_1
            // 
            this.lb8_1.AutoSize = true;
            this.lb8_1.Location = new System.Drawing.Point(123, 32);
            this.lb8_1.Name = "lb8_1";
            this.lb8_1.Size = new System.Drawing.Size(152, 20);
            this.lb8_1.TabIndex = 6;
            this.lb8_1.Text = "Yes or No prediction";
            // 
            // lb8_2
            // 
            this.lb8_2.AutoSize = true;
            this.lb8_2.Location = new System.Drawing.Point(674, 32);
            this.lb8_2.Name = "lb8_2";
            this.lb8_2.Size = new System.Drawing.Size(152, 20);
            this.lb8_2.TabIndex = 7;
            this.lb8_2.Text = "Magic ball prediction";
            this.lb8_2.Click += new System.EventHandler(this.lb8_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 573);
            this.Controls.Add(this.lb8_2);
            this.Controls.Add(this.lb8_1);
            this.Controls.Add(this.tbQuestion2);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.lbAnswer2);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.btAnswer2);
            this.Controls.Add(this.btAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.Button btAnswer2;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Label lbAnswer2;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbQuestion2;
        private System.Windows.Forms.Label lb8_1;
        private System.Windows.Forms.Label lb8_2;
    }
}

