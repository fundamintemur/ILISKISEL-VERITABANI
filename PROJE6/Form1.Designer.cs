
namespace PROJE6
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
            this.proje5DataSet = new PROJE6.Proje5DataSet();
            this.pROJE6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJE6TableAdapter = new PROJE6.Proje5DataSetTableAdapters.PROJE6TableAdapter();
            this.proje5DataSet1 = new PROJE6.Proje5DataSet1();
            this.pROJE6BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROJE6TableAdapter1 = new PROJE6.Proje5DataSet1TableAdapters.PROJE6TableAdapter();
            this.ürünAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fİYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJE6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje5DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJE6BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünAdDataGridViewTextBoxColumn,
            this.mÜŞTERİDataGridViewTextBoxColumn,
            this.pERSONELDataGridViewTextBoxColumn,
            this.fİYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROJE6BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // proje5DataSet
            // 
            this.proje5DataSet.DataSetName = "Proje5DataSet";
            this.proje5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJE6BindingSource
            // 
            this.pROJE6BindingSource.DataMember = "PROJE6";
            this.pROJE6BindingSource.DataSource = this.proje5DataSet;
            // 
            // pROJE6TableAdapter
            // 
            this.pROJE6TableAdapter.ClearBeforeFill = true;
            // 
            // proje5DataSet1
            // 
            this.proje5DataSet1.DataSetName = "Proje5DataSet1";
            this.proje5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJE6BindingSource1
            // 
            this.pROJE6BindingSource1.DataMember = "PROJE6";
            this.pROJE6BindingSource1.DataSource = this.proje5DataSet1;
            // 
            // pROJE6TableAdapter1
            // 
            this.pROJE6TableAdapter1.ClearBeforeFill = true;
            // 
            // ürünAdDataGridViewTextBoxColumn
            // 
            this.ürünAdDataGridViewTextBoxColumn.DataPropertyName = "Ürün Ad";
            this.ürünAdDataGridViewTextBoxColumn.HeaderText = "Ürün Ad";
            this.ürünAdDataGridViewTextBoxColumn.Name = "ürünAdDataGridViewTextBoxColumn";
            // 
            // mÜŞTERİDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ";
            this.mÜŞTERİDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ";
            this.mÜŞTERİDataGridViewTextBoxColumn.Name = "mÜŞTERİDataGridViewTextBoxColumn";
            // 
            // pERSONELDataGridViewTextBoxColumn
            // 
            this.pERSONELDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.HeaderText = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.Name = "pERSONELDataGridViewTextBoxColumn";
            // 
            // fİYATDataGridViewTextBoxColumn
            // 
            this.fİYATDataGridViewTextBoxColumn.DataPropertyName = "FİYAT";
            this.fİYATDataGridViewTextBoxColumn.HeaderText = "FİYAT";
            this.fİYATDataGridViewTextBoxColumn.Name = "fİYATDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJE6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje5DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJE6BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Proje5DataSet proje5DataSet;
        private System.Windows.Forms.BindingSource pROJE6BindingSource;
        private Proje5DataSetTableAdapters.PROJE6TableAdapter pROJE6TableAdapter;
        private Proje5DataSet1 proje5DataSet1;
        private System.Windows.Forms.BindingSource pROJE6BindingSource1;
        private Proje5DataSet1TableAdapters.PROJE6TableAdapter pROJE6TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fİYATDataGridViewTextBoxColumn;
    }
}

