
namespace WinFormsApp1
{
    partial class Form1
    {
        int seed = int.Parse(textBoxSeed, Text);
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
            this.stealButton = new System.Windows.Forms.Button();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.stealButton.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stealButton.Location = new System.Drawing.Point(249, 50);
            this.stealButton.Name = "button1";
            this.stealButton.Size = new System.Drawing.Size(179, 117);
            this.stealButton.TabIndex = 0;
            this.stealButton.Text = "Steal";
            this.stealButton.UseVisualStyleBackColor = true;
            this.stealButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(116, 50);
            this.textBoxSeed.Name = "textBox1";
            this.textBoxSeed.Size = new System.Drawing.Size(100, 23);
            this.textBoxSeed.TabIndex = 1;
            this.textBoxSeed.Tag = "textBoxSeed";
            this.textBoxSeed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(116, 79);
            this.textBoxCapacity.Name = "textBox2";
            this.textBoxCapacity.Size = new System.Drawing.Size(100, 23);
            this.textBoxCapacity.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(2, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(108, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Random Seed";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(2, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(108, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Backpacks capacity";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 266);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 147);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 495);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.textBoxSeed);
            this.Controls.Add(this.stealButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Tag = "textBoxSeed";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stealButton;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListView listView1;
    }
}

