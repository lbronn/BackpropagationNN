namespace BackPropagations
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
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCreateBPNN = new System.Windows.Forms.Button();
            this.btnTrainNN = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputA
            // 
            this.txtInputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputA.Location = new System.Drawing.Point(108, 122);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(307, 34);
            this.txtInputA.TabIndex = 0;
            // 
            // txtInputB
            // 
            this.txtInputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputB.Location = new System.Drawing.Point(108, 191);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(307, 34);
            this.txtInputB.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(559, 152);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(307, 34);
            this.txtOutput.TabIndex = 2;
            // 
            // btnCreateBPNN
            // 
            this.btnCreateBPNN.Location = new System.Drawing.Point(78, 278);
            this.btnCreateBPNN.Name = "btnCreateBPNN";
            this.btnCreateBPNN.Size = new System.Drawing.Size(147, 57);
            this.btnCreateBPNN.TabIndex = 3;
            this.btnCreateBPNN.Text = "Create BPNN";
            this.btnCreateBPNN.UseVisualStyleBackColor = true;
            this.btnCreateBPNN.Click += new System.EventHandler(this.btnCreateBPNN_Click);
            // 
            // btnTrainNN
            // 
            this.btnTrainNN.Location = new System.Drawing.Point(294, 278);
            this.btnTrainNN.Name = "btnTrainNN";
            this.btnTrainNN.Size = new System.Drawing.Size(147, 57);
            this.btnTrainNN.TabIndex = 4;
            this.btnTrainNN.Text = "Train the Neural Net";
            this.btnTrainNN.UseVisualStyleBackColor = true;
            this.btnTrainNN.Click += new System.EventHandler(this.btnTrainNN_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(646, 278);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(147, 57);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 517);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTrainNN);
            this.Controls.Add(this.btnCreateBPNN);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInputB);
            this.Controls.Add(this.txtInputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCreateBPNN;
        private System.Windows.Forms.Button btnTrainNN;
        private System.Windows.Forms.Button btnTest;
    }
}

