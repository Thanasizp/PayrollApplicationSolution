namespace PayrollApplication
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.grpEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.chkUnionMember = new System.Windows.Forms.CheckBox();
            this.lblUnionMembership = new System.Windows.Forms.Label();
            this.grbMaritalStatus = new System.Windows.Forms.GroupBox();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtNationalInsuranceNo = new System.Windows.Forms.TextBox();
            this.lblNationalInsuranceNo = new System.Windows.Forms.Label();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.grpEmployeeContactDetails = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nINumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollSystemDBDataSet = new PayrollApplication.PayrollSystemDBDataSet();
            this.tblEmployeeTableAdapter = new PayrollApplication.PayrollSystemDBDataSetTableAdapters.tblEmployeeTableAdapter();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpEmployeeInformation.SuspendLayout();
            this.grbMaritalStatus.SuspendLayout();
            this.grbGender.SuspendLayout();
            this.grpEmployeeContactDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployeeInformation
            // 
            this.grpEmployeeInformation.Controls.Add(this.chkUnionMember);
            this.grpEmployeeInformation.Controls.Add(this.lblUnionMembership);
            this.grpEmployeeInformation.Controls.Add(this.grbMaritalStatus);
            this.grpEmployeeInformation.Controls.Add(this.dtpDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.lblDateOfBirth);
            this.grpEmployeeInformation.Controls.Add(this.txtNationalInsuranceNo);
            this.grpEmployeeInformation.Controls.Add(this.lblNationalInsuranceNo);
            this.grpEmployeeInformation.Controls.Add(this.grbGender);
            this.grpEmployeeInformation.Controls.Add(this.txtLastName);
            this.grpEmployeeInformation.Controls.Add(this.lblLastName);
            this.grpEmployeeInformation.Controls.Add(this.txtFirstName);
            this.grpEmployeeInformation.Controls.Add(this.lblFirstName);
            this.grpEmployeeInformation.Controls.Add(this.txtEmployeeID);
            this.grpEmployeeInformation.Controls.Add(this.lblEmployeeID);
            this.grpEmployeeInformation.Location = new System.Drawing.Point(132, 42);
            this.grpEmployeeInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmployeeInformation.Name = "grpEmployeeInformation";
            this.grpEmployeeInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmployeeInformation.Size = new System.Drawing.Size(436, 570);
            this.grpEmployeeInformation.TabIndex = 0;
            this.grpEmployeeInformation.TabStop = false;
            this.grpEmployeeInformation.Text = "Employee Information";
            // 
            // chkUnionMember
            // 
            this.chkUnionMember.AutoSize = true;
            this.chkUnionMember.Location = new System.Drawing.Point(233, 501);
            this.chkUnionMember.Margin = new System.Windows.Forms.Padding(4);
            this.chkUnionMember.Name = "chkUnionMember";
            this.chkUnionMember.Size = new System.Drawing.Size(91, 21);
            this.chkUnionMember.TabIndex = 11;
            this.chkUnionMember.Text = "IsMember";
            this.chkUnionMember.UseVisualStyleBackColor = true;
            // 
            // lblUnionMembership
            // 
            this.lblUnionMembership.AutoSize = true;
            this.lblUnionMembership.Location = new System.Drawing.Point(44, 502);
            this.lblUnionMembership.Name = "lblUnionMembership";
            this.lblUnionMembership.Size = new System.Drawing.Size(134, 17);
            this.lblUnionMembership.TabIndex = 8;
            this.lblUnionMembership.Text = "Union Membership :";
            // 
            // grbMaritalStatus
            // 
            this.grbMaritalStatus.Controls.Add(this.rdbSingle);
            this.grbMaritalStatus.Controls.Add(this.rdbMarried);
            this.grbMaritalStatus.Location = new System.Drawing.Point(43, 391);
            this.grbMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbMaritalStatus.Name = "grbMaritalStatus";
            this.grbMaritalStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbMaritalStatus.Size = new System.Drawing.Size(329, 75);
            this.grbMaritalStatus.TabIndex = 8;
            this.grbMaritalStatus.TabStop = false;
            this.grbMaritalStatus.Text = "Marital Status :";
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(191, 36);
            this.rdbSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(68, 21);
            this.rdbSingle.TabIndex = 10;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(57, 36);
            this.rdbMarried.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(77, 21);
            this.rdbMarried.TabIndex = 9;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(233, 338);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(137, 22);
            this.dtpDateOfBirth.TabIndex = 7;
            this.dtpDateOfBirth.Value = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(44, 338);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(98, 17);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // txtNationalInsuranceNo
            // 
            this.txtNationalInsuranceNo.Location = new System.Drawing.Point(233, 294);
            this.txtNationalInsuranceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNationalInsuranceNo.Name = "txtNationalInsuranceNo";
            this.txtNationalInsuranceNo.Size = new System.Drawing.Size(137, 22);
            this.txtNationalInsuranceNo.TabIndex = 6;
            // 
            // lblNationalInsuranceNo
            // 
            this.lblNationalInsuranceNo.AutoSize = true;
            this.lblNationalInsuranceNo.Location = new System.Drawing.Point(43, 298);
            this.lblNationalInsuranceNo.Name = "lblNationalInsuranceNo";
            this.lblNationalInsuranceNo.Size = new System.Drawing.Size(156, 17);
            this.lblNationalInsuranceNo.TabIndex = 7;
            this.lblNationalInsuranceNo.Text = "National Insurance No :";
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbFemale);
            this.grbGender.Controls.Add(this.rdbMale);
            this.grbGender.Location = new System.Drawing.Point(43, 192);
            this.grbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGender.Name = "grbGender";
            this.grbGender.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGender.Size = new System.Drawing.Size(329, 75);
            this.grbGender.TabIndex = 3;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender :";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(191, 36);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(75, 21);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(57, 36);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(59, 21);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(233, 146);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(137, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(40, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "LastName :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(233, 96);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(40, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(233, 52);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(137, 22);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(40, 52);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(95, 17);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID :";
            // 
            // grpEmployeeContactDetails
            // 
            this.grpEmployeeContactDetails.Controls.Add(this.cmbCountry);
            this.grpEmployeeContactDetails.Controls.Add(this.txtNotes);
            this.grpEmployeeContactDetails.Controls.Add(this.lblNotes);
            this.grpEmployeeContactDetails.Controls.Add(this.txtEmailAddress);
            this.grpEmployeeContactDetails.Controls.Add(this.lblEmailAddress);
            this.grpEmployeeContactDetails.Controls.Add(this.txtPhoneNumber);
            this.grpEmployeeContactDetails.Controls.Add(this.lblPhoneNumber);
            this.grpEmployeeContactDetails.Controls.Add(this.lblCountry);
            this.grpEmployeeContactDetails.Controls.Add(this.txtPostCode);
            this.grpEmployeeContactDetails.Controls.Add(this.lblPostCode);
            this.grpEmployeeContactDetails.Controls.Add(this.txtCity);
            this.grpEmployeeContactDetails.Controls.Add(this.lblCity);
            this.grpEmployeeContactDetails.Controls.Add(this.txtAddress);
            this.grpEmployeeContactDetails.Controls.Add(this.lblAddress);
            this.grpEmployeeContactDetails.Location = new System.Drawing.Point(686, 42);
            this.grpEmployeeContactDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmployeeContactDetails.Name = "grpEmployeeContactDetails";
            this.grpEmployeeContactDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEmployeeContactDetails.Size = new System.Drawing.Size(433, 570);
            this.grpEmployeeContactDetails.TabIndex = 1;
            this.grpEmployeeContactDetails.TabStop = false;
            this.grpEmployeeContactDetails.Text = "Employee Contact Details";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.ItemHeight = 16;
            this.cmbCountry.Items.AddRange(new object[] {
            "Select a Country.....",
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "People \'s Republic of China",
            "Republic of China",
            "Christmas Island",
            "Cocos(Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Cook Islands",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "French Polynesia",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea - Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jersey",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "North Korea",
            "South Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Nagorno - Karabakh",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Turkish Republic of Northern Cyprus",
            "Northern Mariana",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn Islands",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Barthelemy",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Martin",
            "Saint Pierre and Miquelon",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "Somaliland",
            "South Africa",
            "South Ossetia",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor - Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Transnistria Pridnestrovie",
            "Trinidad and Tobago",
            "Tristan da Cunha",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "British Virgin Islands",
            "Isle of Man",
            "US Virgin Islands",
            "Wallis and Futuna",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cmbCountry.Location = new System.Drawing.Point(240, 206);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(137, 24);
            this.cmbCountry.TabIndex = 15;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(240, 369);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(137, 96);
            this.txtNotes.TabIndex = 18;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(47, 373);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 17);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes :";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(240, 315);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(137, 22);
            this.txtEmailAddress.TabIndex = 17;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(47, 319);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(106, 17);
            this.lblEmailAddress.TabIndex = 16;
            this.lblEmailAddress.Text = "Email Address :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(240, 265);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(137, 22);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(47, 268);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(111, 17);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(47, 209);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 17);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Country :";
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(240, 146);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(137, 22);
            this.txtPostCode.TabIndex = 14;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(47, 150);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(81, 17);
            this.lblPostCode.TabIndex = 10;
            this.lblPostCode.Text = "Post Code :";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(240, 96);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(137, 22);
            this.txtCity.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(47, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 17);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(240, 52);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(47, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nINumberDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.isMemberDataGridViewCheckBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 692);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nINumberDataGridViewTextBoxColumn
            // 
            this.nINumberDataGridViewTextBoxColumn.DataPropertyName = "NINumber";
            this.nINumberDataGridViewTextBoxColumn.HeaderText = "NINumber";
            this.nINumberDataGridViewTextBoxColumn.Name = "nINumberDataGridViewTextBoxColumn";
            this.nINumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isMemberDataGridViewCheckBoxColumn
            // 
            this.isMemberDataGridViewCheckBoxColumn.DataPropertyName = "IsMember";
            this.isMemberDataGridViewCheckBoxColumn.HeaderText = "IsMember";
            this.isMemberDataGridViewCheckBoxColumn.Name = "isMemberDataGridViewCheckBoxColumn";
            this.isMemberDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.payrollSystemDBDataSet;
            // 
            // payrollSystemDBDataSet
            // 
            this.payrollSystemDBDataSet.DataSetName = "PayrollSystemDBDataSet";
            this.payrollSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = global::PayrollApplication.Properties.Resources.AddEmployee;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(132, 653);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(139, 39);
            this.btnAddEmployee.TabIndex = 7;
            this.btnAddEmployee.Text = "&Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Image = global::PayrollApplication.Properties.Resources.UpdateEmployee;
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(304, 653);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(161, 39);
            this.btnUpdateEmployee.TabIndex = 6;
            this.btnUpdateEmployee.Text = "&Update Employee";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Image = global::PayrollApplication.Properties.Resources.RemoveEmployee;
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(497, 653);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(152, 39);
            this.btnDeleteEmployee.TabIndex = 5;
            this.btnDeleteEmployee.Text = "&Delete Employee";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::PayrollApplication.Properties.Resources.ResetNewEmployee;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(681, 653);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Image = global::PayrollApplication.Properties.Resources.Preview;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(854, 653);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(120, 39);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Pre&view";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::PayrollApplication.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1010, 653);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1292, 744);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpEmployeeContactDetails);
            this.Controls.Add(this.grpEmployeeInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee - by (Thanasi Zoupa) - myorama@yahoo.com";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.grpEmployeeInformation.ResumeLayout(false);
            this.grpEmployeeInformation.PerformLayout();
            this.grbMaritalStatus.ResumeLayout(false);
            this.grbMaritalStatus.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.grpEmployeeContactDetails.ResumeLayout(false);
            this.grpEmployeeContactDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeInformation;
        private System.Windows.Forms.GroupBox grpEmployeeContactDetails;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtNationalInsuranceNo;
        private System.Windows.Forms.Label lblNationalInsuranceNo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.GroupBox grbMaritalStatus;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.Label lblUnionMembership;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.CheckBox chkUnionMember;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PayrollSystemDBDataSet payrollSystemDBDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private PayrollSystemDBDataSetTableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nINumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}

