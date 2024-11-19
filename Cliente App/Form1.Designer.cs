namespace Cliente_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.preLbl = new System.Windows.Forms.Label();
            this.ConectBttn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.sendBttn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.portTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ipTxt);
            this.panel1.Controls.Add(this.preLbl);
            this.panel1.Controls.Add(this.ConectBttn);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 119);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(246, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(41, 50);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(199, 20);
            this.portTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(41, 24);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(298, 20);
            this.ipTxt.TabIndex = 2;
            // 
            // preLbl
            // 
            this.preLbl.AutoSize = true;
            this.preLbl.Location = new System.Drawing.Point(18, 27);
            this.preLbl.Name = "preLbl";
            this.preLbl.Size = new System.Drawing.Size(17, 13);
            this.preLbl.TabIndex = 1;
            this.preLbl.Text = "IP";
            // 
            // ConectBttn
            // 
            this.ConectBttn.BackColor = System.Drawing.Color.PaleGreen;
            this.ConectBttn.Location = new System.Drawing.Point(41, 75);
            this.ConectBttn.Name = "ConectBttn";
            this.ConectBttn.Size = new System.Drawing.Size(199, 29);
            this.ConectBttn.TabIndex = 0;
            this.ConectBttn.Text = "conectar";
            this.ConectBttn.UseVisualStyleBackColor = false;
            this.ConectBttn.Click += new System.EventHandler(this.ConectBttn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.logTxt);
            this.panel2.Location = new System.Drawing.Point(368, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 433);
            this.panel2.TabIndex = 1;
            // 
            // logTxt
            // 
            this.logTxt.Location = new System.Drawing.Point(22, 21);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(384, 380);
            this.logTxt.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.contentTxt);
            this.panel3.Controls.Add(this.sendBttn);
            this.panel3.Location = new System.Drawing.Point(11, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 303);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(180, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar Archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contentTxt
            // 
            this.contentTxt.Location = new System.Drawing.Point(12, 11);
            this.contentTxt.Multiline = true;
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.contentTxt.Size = new System.Drawing.Size(327, 242);
            this.contentTxt.TabIndex = 2;
            // 
            // sendBttn
            // 
            this.sendBttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBttn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sendBttn.Location = new System.Drawing.Point(9, 259);
            this.sendBttn.Name = "sendBttn";
            this.sendBttn.Size = new System.Drawing.Size(151, 33);
            this.sendBttn.TabIndex = 0;
            this.sendBttn.Text = "Enviar";
            this.sendBttn.UseVisualStyleBackColor = false;
            this.sendBttn.Click += new System.EventHandler(this.sendBttn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(383, 20);
            this.button3.TabIndex = 1;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label preLbl;
        private System.Windows.Forms.Button ConectBttn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox contentTxt;
        private System.Windows.Forms.Button sendBttn;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

