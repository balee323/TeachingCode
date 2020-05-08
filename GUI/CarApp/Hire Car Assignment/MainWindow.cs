using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Hire_Car_Assignment
{
    public partial class MainWindow : Form
    {
        //Text File Location
        private string _dataFile = @"DataFile.txt";
        private static int _selectedCompany, _selectedCar;
        //Car ArrayList
        private ArrayList _companyArrayList = new ArrayList();
        private string _output;
        private Company _tempCOMP;
        private Car _tempCAR;
        private ArrayList _carStore, _tempStore;

        //Constructor
        public MainWindow()
        {
            InitializeComponent(); //Call to other partial class
            ListCompanies();
            CarReadOnly();
            CompReadOnly();
        }

        #region Private Methods

        private void ListCompanies()
        {        
            CompanyLoad();

            LstCompany.Items.Clear();
            _output = "";
            //Add Companies to ListBox
            foreach (Company C in _companyArrayList)
            {
                _output = string.Format("ID: {0}, Name: {1}," , C.getID(), C.getCompanyName());
                LstCompany.Items.Add(_output);
            }

            //Selects frist item in the listbox
            if(LstCompany.Items.Count > 0)
            {
                LstCompany.SelectedIndex = 0;
            }
            else //it clears Textboxes
            {   
                LstCompany.SelectedIndex = -1;

                TxtCompID.Text = null;
                txtCompName.Text = null;
                txtCompPostcode.Text = null;
                TxtCompAddress.Text = null;
                txtCompCars.Text = "0";
                LstCars.Items.Clear();
                ListCars();
            }            
        }


        private void CarReadOnly()
        {
            TxtCarID.ReadOnly = true;
            TxtCarMake.ReadOnly = true;
            TxtCarReg.ReadOnly = true;
            TxtCarFuel.ReadOnly = true;
            TxtCarService.ReadOnly = true;
            TxtComments.ReadOnly = true;
        }


        private void CompReadOnly()
        {
            TxtCompID.ReadOnly = true;
            txtCompName.ReadOnly = true;
            txtCompPostcode.ReadOnly = true;
            txtCompCars.ReadOnly = true;
            TxtCompAddress.ReadOnly = true;
        }


        private void CompanyLoad()
        {

            //loads Company Details from file
            StreamReader read = new StreamReader(_dataFile);
            _companyArrayList.Clear();

            while (!read.EndOfStream)
            {
                //Creating Company
                Company RentalCompany = new Company();
                //getting Company Info
                RentalCompany.setID(Convert.ToInt32(read.ReadLine()));
                RentalCompany.setCompanyName(read.ReadLine());
                RentalCompany.setAddress(read.ReadLine());
                RentalCompany.setPostcode(read.ReadLine());
                RentalCompany.setNumCars(Convert.ToInt32(read.ReadLine()));
                //Getting Car Info
                _carStore = new ArrayList();

                for (int i = 0; i < RentalCompany.getCarNumbers(); i++)
                {
                    //geting cars
                    Car RentalCar = new Car();
                    RentalCar.setCarID(Convert.ToInt32(read.ReadLine()));
                    RentalCar.setMake(read.ReadLine());
                    RentalCar.setReg(read.ReadLine());
                    RentalCar.setFuel(read.ReadLine());
                    RentalCar.setServiceDate(read.ReadLine());
                    RentalCar.setComments(read.ReadLine());
                    _carStore.Add(RentalCar);
                }
                //Adding to Array
                RentalCompany.setCars(_carStore);
                _companyArrayList.Add(RentalCompany);
            }
            read.Close();
        }


        private void ListCars()
        {
            if (LstCompany.SelectedIndex >= 0)
            {
                //List the Cars for each Company
                _tempCOMP = (Company)_companyArrayList[_selectedCompany];
                LstCars.Items.Clear();
                foreach (Car A in _tempCOMP.getCars())
                {
                    LstCars.Items.Add(A.getMake().ToUpper());

                }
                //prints a message if Company has no Cars
                if (LstCars.Items.Count == 0)
                {                    
                   
                    MessageBox.Show("No Cars are Listed for that Company");
                }
                else
                {
                    LstCars.SelectedIndex = 0;
                }

            }
            if (LstCars.Items.Count == 0)
            {
                TxtCarID.Text = null;
                TxtCarMake.Text = null;
                TxtCarReg.Text = null;
                TxtCarFuel.Text = null;
                TxtCarService.Text = null;
                TxtComments.Text = null;
            }
            }        


        private void CompanyDetails()
        {
            //Enters Company Details into TextBox
            if (LstCompany.SelectedIndex > -1)
            {
                Company tempCOMP = (Company)_companyArrayList[_selectedCompany];
                TxtCompID.Text = tempCOMP.getID().ToString();
                txtCompName.Text = tempCOMP.getCompanyName();
                TxtCompAddress.Text = tempCOMP.getAddress();
                txtCompPostcode.Text = tempCOMP.getPostcode();
                txtCompCars.Text = tempCOMP.getCarNumbers().ToString();
            }
        }


        private void CarDetails()
        {
            //Enters Car details into the textbox
            if (LstCars.SelectedIndex > -1)
            {
                _tempCOMP = (Company)_companyArrayList[_selectedCompany];
                ArrayList tempStore = new ArrayList();
                foreach (Car A in _tempCOMP.getCars())
                {
                    tempStore.Add(A);
                }
                Car tempCar = (Car)tempStore[_selectedCar];
                TxtCarID.Text = tempCar.getCarID().ToString();
                TxtCarMake.Text = tempCar.getMake();
                TxtCarReg.Text = tempCar.getReg();
                TxtCarFuel.Text = tempCar.getFuel();
                TxtCarService.Text = tempCar.getService();
                TxtComments.Text = tempCar.getComments();
            }
        }


        private void OutputWrite()
        {
            //Writes to File
            StreamWriter Write = new StreamWriter(_dataFile);
            foreach (Company C in _companyArrayList)
            {
                //Writes the Company details
                Write.WriteLine(C.getID());
                Write.WriteLine(C.getCompanyName());
                Write.WriteLine(C.getAddress());
                Write.WriteLine(C.getPostcode());
                Write.WriteLine(C.getCarNumbers());
                
                foreach (Car A in C.getCars())
                {
                    //Writes the Car details
                    Write.WriteLine(A.getCarID());
                    Write.WriteLine(A.getMake());
                    Write.WriteLine(A.getReg());
                    Write.WriteLine(A.getFuel());
                    Write.WriteLine(A.getService());
                    Write.WriteLine(A.getComments());

                }
            }
            Write.Close();
        }


        private void ToggleCarEdit()
        {       
            if(LstCompany.SelectedIndex > -1)
            {
                TxtCarID.ReadOnly = false;
                TxtCarMake.ReadOnly = false;
                TxtCarReg.ReadOnly = false;
                TxtCarFuel.ReadOnly = false;
                TxtCarService.ReadOnly = false;
                TxtComments.ReadOnly = false;
                BtnAddCar.Enabled = false;
            }
        }                


        private void ToggleCompEdit()
        {
            TxtCompID.ReadOnly = false;
            txtCompName.ReadOnly = false;
            txtCompPostcode.ReadOnly = false;
            TxtCompAddress.ReadOnly = false;
        }


        private void SaveCompany()
        {
            //creates a temp company and adds details from the Textboxes
            Company Temp = new Company();
            ArrayList TempCar = new ArrayList();
            try
            {
                Temp.setID(Convert.ToInt32(TxtCompID.Text));
            }
            catch 
            {
                MessageBox.Show("Please Enter Correct Values!");
                return;
            }
            Temp.setCompanyName(txtCompName.Text);
            Temp.setAddress(TxtCompAddress.Text);
            Temp.setPostcode(txtCompPostcode.Text);
            
            
            if (LstCompany.SelectedIndex > -1)
            {
                //Updating a Company
                Company tempCOMP = (Company)_companyArrayList[_selectedCompany];
                foreach(Car A in tempCOMP.getCars())
                {
                    TempCar.Add(A);
                }
                Temp.setCars(TempCar);
                Temp.setNumCars(TempCar.Count);
                _companyArrayList.RemoveAt(_selectedCompany);
                _companyArrayList.Insert(_selectedCompany, Temp);
            }
            else
            {
                //Adding a new Car
                Temp.setCars(TempCar);
                Temp.setNumCars(TempCar.Count);
                _companyArrayList.Add(Temp);
            }        

            //Writing to file
            OutputWrite();
            ListCompanies();
            LstCompany.SelectedIndex = 0;
            MessageBox.Show("Saved!");
        }


        private void SaveCar()
        {
            if (LstCompany.SelectedIndex > -1)
            {
                //Creates a duplicate Company
                _tempCOMP = (Company)_companyArrayList[_selectedCompany];
                _tempStore = new ArrayList();
                _tempCAR = new Car();
                //Sets the Car class detailds from the text file
                try
                {
                    _tempCAR.setCarID(Convert.ToInt32(TxtCarID.Text));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Values!");
                    return;
                }
                _tempCAR.setMake(TxtCarMake.Text);
                _tempCAR.setReg(TxtCarReg.Text);
                _tempCAR.setFuel(TxtCarFuel.Text);
                _tempCAR.setServiceDate(TxtCarService.Text);
                _tempCAR.setComments(TxtComments.Text);
                //Populates tempStore with the Companies cars
                foreach (Car C in _tempCOMP.getCars())
                {
                    _tempStore.Add(C);
                }

                if (LstCars.SelectedIndex < 0)
                {
                    //Adds a new car
                    _tempCOMP.setNumCars(_tempCOMP.getCarNumbers() + 1);
                    _tempStore.Add(_tempCAR);
                }
                else
                {
                    //updates a Car
                    _tempStore.RemoveAt(_selectedCar);
                    _tempStore.Insert(_selectedCar, _tempCAR);
                }
                //updates the Orginal Arraylist
                _tempCOMP.setCars(_tempStore);
                _companyArrayList.RemoveAt(_selectedCompany);
                _companyArrayList.Insert(_selectedCompany, _tempCOMP);
                //writes to file
                OutputWrite();
                ListCars();
                MessageBox.Show("Car Saved");
                CarReadOnly();
            }
        }


        private void CarAdd()
        {
            if (LstCompany.SelectedIndex > -1)
            {
                TxtCarID.Text = null;
                TxtCarMake.Text = null;
                TxtCarReg.Text = null;
                TxtCarFuel.Text = null;
                TxtCarService.Text = null;
                TxtComments.Text = null;

                TxtCarID.ReadOnly = false;
                TxtCarMake.ReadOnly = false;
                TxtCarReg.ReadOnly = false;
                TxtCarFuel.ReadOnly = false;
                TxtCarService.ReadOnly = false;
                TxtComments.ReadOnly = false;
                LstCars.SelectedIndex = -1;

                BtnEditCar.Enabled = false;
                BtnDeleteCar.Enabled = false;
            }
        }


        private void CompanyAdd()
        {
            TxtCompID.Text = null;
            txtCompName.Text = null;
            txtCompPostcode.Text = null;
            TxtCompAddress.Text = null;
            txtCompCars.Text = "0";

            TxtCompID.ReadOnly = false;
            txtCompName.ReadOnly = false;
            txtCompPostcode.ReadOnly = false;
            TxtCompAddress.ReadOnly = false;
            LstCompany.SelectedIndex = -1;
        }


        private void CarDelete()
        {
            //Deletes Selected Car
            if (LstCars.SelectedIndex > -1)
            {
                DialogResult results = MessageBox.Show("Are you sure?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    //Creates a duplicate arraylist of Cars
                    _tempCOMP = (Company)_companyArrayList[_selectedCompany];
                    ArrayList tempStore = new ArrayList();
                    foreach (Car A in _tempCOMP.getCars())
                    {
                        tempStore.Add(A);
                    }
                    //Modifies the duplicate arraylist
                    tempStore.RemoveAt(_selectedCar);
                    //Updates the orginal Arraylist
                    _tempCOMP.setCars(tempStore);
                    _tempCOMP.setNumCars(tempStore.Count);
                    _companyArrayList.RemoveAt(_selectedCompany);
                    _companyArrayList.Insert(_selectedCompany, _tempCOMP);
                    //Writes to File
                    OutputWrite();
                    CompanyLoad();
                    MessageBox.Show("Car Deleted");
                    //Updates Listboxes
                    ListCars();
                }
            }
        }


        private void search()
        {
            //Shows and Adds Columns to DataGrid
            if (GrpSearchTest.Visible == false)
            {
                GrpSearchTest.Visible = true;
                if (dataGridView1.Columns.Count < 2)
                {
                    dataGridView1.Columns.Add("newColumnName", "COMPANY NAME");
                    dataGridView1.Columns.Add("newColumnName", "CAR MAKE");
                }
            }
            dataGridView1.Rows.Clear();
            //Populates the Datagrid
            foreach (Company C in _companyArrayList)
            {
                foreach (Car A in C.getCars())
                {
                    //Checks to see if Company details matches the textbox
                    if (C.compsearch().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        //Adds to the DataGrid if matches
                        dataGridView1.Rows.Add(C.getCompanyName().ToUpper(), A.getMake().ToUpper());
                    }
                    //Checks to see if Car Details matches the textbox
                    else if (A.getCar().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {                        
                        dataGridView1.Rows.Add(C.getCompanyName().ToUpper(), A.getMake().ToUpper());
                    }
                }
            }
        }

        #endregion

        #region Buttons

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnAdd.Enabled = false;
            ToggleCompEdit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BtnEdit.Enabled = false;
            CompanyAdd();
        }

        private void LstCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCompany = LstCompany.SelectedIndex;
            ListCars();
            CompanyDetails();
        }

        private void BtnEditCar_Click(object sender, EventArgs e)
        {
            
            ToggleCarEdit();
        }

        private void BtnCarCancle_Click(object sender, EventArgs e)
        {
            BtnDeleteCar.Enabled = true;
            BtnAddCar.Enabled = true;
            BtnEditCar.Enabled = true;
            ListCars();
            CarReadOnly();
        }

        private void BtnSaveCar_Click(object sender, EventArgs e)
        {
            BtnDeleteCar.Enabled = true;
            BtnAddCar.Enabled = true;
            BtnEditCar.Enabled = true;
            SaveCar();
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            CarAdd();
        }
        

        private void BtnDeleteCar_Click(object sender, EventArgs e)
        {
            CarDelete();
        }
        

        private void BtnCompSave_Click(object sender, EventArgs e)
        {
            BtnEdit.Enabled = true;
            BtnAdd.Enabled = true;
            SaveCompany();
        }


        private void BtnHide_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            GrpSearchTest.Visible = false;
        }

        private void btnCompCancel_Click(object sender, EventArgs e)
        {
            BtnEdit.Enabled = true;
            BtnAdd.Enabled = true;
            CompReadOnly();
            ListCompanies();
        }

        #endregion

        #region Other Control Event Handlers

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            GrpSearchTest.Visible = false;
        }


        private void TxtCarID_TextChanged(object sender, EventArgs e)
        {
            int number1;
            //Creates a new Bool
            bool canConvert = int.TryParse(TxtCarID.Text, out number1);
            //Test if Text is a integer
            if (canConvert == false)
            {
                //Test if text isn't blank
                if (TxtCarID.Text != null)
                {
                    TxtCarID.Text = null;
                }
            }
        }


        private void TxtCompID_TextChanged(object sender, EventArgs e)
        {
            int number1;
            //Creates a new Bool
            bool canConvert = int.TryParse(TxtCompID.Text, out number1);
            //Test if Text is a integer
            if (canConvert == false)
            {
                //Test if text isn't blank
                if (TxtCompID.Text != null)
                {
                    TxtCompID.Text = null;
                }
            }
        }


        private void LstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCar = LstCars.SelectedIndex;
            CarDetails();
        }

        #endregion
    }
}