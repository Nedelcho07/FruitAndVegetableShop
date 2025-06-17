namespace fruit_and_vegetable_shop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veganTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vegansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitAndVegetableStoreDataSet = new fruit_and_vegetable_shop.FruitAndVegetableStoreDataSet();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.vegansTableAdapter = new fruit_and_vegetable_shop.FruitAndVegetableStoreDataSetTableAdapters.VegansTableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_selectAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitAndVegetableStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи продукт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_id.Location = new System.Drawing.Point(17, 74);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(58, 23);
            this.txt_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(97, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Име:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание:";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_description.Location = new System.Drawing.Point(17, 123);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(164, 23);
            this.txt_description.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_name.Location = new System.Drawing.Point(100, 74);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(81, 23);
            this.txt_name.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена:";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_price.Location = new System.Drawing.Point(12, 177);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(63, 23);
            this.txt_price.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(100, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип:";
            // 
            // cmb_type
            // 
            this.cmb_type.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(100, 177);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(81, 24);
            this.cmb_type.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.veganTypeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vegansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(250, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 167);
            this.dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // veganTypeIdDataGridViewTextBoxColumn
            // 
            this.veganTypeIdDataGridViewTextBoxColumn.DataPropertyName = "VeganTypeId";
            this.veganTypeIdDataGridViewTextBoxColumn.HeaderText = "VeganTypeId";
            this.veganTypeIdDataGridViewTextBoxColumn.Name = "veganTypeIdDataGridViewTextBoxColumn";
            // 
            // vegansBindingSource
            // 
            this.vegansBindingSource.DataMember = "Vegans";
            this.vegansBindingSource.DataSource = this.fruitAndVegetableStoreDataSet;
            // 
            // fruitAndVegetableStoreDataSet
            // 
            this.fruitAndVegetableStoreDataSet.DataSetName = "FruitAndVegetableStoreDataSet";
            this.fruitAndVegetableStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 238);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 56);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 300);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 56);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // vegansTableAdapter
            // 
            this.vegansTableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(103, 238);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 55);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.Location = new System.Drawing.Point(103, 299);
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(81, 57);
            this.btn_selectAll.TabIndex = 15;
            this.btn_selectAll.Text = "SelectAll";
            this.btn_selectAll.UseVisualStyleBackColor = true;
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_selectAll);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitAndVegetableStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private FruitAndVegetableStoreDataSet fruitAndVegetableStoreDataSet;
        private System.Windows.Forms.BindingSource vegansBindingSource;
        private FruitAndVegetableStoreDataSetTableAdapters.VegansTableAdapter vegansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veganTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_selectAll;
    }
}

