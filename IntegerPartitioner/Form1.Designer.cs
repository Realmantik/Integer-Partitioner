namespace IntegerPartitioner
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.menuCommands = new System.Windows.Forms.MenuStrip();
            this.commandsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getFractionsCountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.getFractionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.getAndSaveToJSONFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 59);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(774, 522);
            this.outputBox.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(12, 27);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(142, 26);
            this.inputBox.TabIndex = 2;
            this.inputBox.Text = "7";
            // 
            // menuCommands
            // 
            this.menuCommands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsMenuItem});
            this.menuCommands.Location = new System.Drawing.Point(0, 0);
            this.menuCommands.Name = "menuCommands";
            this.menuCommands.Size = new System.Drawing.Size(798, 24);
            this.menuCommands.TabIndex = 5;
            this.menuCommands.Text = "menu";
            // 
            // commandsMenuItem
            // 
            this.commandsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getFractionsCountMenu,
            this.getFractionsMenu,
            this.getAndSaveToJSONFile});
            this.commandsMenuItem.Name = "commandsMenuItem";
            this.commandsMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsMenuItem.Text = "Commands";
            // 
            // getFractionsCountMenu
            // 
            this.getFractionsCountMenu.Name = "getFractionsCountMenu";
            this.getFractionsCountMenu.Size = new System.Drawing.Size(261, 22);
            this.getFractionsCountMenu.Text = "Get Fractions Count";
            this.getFractionsCountMenu.Click += new System.EventHandler(this.getFractionsCountMenu_Click);
            // 
            // getFractionsMenu
            // 
            this.getFractionsMenu.Name = "getFractionsMenu";
            this.getFractionsMenu.Size = new System.Drawing.Size(261, 22);
            this.getFractionsMenu.Text = "Get Fractions";
            this.getFractionsMenu.Click += new System.EventHandler(this.getFractionsMenu_Click);
            // 
            // getAndSaveToJSONFile
            // 
            this.getAndSaveToJSONFile.Name = "getAndSaveToJSONFile";
            this.getAndSaveToJSONFile.Size = new System.Drawing.Size(261, 22);
            this.getAndSaveToJSONFile.Text = "Get Fractions And Save to JSON File";
            this.getAndSaveToJSONFile.Click += new System.EventHandler(this.getAndSaveToJSONFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 593);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.menuCommands);
            this.MainMenuStrip = this.menuCommands;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuCommands.ResumeLayout(false);
            this.menuCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.MenuStrip menuCommands;
        private System.Windows.Forms.ToolStripMenuItem commandsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getFractionsCountMenu;
        private System.Windows.Forms.ToolStripMenuItem getFractionsMenu;
        private System.Windows.Forms.ToolStripMenuItem getAndSaveToJSONFile;
    }
}

