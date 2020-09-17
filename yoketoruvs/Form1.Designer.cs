namespace yoketoruvs
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startbotton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.titleBotton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.titleLabel.Location = new System.Drawing.Point(218, 151);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(565, 97);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2020";
            // 
            // startbotton
            // 
            this.startbotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startbotton.Font = new System.Drawing.Font("游ゴシック", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startbotton.Location = new System.Drawing.Point(388, 318);
            this.startbotton.Name = "startbotton";
            this.startbotton.Size = new System.Drawing.Size(224, 93);
            this.startbotton.TabIndex = 1;
            this.startbotton.Text = "START";
            this.startbotton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.startbotton.UseVisualStyleBackColor = false;
            this.startbotton.Click += new System.EventHandler(this.startbotton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightLabel.Location = new System.Drawing.Point(12, 562);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(258, 21);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright © 2020 yamamura";
            this.copyrightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(132, 27);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.leftLabel.Location = new System.Drawing.Point(890, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(86, 27);
            this.leftLabel.TabIndex = 4;
            this.leftLabel.Text = "★:10";
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HighScoreLabel.Location = new System.Drawing.Point(424, 272);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(153, 21);
            this.HighScoreLabel.TabIndex = 5;
            this.HighScoreLabel.Text = "HighScore 100";
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameoverLabel.Location = new System.Drawing.Point(183, 196);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(635, 109);
            this.gameoverLabel.TabIndex = 6;
            this.gameoverLabel.Text = "GAMEOVER";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLabel.ForeColor = System.Drawing.Color.Red;
            this.clearLabel.Location = new System.Drawing.Point(305, 184);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(391, 109);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "CLEAR";
            // 
            // titleBotton
            // 
            this.titleBotton.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleBotton.Location = new System.Drawing.Point(388, 318);
            this.titleBotton.Name = "titleBotton";
            this.titleBotton.Size = new System.Drawing.Size(224, 93);
            this.titleBotton.TabIndex = 8;
            this.titleBotton.Text = "Back To Title ";
            this.titleBotton.UseVisualStyleBackColor = true;
            this.titleBotton.Click += new System.EventHandler(this.titleBotton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 592);
            this.Controls.Add(this.titleBotton);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startbotton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startbotton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label HighScoreLabel;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button titleBotton;
        private System.Windows.Forms.Timer timer1;
    }
}

