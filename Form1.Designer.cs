namespace NG_11_Saldumini
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
            this.sk1 = new System.Windows.Forms.TextBox();
            this.sk3 = new System.Windows.Forms.Button();
            this.sk2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Daudzums = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sk1
            // 
            this.sk1.Location = new System.Drawing.Point(135, 159);
            this.sk1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sk1.Name = "sk1";
            this.sk1.Size = new System.Drawing.Size(236, 22);
            this.sk1.TabIndex = 0;
            // 
            // sk3
            // 
            this.sk3.Location = new System.Drawing.Point(134, 283);
            this.sk3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sk3.Name = "sk3";
            this.sk3.Size = new System.Drawing.Size(133, 28);
            this.sk3.TabIndex = 1;
            this.sk3.Text = "Aprēķināšana";
            this.sk3.UseVisualStyleBackColor = true;
            this.sk3.Click += new System.EventHandler(this.sk3_Click);
            // 
            // sk2
            // 
            this.sk2.Location = new System.Drawing.Point(135, 236);
            this.sk2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sk2.Name = "sk2";
            this.sk2.Size = new System.Drawing.Size(236, 22);
            this.sk2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(131, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ievadiet naudas summu";
            // 
            // Daudzums
            // 
            this.Daudzums.AutoSize = true;
            this.Daudzums.Location = new System.Drawing.Point(131, 217);
            this.Daudzums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Daudzums.Name = "Daudzums";
            this.Daudzums.Size = new System.Drawing.Size(179, 16);
            this.Daudzums.TabIndex = 4;
            this.Daudzums.Text = "Daudzums ko var iegādāties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(61, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldumu daudzuma aprēķināšana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(184, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldumu cena 9.88 Eur/kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.Location = new System.Drawing.Point(427, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(702, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Daudzums);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sk2);
            this.Controls.Add(this.sk3);
            this.Controls.Add(this.sk1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sk1;
        private System.Windows.Forms.Button sk3;
        private System.Windows.Forms.TextBox sk2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Daudzums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

