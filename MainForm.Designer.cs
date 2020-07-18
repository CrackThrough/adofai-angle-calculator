namespace AngleCalculator
{
    partial class MainForm
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelThis = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.textBoxThis = new System.Windows.Forms.TextBox();
            this.textBoxNext = new System.Windows.Forms.TextBox();
            this.groupBoxTileInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResultAngleFormula = new System.Windows.Forms.TextBox();
            this.labelResultAngleFormula = new System.Windows.Forms.Label();
            this.textBoxResultAngle = new System.Windows.Forms.TextBox();
            this.labelResultAngle = new System.Windows.Forms.Label();
            this.groupBoxOtherInfo = new System.Windows.Forms.GroupBox();
            this.textBoxBpm = new System.Windows.Forms.TextBox();
            this.labelBpm = new System.Windows.Forms.Label();
            this.checkBoxTwirl = new System.Windows.Forms.CheckBox();
            this.labelResultMs = new System.Windows.Forms.Label();
            this.textBoxResultMs = new System.Windows.Forms.TextBox();
            this.labelResultMsFormula = new System.Windows.Forms.Label();
            this.textBoxResultMsFormula = new System.Windows.Forms.TextBox();
            this.groupBoxTileInfo.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxOtherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(468, 12);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "This application is for angle calculation + ms support. Development purpose only." +
    "";
            // 
            // labelThis
            // 
            this.labelThis.AutoSize = true;
            this.labelThis.Location = new System.Drawing.Point(6, 18);
            this.labelThis.Name = "labelThis";
            this.labelThis.Size = new System.Drawing.Size(51, 12);
            this.labelThis.TabIndex = 1;
            this.labelThis.Text = "ThisTile";
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Location = new System.Drawing.Point(63, 18);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(52, 12);
            this.labelNext.TabIndex = 1;
            this.labelNext.Text = "NextTile";
            // 
            // textBoxThis
            // 
            this.textBoxThis.Location = new System.Drawing.Point(6, 33);
            this.textBoxThis.Name = "textBoxThis";
            this.textBoxThis.Size = new System.Drawing.Size(51, 21);
            this.textBoxThis.TabIndex = 0;
            this.textBoxThis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxThis.TextChanged += new System.EventHandler(this.textBoxThis_TextChanged);
            // 
            // textBoxNext
            // 
            this.textBoxNext.Location = new System.Drawing.Point(64, 33);
            this.textBoxNext.Name = "textBoxNext";
            this.textBoxNext.Size = new System.Drawing.Size(51, 21);
            this.textBoxNext.TabIndex = 1;
            this.textBoxNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNext.TextChanged += new System.EventHandler(this.textBoxNext_TextChanged);
            // 
            // groupBoxTileInfo
            // 
            this.groupBoxTileInfo.Controls.Add(this.labelThis);
            this.groupBoxTileInfo.Controls.Add(this.textBoxNext);
            this.groupBoxTileInfo.Controls.Add(this.labelNext);
            this.groupBoxTileInfo.Controls.Add(this.textBoxThis);
            this.groupBoxTileInfo.Location = new System.Drawing.Point(14, 39);
            this.groupBoxTileInfo.Name = "groupBoxTileInfo";
            this.groupBoxTileInfo.Size = new System.Drawing.Size(120, 65);
            this.groupBoxTileInfo.TabIndex = 3;
            this.groupBoxTileInfo.TabStop = false;
            this.groupBoxTileInfo.Text = "Tile Info";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResultAngleFormula);
            this.groupBoxResult.Controls.Add(this.labelResultAngleFormula);
            this.groupBoxResult.Controls.Add(this.textBoxResultMsFormula);
            this.groupBoxResult.Controls.Add(this.labelResultMsFormula);
            this.groupBoxResult.Controls.Add(this.textBoxResultMs);
            this.groupBoxResult.Controls.Add(this.labelResultMs);
            this.groupBoxResult.Controls.Add(this.textBoxResultAngle);
            this.groupBoxResult.Controls.Add(this.labelResultAngle);
            this.groupBoxResult.Location = new System.Drawing.Point(149, 39);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(331, 186);
            this.groupBoxResult.TabIndex = 4;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // textBoxResultAngleFormula
            // 
            this.textBoxResultAngleFormula.Location = new System.Drawing.Point(13, 69);
            this.textBoxResultAngleFormula.Name = "textBoxResultAngleFormula";
            this.textBoxResultAngleFormula.ReadOnly = true;
            this.textBoxResultAngleFormula.Size = new System.Drawing.Size(300, 21);
            this.textBoxResultAngleFormula.TabIndex = 5;
            this.textBoxResultAngleFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResultAngleFormula.TextChanged += new System.EventHandler(this.textBoxNext_TextChanged);
            // 
            // labelResultAngleFormula
            // 
            this.labelResultAngleFormula.AutoSize = true;
            this.labelResultAngleFormula.Location = new System.Drawing.Point(110, 54);
            this.labelResultAngleFormula.Name = "labelResultAngleFormula";
            this.labelResultAngleFormula.Size = new System.Drawing.Size(118, 12);
            this.labelResultAngleFormula.TabIndex = 1;
            this.labelResultAngleFormula.Text = "ResultAngleFormula";
            // 
            // textBoxResultAngle
            // 
            this.textBoxResultAngle.Location = new System.Drawing.Point(13, 28);
            this.textBoxResultAngle.Name = "textBoxResultAngle";
            this.textBoxResultAngle.ReadOnly = true;
            this.textBoxResultAngle.Size = new System.Drawing.Size(300, 21);
            this.textBoxResultAngle.TabIndex = 4;
            this.textBoxResultAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResultAngle.TextChanged += new System.EventHandler(this.textBoxNext_TextChanged);
            // 
            // labelResultAngle
            // 
            this.labelResultAngle.AutoSize = true;
            this.labelResultAngle.Location = new System.Drawing.Point(126, 13);
            this.labelResultAngle.Name = "labelResultAngle";
            this.labelResultAngle.Size = new System.Drawing.Size(72, 12);
            this.labelResultAngle.TabIndex = 1;
            this.labelResultAngle.Text = "ResultAngle";
            // 
            // groupBoxOtherInfo
            // 
            this.groupBoxOtherInfo.Controls.Add(this.checkBoxTwirl);
            this.groupBoxOtherInfo.Controls.Add(this.labelBpm);
            this.groupBoxOtherInfo.Controls.Add(this.textBoxBpm);
            this.groupBoxOtherInfo.Location = new System.Drawing.Point(14, 110);
            this.groupBoxOtherInfo.Name = "groupBoxOtherInfo";
            this.groupBoxOtherInfo.Size = new System.Drawing.Size(120, 114);
            this.groupBoxOtherInfo.TabIndex = 5;
            this.groupBoxOtherInfo.TabStop = false;
            this.groupBoxOtherInfo.Text = "Other Info";
            // 
            // textBoxBpm
            // 
            this.textBoxBpm.Location = new System.Drawing.Point(6, 39);
            this.textBoxBpm.Name = "textBoxBpm";
            this.textBoxBpm.Size = new System.Drawing.Size(108, 21);
            this.textBoxBpm.TabIndex = 2;
            this.textBoxBpm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBpm.TextChanged += new System.EventHandler(this.textBoxBpm_TextChanged);
            // 
            // labelBpm
            // 
            this.labelBpm.AutoSize = true;
            this.labelBpm.Location = new System.Drawing.Point(45, 24);
            this.labelBpm.Name = "labelBpm";
            this.labelBpm.Size = new System.Drawing.Size(32, 12);
            this.labelBpm.TabIndex = 1;
            this.labelBpm.Text = "BPM";
            // 
            // checkBoxTwirl
            // 
            this.checkBoxTwirl.AutoSize = true;
            this.checkBoxTwirl.Location = new System.Drawing.Point(28, 79);
            this.checkBoxTwirl.Name = "checkBoxTwirl";
            this.checkBoxTwirl.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTwirl.TabIndex = 3;
            this.checkBoxTwirl.Text = "Twirled?";
            this.checkBoxTwirl.UseVisualStyleBackColor = true;
            this.checkBoxTwirl.CheckedChanged += new System.EventHandler(this.checkBoxTwirl_CheckedChanged);
            // 
            // labelResultMs
            // 
            this.labelResultMs.AutoSize = true;
            this.labelResultMs.Location = new System.Drawing.Point(136, 98);
            this.labelResultMs.Name = "labelResultMs";
            this.labelResultMs.Size = new System.Drawing.Size(58, 12);
            this.labelResultMs.TabIndex = 1;
            this.labelResultMs.Text = "ResultMs";
            // 
            // textBoxResultMs
            // 
            this.textBoxResultMs.Location = new System.Drawing.Point(13, 113);
            this.textBoxResultMs.Name = "textBoxResultMs";
            this.textBoxResultMs.ReadOnly = true;
            this.textBoxResultMs.Size = new System.Drawing.Size(300, 21);
            this.textBoxResultMs.TabIndex = 6;
            this.textBoxResultMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResultMs.TextChanged += new System.EventHandler(this.textBoxNext_TextChanged);
            // 
            // labelResultMsFormula
            // 
            this.labelResultMsFormula.AutoSize = true;
            this.labelResultMsFormula.Location = new System.Drawing.Point(110, 142);
            this.labelResultMsFormula.Name = "labelResultMsFormula";
            this.labelResultMsFormula.Size = new System.Drawing.Size(104, 12);
            this.labelResultMsFormula.TabIndex = 1;
            this.labelResultMsFormula.Text = "ResultMsFormula";
            // 
            // textBoxResultMsFormula
            // 
            this.textBoxResultMsFormula.Location = new System.Drawing.Point(13, 157);
            this.textBoxResultMsFormula.Name = "textBoxResultMsFormula";
            this.textBoxResultMsFormula.ReadOnly = true;
            this.textBoxResultMsFormula.Size = new System.Drawing.Size(300, 21);
            this.textBoxResultMsFormula.TabIndex = 7;
            this.textBoxResultMsFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxResultMsFormula.TextChanged += new System.EventHandler(this.textBoxNext_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 237);
            this.Controls.Add(this.groupBoxOtherInfo);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTileInfo);
            this.Controls.Add(this.labelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AngleCalculator";
            this.groupBoxTileInfo.ResumeLayout(false);
            this.groupBoxTileInfo.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxOtherInfo.ResumeLayout(false);
            this.groupBoxOtherInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelThis;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.TextBox textBoxThis;
        private System.Windows.Forms.TextBox textBoxNext;
        private System.Windows.Forms.GroupBox groupBoxTileInfo;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResultAngle;
        private System.Windows.Forms.Label labelResultAngle;
        private System.Windows.Forms.TextBox textBoxResultAngleFormula;
        private System.Windows.Forms.Label labelResultAngleFormula;
        private System.Windows.Forms.GroupBox groupBoxOtherInfo;
        private System.Windows.Forms.Label labelBpm;
        private System.Windows.Forms.TextBox textBoxBpm;
        private System.Windows.Forms.TextBox textBoxResultMs;
        private System.Windows.Forms.Label labelResultMs;
        private System.Windows.Forms.CheckBox checkBoxTwirl;
        private System.Windows.Forms.TextBox textBoxResultMsFormula;
        private System.Windows.Forms.Label labelResultMsFormula;
    }
}

