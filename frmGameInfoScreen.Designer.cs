namespace Math_Game_Course_14
{
    partial class frmGameInfoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameInfoScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumberOfQuestion = new System.Windows.Forms.ComboBox();
            this.cbQuestionLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(296, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "How Many Question?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNumberOfQuestion
            // 
            this.cbNumberOfQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbNumberOfQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumberOfQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumberOfQuestion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfQuestion.FormattingEnabled = true;
            this.cbNumberOfQuestion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNumberOfQuestion.Location = new System.Drawing.Point(329, 205);
            this.cbNumberOfQuestion.Name = "cbNumberOfQuestion";
            this.cbNumberOfQuestion.Size = new System.Drawing.Size(181, 27);
            this.cbNumberOfQuestion.TabIndex = 0;
            this.cbNumberOfQuestion.Validating += new System.ComponentModel.CancelEventHandler(this.cbNumberOfQuestion_Validating);
            // 
            // cbQuestionLevel
            // 
            this.cbQuestionLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbQuestionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQuestionLevel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestionLevel.FormattingEnabled = true;
            this.cbQuestionLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mix"});
            this.cbQuestionLevel.Location = new System.Drawing.Point(329, 298);
            this.cbQuestionLevel.Name = "cbQuestionLevel";
            this.cbQuestionLevel.Size = new System.Drawing.Size(181, 27);
            this.cbQuestionLevel.TabIndex = 1;
            this.cbQuestionLevel.Validating += new System.ComponentModel.CancelEventHandler(this.cbQuestionLevel_Validating);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(296, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Question Level?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOperationType
            // 
            this.cbOperationType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOperationType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Divide",
            "Multiplication",
            "Mix"});
            this.cbOperationType.Location = new System.Drawing.Point(329, 391);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(181, 27);
            this.cbOperationType.TabIndex = 2;
            this.cbOperationType.Validating += new System.ComponentModel.CancelEventHandler(this.cbOperationType_Validating);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operation Type?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(330, 503);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Math_Game_Course_14.Properties.Resources.for_children;
            this.pictureBox2.Location = new System.Drawing.Point(632, 449);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Game_Course_14.Properties.Resources.photo_2024_02_18_20_14_25;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGameInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 595);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbQuestionLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNumberOfQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGameInfoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Games";
            this.Load += new System.EventHandler(this.frmInfoGameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQuestionLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ComboBox cbNumberOfQuestion;
    }
}