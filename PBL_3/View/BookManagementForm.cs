using PBL_3.BLL;
using PBL_3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL_3
{
    public partial class BookManagementForm : Form
    {
        bool isClickAdd = false;
        bool isClickCategory = false;
        bool isClickUpdate = false;
        bool isClickDelete = false;
        int numberpage = 1;
        int numberrecord =50;

        string title;
        string author;
        string idcategory;
        string publishyear;
        public BookManagementForm()
        {
            InitializeComponent();
            LoadForm();
            LoadDGV();
          
        }

        public void LoadDeleteDGV(string title, string author, int publishYear)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            deleteDGV.DataSource = bll.deleteList(title, author, publishYear);
        }
        public void LoadDGV()
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            catalogDGV.DataSource = bll.loadRecord(numberpage, numberrecord);

            catalogDGV.Columns[0].HeaderText = "TITLE";
            catalogDGV.Columns[1].HeaderText = "AUTHOR";
            catalogDGV.Columns[2].HeaderText = "CATEGORY";
            catalogDGV.Columns[3].HeaderText = "PUBLISH YEAR";
            catalogDGV.Columns[4].HeaderText = "LOCATION";
            catalogDGV.Columns[5].HeaderText = "QUANTITY";
            catalogDGV.Columns[6].HeaderText = "BORROWABLE";

            catalogDGV.Columns[3].Width = 150;
            catalogDGV.Columns[4].Width = 100;
            catalogDGV.Columns[5].Width = 100;
            catalogDGV.Columns[6].Width = 165;
        }
       
        public void DisplaySearchResultTitle(string Title)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            catalogDGV.DataSource = bll.SearchBookByTitle(Title);
            catalogDGV.Columns[0].HeaderText = "TITLE";
            catalogDGV.Columns[1].HeaderText = "AUTHOR";
            catalogDGV.Columns[2].HeaderText = "CATEGORY";
            catalogDGV.Columns[3].HeaderText = "PUBLISH YEAR";
            catalogDGV.Columns[4].HeaderText = "LOCATION";
            catalogDGV.Columns[5].HeaderText = "QUANTITY";
            catalogDGV.Columns[6].HeaderText = "BORROWABLE";
        }
        public void DisplaySearchResultAuthor(string author)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            catalogDGV.DataSource = bll.searchbookbyAuthor(author);
            catalogDGV.Columns[0].HeaderText = "TITLE";
            catalogDGV.Columns[1].HeaderText = "AUTHOR";
            catalogDGV.Columns[2].HeaderText = "CATEGORY";
            catalogDGV.Columns[3].HeaderText = "PUBLISH YEAR";
            catalogDGV.Columns[4].HeaderText = "LOCATION";
            catalogDGV.Columns[5].HeaderText = "QUANTITY";
            catalogDGV.Columns[6].HeaderText = "BORROWABLE";
        }
        public void DisplaySearchResultCategory(string category)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            catalogDGV.DataSource = bll.searchbookbycategory(category);
            catalogDGV.Columns[0].HeaderText = "TITLE";
            catalogDGV.Columns[1].HeaderText = "AUTHOR";
            catalogDGV.Columns[2].HeaderText = "CATEGORY";
            catalogDGV.Columns[3].HeaderText = "PUBLISH YEAR";
            catalogDGV.Columns[4].HeaderText = "LOCATION";
            catalogDGV.Columns[5].HeaderText = "QUANTITY";
            catalogDGV.Columns[6].HeaderText = "BORROWABLE";
        }
        public void DisplaySearchResultPublishYear(int publish_Year)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            catalogDGV.DataSource = bll.searchbookbyPublishYear(publish_Year);
            catalogDGV.Columns[0].HeaderText = "TITLE";
            catalogDGV.Columns[1].HeaderText = "AUTHOR";
            catalogDGV.Columns[2].HeaderText = "CATEGORY";
            catalogDGV.Columns[3].HeaderText = "PUBLISH YEAR";
            catalogDGV.Columns[4].HeaderText = "LOCATION";
            catalogDGV.Columns[5].HeaderText = "QUANTITY";
            catalogDGV.Columns[6].HeaderText = "BORROWABLE";
        }
        public void LoadForm()
        {
            addPanel.Visible = false;
            addcategorypanel.Visible = false;
            deletePanel.Visible = false;

            catalogPanel.Size = new System.Drawing.Size(1510, 600);
            catalogDGV.Size = new System.Drawing.Size(1445, 497);
            updateBtn.Location = new Point(1191, 10);
            deleteBtn.Location = new Point(1348, 10);

            titleTxt.Text = "";
            authorTxt.Text = "";
            cbbCategory.Text = "";
            yearTxt.Text = "";
            categoryNameTxt.Text = "";
            categoryNumberdayTxt.Text = "";
            categoryLocationTxt.Text = "";

            bookTiltleError.Visible = false;
            bookAuthorError.Visible = false;
            bookCategoryError.Visible = false;
            bookYearError.Visible = false;

            categoryNameError.Visible = false;
            categoryDayError.Visible = false;
            categoryLocationError.Visible = false;

        }
        public void loadCategoryCbb()
        {
            cbbCategory.Items.Clear();
            BookManagement_BLL bll = new BookManagement_BLL();
            if (bll.GetCategoryCBBItems() != null)
            {
                foreach (CategoryCBBItem i in bll.GetCategoryCBBItems())
                {
                    cbbCategory.Items.Add(new CategoryCBBItem
                    {
                        id = i.id,
                        name = i.name
                    });
                }
                cbbCategory.DisplayMember = "Name";
            }
        }
        public void ShowCategoryBar()
        {
            catalogPanel.Size = new System.Drawing.Size(1205, 600);
            addcategorypanel.Visible = true;
            catalogDGV.Size = new System.Drawing.Size(1135, 497);
            updateBtn.Location = new Point(881, 10);
            deleteBtn.Location = new Point(1038, 10);
        }
        public void ShowAddBar()
        {
            catalogPanel.Size = new System.Drawing.Size(1205, 600);
            addPanel.Visible = true;
            catalogDGV.Size = new System.Drawing.Size(1135, 497);
            updateBtn.Location = new Point(881, 10);
            deleteBtn.Location = new Point(1038, 10);
            loadCategoryCbb();
        }


        public void ShowDeleteBar()
        {
            catalogPanel.Size = new System.Drawing.Size(1205, 600);
            deletePanel.Visible = true;
            catalogDGV.Size = new System.Drawing.Size(1135, 497);
            updateBtn.Location = new Point(881, 10);
            deleteBtn.Location = new Point(1038, 10);
        }

        private void saveBookBtn_Click(object sender, EventArgs e)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            bool valid = true;
            int number;

            if (titleTxt.Text.Length == 0)
            {
                bookTiltleError.Text = "Fill information!";
                bookTiltleError.Visible = true;
                valid = false;
            }

            if (titleTxt.Text.Length != 0 && panelLb.Text.Equals("Add Category") && bll.isInexistCategory(titleTxt.Text))
            {
                bookTiltleError.Text = "Exist category!";
                bookTiltleError.Visible = true;
                valid = false;
            }

            if (authorTxt.Text.Length == 0)
            {
                bookAuthorError.Visible = true;
                valid = false;
            }

            if (cbbCategory.Text.Length == 0)
            {
                bookYearError.Text = "Fill information!";
                bookCategoryError.Visible = true;
                valid = false;
            }

            if (yearTxt.Text.Length == 0)
            {
                bookYearError.Text = "Fill information!";
                bookYearError.Visible = true;
                valid = false;
            }

            if (yearTxt.Text.Length != 0)
            {
                if (!int.TryParse(yearTxt.Text, out number))
                {
                    bookYearError.Text = "Invalid value";
                    bookYearError.Visible = true;
                    valid = false;
                }
            }

            if(panelLb.Text != "Update Book")
            {

                if (quantityTxt.Text.Length == 0)
                {
                    quantityError.Location = new Point(180, 301);
                    quantityError.Text = "Fill information!";
                    quantityError.Visible = true;
                    valid = false;
                }
                else
                {
                    if (!int.TryParse(quantityTxt.Text, out number))
                    {
                        quantityError.Location = new Point(180, 301);
                        quantityError.Text = "Invalid value";
                        quantityError.Visible = true;
                        valid = false;
                    }
                    else if(Convert.ToInt32(quantityTxt.Text) <= 0)
                    {
                        quantityError.Location = new Point(110, 301);
                        quantityError.Text = "Quantity must be greater than 0";
                        quantityError.Visible = true;
                        valid = false;
                    }
                }
            }

            if (valid == true)
            {

                if (panelLb.Text.Equals("Add Book"))
                {
                    bll.AddBook(Convert.ToInt32(quantityTxt.Text),titleTxt.Text, authorTxt.Text, cbbCategory.SelectedItem.ToString(), Convert.ToInt32(yearTxt.Text));
                }
                else
                {
                    bll.UpdateBook(title, author, idcategory, Convert.ToInt32(publishyear) ,titleTxt.Text, authorTxt.Text, cbbCategory.SelectedItem.ToString(), Convert.ToInt32(yearTxt.Text));
                    LoadForm();
                }
                LoadDGV();
                quantityTxt.Text = "";
                titleTxt.Text = "";
                authorTxt.Text = "";
                cbbCategory.SelectedIndex = -1;
                yearTxt.Text = "";

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isClickAdd == false)
            {
                LoadForm();
                isClickCategory = false;
                isClickUpdate = false;
                panelLb.Location = new Point(44, 55);
                panelLb.Text = "Add Book";
                ShowAddBar();
                isClickAdd = true;
                isClickDelete = false;
            }
            else
            {
                LoadForm();
                isClickAdd = false;
            }
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            if (isClickCategory == false)
            {
                LoadForm();
                isClickAdd = false;
                isClickUpdate = false;
                ShowCategoryBar();
                isClickCategory = true;
                isClickDelete = false;
            }
            else
            {
                LoadForm();
                isClickCategory = false;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (catalogDGV.SelectedRows.Count == 1)
            {
                if (isClickDelete == false)
                {
                    string title = catalogDGV.SelectedRows[0].Cells[0].Value.ToString();
                    string author = catalogDGV.SelectedRows[0].Cells[1].Value.ToString();
                    int publishyear = Convert.ToInt32(catalogDGV.SelectedRows[0].Cells[3].Value.ToString());
                    LoadDeleteDGV(title, author, publishyear);
                    LoadForm();
                    isClickAdd = false;
                    isClickUpdate = false;
                    isClickCategory = false;
                    ShowDeleteBar();
                    isClickDelete = true;
                }
                else
                {
                    LoadForm();
                    isClickDelete = false;
                }
            }
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (catalogDGV.SelectedRows.Count == 1)
            {
                if (isClickUpdate == false)
                {
                    LoadForm();
                    isClickAdd = false;
                    isClickCategory = false;
                    panelLb.Location = new Point(10, 55);
                    panelLb.Text = "Update Book";
                    ShowAddBar();
                    isClickUpdate = true;

                    quantityTxt.Visible = false;
                    quantityError.Visible = false;

                    titleTxt.Text = catalogDGV.SelectedRows[0].Cells[0].Value.ToString();
                    authorTxt.Text = catalogDGV.SelectedRows[0].Cells[1].Value.ToString();
                    cbbCategory.Text = catalogDGV.SelectedRows[0].Cells[2].Value.ToString();
                    yearTxt.Text = catalogDGV.SelectedRows[0].Cells[3].Value.ToString();

                    title = titleTxt.Text;
                    author = authorTxt.Text;
                    idcategory = cbbCategory.SelectedItem.ToString();
                    publishyear = yearTxt.Text;

                }
                else
                {
                    LoadForm();
                    isClickUpdate = false;
                    titleTxt.Text = "";
                    authorTxt.Text = "";
                    cbbCategory.SelectedIndex = -1;
                    yearTxt.Text = "";
                }
            }
        }
        
        private void SaveCategoryBtn_Click(object sender, EventArgs e)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            categoryNameError.Text = "Fill information!";

            bool valid = true;
            if (categoryNameTxt.Text.Length == 0)
            {
                categoryNameError.Visible = true;
                valid = false;
            }

            if (categoryNumberdayTxt.Text.Length == 0)
            {
                categoryDayError.Visible = true;
                valid = false;
            }

            if (categoryLocationTxt.Text.Length == 0)
            {
                categoryLocationError.Visible = true;
                valid = false;
            }
            if (categoryNameTxt.Text.Length != 0 && !bll.isInexistCategory(categoryNameTxt.Text))
            {
                categoryNameError.Text = "Exist category!";
                categoryNameError.Visible = true;
                valid = false;
            }
            if (valid == true)
            {
                bll.AddCategory(categoryNameTxt.Text, categoryNumberdayTxt.Text, categoryLocationTxt.Text);
                categoryNameTxt.Text = "";
                categoryNumberdayTxt.Text = "";
                categoryLocationTxt.Text = "";
            }
        }

        private void quantityTxt_Click(object sender, EventArgs e)
        {
            quantityError.Visible = false;
        }

        private void titleTxt_Click(object sender, EventArgs e)
        {
            bookTiltleError.Visible = false;
        }

        private void authorTxt_TextChanged(object sender, EventArgs e)
        {
            bookAuthorError.Visible = false;
        }

        private void cbbCategory_Click(object sender, EventArgs e)
        {
            bookCategoryError.Visible = false;
        }

        private void yearTxt_Click(object sender, EventArgs e)
        {
            bookYearError.Visible = false;
        }

        private void categoryNameTxt_Click(object sender, EventArgs e)
        {
            categoryNameError.Visible = false;
        }

        private void categoryNumberdayTxt_Click(object sender, EventArgs e)
        {
            categoryDayError.Visible = false;
        }

        private void categoryLocationTxt_Click(object sender, EventArgs e)
        {
            categoryLocationError.Visible = false;
        }

        private void listSearchCb_Click(object sender, EventArgs e)
        {
            listSearchCb.Items.Clear();
            listSearchCb.Items.Add("Title");
            listSearchCb.Items.Add("Author");
            listSearchCb.Items.Add("Category");
            listSearchCb.Items.Add("Publish year");
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
           
            int publish_year;
            if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Title")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Title = searchTxt.Text;
                   DisplaySearchResultTitle(Title);
                }
                else
                {
                    LoadDGV();
                }
            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Author")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string author = searchTxt.Text;
                    DisplaySearchResultAuthor(author);
                }
                else
                {
                    LoadDGV();
                }

            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Category")
            {
                if (!string.IsNullOrEmpty(searchTxt.Text))
                {
                    string Category = searchTxt.Text;
                    DisplaySearchResultCategory(Category);
                }
                else
                {
                    LoadDGV();
                }
            }
            else if (listSearchCb != null && listSearchCb.SelectedItem.ToString() == "Publish year")
            {
                if (int.TryParse(searchTxt.Text, out publish_year))
                {
                    DisplaySearchResultPublishYear(publish_year);
                }
                else
                {
                        LoadDGV();
                }
            }
        }

        private void searchTxt_Click(object sender, EventArgs e)
        {
            searchTxt.Enabled = !string.IsNullOrEmpty(listSearchCb.Text);
            if (!searchTxt.Enabled)
            {
                MessageBox.Show("Please select search object", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void listSearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSearchCb.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(listSearchCb.Text))
                {
                    searchTxt.Enabled = true;
                }
            }
        }

        private void deleteBarBtn_Click(object sender, EventArgs e)
        {
            if (deleteDGV.SelectedRows.Count > 0)
            {
                BookManagement_BLL bll = new BookManagement_BLL();

                DialogResult result = MessageBox.Show("If deleting those books, you will maybe lost some important information about lended book.\nWill you want to continue?", "Delete warning", MessageBoxButtons.YesNo);
                foreach (DataGridViewRow i in deleteDGV.SelectedRows)
                {
                    if (result == DialogResult.Yes)
                    {
                        bll.deleteBook(i.Cells[0].Value.ToString());
                    }
                }
                LoadDGV();
                LoadForm();
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            
            BookManagement_BLL bll = new BookManagement_BLL();
            if (numberpage -1 > 0)
            {
                numberpage--;
                catalogDGV.DataSource = bll.loadRecord(numberpage, numberrecord);
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            BookManagement_BLL bll = new BookManagement_BLL();
            if (numberpage - 1 < bll.count(numberrecord))
            {
                numberpage++;
                catalogDGV.DataSource = bll.loadRecord(numberpage, numberrecord);

            }

        }

        
    }
}

