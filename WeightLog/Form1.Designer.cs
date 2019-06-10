namespace WeightLog
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
            if (disposing && (components != null)) {
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
            this.weightTxt = new System.Windows.Forms.Label();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.frontPic = new System.Windows.Forms.Label();
            this.sidePic = new System.Windows.Forms.Label();
            this.backPic = new System.Windows.Forms.Label();
            this.facePic = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.frontPicDir = new System.Windows.Forms.TextBox();
            this.sidePicDir = new System.Windows.Forms.TextBox();
            this.backPicDir = new System.Windows.Forms.TextBox();
            this.facePicDir = new System.Windows.Forms.TextBox();
            this.frontPicBtn = new System.Windows.Forms.Button();
            this.sidePicBtn = new System.Windows.Forms.Button();
            this.backPicBtn = new System.Windows.Forms.Button();
            this.facePicBtn = new System.Windows.Forms.Button();
            this.thoughtsLbl = new System.Windows.Forms.Label();
            this.thoughtTxt = new System.Windows.Forms.TextBox();
            this.logBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightTxt
            // 
            this.weightTxt.AutoSize = true;
            this.weightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxt.Location = new System.Drawing.Point(82, 139);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(79, 25);
            this.weightTxt.TabIndex = 0;
            this.weightTxt.Text = "Weight";
            this.weightTxt.Click += new System.EventHandler(this.weightTxt_Click);
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(195, 144);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(148, 20);
            this.weightTxtBox.TabIndex = 1;
            // 
            // frontPic
            // 
            this.frontPic.AutoSize = true;
            this.frontPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontPic.Location = new System.Drawing.Point(82, 203);
            this.frontPic.Name = "frontPic";
            this.frontPic.Size = new System.Drawing.Size(98, 25);
            this.frontPic.TabIndex = 2;
            this.frontPic.Text = "Front Pic";
            // 
            // sidePic
            // 
            this.sidePic.AutoSize = true;
            this.sidePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidePic.Location = new System.Drawing.Point(82, 254);
            this.sidePic.Name = "sidePic";
            this.sidePic.Size = new System.Drawing.Size(91, 25);
            this.sidePic.TabIndex = 3;
            this.sidePic.Text = "Side Pic";
            // 
            // backPic
            // 
            this.backPic.AutoSize = true;
            this.backPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backPic.Location = new System.Drawing.Point(82, 304);
            this.backPic.Name = "backPic";
            this.backPic.Size = new System.Drawing.Size(96, 25);
            this.backPic.TabIndex = 4;
            this.backPic.Text = "Back Pic";
            // 
            // facePic
            // 
            this.facePic.AutoSize = true;
            this.facePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facePic.Location = new System.Drawing.Point(82, 364);
            this.facePic.Name = "facePic";
            this.facePic.Size = new System.Drawing.Size(96, 25);
            this.facePic.TabIndex = 5;
            this.facePic.Text = "Face Pic";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frontPicDir
            // 
            this.frontPicDir.Location = new System.Drawing.Point(195, 207);
            this.frontPicDir.Name = "frontPicDir";
            this.frontPicDir.Size = new System.Drawing.Size(148, 20);
            this.frontPicDir.TabIndex = 6;
            // 
            // sidePicDir
            // 
            this.sidePicDir.Location = new System.Drawing.Point(195, 254);
            this.sidePicDir.Name = "sidePicDir";
            this.sidePicDir.Size = new System.Drawing.Size(148, 20);
            this.sidePicDir.TabIndex = 7;
            // 
            // backPicDir
            // 
            this.backPicDir.Location = new System.Drawing.Point(195, 309);
            this.backPicDir.Name = "backPicDir";
            this.backPicDir.Size = new System.Drawing.Size(148, 20);
            this.backPicDir.TabIndex = 8;
            // 
            // facePicDir
            // 
            this.facePicDir.Location = new System.Drawing.Point(195, 369);
            this.facePicDir.Name = "facePicDir";
            this.facePicDir.Size = new System.Drawing.Size(148, 20);
            this.facePicDir.TabIndex = 9;
            // 
            // frontPicBtn
            // 
            this.frontPicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontPicBtn.Location = new System.Drawing.Point(349, 207);
            this.frontPicBtn.Name = "frontPicBtn";
            this.frontPicBtn.Size = new System.Drawing.Size(27, 23);
            this.frontPicBtn.TabIndex = 10;
            this.frontPicBtn.Text = "...";
            this.frontPicBtn.UseVisualStyleBackColor = true;
            this.frontPicBtn.Click += new System.EventHandler(this.frontPicBtn_Click);
            // 
            // sidePicBtn
            // 
            this.sidePicBtn.Location = new System.Drawing.Point(349, 254);
            this.sidePicBtn.Name = "sidePicBtn";
            this.sidePicBtn.Size = new System.Drawing.Size(27, 23);
            this.sidePicBtn.TabIndex = 11;
            this.sidePicBtn.Text = "...";
            this.sidePicBtn.UseVisualStyleBackColor = true;
            this.sidePicBtn.Click += new System.EventHandler(this.sidePicBtn_Click);
            // 
            // backPicBtn
            // 
            this.backPicBtn.Location = new System.Drawing.Point(349, 307);
            this.backPicBtn.Name = "backPicBtn";
            this.backPicBtn.Size = new System.Drawing.Size(27, 23);
            this.backPicBtn.TabIndex = 12;
            this.backPicBtn.Text = "...";
            this.backPicBtn.UseVisualStyleBackColor = true;
            this.backPicBtn.Click += new System.EventHandler(this.backPicBtn_Click);
            // 
            // facePicBtn
            // 
            this.facePicBtn.Location = new System.Drawing.Point(349, 369);
            this.facePicBtn.Name = "facePicBtn";
            this.facePicBtn.Size = new System.Drawing.Size(27, 23);
            this.facePicBtn.TabIndex = 13;
            this.facePicBtn.Text = "...";
            this.facePicBtn.UseVisualStyleBackColor = true;
            this.facePicBtn.Click += new System.EventHandler(this.facePicBtn_Click);
            // 
            // thoughtsLbl
            // 
            this.thoughtsLbl.AutoSize = true;
            this.thoughtsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoughtsLbl.Location = new System.Drawing.Point(429, 139);
            this.thoughtsLbl.Name = "thoughtsLbl";
            this.thoughtsLbl.Size = new System.Drawing.Size(102, 25);
            this.thoughtsLbl.TabIndex = 14;
            this.thoughtsLbl.Text = "Thoughts";
            // 
            // thoughtTxt
            // 
            this.thoughtTxt.Location = new System.Drawing.Point(434, 167);
            this.thoughtTxt.Multiline = true;
            this.thoughtTxt.Name = "thoughtTxt";
            this.thoughtTxt.Size = new System.Drawing.Size(291, 225);
            this.thoughtTxt.TabIndex = 15;
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.Location = new System.Drawing.Point(339, 449);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(119, 54);
            this.logBtn.TabIndex = 16;
            this.logBtn.Text = "Log";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(323, 46);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(150, 31);
            this.titleLbl.TabIndex = 17;
            this.titleLbl.Text = "Weight Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.thoughtTxt);
            this.Controls.Add(this.thoughtsLbl);
            this.Controls.Add(this.facePicBtn);
            this.Controls.Add(this.backPicBtn);
            this.Controls.Add(this.sidePicBtn);
            this.Controls.Add(this.frontPicBtn);
            this.Controls.Add(this.facePicDir);
            this.Controls.Add(this.backPicDir);
            this.Controls.Add(this.sidePicDir);
            this.Controls.Add(this.frontPicDir);
            this.Controls.Add(this.facePic);
            this.Controls.Add(this.backPic);
            this.Controls.Add(this.sidePic);
            this.Controls.Add(this.frontPic);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.weightTxt);
            this.Name = "Form1";
            this.Text = "Weight Log - Zac Reese";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightTxt;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.Label frontPic;
        private System.Windows.Forms.Label sidePic;
        private System.Windows.Forms.Label backPic;
        private System.Windows.Forms.Label facePic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox frontPicDir;
        private System.Windows.Forms.TextBox sidePicDir;
        private System.Windows.Forms.TextBox backPicDir;
        private System.Windows.Forms.TextBox facePicDir;
        private System.Windows.Forms.Button frontPicBtn;
        private System.Windows.Forms.Button sidePicBtn;
        private System.Windows.Forms.Button backPicBtn;
        private System.Windows.Forms.Button facePicBtn;
        private System.Windows.Forms.Label thoughtsLbl;
        private System.Windows.Forms.TextBox thoughtTxt;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Label titleLbl;
    }
}

