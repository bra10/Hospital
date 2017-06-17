namespace hospital
{
    partial class newPatient
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
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoPaternoLabel;
            System.Windows.Forms.Label apellidoMaternoLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label fecha_nacimientoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label correo_electronicoLabel;
            System.Windows.Forms.Label estaturaLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label condicionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPatient));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet = new hospital.hospitalDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.correo_electronicoTextBox = new System.Windows.Forms.TextBox();
            this.estaturaTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.condicionTextBox = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pacientesTableAdapter = new hospital.hospitalDataSetTableAdapters.pacientesTableAdapter();
            this.tableAdapterManager = new hospital.hospitalDataSetTableAdapters.TableAdapterManager();
            this.pacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idPacienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoPaternoLabel = new System.Windows.Forms.Label();
            apellidoMaternoLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            fecha_nacimientoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            correo_electronicoLabel = new System.Windows.Forms.Label();
            estaturaLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            condicionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).BeginInit();
            this.pacientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(59, 35);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(63, 13);
            idPacienteLabel.TabIndex = 0;
            idPacienteLabel.Text = "id Paciente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(59, 61);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "nombre:";
            // 
            // apellidoPaternoLabel
            // 
            apellidoPaternoLabel.AutoSize = true;
            apellidoPaternoLabel.Location = new System.Drawing.Point(59, 87);
            apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            apellidoPaternoLabel.Size = new System.Drawing.Size(86, 13);
            apellidoPaternoLabel.TabIndex = 4;
            apellidoPaternoLabel.Text = "apellido Paterno:";
            // 
            // apellidoMaternoLabel
            // 
            apellidoMaternoLabel.AutoSize = true;
            apellidoMaternoLabel.Location = new System.Drawing.Point(59, 113);
            apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            apellidoMaternoLabel.Size = new System.Drawing.Size(88, 13);
            apellidoMaternoLabel.TabIndex = 6;
            apellidoMaternoLabel.Text = "apellido Materno:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(59, 139);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(43, 13);
            generoLabel.TabIndex = 8;
            generoLabel.Text = "genero:";
            // 
            // fecha_nacimientoLabel
            // 
            fecha_nacimientoLabel.AutoSize = true;
            fecha_nacimientoLabel.Location = new System.Drawing.Point(59, 166);
            fecha_nacimientoLabel.Name = "fecha_nacimientoLabel";
            fecha_nacimientoLabel.Size = new System.Drawing.Size(91, 13);
            fecha_nacimientoLabel.TabIndex = 10;
            fecha_nacimientoLabel.Text = "fecha nacimiento:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(309, 32);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(53, 13);
            direccionLabel.TabIndex = 12;
            direccionLabel.Text = "direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(309, 58);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "telefono:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(309, 84);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(41, 13);
            celularLabel.TabIndex = 16;
            celularLabel.Text = "celular:";
            // 
            // correo_electronicoLabel
            // 
            correo_electronicoLabel.AutoSize = true;
            correo_electronicoLabel.Location = new System.Drawing.Point(309, 110);
            correo_electronicoLabel.Name = "correo_electronicoLabel";
            correo_electronicoLabel.Size = new System.Drawing.Size(95, 13);
            correo_electronicoLabel.TabIndex = 18;
            correo_electronicoLabel.Text = "correo electronico:";
            // 
            // estaturaLabel
            // 
            estaturaLabel.AutoSize = true;
            estaturaLabel.Location = new System.Drawing.Point(309, 136);
            estaturaLabel.Name = "estaturaLabel";
            estaturaLabel.Size = new System.Drawing.Size(48, 13);
            estaturaLabel.TabIndex = 20;
            estaturaLabel.Text = "estatura:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(309, 162);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(33, 13);
            pesoLabel.TabIndex = 22;
            pesoLabel.Text = "peso:";
            // 
            // condicionLabel
            // 
            condicionLabel.AutoSize = true;
            condicionLabel.Location = new System.Drawing.Point(309, 188);
            condicionLabel.Name = "condicionLabel";
            condicionLabel.Size = new System.Drawing.Size(56, 13);
            condicionLabel.TabIndex = 24;
            condicionLabel.Text = "condicion:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idPacienteLabel);
            this.groupBox1.Controls.Add(this.idPacienteTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(apellidoPaternoLabel);
            this.groupBox1.Controls.Add(this.apellidoPaternoTextBox);
            this.groupBox1.Controls.Add(apellidoMaternoLabel);
            this.groupBox1.Controls.Add(this.apellidoMaternoTextBox);
            this.groupBox1.Controls.Add(generoLabel);
            this.groupBox1.Controls.Add(this.generoTextBox);
            this.groupBox1.Controls.Add(fecha_nacimientoLabel);
            this.groupBox1.Controls.Add(this.fecha_nacimientoDateTimePicker);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Controls.Add(this.celularTextBox);
            this.groupBox1.Controls.Add(correo_electronicoLabel);
            this.groupBox1.Controls.Add(this.correo_electronicoTextBox);
            this.groupBox1.Controls.Add(estaturaLabel);
            this.groupBox1.Controls.Add(this.estaturaTextBox);
            this.groupBox1.Controls.Add(pesoLabel);
            this.groupBox1.Controls.Add(this.pesoTextBox);
            this.groupBox1.Controls.Add(condicionLabel);
            this.groupBox1.Controls.Add(this.condicionTextBox);
            this.groupBox1.Location = new System.Drawing.Point(47, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "idPaciente", true));
            this.idPacienteTextBox.Location = new System.Drawing.Point(160, 32);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(124, 20);
            this.idPacienteTextBox.TabIndex = 1;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.hospitalDataSet;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(160, 58);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(124, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "apellidoPaterno", true));
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(160, 84);
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(124, 20);
            this.apellidoPaternoTextBox.TabIndex = 5;
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "apellidoMaterno", true));
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(160, 110);
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(124, 20);
            this.apellidoMaternoTextBox.TabIndex = 7;
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(160, 136);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(124, 20);
            this.generoTextBox.TabIndex = 9;
            // 
            // fecha_nacimientoDateTimePicker
            // 
            this.fecha_nacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "fecha_nacimiento", true));
            this.fecha_nacimientoDateTimePicker.Location = new System.Drawing.Point(160, 162);
            this.fecha_nacimientoDateTimePicker.Name = "fecha_nacimientoDateTimePicker";
            this.fecha_nacimientoDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.fecha_nacimientoDateTimePicker.TabIndex = 11;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(410, 29);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(124, 20);
            this.direccionTextBox.TabIndex = 13;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(410, 55);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(124, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(410, 81);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(124, 20);
            this.celularTextBox.TabIndex = 17;
            // 
            // correo_electronicoTextBox
            // 
            this.correo_electronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "correo_electronico", true));
            this.correo_electronicoTextBox.Location = new System.Drawing.Point(410, 107);
            this.correo_electronicoTextBox.Name = "correo_electronicoTextBox";
            this.correo_electronicoTextBox.Size = new System.Drawing.Size(124, 20);
            this.correo_electronicoTextBox.TabIndex = 19;
            // 
            // estaturaTextBox
            // 
            this.estaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "estatura", true));
            this.estaturaTextBox.Location = new System.Drawing.Point(410, 133);
            this.estaturaTextBox.Name = "estaturaTextBox";
            this.estaturaTextBox.Size = new System.Drawing.Size(124, 20);
            this.estaturaTextBox.TabIndex = 21;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(410, 159);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(124, 20);
            this.pesoTextBox.TabIndex = 23;
            // 
            // condicionTextBox
            // 
            this.condicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "condicion", true));
            this.condicionTextBox.Location = new System.Drawing.Point(410, 185);
            this.condicionTextBox.Name = "condicionTextBox";
            this.condicionTextBox.Size = new System.Drawing.Size(124, 20);
            this.condicionTextBox.TabIndex = 25;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(572, 338);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(493, 338);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.citasTableAdapter = null;
            this.tableAdapterManager.consultaMedicaTableAdapter = null;
            //this.tableAdapterManager.consultorioTableAdapter = null;
            this.tableAdapterManager.diagnosticoTableAdapter = null;
            this.tableAdapterManager.doctoresTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.RecetaTableAdapter = null;
            this.tableAdapterManager.tipo_consultorioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hospital.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacientesBindingNavigator
            // 
            this.pacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacientesBindingNavigator.BindingSource = this.pacientesBindingSource;
            this.pacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacientesBindingNavigatorSaveItem});
            this.pacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacientesBindingNavigator.Name = "pacientesBindingNavigator";
            this.pacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacientesBindingNavigator.Size = new System.Drawing.Size(682, 25);
            this.pacientesBindingNavigator.TabIndex = 4;
            this.pacientesBindingNavigator.Text = "bindingNavigator1";
            this.pacientesBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pacientesBindingNavigatorSaveItem
            // 
            this.pacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientesBindingNavigatorSaveItem.Image")));
            this.pacientesBindingNavigatorSaveItem.Name = "pacientesBindingNavigatorSaveItem";
            this.pacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // newPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(682, 373);
            this.Controls.Add(this.pacientesBindingNavigator);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "newPatient";
            this.Text = "Nuevo Paciente";
            this.Load += new System.EventHandler(this.templateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).EndInit();
            this.pacientesBindingNavigator.ResumeLayout(false);
            this.pacientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox correo_electronicoTextBox;
        private System.Windows.Forms.TextBox estaturaTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox condicionTextBox;
    }
}