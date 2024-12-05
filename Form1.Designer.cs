namespace BackPropagation
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox12 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "0";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(442, 228);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(285, 27);
            textBox12.TabIndex = 8;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 424);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(285, 27);
            textBox4.TabIndex = 10;
            textBox4.Text = "0";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(40, 368);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(285, 27);
            textBox5.TabIndex = 9;
            textBox5.Text = "0";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 583);
            button1.Name = "button1";
            button1.Size = new Size(285, 54);
            button1.TabIndex = 18;
            button1.Text = "Generate Neural Network";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(442, 583);
            button2.Name = "button2";
            button2.Size = new Size(285, 54);
            button2.TabIndex = 19;
            button2.Text = "Train Model";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(824, 583);
            button3.Name = "button3";
            button3.Size = new Size(285, 54);
            button3.TabIndex = 20;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 205);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 21;
            label1.Text = "Inputs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 205);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 22;
            label2.Text = "Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 317);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 24;
            label3.Text = "Number of Epochs";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(442, 340);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 27);
            textBox3.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 683);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox12);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox12;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
    }
}
