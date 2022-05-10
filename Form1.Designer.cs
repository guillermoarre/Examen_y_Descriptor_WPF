namespace Examen_y_Descriptor_WPF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bOLETADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALIFICACIÓNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPO8CM11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSIMEDataSet1 = new Examen_y_Descriptor_WPF.ESIMEDataSet1();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSIMEDataSet = new Examen_y_Descriptor_WPF.ESIMEDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.alumnosTableAdapter = new Examen_y_Descriptor_WPF.ESIMEDataSetTableAdapters.AlumnosTableAdapter();
            this.gRUPO8CM11TableAdapter = new Examen_y_Descriptor_WPF.ESIMEDataSet1TableAdapters.GRUPO8CM11TableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPO8CM11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSIMEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSIMEDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "BASE DE DATOS RELACIONAL LOCAL DEL 8CM11";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOLETADataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn,
            this.aPELLIDOSDataGridViewTextBoxColumn,
            this.mATERIADataGridViewTextBoxColumn,
            this.cALIFICACIÓNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gRUPO8CM11BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 214);
            this.dataGridView1.TabIndex = 2;
            // 
            // bOLETADataGridViewTextBoxColumn
            // 
            this.bOLETADataGridViewTextBoxColumn.DataPropertyName = "BOLETA";
            this.bOLETADataGridViewTextBoxColumn.HeaderText = "BOLETA";
            this.bOLETADataGridViewTextBoxColumn.Name = "bOLETADataGridViewTextBoxColumn";
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            // 
            // aPELLIDOSDataGridViewTextBoxColumn
            // 
            this.aPELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.Name = "aPELLIDOSDataGridViewTextBoxColumn";
            // 
            // mATERIADataGridViewTextBoxColumn
            // 
            this.mATERIADataGridViewTextBoxColumn.DataPropertyName = "MATERIA";
            this.mATERIADataGridViewTextBoxColumn.HeaderText = "MATERIA";
            this.mATERIADataGridViewTextBoxColumn.Name = "mATERIADataGridViewTextBoxColumn";
            // 
            // cALIFICACIÓNDataGridViewTextBoxColumn
            // 
            this.cALIFICACIÓNDataGridViewTextBoxColumn.DataPropertyName = "CALIFICACIÓN";
            this.cALIFICACIÓNDataGridViewTextBoxColumn.HeaderText = "CALIFICACIÓN";
            this.cALIFICACIÓNDataGridViewTextBoxColumn.Name = "cALIFICACIÓNDataGridViewTextBoxColumn";
            // 
            // gRUPO8CM11BindingSource
            // 
            this.gRUPO8CM11BindingSource.DataMember = "GRUPO8CM11";
            this.gRUPO8CM11BindingSource.DataSource = this.eSIMEDataSet1;
            // 
            // eSIMEDataSet1
            // 
            this.eSIMEDataSet1.DataSetName = "ESIMEDataSet1";
            this.eSIMEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.eSIMEDataSet;
            // 
            // eSIMEDataSet
            // 
            this.eSIMEDataSet.DataSetName = "ESIMEDataSet";
            this.eSIMEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Celdas Primarias";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(490, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 33);
            this.button6.TabIndex = 10;
            this.button6.Text = "Ver Tabla Completa";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(293, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 33);
            this.button5.TabIndex = 8;
            this.button5.Text = "Limpiar Celdas";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPO8CM11BindingSource, "CALIFICACIÓN", true));
            this.textBox5.Location = new System.Drawing.Point(434, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPO8CM11BindingSource, "MATERIA", true));
            this.textBox4.Location = new System.Drawing.Point(434, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Materia";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPO8CM11BindingSource, "APELLIDOS", true));
            this.textBox3.Location = new System.Drawing.Point(82, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPO8CM11BindingSource, "NOMBRES", true));
            this.textBox2.Location = new System.Drawing.Point(82, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gRUPO8CM11BindingSource, "BOLETA", true));
            this.textBox1.Location = new System.Drawing.Point(82, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Boleta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "AGREGAR ALUMNO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "ELIMINAR ALUMNO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(439, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "MODIFICAR DATOS DEL ALUMNO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(624, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 58);
            this.button4.TabIndex = 7;
            this.button4.Text = "BUSCAR POR BOLETA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // gRUPO8CM11TableAdapter
            // 
            this.gRUPO8CM11TableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "SALIR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Base de datos relacional local";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPO8CM11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSIMEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSIMEDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ESIMEDataSet eSIMEDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private ESIMEDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private ESIMEDataSet1 eSIMEDataSet1;
        private System.Windows.Forms.BindingSource gRUPO8CM11BindingSource;
        private ESIMEDataSet1TableAdapters.GRUPO8CM11TableAdapter gRUPO8CM11TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOLETADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALIFICACIÓNDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
    }
}