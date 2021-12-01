
namespace GUI_PBD
{
    partial class fAlumnoEmpresa
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
            System.Windows.Forms.Label idAlumnoEmpresaLabel;
            System.Windows.Forms.Label anioInicioLabel;
            System.Windows.Forms.Label anioFinLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumnoEmpresa));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.anioFinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vAlumnoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBDDataSet = new GUI_PBD.PBDDataSet();
            this.anioInicioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlumno = new System.Windows.Forms.ComboBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idAlumnoEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.vAlumnoEmpresaTableAdapter = new GUI_PBD.PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter();
            this.tableAdapterManager = new GUI_PBD.PBDDataSetTableAdapters.TableAdapterManager();
            this.alumnoEmpresaTableAdapter = new GUI_PBD.PBDDataSetTableAdapters.AlumnoEmpresaTableAdapter();
            this.alumnoTableAdapter = new GUI_PBD.PBDDataSetTableAdapters.AlumnoTableAdapter();
            this.empresaTableAdapter = new GUI_PBD.PBDDataSetTableAdapters.EmpresaTableAdapter();
            this.vAlumnoEmpresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vAlumnoEmpresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Button();
            idAlumnoEmpresaLabel = new System.Windows.Forms.Label();
            anioInicioLabel = new System.Windows.Forms.Label();
            anioFinLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioFinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInicioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingNavigator)).BeginInit();
            this.vAlumnoEmpresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlumnoEmpresaLabel
            // 
            idAlumnoEmpresaLabel.AutoSize = true;
            idAlumnoEmpresaLabel.Location = new System.Drawing.Point(16, 26);
            idAlumnoEmpresaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAlumnoEmpresaLabel.Name = "idAlumnoEmpresaLabel";
            idAlumnoEmpresaLabel.Size = new System.Drawing.Size(134, 17);
            idAlumnoEmpresaLabel.TabIndex = 4;
            idAlumnoEmpresaLabel.Text = "id Alumno Empresa:";
            // 
            // anioInicioLabel
            // 
            anioInicioLabel.AutoSize = true;
            anioInicioLabel.Location = new System.Drawing.Point(16, 142);
            anioInicioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            anioInicioLabel.Name = "anioInicioLabel";
            anioInicioLabel.Size = new System.Drawing.Size(75, 17);
            anioInicioLabel.TabIndex = 9;
            anioInicioLabel.Text = "anio Inicio:";
            // 
            // anioFinLabel
            // 
            anioFinLabel.AutoSize = true;
            anioFinLabel.Location = new System.Drawing.Point(329, 142);
            anioFinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            anioFinLabel.Name = "anioFinLabel";
            anioFinLabel.Size = new System.Drawing.Size(62, 17);
            anioFinLabel.TabIndex = 10;
            anioFinLabel.Text = "anio Fin:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnReport);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsertar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1099, 132);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::GUI_PBD.Properties.Resources.Borrar;
            this.btnEliminar.Location = new System.Drawing.Point(244, 15);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 101);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::GUI_PBD.Properties.Resources.Editar;
            this.btnEditar.Location = new System.Drawing.Point(129, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 101);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = global::GUI_PBD.Properties.Resources.Insertar;
            this.btnInsertar.Location = new System.Drawing.Point(15, 15);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(107, 101);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(anioFinLabel);
            this.pnlDetalle.Controls.Add(this.anioFinNumericUpDown);
            this.pnlDetalle.Controls.Add(anioInicioLabel);
            this.pnlDetalle.Controls.Add(this.anioInicioNumericUpDown);
            this.pnlDetalle.Controls.Add(this.cbEmpresa);
            this.pnlDetalle.Controls.Add(this.label2);
            this.pnlDetalle.Controls.Add(this.cbAlumno);
            this.pnlDetalle.Controls.Add(this.label1);
            this.pnlDetalle.Controls.Add(idAlumnoEmpresaLabel);
            this.pnlDetalle.Controls.Add(this.idAlumnoEmpresaTextBox);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 539);
            this.pnlDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1099, 172);
            this.pnlDetalle.TabIndex = 3;
            // 
            // anioFinNumericUpDown
            // 
            this.anioFinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vAlumnoEmpresaBindingSource, "anioFin", true));
            this.anioFinNumericUpDown.Location = new System.Drawing.Point(400, 142);
            this.anioFinNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anioFinNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.anioFinNumericUpDown.Name = "anioFinNumericUpDown";
            this.anioFinNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.anioFinNumericUpDown.TabIndex = 11;
            // 
            // vAlumnoEmpresaBindingSource
            // 
            this.vAlumnoEmpresaBindingSource.DataMember = "vAlumnoEmpresa";
            this.vAlumnoEmpresaBindingSource.DataSource = this.pBDDataSet;
            // 
            // pBDDataSet
            // 
            this.pBDDataSet.DataSetName = "PBDDataSet";
            this.pBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anioInicioNumericUpDown
            // 
            this.anioInicioNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vAlumnoEmpresaBindingSource, "anioInicio", true));
            this.anioInicioNumericUpDown.Location = new System.Drawing.Point(101, 142);
            this.anioInicioNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anioInicioNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.anioInicioNumericUpDown.Name = "anioInicioNumericUpDown";
            this.anioInicioNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.anioInicioNumericUpDown.TabIndex = 10;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DataSource = this.empresaBindingSource;
            this.cbEmpresa.DisplayMember = "razonSocial";
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(333, 89);
            this.cbEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(269, 24);
            this.cbEmpresa.TabIndex = 9;
            this.cbEmpresa.ValueMember = "idEmpresa";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.pBDDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecciona una empresa";
            // 
            // cbAlumno
            // 
            this.cbAlumno.DataSource = this.alumnoBindingSource;
            this.cbAlumno.DisplayMember = "nombre";
            this.cbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlumno.FormattingEnabled = true;
            this.cbAlumno.Location = new System.Drawing.Point(20, 89);
            this.cbAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(269, 24);
            this.cbAlumno.TabIndex = 7;
            this.cbAlumno.ValueMember = "idAlumno";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.pBDDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona un alumno";
            // 
            // idAlumnoEmpresaTextBox
            // 
            this.idAlumnoEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vAlumnoEmpresaBindingSource, "idAlumnoEmpresa", true));
            this.idAlumnoEmpresaTextBox.Enabled = false;
            this.idAlumnoEmpresaTextBox.Location = new System.Drawing.Point(157, 22);
            this.idAlumnoEmpresaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idAlumnoEmpresaTextBox.Name = "idAlumnoEmpresaTextBox";
            this.idAlumnoEmpresaTextBox.Size = new System.Drawing.Size(132, 22);
            this.idAlumnoEmpresaTextBox.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::GUI_PBD.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(976, 57);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 101);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = global::GUI_PBD.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(861, 57);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 101);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // vAlumnoEmpresaTableAdapter
            // 
            this.vAlumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = this.alumnoEmpresaTableAdapter;
            this.tableAdapterManager.AlumnoTableAdapter = this.alumnoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUI_PBD.PBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.vAlumnoEmpresaTableAdapter = null;
            // 
            // alumnoEmpresaTableAdapter
            // 
            this.alumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // vAlumnoEmpresaBindingNavigator
            // 
            this.vAlumnoEmpresaBindingNavigator.AddNewItem = null;
            this.vAlumnoEmpresaBindingNavigator.BindingSource = this.vAlumnoEmpresaBindingSource;
            this.vAlumnoEmpresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vAlumnoEmpresaBindingNavigator.DeleteItem = null;
            this.vAlumnoEmpresaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vAlumnoEmpresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.vAlumnoEmpresaBindingNavigator.Location = new System.Drawing.Point(0, 132);
            this.vAlumnoEmpresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vAlumnoEmpresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vAlumnoEmpresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vAlumnoEmpresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vAlumnoEmpresaBindingNavigator.Name = "vAlumnoEmpresaBindingNavigator";
            this.vAlumnoEmpresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vAlumnoEmpresaBindingNavigator.Size = new System.Drawing.Size(1099, 27);
            this.vAlumnoEmpresaBindingNavigator.TabIndex = 4;
            this.vAlumnoEmpresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // vAlumnoEmpresaDataGridView
            // 
            this.vAlumnoEmpresaDataGridView.AllowUserToAddRows = false;
            this.vAlumnoEmpresaDataGridView.AllowUserToDeleteRows = false;
            this.vAlumnoEmpresaDataGridView.AllowUserToOrderColumns = true;
            this.vAlumnoEmpresaDataGridView.AutoGenerateColumns = false;
            this.vAlumnoEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vAlumnoEmpresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.idEmpresa,
            this.idAlumno,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8});
            this.vAlumnoEmpresaDataGridView.DataSource = this.vAlumnoEmpresaBindingSource;
            this.vAlumnoEmpresaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vAlumnoEmpresaDataGridView.Location = new System.Drawing.Point(0, 159);
            this.vAlumnoEmpresaDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vAlumnoEmpresaDataGridView.Name = "vAlumnoEmpresaDataGridView";
            this.vAlumnoEmpresaDataGridView.ReadOnly = true;
            this.vAlumnoEmpresaDataGridView.RowHeadersWidth = 51;
            this.vAlumnoEmpresaDataGridView.Size = new System.Drawing.Size(1099, 380);
            this.vAlumnoEmpresaDataGridView.TabIndex = 4;
            this.vAlumnoEmpresaDataGridView.SelectionChanged += new System.EventHandler(this.vAlumnoEmpresaDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idAlumnoEmpresa";
            this.dataGridViewTextBoxColumn4.HeaderText = "idAlumnoEmpresa";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "primerApellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "primerApellido";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "segundoApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "segundoApellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // idEmpresa
            // 
            this.idEmpresa.DataPropertyName = "idEmpresa";
            this.idEmpresa.HeaderText = "idEmpresa";
            this.idEmpresa.MinimumWidth = 6;
            this.idEmpresa.Name = "idEmpresa";
            this.idEmpresa.ReadOnly = true;
            this.idEmpresa.Visible = false;
            this.idEmpresa.Width = 125;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "idAlumno";
            this.idAlumno.HeaderText = "idAlumno";
            this.idAlumno.MinimumWidth = 6;
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            this.idAlumno.Visible = false;
            this.idAlumno.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "razonSocial";
            this.dataGridViewTextBoxColumn7.HeaderText = "razonSocial";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "anioInicio";
            this.dataGridViewTextBoxColumn9.HeaderText = "anioInicio";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "anioFin";
            this.dataGridViewTextBoxColumn8.HeaderText = "anioFin";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::GUI_PBD.Properties.Resources.Reporte;
            this.btnReport.Location = new System.Drawing.Point(359, 15);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 101);
            this.btnReport.TabIndex = 5;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // fAlumnoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 711);
            this.Controls.Add(this.vAlumnoEmpresaDataGridView);
            this.Controls.Add(this.vAlumnoEmpresaBindingNavigator);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fAlumnoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno - Empresa";
            this.Load += new System.EventHandler(this.fAlumnoEmpresa_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioFinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInicioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingNavigator)).EndInit();
            this.vAlumnoEmpresaBindingNavigator.ResumeLayout(false);
            this.vAlumnoEmpresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private PBDDataSet pBDDataSet;
        private System.Windows.Forms.BindingSource vAlumnoEmpresaBindingSource;
        private PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter vAlumnoEmpresaTableAdapter;
        private PBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vAlumnoEmpresaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView vAlumnoEmpresaDataGridView;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idAlumnoEmpresaTextBox;
        private PBDDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PBDDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private PBDDataSetTableAdapters.AlumnoEmpresaTableAdapter alumnoEmpresaTableAdapter;
        private System.Windows.Forms.NumericUpDown anioFinNumericUpDown;
        private System.Windows.Forms.NumericUpDown anioInicioNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnReport;
    }
}