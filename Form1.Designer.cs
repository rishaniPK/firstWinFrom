namespace firstWinFrom
{
    partial class Form_calculator
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
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_resu = new System.Windows.Forms.TextBox();
            this.btn_addi = new System.Windows.Forms.Button();
            this.btn_subr = new System.Windows.Forms.Button();
            this.bnt_divi = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(74, 41);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(66, 13);
            this.lbl_num1.TabIndex = 0;
            this.lbl_num1.Text = "First Number";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(74, 70);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(84, 13);
            this.lbl_num2.TabIndex = 1;
            this.lbl_num2.Text = "Second Number";
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(74, 100);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(37, 13);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "Result";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(227, 41);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(227, 71);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 4;
            // 
            // txt_resu
            // 
            this.txt_resu.Location = new System.Drawing.Point(227, 100);
            this.txt_resu.Name = "txt_resu";
            this.txt_resu.Size = new System.Drawing.Size(100, 20);
            this.txt_resu.TabIndex = 5;
            // 
            // btn_addi
            // 
            this.btn_addi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addi.Location = new System.Drawing.Point(75, 155);
            this.btn_addi.Name = "btn_addi";
            this.btn_addi.Size = new System.Drawing.Size(44, 23);
            this.btn_addi.TabIndex = 6;
            this.btn_addi.Text = "ADD";
            this.btn_addi.UseVisualStyleBackColor = false;
            this.btn_addi.Click += new System.EventHandler(this.Btn_addi_Click);
            // 
            // btn_subr
            // 
            this.btn_subr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_subr.Location = new System.Drawing.Point(125, 155);
            this.btn_subr.Name = "btn_subr";
            this.btn_subr.Size = new System.Drawing.Size(48, 23);
            this.btn_subr.TabIndex = 7;
            this.btn_subr.Text = "SUB";
            this.btn_subr.UseVisualStyleBackColor = false;
            this.btn_subr.Click += new System.EventHandler(this.Btn_subr_Click);
            // 
            // bnt_divi
            // 
            this.bnt_divi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bnt_divi.Location = new System.Drawing.Point(243, 155);
            this.bnt_divi.Name = "bnt_divi";
            this.bnt_divi.Size = new System.Drawing.Size(50, 23);
            this.bnt_divi.TabIndex = 8;
            this.bnt_divi.Text = "DIV";
            this.bnt_divi.UseVisualStyleBackColor = false;
            this.bnt_divi.Click += new System.EventHandler(this.Bnt_divi_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_multi.Location = new System.Drawing.Point(179, 155);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(58, 23);
            this.btn_multi.TabIndex = 9;
            this.btn_multi.Text = "MUL";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.Btn_multi_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_clear.Location = new System.Drawing.Point(299, 155);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(45, 24);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form_calculator
            // 
            this.ClientSize = new System.Drawing.Size(401, 293);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.bnt_divi);
            this.Controls.Add(this.btn_subr);
            this.Controls.Add(this.btn_addi);
            this.Controls.Add(this.txt_resu);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form_calculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number1;
        private System.Windows.Forms.Label lbl_number2;
        private System.Windows.Forms.TextBox num1txt;
        private System.Windows.Forms.TextBox num2txt;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox result_txt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_subract;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_resu;
        private System.Windows.Forms.Button btn_addi;
        private System.Windows.Forms.Button btn_subr;
        private System.Windows.Forms.Button bnt_divi;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_clear;
    }
}

