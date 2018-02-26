namespace calculator_test
{
    partial class Calc_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc_form));
            this.Screen = new System.Windows.Forms.Label();
            this.zero = new System.Windows.Forms.Button();
            this.m_clear = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.reciproc = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.memory = new System.Windows.Forms.Button();
            this.m_store = new System.Windows.Forms.Button();
            this.back_spc = new System.Windows.Forms.Button();
            this.c_entry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.m_plus = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.m_minus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.screen2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Screen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(15, 29);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(210, 80);
            this.Screen.TabIndex = 58;
            this.Screen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(18, 318);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(78, 31);
            this.zero.TabIndex = 57;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // m_clear
            // 
            this.m_clear.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_clear.Location = new System.Drawing.Point(16, 130);
            this.m_clear.Name = "m_clear";
            this.m_clear.Size = new System.Drawing.Size(38, 31);
            this.m_clear.TabIndex = 56;
            this.m_clear.Text = "MC";
            this.m_clear.UseVisualStyleBackColor = true;
            this.m_clear.Click += new System.EventHandler(this.m_clear_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(102, 281);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(36, 31);
            this.three.TabIndex = 55;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // minus
            // 
            this.minus.AutoEllipsis = true;
            this.minus.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(144, 281);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(36, 31);
            this.minus.TabIndex = 54;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(102, 318);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(36, 31);
            this.point.TabIndex = 53;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(144, 318);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(36, 31);
            this.plus.TabIndex = 52;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(18, 244);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(36, 31);
            this.four.TabIndex = 51;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(60, 244);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(36, 31);
            this.five.TabIndex = 50;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(102, 244);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(36, 31);
            this.six.TabIndex = 49;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(144, 244);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(36, 31);
            this.multiply.TabIndex = 48;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // reciproc
            // 
            this.reciproc.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciproc.Location = new System.Drawing.Point(186, 244);
            this.reciproc.Name = "reciproc";
            this.reciproc.Size = new System.Drawing.Size(36, 31);
            this.reciproc.TabIndex = 47;
            this.reciproc.Text = "1/x";
            this.reciproc.UseVisualStyleBackColor = true;
            this.reciproc.Click += new System.EventHandler(this.reciproc_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(18, 281);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(36, 31);
            this.one.TabIndex = 46;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(60, 281);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(36, 31);
            this.two.TabIndex = 45;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // memory
            // 
            this.memory.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory.Location = new System.Drawing.Point(60, 130);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(36, 31);
            this.memory.TabIndex = 44;
            this.memory.Text = "MR";
            this.memory.UseVisualStyleBackColor = true;
            this.memory.Click += new System.EventHandler(this.memory_Click);
            // 
            // m_store
            // 
            this.m_store.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_store.Location = new System.Drawing.Point(102, 130);
            this.m_store.Name = "m_store";
            this.m_store.Size = new System.Drawing.Size(36, 31);
            this.m_store.TabIndex = 43;
            this.m_store.Text = "MS";
            this.m_store.UseVisualStyleBackColor = true;
            this.m_store.Click += new System.EventHandler(this.m_store_Click);
            // 
            // back_spc
            // 
            this.back_spc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.back_spc.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_spc.Location = new System.Drawing.Point(18, 167);
            this.back_spc.Name = "back_spc";
            this.back_spc.Size = new System.Drawing.Size(36, 31);
            this.back_spc.TabIndex = 42;
            this.back_spc.Text = "←";
            this.back_spc.UseVisualStyleBackColor = true;
            this.back_spc.Click += new System.EventHandler(this.back_spc_Click);
            // 
            // c_entry
            // 
            this.c_entry.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_entry.Location = new System.Drawing.Point(60, 167);
            this.c_entry.Name = "c_entry";
            this.c_entry.Size = new System.Drawing.Size(36, 31);
            this.c_entry.TabIndex = 41;
            this.c_entry.Text = "CE";
            this.c_entry.UseVisualStyleBackColor = true;
            this.c_entry.Click += new System.EventHandler(this.c_entry_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(102, 167);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(36, 31);
            this.clear.TabIndex = 40;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // m_plus
            // 
            this.m_plus.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_plus.Location = new System.Drawing.Point(144, 130);
            this.m_plus.Name = "m_plus";
            this.m_plus.Size = new System.Drawing.Size(36, 31);
            this.m_plus.TabIndex = 39;
            this.m_plus.Text = "M+";
            this.m_plus.UseVisualStyleBackColor = true;
            this.m_plus.Click += new System.EventHandler(this.m_plus_Click);
            // 
            // sqrt
            // 
            this.sqrt.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Location = new System.Drawing.Point(186, 167);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(36, 31);
            this.sqrt.TabIndex = 38;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(18, 207);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(36, 31);
            this.seven.TabIndex = 37;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(60, 207);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(36, 31);
            this.eight.TabIndex = 36;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nine.Location = new System.Drawing.Point(102, 207);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(36, 31);
            this.nine.TabIndex = 35;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(144, 207);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(36, 31);
            this.divide.TabIndex = 34;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(186, 207);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(36, 31);
            this.percent.TabIndex = 33;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_minus.Location = new System.Drawing.Point(144, 167);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(36, 31);
            this.plus_minus.TabIndex = 32;
            this.plus_minus.Text = "±";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // m_minus
            // 
            this.m_minus.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_minus.Location = new System.Drawing.Point(186, 130);
            this.m_minus.Name = "m_minus";
            this.m_minus.Size = new System.Drawing.Size(36, 31);
            this.m_minus.TabIndex = 31;
            this.m_minus.Text = "M-";
            this.m_minus.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(186, 281);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(36, 68);
            this.equal.TabIndex = 30;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // screen2
            // 
            this.screen2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.screen2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen2.Location = new System.Drawing.Point(16, 29);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(209, 41);
            this.screen2.TabIndex = 59;
            this.screen2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Calc_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(237, 370);
            this.Controls.Add(this.screen2);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.m_clear);
            this.Controls.Add(this.three);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.point);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.reciproc);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.m_store);
            this.Controls.Add(this.back_spc);
            this.Controls.Add(this.c_entry);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.m_plus);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.m_minus);
            this.Controls.Add(this.equal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Calc_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calc_form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Screen;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button m_clear;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button reciproc;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button memory;
        private System.Windows.Forms.Button m_store;
        private System.Windows.Forms.Button back_spc;
        private System.Windows.Forms.Button c_entry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button m_plus;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button m_minus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label screen2;
    }
}

