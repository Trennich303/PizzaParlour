
namespace PizzaParlour
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
            this.PizzaParlour = new System.Windows.Forms.Label();
            this.RedBox = new System.Windows.Forms.Label();
            this.ToppingLabel = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // PizzaParlour
            // 
            this.PizzaParlour.BackColor = System.Drawing.Color.Lime;
            this.PizzaParlour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PizzaParlour.ForeColor = System.Drawing.Color.Black;
            this.PizzaParlour.Location = new System.Drawing.Point(241, 21);
            this.PizzaParlour.Name = "PizzaParlour";
            this.PizzaParlour.Size = new System.Drawing.Size(292, 68);
            this.PizzaParlour.TabIndex = 0;
            this.PizzaParlour.Text = "Pizza Parlour ";
            this.PizzaParlour.Click += new System.EventHandler(this.PizzaParlour_Click);
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Lime;
            this.RedBox.Location = new System.Drawing.Point(-34, 0);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(841, 120);
            this.RedBox.TabIndex = 1;
            // 
            // ToppingLabel
            // 
            this.ToppingLabel.AutoSize = true;
            this.ToppingLabel.BackColor = System.Drawing.Color.Black;
            this.ToppingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingLabel.ForeColor = System.Drawing.Color.White;
            this.ToppingLabel.Location = new System.Drawing.Point(52, 200);
            this.ToppingLabel.Name = "ToppingLabel";
            this.ToppingLabel.Size = new System.Drawing.Size(326, 37);
            this.ToppingLabel.TabIndex = 2;
            this.ToppingLabel.Text = "Number Of Toppings:";
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(384, 200);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(100, 31);
            this.TextInput.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Black;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(224, 277);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(284, 67);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(120, 369);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(500, 31);
            this.TextOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.ToppingLabel);
            this.Controls.Add(this.PizzaParlour);
            this.Controls.Add(this.RedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PizzaParlour;
        private System.Windows.Forms.Label RedBox;
        private System.Windows.Forms.Label ToppingLabel;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.MaskedTextBox TextOutput;
    }
}

