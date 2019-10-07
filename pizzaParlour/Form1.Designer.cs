namespace pizzaParlour
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calculation = new System.Windows.Forms.Label();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.toppingsInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-7, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(810, 73);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SSES Pizza";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(135, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(528, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // calculation
            // 
            this.calculation.Location = new System.Drawing.Point(218, 362);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(355, 64);
            this.calculation.TabIndex = 6;
            this.calculation.Text = "label3";
            // 
            // toppingLabel
            // 
            this.toppingLabel.AutoSize = true;
            this.toppingLabel.Location = new System.Drawing.Point(186, 187);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(176, 13);
            this.toppingLabel.TabIndex = 7;
            this.toppingLabel.Text = "How many toppings would you like?";
            // 
            // toppingsInput
            // 
            this.toppingsInput.Location = new System.Drawing.Point(385, 179);
            this.toppingsInput.Name = "toppingsInput";
            this.toppingsInput.Size = new System.Drawing.Size(100, 20);
            this.toppingsInput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toppingsInput);
            this.Controls.Add(this.toppingLabel);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label calculation;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.TextBox toppingsInput;
    }
}

