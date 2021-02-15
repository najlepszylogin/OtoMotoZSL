namespace Handlarz_4a
{
    partial class Form4
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
            this.marka_ = new System.Windows.Forms.TextBox();
            this.model_ = new System.Windows.Forms.TextBox();
            this.silnik_ = new System.Windows.Forms.TextBox();
            this.cena_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.info_ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // marka_
            // 
            this.marka_.Location = new System.Drawing.Point(27, 30);
            this.marka_.Name = "marka_";
            this.marka_.Size = new System.Drawing.Size(274, 20);
            this.marka_.TabIndex = 1;
            // 
            // model_
            // 
            this.model_.Location = new System.Drawing.Point(27, 71);
            this.model_.Name = "model_";
            this.model_.Size = new System.Drawing.Size(274, 20);
            this.model_.TabIndex = 2;
            // 
            // silnik_
            // 
            this.silnik_.Location = new System.Drawing.Point(27, 112);
            this.silnik_.Name = "silnik_";
            this.silnik_.Size = new System.Drawing.Size(274, 20);
            this.silnik_.TabIndex = 3;
            // 
            // cena_
            // 
            this.cena_.Location = new System.Drawing.Point(27, 156);
            this.cena_.Name = "cena_";
            this.cena_.Size = new System.Drawing.Size(274, 20);
            this.cena_.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Silnik (nie wymagany):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena:";
            // 
            // info_
            // 
            this.info_.AutoSize = true;
            this.info_.ForeColor = System.Drawing.Color.DarkRed;
            this.info_.Location = new System.Drawing.Point(24, 196);
            this.info_.Name = "info_";
            this.info_.Size = new System.Drawing.Size(0, 13);
            this.info_.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cena_);
            this.Controls.Add(this.silnik_);
            this.Controls.Add(this.model_);
            this.Controls.Add(this.marka_);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Dodaj Pojazd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marka_;
        private System.Windows.Forms.TextBox model_;
        private System.Windows.Forms.TextBox silnik_;
        private System.Windows.Forms.TextBox cena_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label info_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}