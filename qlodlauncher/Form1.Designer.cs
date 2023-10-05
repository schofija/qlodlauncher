namespace qlodlauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            textBoxDebugOutput = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            amdlodtweaker = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 31);
            button1.Name = "button1";
            button1.Size = new Size(109, 22);
            button1.TabIndex = 0;
            button1.Text = "Enable LOD Bias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(96, 58);
            button2.Name = "button2";
            button2.Size = new Size(109, 22);
            button2.TabIndex = 1;
            button2.Text = "Disable LOD Bias";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxDebugOutput
            // 
            textBoxDebugOutput.BackColor = SystemColors.Window;
            textBoxDebugOutput.Location = new Point(12, 110);
            textBoxDebugOutput.Multiline = true;
            textBoxDebugOutput.Name = "textBoxDebugOutput";
            textBoxDebugOutput.ReadOnly = true;
            textBoxDebugOutput.ScrollBars = ScrollBars.Vertical;
            textBoxDebugOutput.Size = new Size(403, 69);
            textBoxDebugOutput.TabIndex = 2;
            textBoxDebugOutput.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Debug:";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // amdlodtweaker
            // 
            amdlodtweaker.AutoSize = true;
            amdlodtweaker.Font = new Font("Surface Sharpened", 12F, FontStyle.Bold, GraphicsUnit.Point);
            amdlodtweaker.Location = new Point(96, 12);
            amdlodtweaker.Name = "amdlodtweaker";
            amdlodtweaker.Size = new Size(121, 16);
            amdlodtweaker.TabIndex = 5;
            amdlodtweaker.Text = "amd-lod-tweaker";
            amdlodtweaker.Click += amdlodtweaker_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(319, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(319, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 16);
            label3.TabIndex = 7;
            label3.Text = "v0.1.0 9-21-23";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(427, 189);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(amdlodtweaker);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBoxDebugOutput);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "amd-lod-tweaker v0.1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxDebugOutput;
        private Label label1;
        private PictureBox pictureBox1;
        private Label amdlodtweaker;
        private Label label2;
        private Label label3;
    }
}