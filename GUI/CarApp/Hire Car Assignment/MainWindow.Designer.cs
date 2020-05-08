namespace Hire_Car_Assignment
{
    partial class MainWindow
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LstCompany = new System.Windows.Forms.ListBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.LstCars = new System.Windows.Forms.ListBox();
            this.BtnAddCar = new System.Windows.Forms.Button();
            this.BtnEditCar = new System.Windows.Forms.Button();
            this.BtnDeleteCar = new System.Windows.Forms.Button();
            this.BtnSaveCar = new System.Windows.Forms.Button();
            this.TxtCarID = new System.Windows.Forms.TextBox();
            this.TxtCarMake = new System.Windows.Forms.TextBox();
            this.TxtCarReg = new System.Windows.Forms.TextBox();
            this.TxtCarFuel = new System.Windows.Forms.TextBox();
            this.TxtCarService = new System.Windows.Forms.TextBox();
            this.TxtComments = new System.Windows.Forms.TextBox();
            this.BtnCarCancle = new System.Windows.Forms.Button();
            this.GrpSearch = new System.Windows.Forms.GroupBox();
            this.GrpCompany = new System.Windows.Forms.GroupBox();
            this.BtnCompSave = new System.Windows.Forms.Button();
            this.btnCompCancel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompCars = new System.Windows.Forms.TextBox();
            this.txtCompPostcode = new System.Windows.Forms.TextBox();
            this.TxtCompAddress = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.TxtCompID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrpCars = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpSearchTest = new System.Windows.Forms.GroupBox();
            this.BtnHide = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrpSearch.SuspendLayout();
            this.GrpCompany.SuspendLayout();
            this.GrpCars.SuspendLayout();
            this.GrpSearchTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(6, 208);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 52);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add New Company";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(653, 25);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(150, 44);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit Company";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // LstCompany
            // 
            this.LstCompany.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCompany.FormattingEnabled = true;
            this.LstCompany.ItemHeight = 15;
            this.LstCompany.Location = new System.Drawing.Point(6, 76);
            this.LstCompany.Margin = new System.Windows.Forms.Padding(2);
            this.LstCompany.Name = "LstCompany";
            this.LstCompany.Size = new System.Drawing.Size(325, 124);
            this.LstCompany.TabIndex = 3;
            this.LstCompany.SelectedIndexChanged += new System.EventHandler(this.LstCompany_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(8, 21);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 52);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(172, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(601, 21);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // LstCars
            // 
            this.LstCars.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCars.FormattingEnabled = true;
            this.LstCars.ItemHeight = 15;
            this.LstCars.Location = new System.Drawing.Point(6, 67);
            this.LstCars.Margin = new System.Windows.Forms.Padding(2);
            this.LstCars.Name = "LstCars";
            this.LstCars.Size = new System.Drawing.Size(325, 124);
            this.LstCars.TabIndex = 7;
            this.LstCars.SelectedIndexChanged += new System.EventHandler(this.LstCars_SelectedIndexChanged);
            // 
            // BtnAddCar
            // 
            this.BtnAddCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddCar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCar.Location = new System.Drawing.Point(4, 210);
            this.BtnAddCar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddCar.Name = "BtnAddCar";
            this.BtnAddCar.Size = new System.Drawing.Size(150, 52);
            this.BtnAddCar.TabIndex = 8;
            this.BtnAddCar.Text = "Add Car";
            this.BtnAddCar.UseVisualStyleBackColor = false;
            this.BtnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // BtnEditCar
            // 
            this.BtnEditCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEditCar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCar.Location = new System.Drawing.Point(650, 21);
            this.BtnEditCar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditCar.Name = "BtnEditCar";
            this.BtnEditCar.Size = new System.Drawing.Size(150, 41);
            this.BtnEditCar.TabIndex = 9;
            this.BtnEditCar.Text = "Edit Car";
            this.BtnEditCar.UseVisualStyleBackColor = false;
            this.BtnEditCar.Click += new System.EventHandler(this.BtnEditCar_Click);
            // 
            // BtnDeleteCar
            // 
            this.BtnDeleteCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDeleteCar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCar.Location = new System.Drawing.Point(159, 210);
            this.BtnDeleteCar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteCar.Name = "BtnDeleteCar";
            this.BtnDeleteCar.Size = new System.Drawing.Size(150, 52);
            this.BtnDeleteCar.TabIndex = 10;
            this.BtnDeleteCar.Text = "Delete Car";
            this.BtnDeleteCar.UseVisualStyleBackColor = false;
            this.BtnDeleteCar.Click += new System.EventHandler(this.BtnDeleteCar_Click);
            // 
            // BtnSaveCar
            // 
            this.BtnSaveCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSaveCar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCar.Location = new System.Drawing.Point(650, 210);
            this.BtnSaveCar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveCar.Name = "BtnSaveCar";
            this.BtnSaveCar.Size = new System.Drawing.Size(150, 52);
            this.BtnSaveCar.TabIndex = 13;
            this.BtnSaveCar.Text = "Save Car";
            this.BtnSaveCar.UseVisualStyleBackColor = false;
            this.BtnSaveCar.Click += new System.EventHandler(this.BtnSaveCar_Click);
            // 
            // TxtCarID
            // 
            this.TxtCarID.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarID.Location = new System.Drawing.Point(518, 67);
            this.TxtCarID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCarID.Name = "TxtCarID";
            this.TxtCarID.Size = new System.Drawing.Size(286, 21);
            this.TxtCarID.TabIndex = 14;
            this.TxtCarID.TextChanged += new System.EventHandler(this.TxtCarID_TextChanged);
            // 
            // TxtCarMake
            // 
            this.TxtCarMake.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarMake.Location = new System.Drawing.Point(518, 90);
            this.TxtCarMake.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCarMake.Name = "TxtCarMake";
            this.TxtCarMake.Size = new System.Drawing.Size(286, 21);
            this.TxtCarMake.TabIndex = 15;
            // 
            // TxtCarReg
            // 
            this.TxtCarReg.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarReg.Location = new System.Drawing.Point(518, 113);
            this.TxtCarReg.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCarReg.Name = "TxtCarReg";
            this.TxtCarReg.Size = new System.Drawing.Size(286, 21);
            this.TxtCarReg.TabIndex = 16;
            // 
            // TxtCarFuel
            // 
            this.TxtCarFuel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarFuel.Location = new System.Drawing.Point(518, 136);
            this.TxtCarFuel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCarFuel.Name = "TxtCarFuel";
            this.TxtCarFuel.Size = new System.Drawing.Size(286, 21);
            this.TxtCarFuel.TabIndex = 17;
            // 
            // TxtCarService
            // 
            this.TxtCarService.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCarService.Location = new System.Drawing.Point(518, 158);
            this.TxtCarService.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCarService.Name = "TxtCarService";
            this.TxtCarService.Size = new System.Drawing.Size(286, 21);
            this.TxtCarService.TabIndex = 18;
            // 
            // TxtComments
            // 
            this.TxtComments.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComments.Location = new System.Drawing.Point(518, 181);
            this.TxtComments.Margin = new System.Windows.Forms.Padding(2);
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(286, 21);
            this.TxtComments.TabIndex = 19;
            // 
            // BtnCarCancle
            // 
            this.BtnCarCancle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCarCancle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarCancle.Location = new System.Drawing.Point(496, 210);
            this.BtnCarCancle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCarCancle.Name = "BtnCarCancle";
            this.BtnCarCancle.Size = new System.Drawing.Size(150, 52);
            this.BtnCarCancle.TabIndex = 20;
            this.BtnCarCancle.Text = "Dont Save";
            this.BtnCarCancle.UseVisualStyleBackColor = false;
            this.BtnCarCancle.Click += new System.EventHandler(this.BtnCarCancle_Click);
            // 
            // GrpSearch
            // 
            this.GrpSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GrpSearch.Controls.Add(this.BtnSearch);
            this.GrpSearch.Controls.Add(this.txtSearch);
            this.GrpSearch.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpSearch.Location = new System.Drawing.Point(9, 19);
            this.GrpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.GrpSearch.Name = "GrpSearch";
            this.GrpSearch.Padding = new System.Windows.Forms.Padding(2);
            this.GrpSearch.Size = new System.Drawing.Size(824, 76);
            this.GrpSearch.TabIndex = 21;
            this.GrpSearch.TabStop = false;
            this.GrpSearch.Text = "Search";
            // 
            // GrpCompany
            // 
            this.GrpCompany.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GrpCompany.Controls.Add(this.BtnCompSave);
            this.GrpCompany.Controls.Add(this.btnCompCancel);
            this.GrpCompany.Controls.Add(this.label12);
            this.GrpCompany.Controls.Add(this.label11);
            this.GrpCompany.Controls.Add(this.label10);
            this.GrpCompany.Controls.Add(this.label9);
            this.GrpCompany.Controls.Add(this.label8);
            this.GrpCompany.Controls.Add(this.txtCompCars);
            this.GrpCompany.Controls.Add(this.txtCompPostcode);
            this.GrpCompany.Controls.Add(this.TxtCompAddress);
            this.GrpCompany.Controls.Add(this.txtCompName);
            this.GrpCompany.Controls.Add(this.TxtCompID);
            this.GrpCompany.Controls.Add(this.label7);
            this.GrpCompany.Controls.Add(this.LstCompany);
            this.GrpCompany.Controls.Add(this.BtnEdit);
            this.GrpCompany.Controls.Add(this.BtnAdd);
            this.GrpCompany.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCompany.Location = new System.Drawing.Point(9, 99);
            this.GrpCompany.Margin = new System.Windows.Forms.Padding(2);
            this.GrpCompany.Name = "GrpCompany";
            this.GrpCompany.Padding = new System.Windows.Forms.Padding(2);
            this.GrpCompany.Size = new System.Drawing.Size(824, 265);
            this.GrpCompany.TabIndex = 22;
            this.GrpCompany.TabStop = false;
            this.GrpCompany.Text = "Companies";
            // 
            // BtnCompSave
            // 
            this.BtnCompSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCompSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompSave.Location = new System.Drawing.Point(653, 208);
            this.BtnCompSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCompSave.Name = "BtnCompSave";
            this.BtnCompSave.Size = new System.Drawing.Size(150, 52);
            this.BtnCompSave.TabIndex = 25;
            this.BtnCompSave.Text = "Save Company";
            this.BtnCompSave.UseVisualStyleBackColor = false;
            this.BtnCompSave.Click += new System.EventHandler(this.BtnCompSave_Click);
            // 
            // btnCompCancel
            // 
            this.btnCompCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCompCancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompCancel.Location = new System.Drawing.Point(499, 208);
            this.btnCompCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompCancel.Name = "btnCompCancel";
            this.btnCompCancel.Size = new System.Drawing.Size(150, 52);
            this.btnCompCancel.TabIndex = 24;
            this.btnCompCancel.Text = "Dont Save";
            this.btnCompCancel.UseVisualStyleBackColor = false;
            this.btnCompCancel.Click += new System.EventHandler(this.btnCompCancel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(345, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Amount of Company Cars";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(383, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Company Postcode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Company Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Company Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Company ID";
            // 
            // txtCompCars
            // 
            this.txtCompCars.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtCompCars.Location = new System.Drawing.Point(518, 181);
            this.txtCompCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompCars.Name = "txtCompCars";
            this.txtCompCars.Size = new System.Drawing.Size(286, 21);
            this.txtCompCars.TabIndex = 18;
            // 
            // txtCompPostcode
            // 
            this.txtCompPostcode.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtCompPostcode.Location = new System.Drawing.Point(518, 154);
            this.txtCompPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompPostcode.Name = "txtCompPostcode";
            this.txtCompPostcode.Size = new System.Drawing.Size(286, 21);
            this.txtCompPostcode.TabIndex = 17;
            // 
            // TxtCompAddress
            // 
            this.TxtCompAddress.Font = new System.Drawing.Font("Courier New", 9F);
            this.TxtCompAddress.Location = new System.Drawing.Point(518, 128);
            this.TxtCompAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompAddress.Name = "TxtCompAddress";
            this.TxtCompAddress.Size = new System.Drawing.Size(286, 21);
            this.TxtCompAddress.TabIndex = 16;
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtCompName.Location = new System.Drawing.Point(518, 101);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(286, 21);
            this.txtCompName.TabIndex = 15;
            // 
            // TxtCompID
            // 
            this.TxtCompID.Font = new System.Drawing.Font("Courier New", 9F);
            this.TxtCompID.Location = new System.Drawing.Point(518, 74);
            this.TxtCompID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCompID.Name = "TxtCompID";
            this.TxtCompID.Size = new System.Drawing.Size(286, 21);
            this.TxtCompID.TabIndex = 14;
            this.TxtCompID.TextChanged += new System.EventHandler(this.TxtCompID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label7.Location = new System.Drawing.Point(4, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "SELECT COMPANY TO LOAD DETAILS";
            // 
            // GrpCars
            // 
            this.GrpCars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GrpCars.Controls.Add(this.label13);
            this.GrpCars.Controls.Add(this.label6);
            this.GrpCars.Controls.Add(this.LstCars);
            this.GrpCars.Controls.Add(this.label5);
            this.GrpCars.Controls.Add(this.label4);
            this.GrpCars.Controls.Add(this.label3);
            this.GrpCars.Controls.Add(this.label2);
            this.GrpCars.Controls.Add(this.label1);
            this.GrpCars.Controls.Add(this.BtnCarCancle);
            this.GrpCars.Controls.Add(this.TxtComments);
            this.GrpCars.Controls.Add(this.TxtCarService);
            this.GrpCars.Controls.Add(this.TxtCarFuel);
            this.GrpCars.Controls.Add(this.TxtCarReg);
            this.GrpCars.Controls.Add(this.TxtCarMake);
            this.GrpCars.Controls.Add(this.TxtCarID);
            this.GrpCars.Controls.Add(this.BtnSaveCar);
            this.GrpCars.Controls.Add(this.BtnDeleteCar);
            this.GrpCars.Controls.Add(this.BtnEditCar);
            this.GrpCars.Controls.Add(this.BtnAddCar);
            this.GrpCars.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCars.Location = new System.Drawing.Point(9, 369);
            this.GrpCars.Margin = new System.Windows.Forms.Padding(2);
            this.GrpCars.Name = "GrpCars";
            this.GrpCars.Padding = new System.Windows.Forms.Padding(2);
            this.GrpCars.Size = new System.Drawing.Size(824, 266);
            this.GrpCars.TabIndex = 23;
            this.GrpCars.TabStop = false;
            this.GrpCars.Text = "Rental Cars";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 10.2F);
            this.label13.Location = new System.Drawing.Point(4, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "SELECT CAR TO LOAD DETAILS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Make / Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "License Plate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fuel Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Service Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Extra Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Car ID number";
            // 
            // GrpSearchTest
            // 
            this.GrpSearchTest.Controls.Add(this.BtnHide);
            this.GrpSearchTest.Controls.Add(this.dataGridView1);
            this.GrpSearchTest.Location = new System.Drawing.Point(9, 99);
            this.GrpSearchTest.Margin = new System.Windows.Forms.Padding(2);
            this.GrpSearchTest.Name = "GrpSearchTest";
            this.GrpSearchTest.Padding = new System.Windows.Forms.Padding(2);
            this.GrpSearchTest.Size = new System.Drawing.Size(824, 536);
            this.GrpSearchTest.TabIndex = 24;
            this.GrpSearchTest.TabStop = false;
            this.GrpSearchTest.Text = "Search!";
            // 
            // BtnHide
            // 
            this.BtnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHide.Location = new System.Drawing.Point(574, 34);
            this.BtnHide.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(196, 44);
            this.BtnHide.TabIndex = 1;
            this.BtnHide.Text = "Back";
            this.BtnHide.UseVisualStyleBackColor = true;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(814, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(842, 645);
            this.Controls.Add(this.GrpCars);
            this.Controls.Add(this.GrpCompany);
            this.Controls.Add(this.GrpSearch);
            this.Controls.Add(this.GrpSearchTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.GrpSearch.ResumeLayout(false);
            this.GrpSearch.PerformLayout();
            this.GrpCompany.ResumeLayout(false);
            this.GrpCompany.PerformLayout();
            this.GrpCars.ResumeLayout(false);
            this.GrpCars.PerformLayout();
            this.GrpSearchTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ListBox LstCompany;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox LstCars;
        private System.Windows.Forms.Button BtnAddCar;
        private System.Windows.Forms.Button BtnEditCar;
        private System.Windows.Forms.Button BtnDeleteCar;
        private System.Windows.Forms.Button BtnSaveCar;
        private System.Windows.Forms.TextBox TxtCarID;
        private System.Windows.Forms.TextBox TxtCarMake;
        private System.Windows.Forms.TextBox TxtCarReg;
        private System.Windows.Forms.TextBox TxtCarFuel;
        private System.Windows.Forms.TextBox TxtCarService;
        private System.Windows.Forms.TextBox TxtComments;
        private System.Windows.Forms.Button BtnCarCancle;
        private System.Windows.Forms.GroupBox GrpSearch;
        private System.Windows.Forms.GroupBox GrpCompany;
        private System.Windows.Forms.GroupBox GrpCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompCars;
        private System.Windows.Forms.TextBox txtCompPostcode;
        private System.Windows.Forms.TextBox TxtCompAddress;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.TextBox TxtCompID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCompSave;
        private System.Windows.Forms.Button btnCompCancel;
        private System.Windows.Forms.GroupBox GrpSearchTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.Label label13;
    }
}

