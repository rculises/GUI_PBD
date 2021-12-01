
namespace GUI_PBD
{
    partial class fAlumno
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
            System.Windows.Forms.Label idAlumnoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label numeroControlLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumno));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBDDataSet = new GUI_PBD.PBDDataSet();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.numeroControlTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.alumnoTableAdapter = new GUI_PBD.PBDDataSetTableAdapters.AlumnoTableAdapter();
            this.tableAdapterManager = new GUI_PBD.PBDDataSetTableAdapters.TableAdapterManager();
            this.alumnoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alumnoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            idAlumnoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            numeroControlLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingNavigator)).BeginInit();
            this.alumnoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Enabled = false;
            idAlumnoLabel.Location = new System.Drawing.Point(63, 25);
            idAlumnoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new System.Drawing.Size(74, 17);
            idAlumnoLabel.TabIndex = 4;
            idAlumnoLabel.Text = "id Alumno:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(77, 65);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(33, 107);
            primerApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(106, 17);
            primerApellidoLabel.TabIndex = 6;
            primerApellidoLabel.Text = "primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(16, 149);
            segundoApellidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(121, 17);
            segundoApellidoLabel.TabIndex = 8;
            segundoApellidoLabel.Text = "segundo Apellido:";
            // 
            // numeroControlLabel
            // 
            numeroControlLabel.AutoSize = true;
            numeroControlLabel.Location = new System.Drawing.Point(403, 65);
            numeroControlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroControlLabel.Name = "numeroControlLabel";
            numeroControlLabel.Size = new System.Drawing.Size(109, 17);
            numeroControlLabel.TabIndex = 10;
            numeroControlLabel.Text = "numero Control:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(460, 107);
            eMailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(49, 17);
            eMailLabel.TabIndex = 12;
            eMailLabel.Text = "e Mail:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(447, 149);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(63, 17);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "telefono:";
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
            this.pnlBotones.Size = new System.Drawing.Size(1223, 132);
            this.pnlBotones.TabIndex = 1;
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
            this.pnlDetalle.Controls.Add(telefonoLabel);
            this.pnlDetalle.Controls.Add(this.telefonoTextBox);
            this.pnlDetalle.Controls.Add(eMailLabel);
            this.pnlDetalle.Controls.Add(this.eMailTextBox);
            this.pnlDetalle.Controls.Add(numeroControlLabel);
            this.pnlDetalle.Controls.Add(this.numeroControlTextBox);
            this.pnlDetalle.Controls.Add(segundoApellidoLabel);
            this.pnlDetalle.Controls.Add(this.segundoApellidoTextBox);
            this.pnlDetalle.Controls.Add(primerApellidoLabel);
            this.pnlDetalle.Controls.Add(this.primerApellidoTextBox);
            this.pnlDetalle.Controls.Add(nombreLabel);
            this.pnlDetalle.Controls.Add(this.nombreTextBox);
            this.pnlDetalle.Controls.Add(idAlumnoLabel);
            this.pnlDetalle.Controls.Add(this.idAlumnoTextBox);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 346);
            this.pnlDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(1223, 188);
            this.pnlDetalle.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(519, 145);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(169, 22);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.pBDDataSet;
            // 
            // pBDDataSet
            // 
            this.pBDDataSet.DataSetName = "PBDDataSet";
            this.pBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(519, 103);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(169, 22);
            this.eMailTextBox.TabIndex = 13;
            // 
            // numeroControlTextBox
            // 
            this.numeroControlTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.numeroControlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "numeroControl", true));
            this.numeroControlTextBox.Location = new System.Drawing.Point(519, 62);
            this.numeroControlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeroControlTextBox.Name = "numeroControlTextBox";
            this.numeroControlTextBox.Size = new System.Drawing.Size(169, 22);
            this.numeroControlTextBox.TabIndex = 11;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "segundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(145, 145);
            this.segundoApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(216, 22);
            this.segundoApellidoTextBox.TabIndex = 9;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "primerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(145, 103);
            this.primerApellidoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(216, 22);
            this.primerApellidoTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(145, 62);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(216, 22);
            this.nombreTextBox.TabIndex = 6;
            // 
            // idAlumnoTextBox
            // 
            this.idAlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "idAlumno", true));
            this.idAlumnoTextBox.Enabled = false;
            this.idAlumnoTextBox.Location = new System.Drawing.Point(145, 21);
            this.idAlumnoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idAlumnoTextBox.Name = "idAlumnoTextBox";
            this.idAlumnoTextBox.Size = new System.Drawing.Size(132, 22);
            this.idAlumnoTextBox.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::GUI_PBD.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(1100, 73);
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
            this.btnGuardar.Location = new System.Drawing.Point(985, 73);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 101);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = this.alumnoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI_PBD.PBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.vAlumnoEmpresaTableAdapter = null;
            // 
            // alumnoBindingNavigator
            // 
            this.alumnoBindingNavigator.AddNewItem = null;
            this.alumnoBindingNavigator.BindingSource = this.alumnoBindingSource;
            this.alumnoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnoBindingNavigator.DeleteItem = null;
            this.alumnoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.alumnoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.alumnoBindingNavigator.Location = new System.Drawing.Point(0, 132);
            this.alumnoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnoBindingNavigator.Name = "alumnoBindingNavigator";
            this.alumnoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnoBindingNavigator.Size = new System.Drawing.Size(1223, 27);
            this.alumnoBindingNavigator.TabIndex = 3;
            this.alumnoBindingNavigator.Text = "bindingNavigator1";
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
            // alumnoDataGridView
            // 
            this.alumnoDataGridView.AllowUserToAddRows = false;
            this.alumnoDataGridView.AllowUserToDeleteRows = false;
            this.alumnoDataGridView.AllowUserToOrderColumns = true;
            this.alumnoDataGridView.AutoGenerateColumns = false;
            this.alumnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.alumnoDataGridView.DataSource = this.alumnoBindingSource;
            this.alumnoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alumnoDataGridView.Location = new System.Drawing.Point(0, 159);
            this.alumnoDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alumnoDataGridView.Name = "alumnoDataGridView";
            this.alumnoDataGridView.ReadOnly = true;
            this.alumnoDataGridView.RowHeadersWidth = 51;
            this.alumnoDataGridView.Size = new System.Drawing.Size(1223, 187);
            this.alumnoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAlumno";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAlumno";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "primerApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "primerApellido";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "segundoApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "segundoApellido";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numeroControl";
            this.dataGridViewTextBoxColumn5.HeaderText = "numeroControl";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn6.HeaderText = "eMail";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::GUI_PBD.Properties.Resources.Reporte;
            this.btnReport.Location = new System.Drawing.Point(359, 13);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 101);
            this.btnReport.TabIndex = 4;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // fAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1223, 534);
            this.Controls.Add(this.alumnoDataGridView);
            this.Controls.Add(this.alumnoBindingNavigator);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.fAlumno_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingNavigator)).EndInit();
            this.alumnoBindingNavigator.ResumeLayout(false);
            this.alumnoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PBDDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private PBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView alumnoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idAlumnoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox numeroControlTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReport;
    }
}