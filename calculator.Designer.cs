namespace WindowsForms_Projectfirst
{
    partial class calculator
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
            this.text_Value1 = new System.Windows.Forms.TextBox();
            this.text_Value2 = new System.Windows.Forms.TextBox();
            this.text_Answer = new System.Windows.Forms.TextBox();
            this.lab_Action = new System.Windows.Forms.Label();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_Substraction = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.btn_Percentage = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_Value1
            // 
            this.text_Value1.Location = new System.Drawing.Point(36, 82);
            this.text_Value1.Margin = new System.Windows.Forms.Padding(4);
            this.text_Value1.Name = "text_Value1";
            this.text_Value1.Size = new System.Drawing.Size(152, 23);
            this.text_Value1.TabIndex = 0;
            this.text_Value1.Text = "5";
            this.text_Value1.TextChanged += new System.EventHandler(this.text_Value1_TextChanged);
            // 
            // text_Value2
            // 
            this.text_Value2.Location = new System.Drawing.Point(254, 82);
            this.text_Value2.Margin = new System.Windows.Forms.Padding(4);
            this.text_Value2.Name = "text_Value2";
            this.text_Value2.Size = new System.Drawing.Size(174, 23);
            this.text_Value2.TabIndex = 1;
            this.text_Value2.TextChanged += new System.EventHandler(this.text_Value2_TextChanged);
            // 
            // text_Answer
            // 
            this.text_Answer.Location = new System.Drawing.Point(144, 157);
            this.text_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.text_Answer.Name = "text_Answer";
            this.text_Answer.Size = new System.Drawing.Size(160, 23);
            this.text_Answer.TabIndex = 2;
            this.text_Answer.TextChanged += new System.EventHandler(this.text_Answer_TextChanged);
            // 
            // lab_Action
            // 
            this.lab_Action.AutoSize = true;
            this.lab_Action.BackColor = System.Drawing.Color.Yellow;
            this.lab_Action.Location = new System.Drawing.Point(122, 123);
            this.lab_Action.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Action.Name = "lab_Action";
            this.lab_Action.Size = new System.Drawing.Size(48, 17);
            this.lab_Action.TabIndex = 3;
            this.lab_Action.Text = "Action";
            this.lab_Action.Click += new System.EventHandler(this.lab_Action_Click);
            // 
            // btn_Addition
            // 
            this.btn_Addition.BackColor = System.Drawing.Color.Red;
            this.btn_Addition.Location = new System.Drawing.Point(36, 201);
            this.btn_Addition.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(110, 30);
            this.btn_Addition.TabIndex = 4;
            this.btn_Addition.Text = "Add";
            this.btn_Addition.UseVisualStyleBackColor = false;
            this.btn_Addition.Click += new System.EventHandler(this.btn_Addition_Click);
            // 
            // btn_Substraction
            // 
            this.btn_Substraction.BackColor = System.Drawing.Color.Red;
            this.btn_Substraction.Location = new System.Drawing.Point(254, 201);
            this.btn_Substraction.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Substraction.Name = "btn_Substraction";
            this.btn_Substraction.Size = new System.Drawing.Size(126, 29);
            this.btn_Substraction.TabIndex = 5;
            this.btn_Substraction.Text = "Sub";
            this.btn_Substraction.UseVisualStyleBackColor = false;
            this.btn_Substraction.Click += new System.EventHandler(this.btn_Substraction_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.BackColor = System.Drawing.Color.Red;
            this.btn_Division.Location = new System.Drawing.Point(254, 263);
            this.btn_Division.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(126, 29);
            this.btn_Division.TabIndex = 6;
            this.btn_Division.Text = "Divis";
            this.btn_Division.UseVisualStyleBackColor = false;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.BackColor = System.Drawing.Color.Red;
            this.btn_Multiplication.Location = new System.Drawing.Point(36, 263);
            this.btn_Multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(110, 29);
            this.btn_Multiplication.TabIndex = 7;
            this.btn_Multiplication.Text = "Mult";
            this.btn_Multiplication.UseVisualStyleBackColor = false;
            this.btn_Multiplication.Click += new System.EventHandler(this.btn_Multiplication_Click);
            // 
            // btn_Answer
            // 
            this.btn_Answer.BackColor = System.Drawing.Color.Lime;
            this.btn_Answer.Location = new System.Drawing.Point(125, 482);
            this.btn_Answer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(130, 31);
            this.btn_Answer.TabIndex = 8;
            this.btn_Answer.Tag = "1";
            this.btn_Answer.Text = "Submit";
            this.btn_Answer.UseVisualStyleBackColor = false;
            this.btn_Answer.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Percentage
            // 
            this.btn_Percentage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Percentage.BackColor = System.Drawing.Color.Red;
            this.btn_Percentage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Percentage.Location = new System.Drawing.Point(155, 297);
            this.btn_Percentage.Name = "btn_Percentage";
            this.btn_Percentage.Size = new System.Drawing.Size(98, 26);
            this.btn_Percentage.TabIndex = 9;
            this.btn_Percentage.Text = "Percentage";
            this.btn_Percentage.UseVisualStyleBackColor = false;
            this.btn_Percentage.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Select You  Are Action",
            "Addition",
            "Substract",
            "Multiplication",
            "Division"});
            this.comboBox2.Location = new System.Drawing.Point(109, 357);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 25);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 579);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_Percentage);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Substraction);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.lab_Action);
            this.Controls.Add(this.text_Answer);
            this.Controls.Add(this.text_Value2);
            this.Controls.Add(this.text_Value1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "calculator";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Value1;
        private System.Windows.Forms.TextBox text_Value2;
        private System.Windows.Forms.TextBox text_Answer;
        private System.Windows.Forms.Label lab_Action;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_Substraction;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Button btn_Answer;
        private System.Windows.Forms.Button btn_Percentage;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}