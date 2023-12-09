using DAL.Entities.Enums;
using DAL.Entities;
using BLL.ServiceContracts;
using BLL.Services;

namespace PL;

public partial class UpdateForm : Form
{
    private readonly IUpdateProductService _updateProductService;
    private Guid _id;

    public UpdateForm()
    {
        InitializeComponent();
        _updateProductService = new UpdateProductService();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        var back = new MainStockForm();
        this.Hide();
        back.Show();
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        var product = new Product();

        product.Id = _id;
        product.Name = NameTextBox.Text;
        product.Measure = Enum.Parse<UnitOfMeasure>(MeasureComboBox.Text);
        product.PriceForUnit = decimal.Parse(PriceForUnitTextBox.Text);
        product.Quantity = int.Parse(QuantityTextBox.Text);
        product.UpdatedAt = DateTime.UtcNow;

        _updateProductService.Update(product);

        var back = new MainStockForm();
        this.Hide();
        back.Show();
    }
    public void SetValues(Guid id, Product product)
    {
        _id = id;
        NameTextBox.Text = product.Name;
        MeasureComboBox.SelectedValue = product.Measure.ToString();
        PriceForUnitTextBox.Text = product.PriceForUnit.ToString();
        QuantityTextBox.Text = product.Quantity.ToString();
    }

    private void UpdateForm_Load(object sender, EventArgs e)
    {
        foreach (var measure in Enum.GetNames<UnitOfMeasure>())
        {
            MeasureComboBox.Items.Add(measure);
        }

        MeasureComboBox.SelectedIndex = 0;
    }

}
