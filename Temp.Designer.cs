
namespace prjMultiConverter
{
    partial class Temp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radFToC = new System.Windows.Forms.RadioButton();
            this.radCToF = new System.Windows.Forms.RadioButton();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.labIn = new System.Windows.Forms.Label();
            this.labOut = new System.Windows.Forms.Label();
            this.txtMesg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.butRead = new System.Windows.Forms.Button();
            this.butConvert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radFToC);
            this.panel1.Controls.Add(this.radCToF);
            this.panel1.Location = new System.Drawing.Point(171, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 152);
            this.panel1.TabIndex = 0;
            // 
            // radFToC
            // 
            this.radFToC.AutoSize = true;
            this.radFToC.Location = new System.Drawing.Point(46, 85);
            this.radFToC.Name = "radFToC";
            this.radFToC.Size = new System.Drawing.Size(128, 24);
            this.radFToC.TabIndex = 0;
            this.radFToC.Text = "From °F to °C";
            this.radFToC.UseVisualStyleBackColor = true;
            this.radFToC.CheckedChanged += new System.EventHandler(this.radFToC_CheckedChanged);
            // 
            // radCToF
            // 
            this.radCToF.AutoSize = true;
            this.radCToF.Checked = true;
            this.radCToF.Location = new System.Drawing.Point(46, 37);
            this.radCToF.Name = "radCToF";
            this.radCToF.Size = new System.Drawing.Size(128, 24);
            this.radCToF.TabIndex = 0;
            this.radCToF.TabStop = true;
            this.radCToF.Text = "From °C to °F";
            this.radCToF.UseVisualStyleBackColor = true;
            this.radCToF.CheckedChanged += new System.EventHandler(this.radCToF_CheckedChanged);
            // 
            // txtIn
            // 
            this.txtIn.BackColor = System.Drawing.Color.White;
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(43, 221);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(201, 30);
            this.txtIn.TabIndex = 1;
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.Color.White;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(298, 221);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(201, 30);
            this.txtOut.TabIndex = 1;
            // 
            // labIn
            // 
            this.labIn.AutoSize = true;
            this.labIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIn.Location = new System.Drawing.Point(128, 271);
            this.labIn.Name = "labIn";
            this.labIn.Size = new System.Drawing.Size(37, 25);
            this.labIn.TabIndex = 2;
            this.labIn.Text = "°C";
            // 
            // labOut
            // 
            this.labOut.AutoSize = true;
            this.labOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOut.Location = new System.Drawing.Point(380, 271);
            this.labOut.Name = "labOut";
            this.labOut.Size = new System.Drawing.Size(34, 25);
            this.labOut.TabIndex = 2;
            this.labOut.Text = "°F";
            // 
            // txtMesg
            // 
            this.txtMesg.BackColor = System.Drawing.Color.White;
            this.txtMesg.Enabled = false;
            this.txtMesg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesg.Location = new System.Drawing.Point(43, 330);
            this.txtMesg.Multiline = true;
            this.txtMesg.Name = "txtMesg";
            this.txtMesg.ReadOnly = true;
            this.txtMesg.Size = new System.Drawing.Size(456, 86);
            this.txtMesg.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // butExit
            // 
            this.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butExit.Location = new System.Drawing.Point(403, 444);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(96, 36);
            this.butExit.TabIndex = 8;
            this.butExit.Text = "&Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butRead
            // 
            this.butRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butRead.Location = new System.Drawing.Point(223, 444);
            this.butRead.Name = "butRead";
            this.butRead.Size = new System.Drawing.Size(96, 36);
            this.butRead.TabIndex = 7;
            this.butRead.Text = "&Read file";
            this.butRead.UseVisualStyleBackColor = true;
            this.butRead.Click += new System.EventHandler(this.butRead_Click);
            // 
            // butConvert
            // 
            this.butConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butConvert.Location = new System.Drawing.Point(43, 444);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(96, 36);
            this.butConvert.TabIndex = 6;
            this.butConvert.Text = "&Convert";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 507);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butRead);
            this.Controls.Add(this.butConvert);
            this.Controls.Add(this.labOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labIn);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtMesg);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.panel1);
            this.Name = "Temp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp app - Dinh Hoang Nhan";
            this.Load += new System.EventHandler(this.Temp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radFToC;
        private System.Windows.Forms.RadioButton radCToF;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label labIn;
        private System.Windows.Forms.Label labOut;
        private System.Windows.Forms.TextBox txtMesg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butRead;
        private System.Windows.Forms.Button butConvert;
    }
}