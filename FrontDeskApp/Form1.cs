using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontDeskApp.Models;
using FrontDeskApp.Interface;
using FrontDeskApp.Implementation;

namespace FrontDeskApp
{
    public partial class Form1 : Form
    {
        private ICustomer _customerSvc;
        private ICategory _categorySvc;
        private IPackage _packageSvc;
        private IFacility _facilitySvc;

        #region Constructor
        public Form1()
        {
            InitializeComponent();

            _customerSvc = new CustomerBl(new FrontDeskContext());
            _categorySvc = new CategoryBl(new FrontDeskContext());
            _packageSvc = new PackageBl(new FrontDeskContext());
            _facilitySvc = new FacilityBl(new FrontDeskContext());
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.PopulateCustomerGrid();
            this.PopulateCategory();
            this.PopulateFacility();
            this.PopulateFacilityGrid();
            this.GetAvailableSlots();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtFirstName.Text)) {
                    MessageBox.Show("Customer First Name is required!");
                    return;
                }

                if (String.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Customer Last Name is required!");
                    return;
                }

                if (String.IsNullOrWhiteSpace(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Customer Phone Number is required!");
                    return;
                }

                Customer customer = new Customer()
                {
                    strFirstName = txtFirstName.Text,
                    strLastName = txtLastName.Text,
                    strPhoneNumber = txtPhoneNumber.Text
                };

                _customerSvc.Add(customer);
                _customerSvc.Save();

                this.ClearFields();
                this.PopulateCustomerGrid();

                MessageBox.Show("Customer Added Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomer.CurrentRow.Index != -1)
                {
                    int intCustomerId = (int)dgvCustomer.CurrentRow.Cells["intCustomerId"].Value;

                    if (intCustomerId > 0)
                    {
                        Customer customer = _customerSvc.Get(intCustomerId);

                        if (customer != null)
                        {
                            customer.strFirstName = txtFirstName.Text;
                            customer.strLastName = txtLastName.Text;
                            customer.strPhoneNumber = txtPhoneNumber.Text;
                            
                            _customerSvc.Save();

                            this.ClearFields();
                            this.PopulateCustomerGrid();
                            this.EnableFields(false);
                            MessageBox.Show("Customer Updated!");                            
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomer.CurrentRow.Index != -1)
                {
                    int intCustomerId = (int)dgvCustomer.CurrentRow.Cells["intCustomerId"].Value;

                    if (intCustomerId > 0)
                    {
                        Customer customer = _customerSvc.Get(intCustomerId);

                        if (customer != null)
                        {
                            _customerSvc.Delete(customer);
                            _customerSvc.Save();

                            this.ClearFields();
                            this.PopulateCustomerGrid();
                            this.EnableFields(false);
                            this.GetAvailableSlots();
                            MessageBox.Show("Customer Deleted!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                bool ysnStore = (sender as Button).Text == "Store Package";

                if (dgvCustomer.CurrentRow.Index != -1)
                {
                    int? intCustomerId = (int?)dgvCustomer.CurrentRow.Cells["intCustomerId"].Value;
                    int? intCategoryId = (int?)cmbCategory.SelectedValue;
                    int? intFacilityId = (int?)cmbFacility.SelectedValue;
                    string strCategory = cmbCategory.Text;
                    int intSmallAvailable = Convert.ToInt32(txtSmall.Text);
                    int intMediumAvailable = Convert.ToInt32(txtMedium.Text);
                    int intLargeAvailable = Convert.ToInt32(txtLarge.Text);

                    if (intCustomerId == null || intCustomerId == 0)
                    {
                        MessageBox.Show("Please select customer.");
                        return;
                    }                        

                    if (intCategoryId == null || intCategoryId == 0)
                    {
                        MessageBox.Show("Please select storage size.");
                        return;
                    }

                    switch (strCategory.ToUpper())
                    {
                        case "SMALL":
                            if (intSmallAvailable < 1)
                            {                                
                                MessageBox.Show("No slot available for Small package.");
                                return;
                            }
                            break;
                        case "MEDIUM":
                            if (intMediumAvailable < 1)
                            {
                                MessageBox.Show("No slot available for Medium package.");
                                return;
                            }
                            break;
                        case "LARGE":
                            if (intLargeAvailable < 1)
                            {
                                MessageBox.Show("No slot available for Large package.");
                                return;
                            }
                            break;
                    }


                    Package package = new Package()
                    {
                        intCustomerId = (int)intCustomerId,
                        intCategoryId = (int)intCategoryId,
                        intFacilityId = (int)intFacilityId,
                        strStatus = ysnStore ? "Stored" : "Reserved",
                        dtmDate = DateTime.Now
                    };

                    _packageSvc.Add(package);
                    _packageSvc.Save();

                    this.ClearFields();
                    this.PopulateCustomerGrid();
                    this.EnableFields(false);
                    this.PopulatePackageGrid();
                    this.GetAvailableSlots();
                    this.PopulateFacilityGrid();
                    MessageBox.Show("Package successfully stored.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPackage.CurrentRow.Index != -1)
                {
                    int intPackageId = (int)dgvPackage.CurrentRow.Cells["intPackageId"].Value;

                    if (intPackageId > 0)
                    {
                        Package package = _packageSvc.Get(intPackageId);

                        if (package != null)
                        {
                            package.strStatus = "Retrieved";
                            package.dtmDate = DateTime.Now;
                            
                            _packageSvc.Save();

                            this.ClearFields();
                            this.PopulateCustomerGrid();
                            this.EnableFields(false);
                            this.PopulatePackageGrid();
                            this.GetAvailableSlots();
                            this.PopulateFacilityGrid();
                            MessageBox.Show("Package Retrieved!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow.Index != -1)
            {
                int intCustomerId = (int)dgvCustomer.CurrentRow.Cells["intCustomerId"].Value;

                txtFirstName.Text = (string)dgvCustomer.CurrentRow.Cells["strFirstName"].Value;
                txtLastName.Text = (string)dgvCustomer.CurrentRow.Cells["strLastName"].Value;
                txtPhoneNumber.Text = (string)dgvCustomer.CurrentRow.Cells["strPhoneNumber"].Value;

                this.PopulatePackageGrid();
                this.EnableFields(true);
            }
        }

        private void dgvPackage_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPackage.CurrentRow.Index != -1)
            {
                btnRetrieve.Enabled = true;
            }
        }
        #endregion

        #region Methods
        private void ClearFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }

        private void EnableFields(bool ysnEnable)
        {
            btnAdd.Enabled = !ysnEnable;
            btnUpdate.Enabled = ysnEnable;
            btnDelete.Enabled = ysnEnable;
            btnStore.Enabled = ysnEnable;
            btnReserve.Enabled = ysnEnable;
            cmbCategory.Enabled = ysnEnable;
            cmbFacility.Enabled = ysnEnable;
        }

        private void PopulateCustomerGrid()
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = _customerSvc.GetAll();
        }

        private void PopulatePackageGrid()
        {
            if (dgvCustomer.CurrentRow.Index != -1)
            {
                int intCustomerId = (int)dgvCustomer.CurrentRow.Cells["intCustomerId"].Value;
                int intFacilityId = cmbFacility.SelectedValue.GetType() != typeof(Int32) ? 0 : (int)cmbFacility.SelectedValue;

                if (intFacilityId == 0)
                    return;

                dgvPackage.AutoGenerateColumns = false;
                dgvPackage.DataSource = _packageSvc.SearchPackages(intCustomerId, intFacilityId);
            }
        }

        private void PopulateCategory()
        {
            cmbCategory.DataSource = _categorySvc.GetAll();
            cmbCategory.DisplayMember = "strCategory";
            cmbCategory.ValueMember = "intCategoryId";
        }

        private void PopulateFacility()
        {
            cmbFacility.DataSource = _facilitySvc.GetAll();
            cmbFacility.DisplayMember = "strFacilityName";
            cmbFacility.ValueMember = "intFacilityId";
        }

        private void PopulateFacilityGrid()
        {
            dgvFacility.AutoGenerateColumns = false;
            dgvFacility.DataSource = _facilitySvc.SearchFacilities();
        }

        public void GetAvailableSlots()
        {
            try
            {
                int intFacilityId = cmbFacility.SelectedValue.GetType() != typeof(Int32) ? 0 : (int)cmbFacility.SelectedValue;

                if (intFacilityId == 0)
                    return;

                List<AvailableSlotView> slots = _categorySvc.GetAvailableSlots(intFacilityId);

                if (slots != null && slots.Count() > 0)
                {
                    foreach (AvailableSlotView slot in slots)
                    {
                        switch (slot.strCategory.ToUpper())
                        {
                            case "SMALL":
                                txtSmall.Text = slot.intAvailable.ToString();
                                break;
                            case "MEDIUM":
                                txtMedium.Text = slot.intAvailable.ToString();
                                break;
                            case "LARGE":
                                txtLarge.Text = slot.intAvailable.ToString();
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void cmbFacility_SelectedValueChanged(object sender, EventArgs e)
        {
            this.GetAvailableSlots();
            this.PopulatePackageGrid();
        }
    }
}
