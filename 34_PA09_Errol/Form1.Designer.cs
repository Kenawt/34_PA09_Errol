namespace _34_PA09_Errol
{
    partial class Form1
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_selectCurrency = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_ConvertedAmt = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_USD = new System.Windows.Forms.RadioButton();
            this.rdb_JP = new System.Windows.Forms.RadioButton();
            this.rdb_MY = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(172, 90);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(104, 17);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount (SGD):";
            // 
            // lbl_selectCurrency
            // 
            this.lbl_selectCurrency.AutoSize = true;
            this.lbl_selectCurrency.Location = new System.Drawing.Point(160, 142);
            this.lbl_selectCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectCurrency.Name = "lbl_selectCurrency";
            this.lbl_selectCurrency.Size = new System.Drawing.Size(110, 17);
            this.lbl_selectCurrency.TabIndex = 1;
            this.lbl_selectCurrency.Text = "Select currency:";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(223, 250);
            this.lbl_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(48, 17);
            this.lbl_value.TabIndex = 2;
            this.lbl_value.Text = "Value:";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(305, 86);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(132, 22);
            this.txt_Amount.TabIndex = 3;
            // 
            // txt_ConvertedAmt
            // 
            this.txt_ConvertedAmt.Location = new System.Drawing.Point(305, 247);
            this.txt_ConvertedAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ConvertedAmt.Name = "txt_ConvertedAmt";
            this.txt_ConvertedAmt.ReadOnly = true;
            this.txt_ConvertedAmt.Size = new System.Drawing.Size(364, 22);
            this.txt_ConvertedAmt.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(571, 86);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(100, 28);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(305, 300);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 28);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_USD
            // 
            this.rdb_USD.AutoSize = true;
            this.rdb_USD.Location = new System.Drawing.Point(305, 119);
            this.rdb_USD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_USD.Name = "rdb_USD";
            this.rdb_USD.Size = new System.Drawing.Size(96, 21);
            this.rdb_USD.TabIndex = 7;
            this.rdb_USD.TabStop = true;
            this.rdb_USD.Text = "US Dollars";
            this.rdb_USD.UseVisualStyleBackColor = true;
            // 
            // rdb_JP
            // 
            this.rdb_JP.AutoSize = true;
            this.rdb_JP.Location = new System.Drawing.Point(305, 148);
            this.rdb_JP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_JP.Name = "rdb_JP";
            this.rdb_JP.Size = new System.Drawing.Size(120, 21);
            this.rdb_JP.TabIndex = 8;
            this.rdb_JP.TabStop = true;
            this.rdb_JP.Text = "Japanese Yen";
            this.rdb_JP.UseVisualStyleBackColor = true;
            // 
            // rdb_MY
            // 
            this.rdb_MY.AutoSize = true;
            this.rdb_MY.Location = new System.Drawing.Point(305, 177);
            this.rdb_MY.Name = "rdb_MY";
            this.rdb_MY.Size = new System.Drawing.Size(144, 21);
            this.rdb_MY.TabIndex = 9;
            this.rdb_MY.TabStop = true;
            this.rdb_MY.Text = "Malaysian Ringgit ";
            this.rdb_MY.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rdb_MY);
            this.Controls.Add(this.rdb_JP);
            this.Controls.Add(this.rdb_USD);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_ConvertedAmt);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_selectCurrency);
            this.Controls.Add(this.lbl_amount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_selectCurrency;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_ConvertedAmt;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rdb_USD;
        private System.Windows.Forms.RadioButton rdb_JP;
        private System.Windows.Forms.RadioButton rdb_MY;
    }
}

