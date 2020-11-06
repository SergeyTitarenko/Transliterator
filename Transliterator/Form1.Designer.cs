namespace Transliterator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Transliterate = new System.Windows.Forms.Button();
            this.inputField = new System.Windows.Forms.TextBox();
            this.outputField = new System.Windows.Forms.TextBox();
            this.russianRButton = new System.Windows.Forms.RadioButton();
            this.italianRButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Transliterate
            // 
            this.Transliterate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transliterate.Location = new System.Drawing.Point(33, 150);
            this.Transliterate.Name = "Transliterate";
            this.Transliterate.Size = new System.Drawing.Size(288, 38);
            this.Transliterate.TabIndex = 3;
            this.Transliterate.Text = "Transliterate";
            this.Transliterate.UseVisualStyleBackColor = true;
            this.Transliterate.Click += new System.EventHandler(this.button1_Click);
            this.Transliterate.Enter += new System.EventHandler(this.Transliterate_Enter);
            // 
            // inputField
            // 
            this.inputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputField.Location = new System.Drawing.Point(33, 41);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(288, 30);
            this.inputField.TabIndex = 1;
            // 
            // outputField
            // 
            this.outputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputField.Location = new System.Drawing.Point(33, 102);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(288, 30);
            this.outputField.TabIndex = 2;
            // 
            // russianRButton
            // 
            this.russianRButton.AutoSize = true;
            this.russianRButton.Checked = true;
            this.russianRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.russianRButton.Location = new System.Drawing.Point(372, 41);
            this.russianRButton.Name = "russianRButton";
            this.russianRButton.Size = new System.Drawing.Size(98, 24);
            this.russianRButton.TabIndex = 4;
            this.russianRButton.TabStop = true;
            this.russianRButton.Text = "Russian";
            this.russianRButton.UseVisualStyleBackColor = true;
            // 
            // italianRButton
            // 
            this.italianRButton.AutoSize = true;
            this.italianRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italianRButton.Location = new System.Drawing.Point(372, 68);
            this.italianRButton.Name = "italianRButton";
            this.italianRButton.Size = new System.Drawing.Size(81, 24);
            this.italianRButton.TabIndex = 5;
            this.italianRButton.TabStop = true;
            this.italianRButton.Text = "Italian";
            this.italianRButton.UseVisualStyleBackColor = true;
            this.italianRButton.CheckedChanged += new System.EventHandler(this.italianRButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text to Transliterate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result:";
            // 
            // copy_button
            // 
            this.copy_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copy_button.Image = global::Transliterator.Properties.Resources.Google_Noto_Emoji_Objects_62930_clipboard;
            this.copy_button.Location = new System.Drawing.Point(327, 102);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(31, 30);
            this.copy_button.TabIndex = 8;
            this.copy_button.Tag = "";
            this.copy_button.UseVisualStyleBackColor = false;
            this.copy_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 200);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.italianRButton);
            this.Controls.Add(this.russianRButton);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.inputField);
            this.Controls.Add(this.Transliterate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Transliteration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Transliterate;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.RadioButton russianRButton;
        private System.Windows.Forms.RadioButton italianRButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copy_button;
    }
}

