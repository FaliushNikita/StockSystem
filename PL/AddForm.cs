using BLL.ServiceContracts;
using BLL.Services;
using DAL.Entities;
using DAL.Entities.Enums;

namespace PL;

public partial class AddForm : Form
{
    private readonly IAddProductService _productService;
    public AddForm()
    {
        InitializeComponent();
        _productService = new AddProductService();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        var back = new MainStockForm();
        this.Hide();
        back.Show();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        var product = new Product();
        
        product.Name = NameTextBox.Text;
        product.Measure = Enum.Parse<UnitOfMeasure>(MeasureComboBox.Text);
        product.PriceForUnit = decimal.Parse(PriceForUnitTextBox.Text);
        product.Quantity = int.Parse(QuantityTextBox.Text);
        product.UpdatedAt = DateTime.UtcNow;

        _productService.AddProduct(product);

        NameTextBox.Text = string.Empty;
        PriceForUnitTextBox.Text = string.Empty;
        QuantityTextBox.Text = string.Empty;
    }

    private void AddForm_Load(object sender, EventArgs e)
    {
        foreach(var measure in Enum.GetNames<UnitOfMeasure>())
        {
            MeasureComboBox.Items.Add(measure);
        }

        MeasureComboBox.SelectedIndex = 0;
    }
}
