
namespace treino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextMain = new System.Windows.Forms.TextBox();
            this.sakilaActors = new treino.sakilaActors();
            this.sakilaActorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorTableAdapter = new treino.sakilaActorsTableAdapters.actorTableAdapter();
            this.lastupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridBanco = new System.Windows.Forms.DataGridView();
            this.ButtonGeraGrid = new System.Windows.Forms.Button();
            this.film_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.film_listTableAdapter = new treino.sakilaActorsTableAdapters.film_listTableAdapter();
            this.tableAdapterManager = new treino.sakilaActorsTableAdapters.TableAdapterManager();
            this.ButtonDataCerto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaActorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.film_listBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teste";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextMain
            // 
            this.TextMain.Location = new System.Drawing.Point(52, 6);
            this.TextMain.Name = "TextMain";
            this.TextMain.Size = new System.Drawing.Size(100, 20);
            this.TextMain.TabIndex = 2;
            this.TextMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextMain_KeyPress);
            this.TextMain.Validated += new System.EventHandler(this.TextMain_Validated);
            // 
            // sakilaActors
            // 
            this.sakilaActors.DataSetName = "sakilaActors";
            this.sakilaActors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sakilaActorsBindingSource
            // 
            this.sakilaActorsBindingSource.DataMember = "actor";
            this.sakilaActorsBindingSource.DataSource = this.sakilaActors;
            this.sakilaActorsBindingSource.Filter = "";
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // lastupdateDataGridViewTextBoxColumn
            // 
            this.lastupdateDataGridViewTextBoxColumn.DataPropertyName = "last_update";
            this.lastupdateDataGridViewTextBoxColumn.HeaderText = "last_update";
            this.lastupdateDataGridViewTextBoxColumn.Name = "lastupdateDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // actoridDataGridViewTextBoxColumn
            // 
            this.actoridDataGridViewTextBoxColumn.DataPropertyName = "actor_id";
            this.actoridDataGridViewTextBoxColumn.HeaderText = "actor_id";
            this.actoridDataGridViewTextBoxColumn.Name = "actoridDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actoridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.lastupdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sakilaActorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(263, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataGridBanco
            // 
            this.DataGridBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBanco.Location = new System.Drawing.Point(263, 197);
            this.DataGridBanco.Name = "DataGridBanco";
            this.DataGridBanco.Size = new System.Drawing.Size(443, 150);
            this.DataGridBanco.TabIndex = 4;
            // 
            // ButtonGeraGrid
            // 
            this.ButtonGeraGrid.Location = new System.Drawing.Point(263, 353);
            this.ButtonGeraGrid.Name = "ButtonGeraGrid";
            this.ButtonGeraGrid.Size = new System.Drawing.Size(75, 23);
            this.ButtonGeraGrid.TabIndex = 5;
            this.ButtonGeraGrid.Text = "button2";
            this.ButtonGeraGrid.UseVisualStyleBackColor = true;
            this.ButtonGeraGrid.Click += new System.EventHandler(this.ButtonGeraGrid_Click);
            // 
            // film_listBindingSource
            // 
            this.film_listBindingSource.DataMember = "film_list";
            this.film_listBindingSource.DataSource = this.sakilaActors;
            // 
            // film_listTableAdapter
            // 
            this.film_listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.actorTableAdapter = this.actorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = treino.sakilaActorsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ButtonDataCerto
            // 
            this.ButtonDataCerto.Location = new System.Drawing.Point(344, 353);
            this.ButtonDataCerto.Name = "ButtonDataCerto";
            this.ButtonDataCerto.Size = new System.Drawing.Size(75, 23);
            this.ButtonDataCerto.TabIndex = 6;
            this.ButtonDataCerto.Text = "ButtonDataCerto";
            this.ButtonDataCerto.UseVisualStyleBackColor = true;
            this.ButtonDataCerto.Click += new System.EventHandler(this.ButtonDataCerto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.ButtonDataCerto);
            this.Controls.Add(this.ButtonGeraGrid);
            this.Controls.Add(this.DataGridBanco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.sakilaActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakilaActorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.film_listBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextMain;
        private System.Windows.Forms.BindingSource sakilaActorsBindingSource;
        private sakilaActors sakilaActors;
        private sakilaActorsTableAdapters.actorTableAdapter actorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DataGridBanco;
        private System.Windows.Forms.Button ButtonGeraGrid;
        private System.Windows.Forms.BindingSource film_listBindingSource;
        private sakilaActorsTableAdapters.film_listTableAdapter film_listTableAdapter;
        private sakilaActorsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button ButtonDataCerto;
    }
}

