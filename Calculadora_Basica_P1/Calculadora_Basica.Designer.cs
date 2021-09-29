
namespace Calculadora_Basica_P1 {
    partial class Calculadora_Basica {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora_Basica));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.tb_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Second = new System.Windows.Forms.Panel();
            this.lbl_SecondNumber = new System.Windows.Forms.Label();
            this.txt_SecondNumber = new System.Windows.Forms.TextBox();
            this.pnl_First = new System.Windows.Forms.Panel();
            this.lbl_FirstNumber = new System.Windows.Forms.Label();
            this.txt_FirstNumber = new System.Windows.Forms.TextBox();
            this.gb_RadioButtons = new System.Windows.Forms.GroupBox();
            this.rd_Division = new System.Windows.Forms.RadioButton();
            this.rd_Multiplication = new System.Windows.Forms.RadioButton();
            this.rd_Subtraction = new System.Windows.Forms.RadioButton();
            this.rd_Addition = new System.Windows.Forms.RadioButton();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.tb_Main.SuspendLayout();
            this.pnl_Second.SuspendLayout();
            this.pnl_First.SuspendLayout();
            this.gb_RadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.tb_Main);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(518, 196);
            this.pnl_Main.TabIndex = 0;
            // 
            // tb_Main
            // 
            this.tb_Main.ColumnCount = 4;
            this.tb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tb_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tb_Main.Controls.Add(this.pnl_Second, 2, 1);
            this.tb_Main.Controls.Add(this.pnl_First, 1, 1);
            this.tb_Main.Controls.Add(this.gb_RadioButtons, 1, 2);
            this.tb_Main.Controls.Add(this.btn_Calculate, 2, 3);
            this.tb_Main.Controls.Add(this.btn_Clean, 1, 3);
            this.tb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Main.Location = new System.Drawing.Point(0, 0);
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.RowCount = 5;
            this.tb_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tb_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tb_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tb_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tb_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tb_Main.Size = new System.Drawing.Size(518, 196);
            this.tb_Main.TabIndex = 0;
            // 
            // pnl_Second
            // 
            this.pnl_Second.Controls.Add(this.lbl_SecondNumber);
            this.pnl_Second.Controls.Add(this.txt_SecondNumber);
            this.pnl_Second.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Second.Location = new System.Drawing.Point(261, 13);
            this.pnl_Second.Name = "pnl_Second";
            this.pnl_Second.Size = new System.Drawing.Size(227, 81);
            this.pnl_Second.TabIndex = 3;
            // 
            // lbl_SecondNumber
            // 
            this.lbl_SecondNumber.AutoSize = true;
            this.lbl_SecondNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_SecondNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SecondNumber.Location = new System.Drawing.Point(0, 36);
            this.lbl_SecondNumber.Name = "lbl_SecondNumber";
            this.lbl_SecondNumber.Size = new System.Drawing.Size(146, 19);
            this.lbl_SecondNumber.TabIndex = 2;
            this.lbl_SecondNumber.Text = "Segundo Número";
            // 
            // txt_SecondNumber
            // 
            this.txt_SecondNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_SecondNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SecondNumber.Location = new System.Drawing.Point(0, 55);
            this.txt_SecondNumber.Name = "txt_SecondNumber";
            this.txt_SecondNumber.Size = new System.Drawing.Size(227, 26);
            this.txt_SecondNumber.TabIndex = 1;
            this.txt_SecondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Inputs);
            // 
            // pnl_First
            // 
            this.pnl_First.Controls.Add(this.lbl_FirstNumber);
            this.pnl_First.Controls.Add(this.txt_FirstNumber);
            this.pnl_First.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_First.Location = new System.Drawing.Point(28, 13);
            this.pnl_First.Name = "pnl_First";
            this.pnl_First.Size = new System.Drawing.Size(227, 81);
            this.pnl_First.TabIndex = 2;
            // 
            // lbl_FirstNumber
            // 
            this.lbl_FirstNumber.AutoSize = true;
            this.lbl_FirstNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_FirstNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_FirstNumber.Location = new System.Drawing.Point(0, 36);
            this.lbl_FirstNumber.Name = "lbl_FirstNumber";
            this.lbl_FirstNumber.Size = new System.Drawing.Size(139, 19);
            this.lbl_FirstNumber.TabIndex = 1;
            this.lbl_FirstNumber.Text = "Primeiro Número";
            // 
            // txt_FirstNumber
            // 
            this.txt_FirstNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_FirstNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_FirstNumber.Location = new System.Drawing.Point(0, 55);
            this.txt_FirstNumber.Name = "txt_FirstNumber";
            this.txt_FirstNumber.Size = new System.Drawing.Size(227, 26);
            this.txt_FirstNumber.TabIndex = 0;
            this.txt_FirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Inputs);
            // 
            // gb_RadioButtons
            // 
            this.tb_Main.SetColumnSpan(this.gb_RadioButtons, 2);
            this.gb_RadioButtons.Controls.Add(this.rd_Division);
            this.gb_RadioButtons.Controls.Add(this.rd_Multiplication);
            this.gb_RadioButtons.Controls.Add(this.rd_Subtraction);
            this.gb_RadioButtons.Controls.Add(this.rd_Addition);
            this.gb_RadioButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RadioButtons.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_RadioButtons.Location = new System.Drawing.Point(28, 100);
            this.gb_RadioButtons.Name = "gb_RadioButtons";
            this.gb_RadioButtons.Size = new System.Drawing.Size(460, 37);
            this.gb_RadioButtons.TabIndex = 4;
            this.gb_RadioButtons.TabStop = false;
            this.gb_RadioButtons.Text = "Operações";
            // 
            // rd_Division
            // 
            this.rd_Division.AutoSize = true;
            this.rd_Division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Division.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_Division.Location = new System.Drawing.Point(339, 11);
            this.rd_Division.Name = "rd_Division";
            this.rd_Division.Size = new System.Drawing.Size(64, 20);
            this.rd_Division.TabIndex = 3;
            this.rd_Division.TabStop = true;
            this.rd_Division.Text = "Divisão";
            this.rd_Division.UseVisualStyleBackColor = true;
            // 
            // rd_Multiplication
            // 
            this.rd_Multiplication.AutoSize = true;
            this.rd_Multiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Multiplication.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_Multiplication.Location = new System.Drawing.Point(233, 11);
            this.rd_Multiplication.Name = "rd_Multiplication";
            this.rd_Multiplication.Size = new System.Drawing.Size(100, 20);
            this.rd_Multiplication.TabIndex = 2;
            this.rd_Multiplication.TabStop = true;
            this.rd_Multiplication.Text = "Multiplicação";
            this.rd_Multiplication.UseVisualStyleBackColor = true;
            // 
            // rd_Subtraction
            // 
            this.rd_Subtraction.AutoSize = true;
            this.rd_Subtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Subtraction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_Subtraction.Location = new System.Drawing.Point(144, 11);
            this.rd_Subtraction.Name = "rd_Subtraction";
            this.rd_Subtraction.Size = new System.Drawing.Size(83, 20);
            this.rd_Subtraction.TabIndex = 1;
            this.rd_Subtraction.TabStop = true;
            this.rd_Subtraction.Text = "Subtração";
            this.rd_Subtraction.UseVisualStyleBackColor = true;
            // 
            // rd_Addition
            // 
            this.rd_Addition.AutoSize = true;
            this.rd_Addition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rd_Addition.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_Addition.Location = new System.Drawing.Point(74, 11);
            this.rd_Addition.Name = "rd_Addition";
            this.rd_Addition.Size = new System.Drawing.Size(64, 20);
            this.rd_Addition.TabIndex = 0;
            this.rd_Addition.TabStop = true;
            this.rd_Addition.Text = "Adição";
            this.rd_Addition.UseVisualStyleBackColor = true;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Calculate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(261, 143);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(227, 37);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "Calcular";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Clean.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clean.Location = new System.Drawing.Point(28, 143);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(227, 37);
            this.btn_Clean.TabIndex = 6;
            this.btn_Clean.Text = "Limpar";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // Calculadora_Basica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 196);
            this.Controls.Add(this.pnl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora_Basica";
            this.Text = "Form1";
            this.pnl_Main.ResumeLayout(false);
            this.tb_Main.ResumeLayout(false);
            this.pnl_Second.ResumeLayout(false);
            this.pnl_Second.PerformLayout();
            this.pnl_First.ResumeLayout(false);
            this.pnl_First.PerformLayout();
            this.gb_RadioButtons.ResumeLayout(false);
            this.gb_RadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.TableLayoutPanel tb_Main;
        private System.Windows.Forms.TextBox txt_FirstNumber;
        private System.Windows.Forms.Panel pnl_Second;
        private System.Windows.Forms.Label lbl_SecondNumber;
        private System.Windows.Forms.TextBox txt_SecondNumber;
        private System.Windows.Forms.Panel pnl_First;
        private System.Windows.Forms.Label lbl_FirstNumber;
        private System.Windows.Forms.GroupBox gb_RadioButtons;
        private System.Windows.Forms.RadioButton rd_Division;
        private System.Windows.Forms.RadioButton rd_Multiplication;
        private System.Windows.Forms.RadioButton rd_Subtraction;
        private System.Windows.Forms.RadioButton rd_Addition;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clean;
    }
}

