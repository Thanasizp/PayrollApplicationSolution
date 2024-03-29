﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;

namespace PayrollApplication
{
    public partial class EmployeeForm : Form
    {
        string gender;
        string maritalStatus;
        bool isMember;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        // User Input Validation Method
        private bool isControlsDataValid()
        {
            Regex objEmployeeID = new Regex("^[0-9]{3,4}$");
            Regex objFirstName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objLastName = new Regex("^[A-Z][a-zA-Z]*$");

            // Must be 9 characters only
            // First 2 characters must be letters
            // Next 6 characters must be numeric digits
            // First character must not be D, F, I, Q, U or V
            // Second character must not be D, F, I, O, Q, U or V
            // Final character can only be A, B, C, D or space
            // [ Example NiNo FORMAT = SB123456C ]
            Regex objNI = new Regex(@"^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\s]$");

            // 000-00-000 
            Regex objSSN = new Regex(@"^d\{3}-d\{2}-d\{4}$");

            // Peter20@yahoo.com
            Regex objEmail = new Regex("^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}$");

            // Employee ID Validation
            if (Convert.ToInt32(txtEmployeeID.Text.Length) < 1)
            {
                MessageBox.Show("Please, Enter Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else if (!objEmployeeID.IsMatch(txtEmployeeID.Text))
            {
                MessageBox.Show("Please, Enter a Valid Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmployeeID.BackColor = Color.White;
            }

            // First Name Validation
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please, Enter First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                return false;
            }
            else if (!objFirstName.IsMatch(txtFirstName.Text))
            {
                MessageBox.Show("Please, Enter a Valid First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtFirstName.BackColor = Color.White;
            }
         
            // Last Name Validation
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please, Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            }
            else if (!objLastName.IsMatch(txtLastName.Text))
            {
                MessageBox.Show("Please, Enter a valid Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }

            // Gender Validation
            if (rdbFemale.Checked==false && rdbMale.Checked == false)
            {
                MessageBox.Show("Please, Check either Male or Female.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grbGender.Focus();
                rdbMale.BackColor = Color.Silver;
                rdbFemale.BackColor = Color.Silver;
                return false;
            }
            else
            {
                rdbMale.BackColor = Color.CornflowerBlue;
                rdbFemale.BackColor = Color.CornflowerBlue;
            }

            // National Insurance Validation
            if (txtNationalInsuranceNo.Text == "")
            {
                MessageBox.Show("Please, Enter National Insurance No", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalInsuranceNo.Focus();
                txtNationalInsuranceNo.BackColor = Color.Silver;
                return false;
            }
            else if (!objNI.IsMatch(txtNationalInsuranceNo.Text))
            {
                MessageBox.Show("Please, Enter a Valid National Insurance No", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalInsuranceNo.Focus();
                txtNationalInsuranceNo.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtNationalInsuranceNo.BackColor = Color.White;
            }

            // Marital Status Validation
            if (rdbMarried.Checked == false && rdbSingle.Checked == false)
            {
                MessageBox.Show("Please, Check either Married or Single.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grbMaritalStatus.Focus();
                rdbMarried.BackColor = Color.Silver;
                rdbSingle.BackColor = Color.Silver;
                return false;
            }
            else
            {
                rdbMarried.BackColor = Color.CornflowerBlue;
                rdbSingle.BackColor = Color.CornflowerBlue;
            }

            // Address Validation
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please, Enter Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                txtAddress.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }


            // City Validation
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please, Enter City", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                txtCity.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtCity.BackColor = Color.White;
            }

            // Post Code Validation
            if (txtPostCode.Text == "")
            {
                MessageBox.Show("Please, Enter Post Code", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Focus();
                txtPostCode.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtPostCode.BackColor = Color.White;
            }

            // Country Validation
            if (cmbCountry.SelectedIndex == 0 || cmbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please, Select a Country from the List", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                cmbCountry.BackColor = Color.Silver;
                return false;
            }
            else
            {
                cmbCountry.BackColor = Color.White;
            }

            // Phone Number Validation
            if (txtPhoneNumber.Text.Length == 0)
            {
                MessageBox.Show("Please, Enter Phone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                txtPhoneNumber.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }

            // Email Address Validation
            if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please, Enter Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                txtEmailAddress.BackColor = Color.Silver;
                return false;
            }
            //else if (!objEmail.IsMatch(txtEmailAddress.Text))
            //{
            //    MessageBox.Show("Please, Enter a Valid Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtEmailAddress.Focus();
            //    txtEmailAddress.BackColor = Color.Silver;
            //    return false;
            //}
            else if (txtEmailAddress.Text.Length >= 1)
            {
                try
                {
                    MailAddress objMail = new MailAddress(txtEmailAddress.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailAddress.Focus();
                    txtEmailAddress.BackColor = Color.Silver;
                    return false;
                }
            }
            else
            {
                txtEmailAddress.BackColor = Color.White;
            }

            // Notes Validation
            if (txtNotes.Text.Length > 30)
            {
                MessageBox.Show("Too Much Text! Please, enter fewer text", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNotes.Focus();
                txtNotes.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtNotes.BackColor = Color.White;
            }

            return true;
        }

        // Checked Items Controls Method
        private void CheckedItems()
        {
            // Checked Gender
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            // Checked Marital Status
            if (rdbMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else
            {
                maritalStatus = "Single";
            }

            // Checked Marital Status
            if (chkUnionMember.Checked)
            {
                isMember = true;
            }
            else
            {
                isMember = false;
            }
        }

        // Clear Controls
        private void ClearControls()
        {
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtNationalInsuranceNo.Text = "";
            dtpDateOfBirth.Value = new DateTime(1990, 12, 30);
            rdbMarried.Checked = false;
            rdbSingle.Checked = false;
            chkUnionMember.Checked = false;
            txtAddress.Text = String.Empty;
            txtCity.Text = null;
            txtPostCode.Text = "";
            cmbCountry.SelectedIndex = 0;
            txtPhoneNumber.Text = "";
            txtEmailAddress.Text = "";
            txtNotes.Text = "";
        }

        // Add Employee Functionality
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (isControlsDataValid())
            {
                //MessageBox.Show("Employee Added");

                CheckedItems();

                //  Connection String
                // App.config -->  <add name="PayrollApplication.Properties.Settings.PayrollSystemDBConnectionString"
                string cs = ConfigurationManager.ConnectionStrings["PayrollApplication.Properties.Settings.PayrollSystemDBConnectionString"].ConnectionString;

                // Instatiate the SqlConnection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                try
                {
                    // Open Connection
                    objSqlConnection.Open();

                    // Prepare Insert Command
                    string InsertCommand = "INSERT INTO tblEmployee VALUES (" + Convert.ToInt32(txtEmployeeID.Text) + ", '" + txtFirstName.Text + "',  '"
                                                                              + txtLastName.Text + "', '" + gender + "', '" + txtNationalInsuranceNo.Text + "', '"
                                                                              + dtpDateOfBirth.Value.ToString("MM/dd/yyyy") + "', '" + maritalStatus + "', '"
                                                                              + isMember + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '"
                                                                              + txtPostCode.Text + "', '" + cmbCountry.SelectedItem.ToString() + "', '"
                                                                              + txtPhoneNumber.Text + "', '" + txtEmailAddress.Text + "', '" + txtNotes.Text + "')";

                    // Instatiate SqlCommand and Pass in CommandText and connection object
                    SqlCommand objSqlCommand = new SqlCommand(InsertCommand, objSqlConnection);

                    //Execute the query identified within our command object
                    objSqlCommand.ExecuteNonQuery();

                    // TODO: This line of code loads data into the 'payrollSystemDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
                    this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);

                    // Diplay success message
                    MessageBox.Show("Employee with ID " + txtEmployeeID.Text + " " + "has been Added successfully!", "Insertion successful ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear Controls
                    ClearControls();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("The following error occured : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
                finally
                {
                    // Close Connection
                    objSqlConnection.Close();
                }
            }          
        }

        // Update Employee Functionality
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Employee Updated");

            if (isControlsDataValid())
            {
                //MessageBox.Show("Employee Added");

                CheckedItems();

                //  Connection String
                // App.config -->  <add name="PayrollApplication.Properties.Settings.PayrollSystemDBConnectionString"
                string cs = ConfigurationManager.ConnectionStrings["PayrollApplication.Properties.Settings.PayrollSystemDBConnectionString"].ConnectionString;

                // Instatiate the SqlConnection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                try
                {
                    // Open Connection
                    objSqlConnection.Open();

                    // Prepare Update Command
                    string UpdateCommand = "UPDATE tblEmployee SET FirstName = '" + this.txtFirstName.Text + "', LastName = '" + this.txtLastName.Text + "', Gender = '"
                                                                                  + this.gender + "', NINumber = '" + this.txtNationalInsuranceNo.Text + "', DateOfBirth = '"
                                                                                  + this.dtpDateOfBirth.Value.ToString("MM/dd/yyyy") + "', MaritalStatus = '"
                                                                                  + this.maritalStatus + "', IsMember = '" + this.isMember + "', Address = '"
                                                                                  + this.txtAddress.Text + "', City = '" + this.txtCity.Text + "', PostCode = '"
                                                                                  + this.txtPostCode.Text + "', Country = '" + this.cmbCountry.SelectedItem.ToString() + "', PhoneNumber = '"
                                                                                  + this.txtPhoneNumber.Text + "', Email = '" + this.txtEmailAddress.Text + "', Notes = '"
                                                                                  + this.txtNotes.Text + "' WHERE EmployeeID = " + txtEmployeeID.Text + "";

                    // Instatiate SqlCommand and Pass in CommandText and connection object
                    SqlCommand objSqlCommand = new SqlCommand(UpdateCommand, objSqlConnection);

                    //Execute the query identified within our command object
                    objSqlCommand.ExecuteNonQuery();

                    // TODO: This line of code loads data into the 'payrollSystemDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
                    this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);

                    // Diplay success message
                    MessageBox.Show("Employee with ID " + txtEmployeeID.Text + " " + "has been Updated successfully!", "Update success! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Clear Controls
                    ClearControls();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("The following error occured : " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    // Close Connection
                    objSqlConnection.Close();
                }
            }
        }

        // Delete Employee Functionality
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Employee Deleted");

            DialogResult objDialogResult = MessageBox.Show("Are you sure you want to permanently delete this Employee's Record?", "Confirm Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (objDialogResult == DialogResult.Yes)
            {

                //  Connection String
                // App.config -->  <add name="PayrollApplication.Properties.Settings.PayrollSystemDBConnectionString"
                string cs = ConfigurationManager.ConnectionStrings["PayrollApplication.Properties.Settings.PayrollSystemDBConnectionString"].ConnectionString;

                // Instatiate the SqlConnection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                try
                {
                    // Open Connection
                    objSqlConnection.Open();

                    // Prepare Delete Command
                    string DeleteCommand = "DELETE FROM tblEmployee WHERE EmployeeID = " + txtEmployeeID.Text + "";

                    // Instatiate SqlCommand and Pass in CommandText and connection object
                    SqlCommand objSqlCommand = new SqlCommand(DeleteCommand, objSqlConnection);

                    //Execute the query identified within our command object
                    objSqlCommand.ExecuteNonQuery();

                    // TODO: This line of code loads data into the 'payrollSystemDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
                    this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);

                    // Diplay success message
                    MessageBox.Show("Employee with ID " + txtEmployeeID.Text + " " + "has been Deleted successfully!", "Delete success! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear Controls
                    ClearControls();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("The following error occured : " + ex.Message, "Daeletion Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    // Close Connection
                    objSqlConnection.Close();
                }
            }
    }

        // Clear or Reset Controls Functionality
        private void btnReset_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Controls Reset");

            // Clear Controls
            ClearControls();
        }

        // Preview Employee's Record Functionality - Parameters and Arguments  
        private void btnPreview_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Employee Preview");
            PreviewForm objPreviewForm = new PreviewForm();

            CheckedItems();

            objPreviewForm.PreviewEmployeeData(Convert.ToInt32(txtEmployeeID.Text),txtFirstName.Text, txtLastName.Text, gender, 
                                               txtNationalInsuranceNo.Text, dtpDateOfBirth.Text, maritalStatus, isMember, 
                                               txtAddress.Text, txtCity.Text, txtPostCode.Text, cmbCountry.SelectedIndex.ToString(),
                                               txtPhoneNumber.Text, txtEmailAddress.Text, txtNotes.Text);
            objPreviewForm.ShowDialog();
        }

        // Close Employee Form
        void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region  // Keypress Event Validation
        bool IsNumberOrBackspace;

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumberOrBackspace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackspace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumberOrBackspace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackspace = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        // Form Load Event
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);

        }

        // DataGridView Cell Click Event
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtNationalInsuranceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            dtpDateOfBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            maritalStatus = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            isMember = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            txtPostCode.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            cmbCountry.Text = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            txtEmailAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
            txtNotes.Text = dataGridView1.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();

            // Gender
            if (gender=="Male")
            {
                rdbMale.Checked = true;
                rdbFemale.Checked = false;
            }
            else
            {
                rdbMale.Checked = false;
                rdbFemale.Checked = true;
            }

            // Gender
            if (gender == "Male")
            {
                rdbMale.Checked = true;
                rdbFemale.Checked = false;
            }
            else
            {
                rdbMale.Checked = false;
                rdbFemale.Checked = true;
            }

            // Marital Status
            if (maritalStatus == "Married")
            {
                rdbMarried.Checked = true;
                rdbSingle.Checked = false;
            }
            else
            {
                rdbMarried.Checked = false;
                rdbSingle.Checked = true;
            }

            // Union Member
            if (isMember == true)
            {
                chkUnionMember.Checked = true;
            }
            else
            {
                chkUnionMember.Checked = false;
             }
        }
    }
}
