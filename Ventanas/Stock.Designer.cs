namespace MANGO
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mangoDBDataSet = new MANGO.MangoDBDataSet();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.importar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Button();
            this.añadir = new System.Windows.Forms.Button();
            this.productosTableAdapter = new MANGO.MangoDBDataSetTableAdapters.ProductosTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtima = new System.Windows.Forms.TextBox();
            this.idreferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(1167, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 69);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaProductos
            // 
            this.tablaProductos.AutoGenerateColumns = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaProductos.ColumnHeadersHeight = 30;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreferenciaDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.tallaDataGridViewTextBoxColumn,
            this.imagenDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.tablaProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaProductos.DataSource = this.productosBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaProductos.EnableHeadersVisualStyles = false;
            this.tablaProductos.GridColor = System.Drawing.Color.MistyRose;
            this.tablaProductos.Location = new System.Drawing.Point(363, 72);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablaProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tablaProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Khaki;
            this.tablaProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaProductos.RowTemplate.Height = 30;
            this.tablaProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProductos.Size = new System.Drawing.Size(780, 494);
            this.tablaProductos.TabIndex = 2;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_fila);
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.mangoDBDataSet;
            // 
            // mangoDBDataSet
            // 
            this.mangoDBDataSet.DataSetName = "MangoDBDataSet";
            this.mangoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.SeaShell;
            this.imagen.InitialImage = global::MANGO.Properties.Resources.cierre_color_nude_arrugado_fondo_textura_cuero_7189_1881;
            this.imagen.Location = new System.Drawing.Point(2, 66);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(355, 500);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 4;
            this.imagen.TabStop = false;
            // 
            // importar
            // 
            this.importar.BackColor = System.Drawing.Color.Chocolate;
            this.importar.FlatAppearance.BorderSize = 3;
            this.importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.importar.Location = new System.Drawing.Point(1149, 408);
            this.importar.Name = "importar";
            this.importar.Size = new System.Drawing.Size(137, 45);
            this.importar.TabIndex = 6;
            this.importar.Text = "Importar";
            this.importar.UseVisualStyleBackColor = false;
            this.importar.Click += new System.EventHandler(this.importar_Click);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.Chocolate;
            this.buscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buscar.FlatAppearance.BorderSize = 3;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buscar.Location = new System.Drawing.Point(1149, 72);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(137, 41);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.Color.Chocolate;
            this.modificar.FlatAppearance.BorderSize = 3;
            this.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.modificar.Location = new System.Drawing.Point(1149, 273);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(137, 43);
            this.modificar.TabIndex = 9;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.button5_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Chocolate;
            this.borrar.FlatAppearance.BorderSize = 3;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.borrar.Location = new System.Drawing.Point(1149, 338);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(137, 44);
            this.borrar.TabIndex = 10;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.Color.Chocolate;
            this.mostrar.FlatAppearance.BorderSize = 3;
            this.mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.ForeColor = System.Drawing.Color.White;
            this.mostrar.Location = new System.Drawing.Point(1149, 134);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(137, 43);
            this.mostrar.TabIndex = 14;
            this.mostrar.Text = "Mostrar";
            this.mostrar.UseVisualStyleBackColor = false;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // añadir
            // 
            this.añadir.BackColor = System.Drawing.Color.Chocolate;
            this.añadir.FlatAppearance.BorderSize = 3;
            this.añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.añadir.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadir.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.añadir.Location = new System.Drawing.Point(1149, 203);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(137, 43);
            this.añadir.TabIndex = 8;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = false;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(363, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 34);
            this.txtId.TabIndex = 15;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtFam
            // 
            this.txtFam.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFam.Location = new System.Drawing.Point(621, 32);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(81, 34);
            this.txtFam.TabIndex = 16;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(708, 32);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(81, 34);
            this.txtColor.TabIndex = 17;
            // 
            // txtTalla
            // 
            this.txtTalla.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTalla.Location = new System.Drawing.Point(795, 32);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(83, 34);
            this.txtTalla.TabIndex = 18;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(975, 32);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(83, 34);
            this.txtPrecio.TabIndex = 20;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(1064, 32);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(79, 34);
            this.txtStock.TabIndex = 21;
            // 
            // txtima
            // 
            this.txtima.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtima.Location = new System.Drawing.Point(884, 32);
            this.txtima.Name = "txtima";
            this.txtima.Size = new System.Drawing.Size(85, 34);
            this.txtima.TabIndex = 19;
            // 
            // idreferenciaDataGridViewTextBoxColumn
            // 
            this.idreferenciaDataGridViewTextBoxColumn.DataPropertyName = "Id_referencia";
            this.idreferenciaDataGridViewTextBoxColumn.FillWeight = 120.1979F;
            this.idreferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.idreferenciaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idreferenciaDataGridViewTextBoxColumn.Name = "idreferenciaDataGridViewTextBoxColumn";
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "familia";
            this.familiaDataGridViewTextBoxColumn.FillWeight = 41.80034F;
            this.familiaDataGridViewTextBoxColumn.HeaderText = "familia";
            this.familiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.FillWeight = 41.80034F;
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // tallaDataGridViewTextBoxColumn
            // 
            this.tallaDataGridViewTextBoxColumn.DataPropertyName = "talla";
            this.tallaDataGridViewTextBoxColumn.FillWeight = 41.80034F;
            this.tallaDataGridViewTextBoxColumn.HeaderText = "talla";
            this.tallaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tallaDataGridViewTextBoxColumn.Name = "tallaDataGridViewTextBoxColumn";
            // 
            // imagenDataGridViewTextBoxColumn
            // 
            this.imagenDataGridViewTextBoxColumn.DataPropertyName = "imagen";
            this.imagenDataGridViewTextBoxColumn.FillWeight = 41.80034F;
            this.imagenDataGridViewTextBoxColumn.HeaderText = "imagen";
            this.imagenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.FillWeight = 41.80034F;
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.FillWeight = 41.80034F;
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1333, 611);
            this.Controls.Add(this.txtima);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.añadir);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.importar);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
      
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.PictureBox imagen;
        private MangoDBDataSet mangoDBDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private MangoDBDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Button importar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Button añadir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtima;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreferenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}