namespace Task6TTP
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
            this.dGVDB = new System.Windows.Forms.DataGridView();
            this.lSQL = new System.Windows.Forms.Label();
            this.tBoxSQL = new System.Windows.Forms.TextBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDB
            // 
            this.dGVDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prod,
            this.type,
            this.model,
            this.price});
            this.dGVDB.Location = new System.Drawing.Point(51, 47);
            this.dGVDB.Name = "dGVDB";
            this.dGVDB.RowHeadersWidth = 82;
            this.dGVDB.RowTemplate.Height = 33;
            this.dGVDB.Size = new System.Drawing.Size(1084, 311);
            this.dGVDB.TabIndex = 0;
            // 
            // lSQL
            // 
            this.lSQL.AutoSize = true;
            this.lSQL.Location = new System.Drawing.Point(46, 393);
            this.lSQL.Name = "lSQL";
            this.lSQL.Size = new System.Drawing.Size(54, 25);
            this.lSQL.TabIndex = 1;
            this.lSQL.Text = "SQL";
            // 
            // tBoxSQL
            // 
            this.tBoxSQL.Location = new System.Drawing.Point(106, 390);
            this.tBoxSQL.Name = "tBoxSQL";
            this.tBoxSQL.Size = new System.Drawing.Size(882, 31);
            this.tBoxSQL.TabIndex = 2;
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(994, 385);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(160, 40);
            this.btnSQL.TabIndex = 3;
            this.btnSQL.Text = "Выполнить";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // prod
            // 
            this.prod.HeaderText = "Производитель";
            this.prod.MinimumWidth = 10;
            this.prod.Name = "prod";
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 10;
            this.type.Name = "type";
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.MinimumWidth = 10;
            this.model.Name = "model";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            this.price.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 621);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.tBoxSQL);
            this.Controls.Add(this.lSQL);
            this.Controls.Add(this.dGVDB);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Task6";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDB;
        private System.Windows.Forms.Label lSQL;
        private System.Windows.Forms.TextBox tBoxSQL;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

