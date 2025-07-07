namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string accessKey = "1234";
        int foundIndex = -1;
        List<InventoryItem> inventoryList = new List<InventoryItem>
        {
            new InventoryItem("Bottle Rocket", "1234-5678", 15m, 100m, 50),
            new InventoryItem("TNT", "1000-1000", 100m, 90m, 1),
            new InventoryItem("Firecracker", "1111-2222", 100m, 50m, 200),
            new InventoryItem("Nuke", "1234-4321", 1000m, 800m, 1),
            new InventoryItem("Streamer", "4567-1234", 10m, 250m, 20),
        };


        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            string userSearch = txtSearchUPC.Text;
            bool found = false;

            for (int i = 0; i < inventoryList.Count; i++)
            {
                if (inventoryList[i].getUpc().ToLower().Contains(userSearch.ToLower()))
                {
                    found = true;
                    foundIndex = i;
                    lblName.Text = $"Name: {inventoryList[i].getItemName()}";
                    lblUPC.Text = $"UPC: {inventoryList[i].getUpc()}";
                    lblStorePrice.Text = $"Store Price: {inventoryList[i].getPrice():C}";
                    lblCostCase.Text = $"Cost per case: {inventoryList[i].getCostPerCase():C}";
                    lblUnitsCase.Text = $"Units per case: {inventoryList[i].getUnitsPerCase()}";
                    grpAdd.Visible = true;
                    grpChange.Visible = true;
                    grpDelete.Visible = true;
                    lblChangeError.Text = string.Empty;
                    lblErrorDelete.Text = string.Empty;
                    lblResult.Text = string.Empty;
                }
                if (!found)
                {
                    lblName.Text = "Item does not exist";
                    lblUPC.Text = string.Empty;
                    lblStorePrice.Text = string.Empty;
                    lblCostCase.Text = string.Empty;
                    lblUnitsCase.Text = string.Empty;
                    grpAdd.Visible = true;
                    grpChange.Visible = false;
                    grpDelete.Visible = false;
                    lblChangeError.Text = string.Empty;
                    lblErrorDelete.Text = string.Empty;
                    lblResult.Text = string.Empty;
                }
            }

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string userSearch = txtSearchName.Text;
            bool found = false;

            for (int i = 0; i < inventoryList.Count; i++)
            {
                if (inventoryList[i].getItemName().ToLower().Contains(userSearch.ToLower()))
                {
                    found = true;
                    foundIndex = i;
                    lblName.Text = $"Name: {inventoryList[i].getItemName()}";
                    lblUPC.Text = $"UPC: {inventoryList[i].getUpc()}";
                    lblStorePrice.Text = $"Store Price: {inventoryList[i].getPrice():C}";
                    lblCostCase.Text = $"Cost per case: {inventoryList[i].getCostPerCase():C}";
                    lblUnitsCase.Text = $"Units per case: {inventoryList[i].getUnitsPerCase()}";
                    grpAdd.Visible = true;
                    grpChange.Visible = true;
                    grpDelete.Visible = true;
                    lblChangeError.Text = string.Empty;
                    lblErrorDelete.Text = string.Empty;
                    lblResult.Text = string.Empty;
                }
                if (!found)
                {
                    lblName.Text = "Item does not exist";
                    lblUPC.Text = string.Empty;
                    lblStorePrice.Text = string.Empty;
                    lblCostCase.Text = string.Empty;
                    lblUnitsCase.Text = string.Empty;
                    grpAdd.Visible = true;
                    grpChange.Visible = false;
                    grpDelete.Visible = false;
                    lblChangeError.Text = string.Empty;
                    lblErrorDelete.Text = string.Empty;
                    lblResult.Text = string.Empty;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtChangeAccess.Text == accessKey)
            {
                decimal newPrice = Convert.ToDecimal(txtNewPrice.Text);
                inventoryList[foundIndex].setPrice(newPrice);
                lblChangeError.Text = "Price Changed";
            }
            else
            {
                lblChangeError.Text = "Incorrect access key";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteAccess.Text == accessKey && txtVerifyUPC.Text == inventoryList[foundIndex].getUpc())
            {
                inventoryList.RemoveAt(foundIndex);
                lblErrorDelete.Text = "Item Deleted";
            }
            else
            {
                lblErrorDelete.Text = "Incorrect access key or UPC";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = txtName.Text;
            string upc = txtUPC.Text;
            decimal price = Convert.ToDecimal(txtStorePrice.Text);
            decimal costPerCase = Convert.ToDecimal(txtCostCase.Text);
            int unitsPerCase = Convert.ToInt32(txtUnitsCase.Text);

            if (txtAddAccess.Text == accessKey)
            {
                InventoryItem newItem = new InventoryItem(itemName, upc, price, costPerCase, unitsPerCase);
                inventoryList.Add(newItem);
                lblResult.Text = "Item Added";
            }
            else
            {
                lblResult.Text = "Incorrect access key";
            }
        }
    }
}
