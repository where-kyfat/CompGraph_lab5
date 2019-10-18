namespace BezierCubicSplines
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PointslistBox = new System.Windows.Forms.ListBox();
            this.DeletePntBtn = new System.Windows.Forms.Button();
            this.AddPointBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(580, 523);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(123, 52);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PointslistBox
            // 
            this.PointslistBox.FormattingEnabled = true;
            this.PointslistBox.Location = new System.Drawing.Point(580, 10);
            this.PointslistBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PointslistBox.Name = "PointslistBox";
            this.PointslistBox.Size = new System.Drawing.Size(124, 498);
            this.PointslistBox.TabIndex = 2;
            this.PointslistBox.SelectedIndexChanged += new System.EventHandler(this.PointslistBox_SelectedIndexChanged);
            // 
            // DeletePntBtn
            // 
            this.DeletePntBtn.Location = new System.Drawing.Point(178, 533);
            this.DeletePntBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeletePntBtn.Name = "DeletePntBtn";
            this.DeletePntBtn.Size = new System.Drawing.Size(123, 33);
            this.DeletePntBtn.TabIndex = 3;
            this.DeletePntBtn.Text = "Удалить точку";
            this.DeletePntBtn.UseVisualStyleBackColor = true;
            this.DeletePntBtn.Click += new System.EventHandler(this.DeletePntBtn_Click);
            // 
            // AddPointBtn
            // 
            this.AddPointBtn.Location = new System.Drawing.Point(11, 533);
            this.AddPointBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPointBtn.Name = "AddPointBtn";
            this.AddPointBtn.Size = new System.Drawing.Size(123, 33);
            this.AddPointBtn.TabIndex = 4;
            this.AddPointBtn.Text = "Добавить точку";
            this.AddPointBtn.UseVisualStyleBackColor = true;
            this.AddPointBtn.Click += new System.EventHandler(this.AddPointBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 599);
            this.Controls.Add(this.AddPointBtn);
            this.Controls.Add(this.DeletePntBtn);
            this.Controls.Add(this.PointslistBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CubSplines";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ListBox PointslistBox;
        private System.Windows.Forms.Button DeletePntBtn;
        private System.Windows.Forms.Button AddPointBtn;
    }
}

