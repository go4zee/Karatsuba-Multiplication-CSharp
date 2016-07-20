namespace Karatsuba_Multiplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.karatsubaMultiplyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.normalMultiplyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.karatsubaTimeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.normalTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 3;
            // 
            // karatsubaMultiplyButton
            // 
            this.karatsubaMultiplyButton.Location = new System.Drawing.Point(68, 100);
            this.karatsubaMultiplyButton.Name = "karatsubaMultiplyButton";
            this.karatsubaMultiplyButton.Size = new System.Drawing.Size(119, 23);
            this.karatsubaMultiplyButton.TabIndex = 4;
            this.karatsubaMultiplyButton.Text = "Karatsuba Multiplication";
            this.karatsubaMultiplyButton.UseVisualStyleBackColor = true;
            this.karatsubaMultiplyButton.Click += new System.EventHandler(this.karatsubaMultiply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Answer";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(95, 68);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 6;
            // 
            // normalMultiplyButton
            // 
            this.normalMultiplyButton.Location = new System.Drawing.Point(254, 100);
            this.normalMultiplyButton.Name = "normalMultiplyButton";
            this.normalMultiplyButton.Size = new System.Drawing.Size(119, 23);
            this.normalMultiplyButton.TabIndex = 7;
            this.normalMultiplyButton.Text = "Normal Multiplication";
            this.normalMultiplyButton.UseVisualStyleBackColor = true;
            this.normalMultiplyButton.Click += new System.EventHandler(this.normalMultiplyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Karatsuba Time";
            // 
            // karatsubaTimeLabel
            // 
            this.karatsubaTimeLabel.AutoSize = true;
            this.karatsubaTimeLabel.Location = new System.Drawing.Point(134, 28);
            this.karatsubaTimeLabel.Name = "karatsubaTimeLabel";
            this.karatsubaTimeLabel.Size = new System.Drawing.Size(22, 13);
            this.karatsubaTimeLabel.TabIndex = 9;
            this.karatsubaTimeLabel.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Normal Time";
            // 
            // normalTimeLabel
            // 
            this.normalTimeLabel.AutoSize = true;
            this.normalTimeLabel.Location = new System.Drawing.Point(134, 66);
            this.normalTimeLabel.Name = "normalTimeLabel";
            this.normalTimeLabel.Size = new System.Drawing.Size(22, 13);
            this.normalTimeLabel.TabIndex = 11;
            this.normalTimeLabel.Text = "0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.normalTimeLabel);
            this.groupBox1.Controls.Add(this.karatsubaTimeLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(26, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 98);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Statistics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.normalMultiplyButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.karatsubaMultiplyButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button karatsubaMultiplyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button normalMultiplyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label karatsubaTimeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label normalTimeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

