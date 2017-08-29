namespace Pif3
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
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(474, 107);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(318, 457);
            this.outputBox.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(474, 32);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 2;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(474, 67);
            this.progBar.Maximum = 23170;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(318, 23);
            this.progBar.Step = 1;
            this.progBar.TabIndex = 3;
            this.progBar.Value = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button button2;
    }
}

