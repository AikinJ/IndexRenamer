
namespace IndexRenamer
{
    partial class ProgramForm
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
            this.btnOpenPictures = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPictures
            // 
            this.btnOpenPictures.Location = new System.Drawing.Point(12, 12);
            this.btnOpenPictures.Name = "btnOpenPictures";
            this.btnOpenPictures.Size = new System.Drawing.Size(170, 36);
            this.btnOpenPictures.TabIndex = 0;
            this.btnOpenPictures.Text = "Open Pictures";
            this.btnOpenPictures.UseVisualStyleBackColor = true;
            this.btnOpenPictures.Click += new System.EventHandler(this.btnOpenPicturesClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rename to indexes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RenameIndexes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpenPictures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPictures;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

