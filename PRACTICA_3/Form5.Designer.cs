namespace PRACTICA_3
{
    partial class Form5
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
            this.rdbtnsquare = new System.Windows.Forms.RadioButton();
            this.rdbcircle = new System.Windows.Forms.RadioButton();
            this.rdbtriangle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsquare = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcircle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbtnsquare
            // 
            this.rdbtnsquare.AutoSize = true;
            this.rdbtnsquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnsquare.Location = new System.Drawing.Point(38, 32);
            this.rdbtnsquare.Name = "rdbtnsquare";
            this.rdbtnsquare.Size = new System.Drawing.Size(116, 20);
            this.rdbtnsquare.TabIndex = 0;
            this.rdbtnsquare.Text = "Area of Square";
            this.rdbtnsquare.UseVisualStyleBackColor = true;
            this.rdbtnsquare.CheckedChanged += new System.EventHandler(this.rdbtnsquare_CheckedChanged);
            // 
            // rdbcircle
            // 
            this.rdbcircle.AutoSize = true;
            this.rdbcircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcircle.Location = new System.Drawing.Point(188, 32);
            this.rdbcircle.Name = "rdbcircle";
            this.rdbcircle.Size = new System.Drawing.Size(106, 20);
            this.rdbcircle.TabIndex = 1;
            this.rdbcircle.Text = "Area of Circle";
            this.rdbcircle.UseVisualStyleBackColor = true;
            this.rdbcircle.CheckedChanged += new System.EventHandler(this.rdbcircle_CheckedChanged);
            // 
            // rdbtriangle
            // 
            this.rdbtriangle.AutoSize = true;
            this.rdbtriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtriangle.Location = new System.Drawing.Point(334, 32);
            this.rdbtriangle.Name = "rdbtriangle";
            this.rdbtriangle.Size = new System.Drawing.Size(122, 20);
            this.rdbtriangle.TabIndex = 2;
            this.rdbtriangle.Text = "Area of Triangle";
            this.rdbtriangle.UseVisualStyleBackColor = true;
            this.rdbtriangle.CheckedChanged += new System.EventHandler(this.rdbtriangle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter value of sides ";
            this.label1.Visible = false;
            // 
            // txtsquare
            // 
            this.txtsquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsquare.Location = new System.Drawing.Point(208, 79);
            this.txtsquare.Name = "txtsquare";
            this.txtsquare.Size = new System.Drawing.Size(139, 22);
            this.txtsquare.TabIndex = 4;
            this.txtsquare.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(381, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 162);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcircle
            // 
            this.txtcircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcircle.Location = new System.Drawing.Point(208, 128);
            this.txtcircle.Name = "txtcircle";
            this.txtcircle.Size = new System.Drawing.Size(139, 22);
            this.txtcircle.TabIndex = 7;
            this.txtcircle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter value of radius";
            this.label2.Visible = false;
            // 
            // txtbase
            // 
            this.txtbase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbase.Location = new System.Drawing.Point(208, 174);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(139, 22);
            this.txtbase.TabIndex = 9;
            this.txtbase.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter value of base";
            this.label3.Visible = false;
            // 
            // txtheight
            // 
            this.txtheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheight.Location = new System.Drawing.Point(208, 219);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(139, 22);
            this.txtheight.TabIndex = 11;
            this.txtheight.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter value of height";
            this.label4.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsquare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtriangle);
            this.Controls.Add(this.rdbcircle);
            this.Controls.Add(this.rdbtnsquare);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnsquare;
        private System.Windows.Forms.RadioButton rdbcircle;
        private System.Windows.Forms.RadioButton rdbtriangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsquare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcircle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label label4;
    }
}