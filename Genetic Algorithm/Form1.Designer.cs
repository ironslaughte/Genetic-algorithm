namespace Genetic_Algorithm
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
            System.Windows.Forms.Label Label1;
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxMinBound = new System.Windows.Forms.TextBox();
            this.TextBoxMaxBound = new System.Windows.Forms.TextBox();
            this.textBoxNumIndivid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumGeneration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeDecode = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxMutateRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCuttOffThreshold = new System.Windows.Forms.TextBox();
            this.textBoxCrossoverRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(12, 28);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(53, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Функция";
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Location = new System.Drawing.Point(71, 25);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(361, 20);
            this.textBoxFunction.TabIndex = 0;
            this.textBoxFunction.Text = "x^2 + 3*y^2 + 2*x*y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диапазон значений";
            // 
            // TextBoxMinBound
            // 
            this.TextBoxMinBound.Location = new System.Drawing.Point(121, 235);
            this.TextBoxMinBound.Name = "TextBoxMinBound";
            this.TextBoxMinBound.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMinBound.TabIndex = 3;
            this.TextBoxMinBound.Text = "-100";
            // 
            // TextBoxMaxBound
            // 
            this.TextBoxMaxBound.Location = new System.Drawing.Point(227, 235);
            this.TextBoxMaxBound.Name = "TextBoxMaxBound";
            this.TextBoxMaxBound.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMaxBound.TabIndex = 4;
            this.TextBoxMaxBound.Text = "100";
            // 
            // textBoxNumIndivid
            // 
            this.textBoxNumIndivid.Location = new System.Drawing.Point(184, 52);
            this.textBoxNumIndivid.Name = "textBoxNumIndivid";
            this.textBoxNumIndivid.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumIndivid.TabIndex = 5;
            this.textBoxNumIndivid.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Размер популяции";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество поколений";
            // 
            // textBoxNumGeneration
            // 
            this.textBoxNumGeneration.Location = new System.Drawing.Point(184, 84);
            this.textBoxNumGeneration.Name = "textBoxNumGeneration";
            this.textBoxNumGeneration.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumGeneration.TabIndex = 8;
            this.textBoxNumGeneration.Text = "2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Способ кодирования генов";
            // 
            // TypeDecode
            // 
            this.TypeDecode.FormattingEnabled = true;
            this.TypeDecode.Items.AddRange(new object[] {
            "Целочисленное",
            "Вещественное"});
            this.TypeDecode.Location = new System.Drawing.Point(166, 113);
            this.TypeDecode.Name = "TypeDecode";
            this.TypeDecode.Size = new System.Drawing.Size(121, 21);
            this.TypeDecode.TabIndex = 10;
            this.TypeDecode.SelectedIndexChanged += new System.EventHandler(this.TypeDecode_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(87, 265);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 49);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Запустить генетический алгоритм";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxMutateRate
            // 
            this.textBoxMutateRate.Location = new System.Drawing.Point(184, 143);
            this.textBoxMutateRate.Name = "textBoxMutateRate";
            this.textBoxMutateRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxMutateRate.TabIndex = 12;
            this.textBoxMutateRate.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вероятность мутации";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(433, 59);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(0, 13);
            this.labelAnswer.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Порог отсечения";
            // 
            // textBoxCuttOffThreshold
            // 
            this.textBoxCuttOffThreshold.Location = new System.Drawing.Point(184, 195);
            this.textBoxCuttOffThreshold.Name = "textBoxCuttOffThreshold";
            this.textBoxCuttOffThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuttOffThreshold.TabIndex = 16;
            this.textBoxCuttOffThreshold.Text = "30";
            // 
            // textBoxCrossoverRate
            // 
            this.textBoxCrossoverRate.Location = new System.Drawing.Point(184, 169);
            this.textBoxCrossoverRate.Name = "textBoxCrossoverRate";
            this.textBoxCrossoverRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCrossoverRate.TabIndex = 17;
            this.textBoxCrossoverRate.Text = "80";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Вероятность кроссовера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCrossoverRate);
            this.Controls.Add(this.textBoxCuttOffThreshold);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMutateRate);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.TypeDecode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumGeneration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumIndivid);
            this.Controls.Add(this.TextBoxMaxBound);
            this.Controls.Add(this.TextBoxMinBound);
            this.Controls.Add(this.label2);
            this.Controls.Add(Label1);
            this.Controls.Add(this.textBoxFunction);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxMinBound;
        private System.Windows.Forms.TextBox TextBoxMaxBound;
        private System.Windows.Forms.TextBox textBoxNumIndivid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumGeneration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TypeDecode;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxMutateRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCuttOffThreshold;
        private System.Windows.Forms.TextBox textBoxCrossoverRate;
        private System.Windows.Forms.Label label8;
    }
}

