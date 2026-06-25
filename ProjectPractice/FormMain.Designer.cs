namespace ProjectPractice
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxMain = new GroupBox();
            textBoxInfix = new TextBox();
            buttonCheck = new Button();
            buttonRun = new Button();
            groupBoxPrefix = new GroupBox();
            textBoxPrefix = new TextBox();
            groupBoxPostfix = new GroupBox();
            textBoxPostfix = new TextBox();
            groupBoxMain.SuspendLayout();
            groupBoxPrefix.SuspendLayout();
            groupBoxPostfix.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain
            // 
            groupBoxMain.Controls.Add(textBoxInfix);
            groupBoxMain.Location = new Point(12, 24);
            groupBoxMain.Name = "groupBoxMain";
            groupBoxMain.Size = new Size(323, 345);
            groupBoxMain.TabIndex = 0;
            groupBoxMain.TabStop = false;
            groupBoxMain.Text = "Введите выражение в инфиксной записи";
            // 
            // textBoxInfix
            // 
            textBoxInfix.Location = new Point(0, 44);
            textBoxInfix.Multiline = true;
            textBoxInfix.Name = "textBoxInfix";
            textBoxInfix.Size = new Size(323, 301);
            textBoxInfix.TabIndex = 1;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(18, 388);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(142, 131);
            buttonCheck.TabIndex = 1;
            buttonCheck.Text = "Проверить правильность скобочной последовательности";
            buttonCheck.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            buttonRun.Enabled = false;
            buttonRun.Location = new Point(192, 388);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(129, 131);
            buttonRun.TabIndex = 2;
            buttonRun.Text = "Выполнить";
            buttonRun.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrefix
            // 
            groupBoxPrefix.Controls.Add(textBoxPrefix);
            groupBoxPrefix.Location = new Point(437, 24);
            groupBoxPrefix.Name = "groupBoxPrefix";
            groupBoxPrefix.Size = new Size(372, 228);
            groupBoxPrefix.TabIndex = 3;
            groupBoxPrefix.TabStop = false;
            groupBoxPrefix.Text = "Введёное выражение в префиксной форме";
            // 
            // textBoxPrefix
            // 
            textBoxPrefix.Location = new Point(0, 26);
            textBoxPrefix.Multiline = true;
            textBoxPrefix.Name = "textBoxPrefix";
            textBoxPrefix.Size = new Size(372, 202);
            textBoxPrefix.TabIndex = 0;
            // 
            // groupBoxPostfix
            // 
            groupBoxPostfix.Controls.Add(textBoxPostfix);
            groupBoxPostfix.Location = new Point(437, 271);
            groupBoxPostfix.Name = "groupBoxPostfix";
            groupBoxPostfix.Size = new Size(372, 263);
            groupBoxPostfix.TabIndex = 4;
            groupBoxPostfix.TabStop = false;
            groupBoxPostfix.Text = "Введёное выражение в постфиксной форме";
            // 
            // textBoxPostfix
            // 
            textBoxPostfix.Location = new Point(0, 37);
            textBoxPostfix.Multiline = true;
            textBoxPostfix.Name = "textBoxPostfix";
            textBoxPostfix.Size = new Size(372, 226);
            textBoxPostfix.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 546);
            Controls.Add(groupBoxPostfix);
            Controls.Add(groupBoxPrefix);
            Controls.Add(buttonRun);
            Controls.Add(buttonCheck);
            Controls.Add(groupBoxMain);
            Name = "FormMain";
            Text = "Перевод в префиксную и постфиксную записи";
            groupBoxMain.ResumeLayout(false);
            groupBoxMain.PerformLayout();
            groupBoxPrefix.ResumeLayout(false);
            groupBoxPrefix.PerformLayout();
            groupBoxPostfix.ResumeLayout(false);
            groupBoxPostfix.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain;
        private TextBox textBoxInfix;
        private Button buttonCheck;
        private Button buttonRun;
        private GroupBox groupBoxPrefix;
        private TextBox textBoxPrefix;
        private GroupBox groupBoxPostfix;
        private TextBox textBoxPostfix;
    }
}
