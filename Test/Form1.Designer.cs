namespace Test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBNumero = new System.Windows.Forms.RadioButton();
            this.radioBRef = new System.Windows.Forms.RadioButton();
            this.buttonValidation = new System.Windows.Forms.Button();
            this.buttonDst = new System.Windows.Forms.Button();
            this.textBoxDst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.textBoxExcel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBNumero);
            this.groupBox1.Controls.Add(this.radioBRef);
            this.groupBox1.Controls.Add(this.buttonValidation);
            this.groupBox1.Controls.Add(this.buttonDst);
            this.groupBox1.Controls.Add(this.textBoxDst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonImage);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxImage);
            this.groupBox1.Controls.Add(this.textBoxExcel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations de Vente";
            // 
            // radioBNumero
            // 
            this.radioBNumero.Location = new System.Drawing.Point(128, 263);
            this.radioBNumero.Name = "radioBNumero";
            this.radioBNumero.Size = new System.Drawing.Size(104, 24);
            this.radioBNumero.TabIndex = 12;
            this.radioBNumero.TabStop = true;
            this.radioBNumero.Text = "Numero";
            this.radioBNumero.UseVisualStyleBackColor = true;
            this.radioBNumero.Checked = true;
            this.radioBNumero.CheckedChanged += new System.EventHandler(this.radioBNumero_CheckedChanged);
            // 
            // radioBRef
            // 
            this.radioBRef.Location = new System.Drawing.Point(18, 263);
            this.radioBRef.Name = "radioBRef";
            this.radioBRef.Size = new System.Drawing.Size(104, 24);
            this.radioBRef.TabIndex = 11;
            this.radioBRef.TabStop = true;
            this.radioBRef.Text = "Ref";
            this.radioBRef.UseVisualStyleBackColor = true;
            this.radioBRef.CheckedChanged += new System.EventHandler(this.radioBRef_CheckedChanged);
            // 
            // buttonValidation
            // 
            this.buttonValidation.Location = new System.Drawing.Point(18, 318);
            this.buttonValidation.Name = "buttonValidation";
            this.buttonValidation.Size = new System.Drawing.Size(108, 31);
            this.buttonValidation.TabIndex = 10;
            this.buttonValidation.Text = "Valider";
            this.buttonValidation.UseVisualStyleBackColor = true;
            this.buttonValidation.Click += new System.EventHandler(this.buttonValidation_Click);
            // 
            // buttonDst
            // 
            this.buttonDst.Location = new System.Drawing.Point(393, 224);
            this.buttonDst.Name = "buttonDst";
            this.buttonDst.Size = new System.Drawing.Size(35, 23);
            this.buttonDst.TabIndex = 9;
            this.buttonDst.Text = "...";
            this.buttonDst.UseVisualStyleBackColor = true;
            this.buttonDst.Click += new System.EventHandler(this.buttonDst_Click);
            // 
            // textBoxDst
            // 
            this.textBoxDst.Location = new System.Drawing.Point(18, 224);
            this.textBoxDst.Name = "textBoxDst";
            this.textBoxDst.Size = new System.Drawing.Size(369, 22);
            this.textBoxDst.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chemin de destination";
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(393, 138);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(35, 22);
            this.buttonImage.TabIndex = 5;
            this.buttonImage.Text = "...";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(18, 138);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(369, 22);
            this.textBoxImage.TabIndex = 3;
            // 
            // textBoxExcel
            // 
            this.textBoxExcel.Location = new System.Drawing.Point(18, 53);
            this.textBoxExcel.Name = "textBoxExcel";
            this.textBoxExcel.Size = new System.Drawing.Size(369, 22);
            this.textBoxExcel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chemin du dossier image";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chemin vers le Excel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 443);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton radioBNumero;
        private System.Windows.Forms.RadioButton radioBRef;

        private System.Windows.Forms.Button buttonDst;
        private System.Windows.Forms.Button buttonValidation;

        private System.Windows.Forms.Button buttonImage;

        private System.Windows.Forms.TextBox textBoxDst;

        private System.Windows.Forms.TextBox textBoxExcel;
        private System.Windows.Forms.TextBox textBoxImage;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}