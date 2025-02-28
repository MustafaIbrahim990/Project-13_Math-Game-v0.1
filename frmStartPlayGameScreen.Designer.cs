namespace Math_Game_Course_14
{
    partial class frmStartPlayGameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartPlayGameScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblOpType = new System.Windows.Forms.Label();
            this.txtPlayerAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckPlayerAnswer = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumberOfCorrectAnswer = new System.Windows.Forms.Label();
            this.lblNumberOfWrongAnswer = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(276, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question";
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.AutoSize = true;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCurrentQuestion.Location = new System.Drawing.Point(404, 61);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(28, 32);
            this.lblCurrentQuestion.TabIndex = 4;
            this.lblCurrentQuestion.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(438, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestion.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(466, 61);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(28, 32);
            this.lblNumberOfQuestion.TabIndex = 6;
            this.lblNumberOfQuestion.Text = "0";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNumber1.Location = new System.Drawing.Point(404, 232);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(28, 32);
            this.lblNumber1.TabIndex = 7;
            this.lblNumber1.Text = "0";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNumber2.Location = new System.Drawing.Point(404, 311);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(28, 32);
            this.lblNumber2.TabIndex = 8;
            this.lblNumber2.Text = "0";
            // 
            // lblOpType
            // 
            this.lblOpType.AutoSize = true;
            this.lblOpType.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOpType.Location = new System.Drawing.Point(368, 269);
            this.lblOpType.Name = "lblOpType";
            this.lblOpType.Size = new System.Drawing.Size(47, 35);
            this.lblOpType.TabIndex = 9;
            this.lblOpType.Text = "op";
            // 
            // txtPlayerAnswer
            // 
            this.txtPlayerAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPlayerAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerAnswer.Location = new System.Drawing.Point(323, 378);
            this.txtPlayerAnswer.Multiline = true;
            this.txtPlayerAnswer.Name = "txtPlayerAnswer";
            this.txtPlayerAnswer.Size = new System.Drawing.Size(190, 33);
            this.txtPlayerAnswer.TabIndex = 0;
            this.txtPlayerAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlayerAnswer_Validating);
            // 
            // btnCheckPlayerAnswer
            // 
            this.btnCheckPlayerAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCheckPlayerAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckPlayerAnswer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPlayerAnswer.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckPlayerAnswer.Location = new System.Drawing.Point(323, 427);
            this.btnCheckPlayerAnswer.Name = "btnCheckPlayerAnswer";
            this.btnCheckPlayerAnswer.Size = new System.Drawing.Size(190, 45);
            this.btnCheckPlayerAnswer.TabIndex = 1;
            this.btnCheckPlayerAnswer.Text = "Check";
            this.btnCheckPlayerAnswer.UseVisualStyleBackColor = false;
            this.btnCheckPlayerAnswer.Click += new System.EventHandler(this.btnCheckPlayerAnswer_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextQuestion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.Blue;
            this.btnNextQuestion.Location = new System.Drawing.Point(256, 524);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(142, 45);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(444, 524);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "✅";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "❎";
            // 
            // lblNumberOfCorrectAnswer
            // 
            this.lblNumberOfCorrectAnswer.AutoSize = true;
            this.lblNumberOfCorrectAnswer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCorrectAnswer.ForeColor = System.Drawing.Color.Lime;
            this.lblNumberOfCorrectAnswer.Location = new System.Drawing.Point(83, 232);
            this.lblNumberOfCorrectAnswer.Name = "lblNumberOfCorrectAnswer";
            this.lblNumberOfCorrectAnswer.Size = new System.Drawing.Size(34, 37);
            this.lblNumberOfCorrectAnswer.TabIndex = 16;
            this.lblNumberOfCorrectAnswer.Text = "0";
            // 
            // lblNumberOfWrongAnswer
            // 
            this.lblNumberOfWrongAnswer.AutoSize = true;
            this.lblNumberOfWrongAnswer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfWrongAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfWrongAnswer.Location = new System.Drawing.Point(83, 311);
            this.lblNumberOfWrongAnswer.Name = "lblNumberOfWrongAnswer";
            this.lblNumberOfWrongAnswer.Size = new System.Drawing.Size(34, 37);
            this.lblNumberOfWrongAnswer.TabIndex = 17;
            this.lblNumberOfWrongAnswer.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Math_Game_Course_14.Properties.Resources.photo_2023_11_20_17_27_26;
            this.pictureBox3.Location = new System.Drawing.Point(749, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Math_Game_Course_14.Properties.Resources.for_children;
            this.pictureBox2.Location = new System.Drawing.Point(632, 427);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Game_Course_14.Properties.Resources.photo_2024_02_18_20_14_25;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Blue;
            this.lblTimer.Location = new System.Drawing.Point(690, 56);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 37);
            this.lblTimer.TabIndex = 19;
            this.lblTimer.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmStartPlayGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 595);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblNumberOfWrongAnswer);
            this.Controls.Add(this.lblNumberOfCorrectAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnCheckPlayerAnswer);
            this.Controls.Add(this.txtPlayerAnswer);
            this.Controls.Add(this.lblOpType);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblNumberOfQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurrentQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStartPlayGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Games";
            this.Load += new System.EventHandler(this.frmStartPlayGameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblOpType;
        private System.Windows.Forms.TextBox txtPlayerAnswer;
        private System.Windows.Forms.Button btnCheckPlayerAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumberOfCorrectAnswer;
        private System.Windows.Forms.Label lblNumberOfWrongAnswer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}