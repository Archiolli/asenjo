namespace BANCO
{
    partial class Dashboard
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
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtValorBaixo = new System.Windows.Forms.RadioButton();
            this.rbtValorAlto = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic20 = new System.Windows.Forms.PictureBox();
            this.pic50 = new System.Windows.Forms.PictureBox();
            this.pic100 = new System.Windows.Forms.PictureBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic100)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaque
            // 
            this.txtSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaque.Location = new System.Drawing.Point(255, 45);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(236, 38);
            this.txtSaque.TabIndex = 96;
            this.txtSaque.TextChanged += new System.EventHandler(this.txtSaque_TextChanged);
            this.txtSaque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaque_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(239, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Digite o valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtValorBaixo
            // 
            this.rbtValorBaixo.AutoSize = true;
            this.rbtValorBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtValorBaixo.ForeColor = System.Drawing.Color.Thistle;
            this.rbtValorBaixo.Location = new System.Drawing.Point(9, 35);
            this.rbtValorBaixo.Name = "rbtValorBaixo";
            this.rbtValorBaixo.Size = new System.Drawing.Size(160, 22);
            this.rbtValorBaixo.TabIndex = 99;
            this.rbtValorBaixo.Text = "notas de valor Baixo";
            this.rbtValorBaixo.UseVisualStyleBackColor = true;
            // 
            // rbtValorAlto
            // 
            this.rbtValorAlto.AutoSize = true;
            this.rbtValorAlto.Checked = true;
            this.rbtValorAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtValorAlto.ForeColor = System.Drawing.Color.Thistle;
            this.rbtValorAlto.Location = new System.Drawing.Point(9, 10);
            this.rbtValorAlto.Name = "rbtValorAlto";
            this.rbtValorAlto.Size = new System.Drawing.Size(148, 22);
            this.rbtValorAlto.TabIndex = 100;
            this.rbtValorAlto.TabStop = true;
            this.rbtValorAlto.Text = "notas de valor Alto";
            this.rbtValorAlto.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Thistle;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnOk.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnOk.Location = new System.Drawing.Point(727, 34);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 46);
            this.btnOk.TabIndex = 117;
            this.btnOk.Text = "Sacar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.groupBox);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSaque);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 99);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rbtValorBaixo);
            this.groupBox.Controls.Add(this.rbtValorAlto);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox.Location = new System.Drawing.Point(499, 24);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 61);
            this.groupBox.TabIndex = 133;
            this.groupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BANCO.Properties.Resources.open_graph_logo_large_br;
            this.pictureBox1.Location = new System.Drawing.Point(2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic10
            // 
            this.pic10.Image = global::BANCO.Properties.Resources._10;
            this.pic10.Location = new System.Drawing.Point(252, 191);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(188, 90);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic10.TabIndex = 124;
            this.pic10.TabStop = false;
            this.pic10.Visible = false;
            this.pic10.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pic5
            // 
            this.pic5.Image = global::BANCO.Properties.Resources._5;
            this.pic5.Location = new System.Drawing.Point(252, 100);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(174, 85);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 123;
            this.pic5.TabStop = false;
            this.pic5.Visible = false;
            // 
            // pic20
            // 
            this.pic20.Image = global::BANCO.Properties.Resources._20;
            this.pic20.Location = new System.Drawing.Point(252, 287);
            this.pic20.Name = "pic20";
            this.pic20.Size = new System.Drawing.Size(197, 90);
            this.pic20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic20.TabIndex = 122;
            this.pic20.TabStop = false;
            this.pic20.Visible = false;
            // 
            // pic50
            // 
            this.pic50.Image = global::BANCO.Properties.Resources._50;
            this.pic50.Location = new System.Drawing.Point(252, 383);
            this.pic50.Name = "pic50";
            this.pic50.Size = new System.Drawing.Size(210, 100);
            this.pic50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic50.TabIndex = 121;
            this.pic50.TabStop = false;
            this.pic50.Visible = false;
            // 
            // pic100
            // 
            this.pic100.Image = global::BANCO.Properties.Resources._100;
            this.pic100.Location = new System.Drawing.Point(252, 489);
            this.pic100.Name = "pic100";
            this.pic100.Size = new System.Drawing.Size(224, 100);
            this.pic100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic100.TabIndex = 120;
            this.pic100.TabStop = false;
            this.pic100.Visible = false;
            this.pic100.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.Thistle;
            this.lbl5.Location = new System.Drawing.Point(163, 153);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(23, 33);
            this.lbl5.TabIndex = 119;
            this.lbl5.Text = " ";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.Thistle;
            this.lbl10.Location = new System.Drawing.Point(163, 249);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(0, 33);
            this.lbl10.TabIndex = 126;
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl20.ForeColor = System.Drawing.Color.Thistle;
            this.lbl20.Location = new System.Drawing.Point(163, 345);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(0, 33);
            this.lbl20.TabIndex = 128;
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50.ForeColor = System.Drawing.Color.Thistle;
            this.lbl50.Location = new System.Drawing.Point(163, 451);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(0, 33);
            this.lbl50.TabIndex = 130;
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.ForeColor = System.Drawing.Color.Thistle;
            this.lbl100.Location = new System.Drawing.Point(163, 557);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(23, 33);
            this.lbl100.TabIndex = 132;
            this.lbl100.Text = " ";
            this.lbl100.Click += new System.EventHandler(this.lbl100_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(636, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 134;
            this.label3.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Lime;
            this.lblSaldo.Location = new System.Drawing.Point(710, 108);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(65, 29);
            this.lblSaldo.TabIndex = 135;
            this.lblSaldo.Text = "3000";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(852, 595);
            this.Controls.Add(this.pic100);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.pic10);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic20);
            this.Controls.Add(this.pic50);
            this.Controls.Add(this.groupBox1);
            this.Name = "Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUbank";
            this.Load += new System.EventHandler(this.Conta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic100)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtValorBaixo;
        private System.Windows.Forms.RadioButton rbtValorAlto;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic100;
        private System.Windows.Forms.PictureBox pic50;
        private System.Windows.Forms.PictureBox pic20;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic10;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaldo;
    }
}