
namespace ExchangeCurrency
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выбиритеВалютуНаКоторуюМеняемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxOf = new System.Windows.Forms.ComboBox();
            this.comboBoxIn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResalt = new System.Windows.Forms.TextBox();
            this.labelResalt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(486, 90);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбиритеВалютуНаКоторуюМеняемToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(286, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // выбиритеВалютуНаКоторуюМеняемToolStripMenuItem
            // 
            this.выбиритеВалютуНаКоторуюМеняемToolStripMenuItem.Name = "выбиритеВалютуНаКоторуюМеняемToolStripMenuItem";
            this.выбиритеВалютуНаКоторуюМеняемToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.выбиритеВалютуНаКоторуюМеняемToolStripMenuItem.Text = "Выбирите валюту на которую меняем";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxOf
            // 
            this.comboBoxOf.FormattingEnabled = true;
            this.comboBoxOf.Location = new System.Drawing.Point(602, 61);
            this.comboBoxOf.Name = "comboBoxOf";
            this.comboBoxOf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOf.TabIndex = 3;
            this.comboBoxOf.SelectedIndexChanged += new System.EventHandler(this.comboBoxOf_SelectedIndexChanged);
            // 
            // comboBoxIn
            // 
            this.comboBoxIn.ContextMenuStrip = this.contextMenuStrip1;
            this.comboBoxIn.FormattingEnabled = true;
            this.comboBoxIn.Location = new System.Drawing.Point(602, 130);
            this.comboBoxIn.Name = "comboBoxIn";
            this.comboBoxIn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIn.TabIndex = 4;
            this.comboBoxIn.SelectedIndexChanged += new System.EventHandler(this.comboBoxIn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(542, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Валюта,на каторую меняем(правая клавиша)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(542, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сумма для обмена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(542, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Валюта ,которую меняем(левая клавиша мыши)";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(704, 197);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 9;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxResalt
            // 
            this.textBoxResalt.Location = new System.Drawing.Point(704, 367);
            this.textBoxResalt.Name = "textBoxResalt";
            this.textBoxResalt.ReadOnly = true;
            this.textBoxResalt.Size = new System.Drawing.Size(100, 20);
            this.textBoxResalt.TabIndex = 10;
            // 
            // labelResalt
            // 
            this.labelResalt.AutoSize = true;
            this.labelResalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResalt.Location = new System.Drawing.Point(494, 371);
            this.labelResalt.Name = "labelResalt";
            this.labelResalt.Size = new System.Drawing.Size(188, 16);
            this.labelResalt.TabIndex = 11;
            this.labelResalt.Text = "Результат конвертации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.labelResalt);
            this.Controls.Add(this.textBoxResalt);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIn);
            this.Controls.Add(this.comboBoxOf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обмен валют";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxOf;
        private System.Windows.Forms.ComboBox comboBoxIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбиритеВалютуНаКоторуюМеняемToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResalt;
        private System.Windows.Forms.Label labelResalt;
    }
}

