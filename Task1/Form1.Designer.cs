namespace Task1
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
            this.emp_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DocDestroy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_name
            // 
            this.emp_name.BackColor = System.Drawing.SystemColors.Window;
            this.emp_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emp_name.Location = new System.Drawing.Point(152, 23);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(169, 20);
            this.emp_name.TabIndex = 0;
            this.emp_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "emp_name";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(258, 234);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Submit";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.MaximumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "emp_salary";
            // 
            // emp_salary
            // 
            this.emp_salary.Location = new System.Drawing.Point(152, 49);
            this.emp_salary.Name = "emp_salary";
            this.emp_salary.Size = new System.Drawing.Size(169, 20);
            this.emp_salary.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DocDestroy";
            // 
            // DocDestroy
            // 
            this.DocDestroy.Location = new System.Drawing.Point(152, 79);
            this.DocDestroy.Name = "DocDestroy";
            this.DocDestroy.Size = new System.Drawing.Size(169, 20);
            this.DocDestroy.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(152, 105);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(169, 20);
            this.ID.TabIndex = 8;
            // 
            // grd
            // 
            this.grd.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grd.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grd.Location = new System.Drawing.Point(339, 32);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(437, 225);
            this.grd.TabIndex = 10;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.senddatatb);
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            this.grd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deldatatb);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gride View ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 258);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocDestroy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emp_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emp_name);
            this.Name = "Form1";
            this.Text = "Crud Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emp_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DocDestroy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label label6;
    }
}

