namespace bankInterestCalc
{
    partial class Interest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_cunqi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_balance = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.calc = new System.Windows.Forms.Button();
            this.recalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_lilv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_zonge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "储蓄存期：";
            // 
            // cmb_cunqi
            // 
            this.cmb_cunqi.DisplayMember = "1111";
            this.cmb_cunqi.FormattingEnabled = true;
            this.cmb_cunqi.Items.AddRange(new object[] {
            "3个月",
            "半年",
            "1年",
            "2年",
            "3年",
            "5年"});
            this.cmb_cunqi.Location = new System.Drawing.Point(96, 38);
            this.cmb_cunqi.Name = "cmb_cunqi";
            this.cmb_cunqi.Size = new System.Drawing.Size(121, 20);
            this.cmb_cunqi.TabIndex = 4;
            this.cmb_cunqi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "初始存入日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "存入金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "年利率：";
            // 
            // l_balance
            // 
            this.l_balance.Location = new System.Drawing.Point(96, 143);
            this.l_balance.Name = "l_balance";
            this.l_balance.Size = new System.Drawing.Size(100, 21);
            this.l_balance.TabIndex = 8;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(120, 89);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(124, 21);
            this.dtp_date.TabIndex = 9;
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(49, 229);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 10;
            this.calc.Text = "开始计算";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // recalc
            // 
            this.recalc.Location = new System.Drawing.Point(188, 229);
            this.recalc.Name = "recalc";
            this.recalc.Size = new System.Drawing.Size(75, 23);
            this.recalc.TabIndex = 10;
            this.recalc.Text = "重新计算";
            this.recalc.UseVisualStyleBackColor = true;
            this.recalc.Click += new System.EventHandler(this.recalc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "%";
            // 
            // cmb_lilv
            // 
            this.cmb_lilv.FormattingEnabled = true;
            this.cmb_lilv.Location = new System.Drawing.Point(96, 170);
            this.cmb_lilv.Name = "cmb_lilv";
            this.cmb_lilv.Size = new System.Drawing.Size(100, 20);
            this.cmb_lilv.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "存款类型：";
            // 
            // cmb_type
            // 
            this.cmb_type.DisplayMember = "1111";
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "活期",
            "整存整取",
            "整存零取",
            "零存整取"});
            this.cmb_type.Location = new System.Drawing.Point(95, 63);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 20);
            this.cmb_type.TabIndex = 4;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "计算结果";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "到期本息总额：";
            // 
            // tbx_zonge
            // 
            this.tbx_zonge.Location = new System.Drawing.Point(120, 309);
            this.tbx_zonge.Name = "tbx_zonge";
            this.tbx_zonge.Size = new System.Drawing.Size(100, 21);
            this.tbx_zonge.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 405);
            this.Controls.Add(this.tbx_zonge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_lilv);
            this.Controls.Add(this.recalc);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.l_balance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.cmb_cunqi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "银行存款利息计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_cunqi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox l_balance;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button recalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_lilv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_zonge;
    }
}

