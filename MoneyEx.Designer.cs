
namespace prjMultiConverter
{
    partial class MoneyEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyEx));
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radUsdIn = new System.Windows.Forms.RadioButton();
            this.radVndIn = new System.Windows.Forms.RadioButton();
            this.radCadIn = new System.Windows.Forms.RadioButton();
            this.radEurIn = new System.Windows.Forms.RadioButton();
            this.radGbpIn = new System.Windows.Forms.RadioButton();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radVndOut = new System.Windows.Forms.RadioButton();
            this.radGbpOut = new System.Windows.Forms.RadioButton();
            this.radEurOut = new System.Windows.Forms.RadioButton();
            this.radUsdOut = new System.Windows.Forms.RadioButton();
            this.radCadOut = new System.Windows.Forms.RadioButton();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.butExit = new System.Windows.Forms.Button();
            this.butRead = new System.Windows.Forms.Button();
            this.butConvert = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.pictureBox1);
            this.grb1.Controls.Add(this.radUsdIn);
            this.grb1.Controls.Add(this.radVndIn);
            this.grb1.Controls.Add(this.radCadIn);
            this.grb1.Controls.Add(this.radEurIn);
            this.grb1.Controls.Add(this.radGbpIn);
            this.grb1.Location = new System.Drawing.Point(35, 30);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(189, 286);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "From";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // radUsdIn
            // 
            this.radUsdIn.AutoSize = true;
            this.radUsdIn.Location = new System.Drawing.Point(23, 90);
            this.radUsdIn.Name = "radUsdIn";
            this.radUsdIn.Size = new System.Drawing.Size(69, 24);
            this.radUsdIn.TabIndex = 0;
            this.radUsdIn.TabStop = true;
            this.radUsdIn.Text = "USD";
            this.radUsdIn.UseVisualStyleBackColor = true;
            // 
            // radVndIn
            // 
            this.radVndIn.AutoSize = true;
            this.radVndIn.Location = new System.Drawing.Point(23, 216);
            this.radVndIn.Name = "radVndIn";
            this.radVndIn.Size = new System.Drawing.Size(68, 24);
            this.radVndIn.TabIndex = 0;
            this.radVndIn.TabStop = true;
            this.radVndIn.Text = "VND";
            this.radVndIn.UseVisualStyleBackColor = true;
            // 
            // radCadIn
            // 
            this.radCadIn.AutoSize = true;
            this.radCadIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCadIn.Location = new System.Drawing.Point(23, 48);
            this.radCadIn.Name = "radCadIn";
            this.radCadIn.Size = new System.Drawing.Size(68, 24);
            this.radCadIn.TabIndex = 0;
            this.radCadIn.Text = "CAD";
            this.radCadIn.UseVisualStyleBackColor = true;
            // 
            // radEurIn
            // 
            this.radEurIn.AutoSize = true;
            this.radEurIn.Location = new System.Drawing.Point(23, 132);
            this.radEurIn.Name = "radEurIn";
            this.radEurIn.Size = new System.Drawing.Size(69, 24);
            this.radEurIn.TabIndex = 0;
            this.radEurIn.TabStop = true;
            this.radEurIn.Text = "EUR";
            this.radEurIn.UseVisualStyleBackColor = true;
            // 
            // radGbpIn
            // 
            this.radGbpIn.AutoSize = true;
            this.radGbpIn.Location = new System.Drawing.Point(23, 174);
            this.radGbpIn.Name = "radGbpIn";
            this.radGbpIn.Size = new System.Drawing.Size(68, 24);
            this.radGbpIn.TabIndex = 0;
            this.radGbpIn.TabStop = true;
            this.radGbpIn.Text = "GBP";
            this.radGbpIn.UseVisualStyleBackColor = true;
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.pictureBox2);
            this.grb2.Controls.Add(this.radVndOut);
            this.grb2.Controls.Add(this.radGbpOut);
            this.grb2.Controls.Add(this.radEurOut);
            this.grb2.Controls.Add(this.radUsdOut);
            this.grb2.Controls.Add(this.radCadOut);
            this.grb2.Location = new System.Drawing.Point(281, 30);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(189, 286);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "To";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(110, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // radVndOut
            // 
            this.radVndOut.AutoSize = true;
            this.radVndOut.Location = new System.Drawing.Point(26, 216);
            this.radVndOut.Name = "radVndOut";
            this.radVndOut.Size = new System.Drawing.Size(68, 24);
            this.radVndOut.TabIndex = 0;
            this.radVndOut.Text = "VND";
            this.radVndOut.UseVisualStyleBackColor = true;
            // 
            // radGbpOut
            // 
            this.radGbpOut.AutoSize = true;
            this.radGbpOut.Location = new System.Drawing.Point(26, 174);
            this.radGbpOut.Name = "radGbpOut";
            this.radGbpOut.Size = new System.Drawing.Size(68, 24);
            this.radGbpOut.TabIndex = 0;
            this.radGbpOut.Text = "GBP";
            this.radGbpOut.UseVisualStyleBackColor = true;
            // 
            // radEurOut
            // 
            this.radEurOut.AutoSize = true;
            this.radEurOut.Location = new System.Drawing.Point(26, 132);
            this.radEurOut.Name = "radEurOut";
            this.radEurOut.Size = new System.Drawing.Size(69, 24);
            this.radEurOut.TabIndex = 0;
            this.radEurOut.Text = "EUR";
            this.radEurOut.UseVisualStyleBackColor = true;
            // 
            // radUsdOut
            // 
            this.radUsdOut.AutoSize = true;
            this.radUsdOut.Location = new System.Drawing.Point(26, 90);
            this.radUsdOut.Name = "radUsdOut";
            this.radUsdOut.Size = new System.Drawing.Size(69, 24);
            this.radUsdOut.TabIndex = 0;
            this.radUsdOut.Text = "USD";
            this.radUsdOut.UseVisualStyleBackColor = true;
            // 
            // radCadOut
            // 
            this.radCadOut.AutoSize = true;
            this.radCadOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCadOut.Location = new System.Drawing.Point(26, 48);
            this.radCadOut.Name = "radCadOut";
            this.radCadOut.Size = new System.Drawing.Size(68, 24);
            this.radCadOut.TabIndex = 0;
            this.radCadOut.Text = "CAD";
            this.radCadOut.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            this.txtIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(36, 345);
            this.txtIn.Name = "txtDisplay";
            this.txtIn.Size = new System.Drawing.Size(188, 30);
            this.txtIn.TabIndex = 2;
            // 
            // txtOut
            // 
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(281, 345);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(189, 30);
            this.txtOut.TabIndex = 2;
            // 
            // butExit
            // 
            this.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butExit.Location = new System.Drawing.Point(374, 426);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(96, 36);
            this.butExit.TabIndex = 5;
            this.butExit.Text = "&Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // butRead
            // 
            this.butRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butRead.Location = new System.Drawing.Point(205, 426);
            this.butRead.Name = "butRead";
            this.butRead.Size = new System.Drawing.Size(96, 36);
            this.butRead.TabIndex = 4;
            this.butRead.Text = "&Read file";
            this.butRead.UseVisualStyleBackColor = true;
            this.butRead.Click += new System.EventHandler(this.butRead_Click);
            // 
            // butConvert
            // 
            this.butConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.butConvert.Location = new System.Drawing.Point(36, 426);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(96, 36);
            this.butConvert.TabIndex = 3;
            this.butConvert.Text = "&Convert";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click);
            // 
            // MoneyEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 494);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butRead);
            this.Controls.Add(this.butConvert);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "MoneyEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyEx";
            this.Load += new System.EventHandler(this.MoneyEx_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.RadioButton radVndIn;
        private System.Windows.Forms.RadioButton radGbpIn;
        private System.Windows.Forms.RadioButton radEurIn;
        private System.Windows.Forms.RadioButton radUsdIn;
        private System.Windows.Forms.RadioButton radCadIn;
        private System.Windows.Forms.RadioButton radVndOut;
        private System.Windows.Forms.RadioButton radGbpOut;
        private System.Windows.Forms.RadioButton radEurOut;
        private System.Windows.Forms.RadioButton radUsdOut;
        private System.Windows.Forms.RadioButton radCadOut;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butRead;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}