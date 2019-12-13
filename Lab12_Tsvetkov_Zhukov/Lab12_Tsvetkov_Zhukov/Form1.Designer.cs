namespace Lab12_Tsvetkov_Zhukov
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keyPeopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._374_lab12_Tsvetkov_ZhukovDataSet = new Lab12_Tsvetkov_Zhukov._374_lab12_Tsvetkov_ZhukovDataSet();
            this.userAgeTableAdapter = new Lab12_Tsvetkov_Zhukov._374_lab12_Tsvetkov_ZhukovDataSetTableAdapters.UserAgeTableAdapter();
            this.button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ubiv = new System.Windows.Forms.RadioButton();
            this.Vozr = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._374_lab12_Tsvetkov_ZhukovDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyPeopDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.nickNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userAgeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // keyPeopDataGridViewTextBoxColumn
            // 
            this.keyPeopDataGridViewTextBoxColumn.DataPropertyName = "KeyPeop";
            this.keyPeopDataGridViewTextBoxColumn.HeaderText = "KeyPeop";
            this.keyPeopDataGridViewTextBoxColumn.Name = "keyPeopDataGridViewTextBoxColumn";
            this.keyPeopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // nickNameDataGridViewTextBoxColumn
            // 
            this.nickNameDataGridViewTextBoxColumn.DataPropertyName = "NickName";
            this.nickNameDataGridViewTextBoxColumn.HeaderText = "NickName";
            this.nickNameDataGridViewTextBoxColumn.Name = "nickNameDataGridViewTextBoxColumn";
            // 
            // userAgeBindingSource
            // 
            this.userAgeBindingSource.DataMember = "UserAge";
            this.userAgeBindingSource.DataSource = this._374_lab12_Tsvetkov_ZhukovDataSet;
            // 
            // _374_lab12_Tsvetkov_ZhukovDataSet
            // 
            this._374_lab12_Tsvetkov_ZhukovDataSet.DataSetName = "_374_lab12_Tsvetkov_ZhukovDataSet";
            this._374_lab12_Tsvetkov_ZhukovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userAgeTableAdapter
            // 
            this.userAgeTableAdapter.ClearBeforeFill = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 371);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(93, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Сортировать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ubiv);
            this.panel1.Controls.Add(this.Vozr);
            this.panel1.Location = new System.Drawing.Point(211, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // Ubiv
            // 
            this.Ubiv.AutoSize = true;
            this.Ubiv.Location = new System.Drawing.Point(18, 62);
            this.Ubiv.Name = "Ubiv";
            this.Ubiv.Size = new System.Drawing.Size(93, 17);
            this.Ubiv.TabIndex = 1;
            this.Ubiv.TabStop = true;
            this.Ubiv.Text = "По убыванию";
            this.Ubiv.UseVisualStyleBackColor = true;
            this.Ubiv.Click += new System.EventHandler(this.Ubiv_Click);
            // 
            // Vozr
            // 
            this.Vozr.AutoSize = true;
            this.Vozr.Location = new System.Drawing.Point(18, 17);
            this.Vozr.Name = "Vozr";
            this.Vozr.Size = new System.Drawing.Size(109, 17);
            this.Vozr.TabIndex = 0;
            this.Vozr.TabStop = true;
            this.Vozr.Text = "По возрастанию";
            this.Vozr.UseVisualStyleBackColor = true;
            this.Vozr.Click += new System.EventHandler(this.Vozr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 244);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 406);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._374_lab12_Tsvetkov_ZhukovDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _374_lab12_Tsvetkov_ZhukovDataSet _374_lab12_Tsvetkov_ZhukovDataSet;
        private System.Windows.Forms.BindingSource userAgeBindingSource;
        private _374_lab12_Tsvetkov_ZhukovDataSetTableAdapters.UserAgeTableAdapter userAgeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyPeopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Ubiv;
        private System.Windows.Forms.RadioButton Vozr;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

