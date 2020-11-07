namespace QECalc
{
    partial class MainExec
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sprvkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aInp = new System.Windows.Forms.NumericUpDown();
            this.bInp = new System.Windows.Forms.NumericUpDown();
            this.cInp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aInp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprvkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sprvkToolStripMenuItem
            // 
            this.sprvkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.sprvkToolStripMenuItem.Name = "sprvkToolStripMenuItem";
            this.sprvkToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sprvkToolStripMenuItem.Text = "Справка";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Информация";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // aInp
            // 
            this.aInp.DecimalPlaces = 2;
            this.aInp.Location = new System.Drawing.Point(38, 32);
            this.aInp.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.aInp.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.aInp.Name = "aInp";
            this.aInp.Size = new System.Drawing.Size(84, 20);
            this.aInp.TabIndex = 1;
            this.aInp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aInp.ValueChanged += new System.EventHandler(this.ValueHasChanged);
            // 
            // bInp
            // 
            this.bInp.DecimalPlaces = 2;
            this.bInp.Location = new System.Drawing.Point(148, 32);
            this.bInp.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.bInp.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.bInp.Name = "bInp";
            this.bInp.Size = new System.Drawing.Size(84, 20);
            this.bInp.TabIndex = 2;
            this.bInp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bInp.ValueChanged += new System.EventHandler(this.ValueHasChanged);
            // 
            // cInp
            // 
            this.cInp.DecimalPlaces = 2;
            this.cInp.Location = new System.Drawing.Point(258, 32);
            this.cInp.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.cInp.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.cInp.Name = "cInp";
            this.cInp.Size = new System.Drawing.Size(84, 20);
            this.cInp.TabIndex = 3;
            this.cInp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cInp.ValueChanged += new System.EventHandler(this.ValueHasChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bInp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aInp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cInp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 81);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.OutputLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // OutputLabel
            // 
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(3, 16);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(352, 101);
            this.OutputLabel.TabIndex = 0;
            // 
            // MainExec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainExec";
            this.Text = "QECalc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aInp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown aInp;
        private System.Windows.Forms.NumericUpDown bInp;
        private System.Windows.Forms.NumericUpDown cInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem sprvkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label OutputLabel;
    }
}

