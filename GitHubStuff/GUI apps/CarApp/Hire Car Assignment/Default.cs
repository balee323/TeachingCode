using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
namespace Hire_Car_Assignment
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            ListCompanies();
            CarReadOnly();
            CompReadOnly();
            GrpSearchTest.Visible = false;
        }

        //Text File Location
        public string Input = @"input.txt";

        public string Out, SearchOut;
        public static int SelectedCompany, SelectedCar;
        //Car ArrayList
        ArrayList CompanyArrayList = new ArrayList();
        //Listbox Ints 
        string output;
        //Class and ArrayList
        Company tempCOMP;
        Car tempCAR;
        ArrayList carStore, tempStore;
        
        
        
        private void CompanyLoad()
        {

            //loads Company Details
            StreamReader read = new StreamReader(Input);
            CompanyArrayList.Clear();
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
                carStore = new ArrayList();
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
                    carStore.Add(RentalCar); 
                }
                //Adding to Array
                RentalCompany.setCars(carStore);
                CompanyArrayList.Add(RentalCompany);
            }                
            read.Close();
        }
        private void ListCompanies()
        {
            //List Companies into the ListBox
            
            CompanyLoad();
            LstCompany.Items.Clear();
            output = "";
            //Adds to Listbox
            foreach (Company C in CompanyArrayList)
            {
                output = string.Format("ID: {0}, Name: {1}," ,C.getID(), C.getCompanyName());
                LstCompany.Items.Add(output);
            }
            //Selects frist item in the listbox
            if(LstCompany.Items.Count > 0)
            {
                LstCompany.SelectedIndex = 0;
            }
            //if listbox is empty it clears Textboxes
            else
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
        private void ListCars()
        {
            if (LstCompany.SelectedIndex >= 0)
            {
                //List the Cars for each Company
                tempCOMP = (Company)CompanyArrayList[SelectedCompany];
                LstCars.Items.Clear();
                foreach (Car A in tempCOMP.getCars())
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
                Company tempCOMP = (Company)CompanyArrayList[SelectedCompany];
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
                tempCOMP = (Company)CompanyArrayList[SelectedCompany];
                ArrayList tempStore = new ArrayList();
                foreach (Car A in tempCOMP.getCars())
                {
                    tempStore.Add(A);
                }
                Car tempCar = (Car)tempStore[SelectedCar];
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
            StreamWriter Write = new StreamWriter(Input);
            foreach (Company C in CompanyArrayList)
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
                Company tempCOMP = (Company)CompanyArrayList[SelectedCompany];
                foreach(Car A in tempCOMP.getCars())
                {
                    TempCar.Add(A);
                }
                Temp.setCars(TempCar);
                Temp.setNumCars(TempCar.Count);
                CompanyArrayList.RemoveAt(SelectedCompany);
                CompanyArrayList.Insert(SelectedCompany, Temp);
            }
            else
            {
                //Adding a new Car
                Temp.setCars(TempCar);
                Temp.setNumCars(TempCar.Count);
                CompanyArrayList.Add(Temp);
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
                tempCOMP = (Company)CompanyArrayList[SelectedCompany];
                tempStore = new ArrayList();
                tempCAR = new Car();
                //Sets the Car class detailds from the text file
                try
                {
                    tempCAR.setCarID(Convert.ToInt32(TxtCarID.Text));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Values!");
                    return;
                }
                tempCAR.setMake(TxtCarMake.Text);
                tempCAR.setReg(TxtCarReg.Text);
                tempCAR.setFuel(TxtCarFuel.Text);
                tempCAR.setServiceDate(TxtCarService.Text);
                tempCAR.setComments(TxtComments.Text);
                //Populates tempStore with the Companies cars
                foreach (Car C in tempCOMP.getCars())
                {
                    tempStore.Add(C);
                }

                if (LstCars.SelectedIndex < 0)
                {
                    //Adds a new car
                    tempCOMP.setNumCars(tempCOMP.getCarNumbers() + 1);
                    tempStore.Add(tempCAR);
                }
                else
                {
                    //updates a Car
                    tempStore.RemoveAt(SelectedCar);
                    tempStore.Insert(SelectedCar, tempCAR);
                }
                //updates the Orginal Arraylist
                tempCOMP.setCars(tempStore);
                CompanyArrayList.RemoveAt(SelectedCompany);
                CompanyArrayList.Insert(SelectedCompany, tempCOMP);
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
                    tempCOMP = (Company)CompanyArrayList[SelectedCompany];
                    ArrayList tempStore = new ArrayList();
                    foreach (Car A in tempCOMP.getCars())
                    {
                        tempStore.Add(A);
                    }
                    //Modifies the duplicate arraylist
                    tempStore.RemoveAt(SelectedCar);
                    //Updates the orginal Arraylist
                    tempCOMP.setCars(tempStore);
                    tempCOMP.setNumCars(tempStore.Count);
                    CompanyArrayList.RemoveAt(SelectedCompany);
                    CompanyArrayList.Insert(SelectedCompany, tempCOMP);
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
            foreach (Company C in CompanyArrayList)
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

        //Buttons

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
            SelectedCompany = LstCompany.SelectedIndex;
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

       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
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

        private void LstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCar = LstCars.SelectedIndex;
            CarDetails();
        }
    }

}