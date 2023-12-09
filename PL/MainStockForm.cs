using BLL.ServiceContracts;
using BLL.Services;

namespace PL;

public partial class MainStockForm : Form
{
    private readonly IGetProductService _getproductService;
    private readonly IDeleteProductService _deleteproductService;
    public MainStockForm()
    {
        InitializeComponent();
        _getproductService = new GetProductsService();
        _deleteproductService = new DeleteProductService();
    }

    private void AddNewItemButton_Click(object sender, EventArgs e)
    {
        var form = new AddForm();
        this.Hide();
        form.Show();
    }

    private void CloseButton_Click(object sender, EventArgs e) => Close();

    private void MainStockForm_Load(object sender, EventArgs e)
    {
        dataGridView1.DataSource = _getproductService.GetAllProducts();
    }

    private void DeleteItemButton_Click(object sender, EventArgs e)
    {
        var value = dataGridView1.SelectedRows[0].Cells[0].Value;

        if (value is Guid id)
        {
            var entity = _getproductService.GetById(id);

            _deleteproductService.Delete(entity);

            dataGridView1.DataSource = _getproductService.GetAllProducts();
        }
    }

    private void UpdateItemButton_Click(object sender, EventArgs e)
    {
        var value = dataGridView1.SelectedRows[0].Cells[0].Value;

        if (value is Guid id)
        {
            var updateForm = new UpdateForm();

            var entity = _getproductService.GetById(id);

            updateForm.SetValues(id, entity);

            this.Hide();
            updateForm.Show();
        }
    }
}
