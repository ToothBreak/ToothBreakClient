namespace project_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.tooth7 = new System.Windows.Forms.Button();
            this.tooth1 = new System.Windows.Forms.Button();
            this.tooth6 = new System.Windows.Forms.Button();
            this.tooth2 = new System.Windows.Forms.Button();
            this.tooth5 = new System.Windows.Forms.Button();
            this.tooth3 = new System.Windows.Forms.Button();
            this.tooth4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(627, -41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "존잘상미니 ";
            // 
            // tooth7
            // 
            this.tooth7.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth7.Location = new System.Drawing.Point(485, 342);
            this.tooth7.Name = "tooth7";
            this.tooth7.Size = new System.Drawing.Size(14, 11);
            this.tooth7.TabIndex = 23;
            this.tooth7.UseVisualStyleBackColor = false;
            this.tooth7.Click += new System.EventHandler(this.tooth7_Click);
            // 
            // tooth1
            // 
            this.tooth1.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth1.Location = new System.Drawing.Point(324, 341);
            this.tooth1.Name = "tooth1";
            this.tooth1.Size = new System.Drawing.Size(18, 11);
            this.tooth1.TabIndex = 22;
            this.tooth1.UseVisualStyleBackColor = false;
            this.tooth1.Click += new System.EventHandler(this.tooth1_Click);
            // 
            // tooth6
            // 
            this.tooth6.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth6.Location = new System.Drawing.Point(464, 334);
            this.tooth6.Name = "tooth6";
            this.tooth6.Size = new System.Drawing.Size(18, 16);
            this.tooth6.TabIndex = 21;
            this.tooth6.UseVisualStyleBackColor = false;
            this.tooth6.Click += new System.EventHandler(this.tooth6_Click);
            // 
            // tooth2
            // 
            this.tooth2.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth2.Location = new System.Drawing.Point(345, 331);
            this.tooth2.Name = "tooth2";
            this.tooth2.Size = new System.Drawing.Size(19, 18);
            this.tooth2.TabIndex = 20;
            this.tooth2.UseVisualStyleBackColor = false;
            this.tooth2.Click += new System.EventHandler(this.tooth2_Click);
            // 
            // tooth5
            // 
            this.tooth5.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth5.Location = new System.Drawing.Point(438, 327);
            this.tooth5.Name = "tooth5";
            this.tooth5.Size = new System.Drawing.Size(22, 20);
            this.tooth5.TabIndex = 19;
            this.tooth5.UseVisualStyleBackColor = false;
            this.tooth5.Click += new System.EventHandler(this.tooth5_Click);
            // 
            // tooth3
            // 
            this.tooth3.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth3.Location = new System.Drawing.Point(371, 326);
            this.tooth3.Name = "tooth3";
            this.tooth3.Size = new System.Drawing.Size(25, 20);
            this.tooth3.TabIndex = 18;
            this.tooth3.UseVisualStyleBackColor = false;
            this.tooth3.Click += new System.EventHandler(this.tooth3_Click);
            // 
            // tooth4
            // 
            this.tooth4.BackColor = System.Drawing.SystemColors.WindowText;
            this.tooth4.Location = new System.Drawing.Point(406, 326);
            this.tooth4.Name = "tooth4";
            this.tooth4.Size = new System.Drawing.Size(25, 20);
            this.tooth4.TabIndex = 17;
            this.tooth4.UseVisualStyleBackColor = false;
            this.tooth4.Click += new System.EventHandler(this.tooth4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(227, -85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "이빨을 부셔라!!";
            // 
            // finish
            // 
            this.finish.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.finish.Location = new System.Drawing.Point(416, 601);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(206, 55);
            this.finish.TabIndex = 16;
            this.finish.Text = "게임 끝내기 ";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.restart.Location = new System.Drawing.Point(147, 601);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(203, 55);
            this.restart.TabIndex = 15;
            this.restart.Text = "다시 시작";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(615, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "존잘상미니 ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("배달의민족 주아", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(215, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 55);
            this.label4.TabIndex = 25;
            this.label4.Text = "이빨을 부셔라!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tooth7);
            this.Controls.Add(this.tooth1);
            this.Controls.Add(this.tooth6);
            this.Controls.Add(this.tooth2);
            this.Controls.Add(this.tooth5);
            this.Controls.Add(this.tooth3);
            this.Controls.Add(this.tooth4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tooth7;
        private System.Windows.Forms.Button tooth1;
        private System.Windows.Forms.Button tooth6;
        private System.Windows.Forms.Button tooth2;
        private System.Windows.Forms.Button tooth5;
        private System.Windows.Forms.Button tooth3;
        private System.Windows.Forms.Button tooth4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

