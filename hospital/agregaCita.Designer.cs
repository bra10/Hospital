namespace hospital
{
    partial class agregaCita
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pacienteIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoPaternoLabel;
            System.Windows.Forms.Label apellidoMaternoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correo_electronicoLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label apellidoPaternoLabel1;
            System.Windows.Forms.Label apellidoMaternoLabel1;
            System.Windows.Forms.Label nombreLabel2;
            System.Windows.Forms.Label apeliido_paternoLabel;
            System.Windows.Forms.Label apellido_maternoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label pacienteIdLabel1;
            System.Windows.Forms.Label doctorIdLabel;
            System.Windows.Forms.Label idEmpleadoLabel1;
            System.Windows.Forms.Label idConsultorioLabel;
            System.Windows.Forms.Label hora_inicioLabel1;
            System.Windows.Forms.Label idCitaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregaCita));
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.ctApellidoP = new System.Windows.Forms.TextBox();
            this.ctApellidoM = new System.Windows.Forms.TextBox();
            this.ctTelefono = new System.Windows.Forms.TextBox();
            this.ctCorreo = new System.Windows.Forms.TextBox();
            this.ctNombreDoctor = new System.Windows.Forms.TextBox();
            this.ctApellidoPD = new System.Windows.Forms.TextBox();
            this.ctApellidoMD = new System.Windows.Forms.TextBox();
            this.ctNombreEmpleado = new System.Windows.Forms.TextBox();
            this.ctApellidoPE = new System.Windows.Forms.TextBox();
            this.buscarPaciente = new System.Windows.Forms.Button();
            this.buscaDoctor = new System.Windows.Forms.Button();
            this.buscaEmpleado = new System.Windows.Forms.Button();
            this.buscaConsultorio = new System.Windows.Forms.Button();
            this.ctApellidoME = new System.Windows.Forms.TextBox();
            this.hospitalDataSet = new hospital.hospitalDataSet();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new hospital.hospitalDataSetTableAdapters.citasTableAdapter();
            this.tableAdapterManager = new hospital.hospitalDataSetTableAdapters.TableAdapterManager();
            this.citasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.citasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pacienteIdTextBox = new System.Windows.Forms.TextBox();
            this.doctorIdTextBox = new System.Windows.Forms.TextBox();
            this.idEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.idConsultorioTextBox = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.hora_inicioComboBox = new System.Windows.Forms.ComboBox();
            this.idCitaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdReporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReporte = new System.Windows.Forms.TextBox();
            pacienteIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoPaternoLabel = new System.Windows.Forms.Label();
            apellidoMaternoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correo_electronicoLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            apellidoPaternoLabel1 = new System.Windows.Forms.Label();
            apellidoMaternoLabel1 = new System.Windows.Forms.Label();
            nombreLabel2 = new System.Windows.Forms.Label();
            apeliido_paternoLabel = new System.Windows.Forms.Label();
            apellido_maternoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            pacienteIdLabel1 = new System.Windows.Forms.Label();
            doctorIdLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel1 = new System.Windows.Forms.Label();
            idConsultorioLabel = new System.Windows.Forms.Label();
            hora_inicioLabel1 = new System.Windows.Forms.Label();
            idCitaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingNavigator)).BeginInit();
            this.citasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Size = new System.Drawing.Size(1138, 34);
            this.label1.Text = "Agregar Cita";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idCitaLabel);
            this.groupBox1.Controls.Add(this.idCitaTextBox);
            this.groupBox1.Controls.Add(hora_inicioLabel1);
            this.groupBox1.Controls.Add(this.hora_inicioComboBox);
            this.groupBox1.Controls.Add(this.dg);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(pacienteIdLabel1);
            this.groupBox1.Controls.Add(this.pacienteIdTextBox);
            this.groupBox1.Controls.Add(doctorIdLabel);
            this.groupBox1.Controls.Add(this.doctorIdTextBox);
            this.groupBox1.Controls.Add(idEmpleadoLabel1);
            this.groupBox1.Controls.Add(this.idEmpleadoTextBox);
            this.groupBox1.Controls.Add(idConsultorioLabel);
            this.groupBox1.Controls.Add(this.idConsultorioTextBox);
            this.groupBox1.Controls.Add(this.buscaConsultorio);
            this.groupBox1.Controls.Add(this.buscaEmpleado);
            this.groupBox1.Controls.Add(this.buscaDoctor);
            this.groupBox1.Controls.Add(this.buscarPaciente);
            this.groupBox1.Controls.Add(apellido_maternoLabel);
            this.groupBox1.Controls.Add(this.ctApellidoME);
            this.groupBox1.Controls.Add(apeliido_paternoLabel);
            this.groupBox1.Controls.Add(this.ctApellidoPE);
            this.groupBox1.Controls.Add(nombreLabel2);
            this.groupBox1.Controls.Add(this.ctNombreEmpleado);
            this.groupBox1.Controls.Add(apellidoMaternoLabel1);
            this.groupBox1.Controls.Add(this.ctApellidoMD);
            this.groupBox1.Controls.Add(apellidoPaternoLabel1);
            this.groupBox1.Controls.Add(this.ctApellidoPD);
            this.groupBox1.Controls.Add(nombreLabel1);
            this.groupBox1.Controls.Add(this.ctNombreDoctor);
            this.groupBox1.Controls.Add(correo_electronicoLabel);
            this.groupBox1.Controls.Add(this.ctCorreo);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.ctTelefono);
            this.groupBox1.Controls.Add(apellidoMaternoLabel);
            this.groupBox1.Controls.Add(this.ctApellidoM);
            this.groupBox1.Controls.Add(apellidoPaternoLabel);
            this.groupBox1.Controls.Add(this.ctApellidoP);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.ctNombre);
            this.groupBox1.Controls.Add(pacienteIdLabel);
            this.groupBox1.Size = new System.Drawing.Size(1121, 502);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(1020, 635);
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(1100, 635);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // pacienteIdLabel
            // 
            pacienteIdLabel.AutoSize = true;
            pacienteIdLabel.Location = new System.Drawing.Point(416, 27);
            pacienteIdLabel.Name = "pacienteIdLabel";
            pacienteIdLabel.Size = new System.Drawing.Size(0, 13);
            pacienteIdLabel.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(434, 53);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 14;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoPaternoLabel
            // 
            apellidoPaternoLabel.AutoSize = true;
            apellidoPaternoLabel.Location = new System.Drawing.Point(395, 79);
            apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            apellidoPaternoLabel.Size = new System.Drawing.Size(87, 13);
            apellidoPaternoLabel.TabIndex = 16;
            apellidoPaternoLabel.Text = "Apellido Paterno:";
            // 
            // apellidoMaternoLabel
            // 
            apellidoMaternoLabel.AutoSize = true;
            apellidoMaternoLabel.Location = new System.Drawing.Point(392, 109);
            apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            apellidoMaternoLabel.Size = new System.Drawing.Size(89, 13);
            apellidoMaternoLabel.TabIndex = 18;
            apellidoMaternoLabel.Text = "Apellido Materno:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(428, 131);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // correo_electronicoLabel
            // 
            correo_electronicoLabel.AutoSize = true;
            correo_electronicoLabel.Location = new System.Drawing.Point(386, 160);
            correo_electronicoLabel.Name = "correo_electronicoLabel";
            correo_electronicoLabel.Size = new System.Drawing.Size(97, 13);
            correo_electronicoLabel.TabIndex = 22;
            correo_electronicoLabel.Text = "Correo Electronico:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(814, 48);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 24;
            nombreLabel1.Text = "Nombre:";
            // 
            // apellidoPaternoLabel1
            // 
            apellidoPaternoLabel1.AutoSize = true;
            apellidoPaternoLabel1.Location = new System.Drawing.Point(774, 77);
            apellidoPaternoLabel1.Name = "apellidoPaternoLabel1";
            apellidoPaternoLabel1.Size = new System.Drawing.Size(87, 13);
            apellidoPaternoLabel1.TabIndex = 26;
            apellidoPaternoLabel1.Text = "Apellido Paterno:";
            // 
            // apellidoMaternoLabel1
            // 
            apellidoMaternoLabel1.AutoSize = true;
            apellidoMaternoLabel1.Location = new System.Drawing.Point(775, 102);
            apellidoMaternoLabel1.Name = "apellidoMaternoLabel1";
            apellidoMaternoLabel1.Size = new System.Drawing.Size(89, 13);
            apellidoMaternoLabel1.TabIndex = 28;
            apellidoMaternoLabel1.Text = "Apellido Materno:";
            // 
            // nombreLabel2
            // 
            nombreLabel2.AutoSize = true;
            nombreLabel2.Location = new System.Drawing.Point(813, 155);
            nombreLabel2.Name = "nombreLabel2";
            nombreLabel2.Size = new System.Drawing.Size(47, 13);
            nombreLabel2.TabIndex = 30;
            nombreLabel2.Text = "Nombre:";
            // 
            // apeliido_paternoLabel
            // 
            apeliido_paternoLabel.AutoSize = true;
            apeliido_paternoLabel.Location = new System.Drawing.Point(774, 181);
            apeliido_paternoLabel.Name = "apeliido_paternoLabel";
            apeliido_paternoLabel.Size = new System.Drawing.Size(87, 13);
            apeliido_paternoLabel.TabIndex = 32;
            apeliido_paternoLabel.Text = "Apeliido Paterno:";
            // 
            // apellido_maternoLabel
            // 
            apellido_maternoLabel.AutoSize = true;
            apellido_maternoLabel.Location = new System.Drawing.Point(774, 206);
            apellido_maternoLabel.Name = "apellido_maternoLabel";
            apellido_maternoLabel.Size = new System.Drawing.Size(89, 13);
            apellido_maternoLabel.TabIndex = 34;
            apellido_maternoLabel.Text = "Apellido Materno:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(67, 61);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 43;
            fechaLabel.Text = "Fecha:";
            // 
            // pacienteIdLabel1
            // 
            pacienteIdLabel1.AutoSize = true;
            pacienteIdLabel1.Location = new System.Drawing.Point(415, 26);
            pacienteIdLabel1.Name = "pacienteIdLabel1";
            pacienteIdLabel1.Size = new System.Drawing.Size(64, 13);
            pacienteIdLabel1.TabIndex = 47;
            pacienteIdLabel1.Text = "Paciente Id:";
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Location = new System.Drawing.Point(806, 23);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new System.Drawing.Size(54, 13);
            doctorIdLabel.TabIndex = 49;
            doctorIdLabel.Text = "Doctor Id:";
            // 
            // idEmpleadoLabel1
            // 
            idEmpleadoLabel1.AutoSize = true;
            idEmpleadoLabel1.Location = new System.Drawing.Point(792, 130);
            idEmpleadoLabel1.Name = "idEmpleadoLabel1";
            idEmpleadoLabel1.Size = new System.Drawing.Size(69, 13);
            idEmpleadoLabel1.TabIndex = 51;
            idEmpleadoLabel1.Text = "Id Empleado:";
            // 
            // idConsultorioLabel
            // 
            idConsultorioLabel.AutoSize = true;
            idConsultorioLabel.Location = new System.Drawing.Point(15, 116);
            idConsultorioLabel.Name = "idConsultorioLabel";
            idConsultorioLabel.Size = new System.Drawing.Size(102, 13);
            idConsultorioLabel.TabIndex = 53;
            idConsultorioLabel.Text = "Numero Consultorio:";
            // 
            // hora_inicioLabel1
            // 
            hora_inicioLabel1.AutoSize = true;
            hora_inicioLabel1.Location = new System.Drawing.Point(49, 90);
            hora_inicioLabel1.Name = "hora_inicioLabel1";
            hora_inicioLabel1.Size = new System.Drawing.Size(61, 13);
            hora_inicioLabel1.TabIndex = 55;
            hora_inicioLabel1.Text = "Hora Inicio:";
            // 
            // idCitaLabel
            // 
            idCitaLabel.AutoSize = true;
            idCitaLabel.Location = new System.Drawing.Point(80, 34);
            idCitaLabel.Name = "idCitaLabel";
            idCitaLabel.Size = new System.Drawing.Size(39, 13);
            idCitaLabel.TabIndex = 56;
            idCitaLabel.Text = "id Cita:";
            // 
            // ctNombre
            // 
            this.ctNombre.Location = new System.Drawing.Point(495, 50);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.ReadOnly = true;
            this.ctNombre.Size = new System.Drawing.Size(140, 20);
            this.ctNombre.TabIndex = 15;
            // 
            // ctApellidoP
            // 
            this.ctApellidoP.Location = new System.Drawing.Point(495, 76);
            this.ctApellidoP.Name = "ctApellidoP";
            this.ctApellidoP.ReadOnly = true;
            this.ctApellidoP.Size = new System.Drawing.Size(140, 20);
            this.ctApellidoP.TabIndex = 17;
            // 
            // ctApellidoM
            // 
            this.ctApellidoM.Location = new System.Drawing.Point(495, 102);
            this.ctApellidoM.Name = "ctApellidoM";
            this.ctApellidoM.ReadOnly = true;
            this.ctApellidoM.Size = new System.Drawing.Size(140, 20);
            this.ctApellidoM.TabIndex = 19;
            // 
            // ctTelefono
            // 
            this.ctTelefono.Location = new System.Drawing.Point(496, 128);
            this.ctTelefono.Name = "ctTelefono";
            this.ctTelefono.ReadOnly = true;
            this.ctTelefono.Size = new System.Drawing.Size(139, 20);
            this.ctTelefono.TabIndex = 21;
            // 
            // ctCorreo
            // 
            this.ctCorreo.Location = new System.Drawing.Point(494, 157);
            this.ctCorreo.Name = "ctCorreo";
            this.ctCorreo.ReadOnly = true;
            this.ctCorreo.Size = new System.Drawing.Size(141, 20);
            this.ctCorreo.TabIndex = 23;
            // 
            // ctNombreDoctor
            // 
            this.ctNombreDoctor.Location = new System.Drawing.Point(878, 45);
            this.ctNombreDoctor.Name = "ctNombreDoctor";
            this.ctNombreDoctor.ReadOnly = true;
            this.ctNombreDoctor.Size = new System.Drawing.Size(129, 20);
            this.ctNombreDoctor.TabIndex = 25;
            // 
            // ctApellidoPD
            // 
            this.ctApellidoPD.Location = new System.Drawing.Point(878, 71);
            this.ctApellidoPD.Name = "ctApellidoPD";
            this.ctApellidoPD.ReadOnly = true;
            this.ctApellidoPD.Size = new System.Drawing.Size(129, 20);
            this.ctApellidoPD.TabIndex = 27;
            // 
            // ctApellidoMD
            // 
            this.ctApellidoMD.Location = new System.Drawing.Point(878, 99);
            this.ctApellidoMD.Name = "ctApellidoMD";
            this.ctApellidoMD.ReadOnly = true;
            this.ctApellidoMD.Size = new System.Drawing.Size(129, 20);
            this.ctApellidoMD.TabIndex = 29;
            // 
            // ctNombreEmpleado
            // 
            this.ctNombreEmpleado.Location = new System.Drawing.Point(876, 152);
            this.ctNombreEmpleado.Name = "ctNombreEmpleado";
            this.ctNombreEmpleado.ReadOnly = true;
            this.ctNombreEmpleado.Size = new System.Drawing.Size(131, 20);
            this.ctNombreEmpleado.TabIndex = 31;
            // 
            // ctApellidoPE
            // 
            this.ctApellidoPE.Location = new System.Drawing.Point(876, 178);
            this.ctApellidoPE.Name = "ctApellidoPE";
            this.ctApellidoPE.ReadOnly = true;
            this.ctApellidoPE.Size = new System.Drawing.Size(131, 20);
            this.ctApellidoPE.TabIndex = 33;
            // 
            // buscarPaciente
            // 
            this.buscarPaciente.Location = new System.Drawing.Point(641, 24);
            this.buscarPaciente.Name = "buscarPaciente";
            this.buscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.buscarPaciente.TabIndex = 38;
            this.buscarPaciente.Text = "Buscar";
            this.buscarPaciente.UseVisualStyleBackColor = true;
            this.buscarPaciente.Click += new System.EventHandler(this.buscarPaciente_Click);
            // 
            // buscaDoctor
            // 
            this.buscaDoctor.Location = new System.Drawing.Point(1015, 17);
            this.buscaDoctor.Name = "buscaDoctor";
            this.buscaDoctor.Size = new System.Drawing.Size(75, 23);
            this.buscaDoctor.TabIndex = 39;
            this.buscaDoctor.Text = "Buscar";
            this.buscaDoctor.UseVisualStyleBackColor = true;
            this.buscaDoctor.Click += new System.EventHandler(this.buscaDoctor_Click);
            // 
            // buscaEmpleado
            // 
            this.buscaEmpleado.Location = new System.Drawing.Point(1015, 124);
            this.buscaEmpleado.Name = "buscaEmpleado";
            this.buscaEmpleado.Size = new System.Drawing.Size(75, 23);
            this.buscaEmpleado.TabIndex = 40;
            this.buscaEmpleado.Text = "Buscar";
            this.buscaEmpleado.UseVisualStyleBackColor = true;
            this.buscaEmpleado.Click += new System.EventHandler(this.buscaEmpleado_Click);
            // 
            // buscaConsultorio
            // 
            this.buscaConsultorio.Location = new System.Drawing.Point(266, 111);
            this.buscaConsultorio.Name = "buscaConsultorio";
            this.buscaConsultorio.Size = new System.Drawing.Size(75, 23);
            this.buscaConsultorio.TabIndex = 41;
            this.buscaConsultorio.Text = "Buscar";
            this.buscaConsultorio.UseVisualStyleBackColor = true;
            this.buscaConsultorio.Click += new System.EventHandler(this.buscaConsultorio_Click);
            // 
            // ctApellidoME
            // 
            this.ctApellidoME.Location = new System.Drawing.Point(876, 203);
            this.ctApellidoME.Name = "ctApellidoME";
            this.ctApellidoME.ReadOnly = true;
            this.ctApellidoME.Size = new System.Drawing.Size(131, 20);
            this.ctApellidoME.TabIndex = 35;
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "citas";
            this.citasBindingSource.DataSource = this.hospitalDataSet;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.citasTableAdapter = this.citasTableAdapter;
            this.tableAdapterManager.consultaMedicaTableAdapter = null;
            this.tableAdapterManager.consultorio1TableAdapter = null;
            this.tableAdapterManager.DatosMedicosTableAdapter = null;
            this.tableAdapterManager.diagnosticoTableAdapter = null;
            this.tableAdapterManager.doctoresTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.EstudiosTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.RecetaTableAdapter = null;
            this.tableAdapterManager.tipo_consultorioTableAdapter = null;
            this.tableAdapterManager.TratamientoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hospital.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // citasBindingNavigator
            // 
            this.citasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.citasBindingNavigator.BindingSource = this.citasBindingSource;
            this.citasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.citasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.citasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.citasBindingNavigatorSaveItem});
            this.citasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.citasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.citasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.citasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.citasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.citasBindingNavigator.Name = "citasBindingNavigator";
            this.citasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.citasBindingNavigator.Size = new System.Drawing.Size(866, 25);
            this.citasBindingNavigator.TabIndex = 4;
            this.citasBindingNavigator.Text = "bindingNavigator1";
            this.citasBindingNavigator.Visible = false;
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
            // citasBindingNavigatorSaveItem
            // 
            this.citasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.citasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citasBindingNavigatorSaveItem.Image")));
            this.citasBindingNavigatorSaveItem.Name = "citasBindingNavigatorSaveItem";
            this.citasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.citasBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.citasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(126, 57);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.fechaDateTimePicker.TabIndex = 44;
            this.fechaDateTimePicker.ValueChanged += new System.EventHandler(this.fechaDateTimePicker_ValueChanged);
            // 
            // pacienteIdTextBox
            // 
            this.pacienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citasBindingSource, "pacienteId", true));
            this.pacienteIdTextBox.Location = new System.Drawing.Point(494, 23);
            this.pacienteIdTextBox.Name = "pacienteIdTextBox";
            this.pacienteIdTextBox.ReadOnly = true;
            this.pacienteIdTextBox.Size = new System.Drawing.Size(141, 20);
            this.pacienteIdTextBox.TabIndex = 48;
            // 
            // doctorIdTextBox
            // 
            this.doctorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citasBindingSource, "doctorId", true));
            this.doctorIdTextBox.Location = new System.Drawing.Point(876, 20);
            this.doctorIdTextBox.Name = "doctorIdTextBox";
            this.doctorIdTextBox.ReadOnly = true;
            this.doctorIdTextBox.Size = new System.Drawing.Size(131, 20);
            this.doctorIdTextBox.TabIndex = 50;
            this.doctorIdTextBox.TextChanged += new System.EventHandler(this.doctorIdTextBox_TextChanged);
            // 
            // idEmpleadoTextBox
            // 
            this.idEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citasBindingSource, "idEmpleado", true));
            this.idEmpleadoTextBox.Location = new System.Drawing.Point(876, 127);
            this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
            this.idEmpleadoTextBox.ReadOnly = true;
            this.idEmpleadoTextBox.Size = new System.Drawing.Size(131, 20);
            this.idEmpleadoTextBox.TabIndex = 52;
            // 
            // idConsultorioTextBox
            // 
            this.idConsultorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citasBindingSource, "idConsultorio", true));
            this.idConsultorioTextBox.Location = new System.Drawing.Point(127, 113);
            this.idConsultorioTextBox.Name = "idConsultorioTextBox";
            this.idConsultorioTextBox.ReadOnly = true;
            this.idConsultorioTextBox.Size = new System.Drawing.Size(133, 20);
            this.idConsultorioTextBox.TabIndex = 54;
            this.idConsultorioTextBox.TextChanged += new System.EventHandler(this.idConsultorioTextBox_TextChanged);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(20, 245);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(1069, 241);
            this.dg.TabIndex = 55;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // hora_inicioComboBox
            // 
            this.hora_inicioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citasBindingSource, "hora_inicio", true));
            this.hora_inicioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hora_inicioComboBox.FormattingEnabled = true;
            this.hora_inicioComboBox.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.hora_inicioComboBox.Location = new System.Drawing.Point(127, 84);
            this.hora_inicioComboBox.Name = "hora_inicioComboBox";
            this.hora_inicioComboBox.Size = new System.Drawing.Size(139, 21);
            this.hora_inicioComboBox.TabIndex = 56;
            // 
            // idCitaTextBox
            // 
            this.idCitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.citasBindingSource, "idCita", true));
            this.idCitaTextBox.Location = new System.Drawing.Point(125, 31);
            this.idCitaTextBox.Name = "idCitaTextBox";
            this.idCitaTextBox.ReadOnly = true;
            this.idCitaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCitaTextBox.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdReporte
            // 
            this.cmdReporte.Location = new System.Drawing.Point(233, 623);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(150, 23);
            this.cmdReporte.TabIndex = 6;
            this.cmdReporte.Text = "Generar Repotte";
            this.cmdReporte.UseVisualStyleBackColor = true;
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(112, 623);
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(100, 20);
            this.txtReporte.TabIndex = 8;
            // 
            // agregaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1203, 670);
            this.Controls.Add(this.citasBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdReporte);
            this.Name = "agregaCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cita";
            this.Load += new System.EventHandler(this.agregaCita_Load);
            this.Controls.SetChildIndex(this.cmdReporte, 0);
            this.Controls.SetChildIndex(this.btAceptar, 0);
            this.Controls.SetChildIndex(this.btCancelar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.txtReporte, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.citasBindingNavigator, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingNavigator)).EndInit();
            this.citasBindingNavigator.ResumeLayout(false);
            this.citasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctApellidoM;
        private System.Windows.Forms.TextBox ctApellidoP;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.TextBox ctCorreo;
        private System.Windows.Forms.TextBox ctTelefono;
        private System.Windows.Forms.TextBox ctApellidoMD;
        private System.Windows.Forms.TextBox ctApellidoPD;
        private System.Windows.Forms.TextBox ctNombreDoctor;
        private System.Windows.Forms.TextBox ctApellidoPE;
        private System.Windows.Forms.TextBox ctNombreEmpleado;
        private System.Windows.Forms.Button buscaConsultorio;
        private System.Windows.Forms.Button buscaEmpleado;
        private System.Windows.Forms.Button buscaDoctor;
        private System.Windows.Forms.Button buscarPaciente;
        private System.Windows.Forms.TextBox ctApellidoME;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private hospitalDataSetTableAdapters.citasTableAdapter citasTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator citasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton citasBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox pacienteIdTextBox;
        private System.Windows.Forms.TextBox doctorIdTextBox;
        private System.Windows.Forms.TextBox idEmpleadoTextBox;
        private System.Windows.Forms.TextBox idConsultorioTextBox;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox hora_inicioComboBox;
        private System.Windows.Forms.TextBox idCitaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReporte;
    }
}
