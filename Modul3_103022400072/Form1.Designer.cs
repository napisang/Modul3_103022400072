namespace Modul3_103022400072
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
            satuanawal = new ComboBox();
            satuanakhir = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            nilaiawal = new TextBox();
            nilaiakhir = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // satuanawal
            // 
            satuanawal.FormattingEnabled = true;
            satuanawal.Items.AddRange(new object[] { "celcius", "fahrenheit", "kelvin", "reamur" });
            satuanawal.Location = new Point(129, 77);
            satuanawal.Name = "satuanawal";
            satuanawal.Size = new Size(151, 28);
            satuanawal.TabIndex = 0;
            // 
            // satuanakhir
            // 
            satuanakhir.FormattingEnabled = true;
            satuanakhir.Items.AddRange(new object[] { "celcius", "fahrenheit", "kelvin", "reamur" });
            satuanakhir.Location = new Point(129, 174);
            satuanakhir.Name = "satuanakhir";
            satuanakhir.Size = new Size(151, 28);
            satuanakhir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 54);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 151);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Satuan Akhir";
            // 
            // nilaiawal
            // 
            nilaiawal.Location = new Point(324, 77);
            nilaiawal.Name = "nilaiawal";
            nilaiawal.Size = new Size(125, 27);
            nilaiawal.TabIndex = 4;
            // 
            // nilaiakhir
            // 
            nilaiakhir.Location = new Point(324, 174);
            nilaiakhir.Name = "nilaiakhir";
            nilaiakhir.Size = new Size(125, 27);
            nilaiakhir.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 54);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Nilai Awal";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 151);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 7;
            label4.Text = "Nilai Akhir";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(487, 77);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nilaiakhir);
            Controls.Add(nilaiawal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(satuanakhir);
            Controls.Add(satuanawal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox satuanawal;
        private ComboBox satuanakhir;
        private Label label1;
        private Label label2;
        private TextBox nilaiawal;
        private TextBox nilaiakhir;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
