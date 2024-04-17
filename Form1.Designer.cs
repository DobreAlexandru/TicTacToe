namespace TicTacToe
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            winner = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(125, 125);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += select;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(267, 136);
            label2.Margin = new Padding(1);
            label2.Name = "label2";
            label2.Size = new Size(125, 125);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += select;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(140, 263);
            label3.Margin = new Padding(1);
            label3.Name = "label3";
            label3.Size = new Size(125, 125);
            label3.TabIndex = 2;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += select;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 136);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(125, 125);
            label4.TabIndex = 3;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += select;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(267, 9);
            label5.Margin = new Padding(1);
            label5.Name = "label5";
            label5.Size = new Size(125, 125);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += select;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(267, 263);
            label6.Margin = new Padding(1);
            label6.Name = "label6";
            label6.Size = new Size(125, 125);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += select;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(140, 9);
            label7.Margin = new Padding(1);
            label7.Name = "label7";
            label7.Size = new Size(125, 125);
            label7.TabIndex = 6;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += select;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(140, 136);
            label8.Margin = new Padding(1);
            label8.Name = "label8";
            label8.Size = new Size(125, 125);
            label8.TabIndex = 7;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += select;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Sitka Text", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 263);
            label9.Margin = new Padding(1);
            label9.Name = "label9";
            label9.Size = new Size(125, 125);
            label9.TabIndex = 8;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += select;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += check;
            // 
            // winner
            // 
            winner.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            winner.Location = new Point(420, 49);
            winner.Name = "winner";
            winner.Size = new Size(216, 125);
            winner.TabIndex = 9;
            winner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(454, 236);
            button1.Name = "button1";
            button1.Size = new Size(125, 71);
            button1.TabIndex = 10;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += restart;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 401);
            Controls.Add(button1);
            Controls.Add(winner);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private Label winner;
        private Button button1;
    }
}