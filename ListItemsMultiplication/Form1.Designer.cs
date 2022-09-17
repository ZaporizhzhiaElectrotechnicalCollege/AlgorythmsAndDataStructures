namespace ListItemsMultiplication
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
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelMultiplication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(222, 28);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(127, 20);
            this.textBoxNumbers.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelText.Location = new System.Drawing.Point(97, 31);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(108, 13);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Введите 8 значений";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Azure;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResult.Location = new System.Drawing.Point(100, 71);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(105, 43);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = " Расчитать";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(219, 71);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(130, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "Количество элементов: ";
            // 
            // labelMultiplication
            // 
            this.labelMultiplication.AutoSize = true;
            this.labelMultiplication.Location = new System.Drawing.Point(219, 99);
            this.labelMultiplication.Name = "labelMultiplication";
            this.labelMultiplication.Size = new System.Drawing.Size(114, 13);
            this.labelMultiplication.TabIndex = 4;
            this.labelMultiplication.Text = "Добуток элементов: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(417, 161);
            this.Controls.Add(this.labelMultiplication);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxNumbers);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practical Work 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelMultiplication;
    }
}

