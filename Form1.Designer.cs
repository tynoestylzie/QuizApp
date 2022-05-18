
namespace QuizApp
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
            this.pctBx = new System.Windows.Forms.PictureBox();
            this.lblQues = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBx
            // 
            this.pctBx.Image = global::QuizApp.Properties.Resources._15;
            this.pctBx.Location = new System.Drawing.Point(1, 1);
            this.pctBx.Name = "pctBx";
            this.pctBx.Size = new System.Drawing.Size(784, 385);
            this.pctBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBx.TabIndex = 0;
            this.pctBx.TabStop = false;
            this.pctBx.Click += new System.EventHandler(this.pctBx_Click);
            // 
            // lblQues
            // 
            this.lblQues.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQues.Location = new System.Drawing.Point(1, 389);
            this.lblQues.Name = "lblQues";
            this.lblQues.Size = new System.Drawing.Size(784, 38);
            this.lblQues.TabIndex = 1;
            this.lblQues.Text = "Choose the approriate answer...";
            this.lblQues.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 68);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 68);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 68);
            this.button3.TabIndex = 5;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 571);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 68);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 661);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "EXIT APP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 695);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQues);
            this.Controls.Add(this.pctBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBx;
        private System.Windows.Forms.Label lblQues;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

