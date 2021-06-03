using Examen.Elipgo.BusinessLogic.Entities;
using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.Presentation.Configuration.Contexts;
using Examen.Elipgo.Presentation.Forms.Loader;
using Examen.Elipgo.Presentation.Forms.MessageBoxUI;
using Examen.Elipgo.Presentation.Models;
using Examen.Elipgo.Presentation.Tools;
using Examen.Elipgo.Presentation.Tools.ComboBox;
using Examen.Elipgo.Presentation.Tools.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Forms.Views
{
    public partial class Inventory : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly IArticlesRepository _articlesRepository;
        private readonly IStoresRepository _storesRepository;
        private MessageBoxForm form = null;
        private bool haveError = false;
        private bool searchByStore = false;
        public Inventory()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            var urlApi = _context.ApplicationSettings
                .Where(x => x.Id == 1)
                .Select(x => x.UrlConnectionRestAPI)
                .FirstOrDefault();
            _articlesRepository = new ArticlesRepository(urlApi);
            _storesRepository = new StoresRepository(urlApi);
        }

        #region LoadView

        private void Inventory_Resize(object sender, EventArgs e)
        {
            UtilityTools.CenterX(pnlTitulo, lblTitulo);
        }

        private async void Inventory_Load(object sender, EventArgs e)
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var response = await _articlesRepository.GetAll();
            Loading.Close();
            PopulateDataGridView(response.Value);
            PopulateComboBox(cbxStore);

        }

        #endregion

        #region PrivateMethods

        private async void PopulateComboBox(ComboBox combo)
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var stores = await getStores();
            var _comboItems = new BindingList<Item>();
            if (stores.Count() > 0)
            {
                _comboItems.Add(new Item { Value = "0", Text = "Seleccionar Opción" });
                foreach (var store in stores)
                {
                    _comboItems.Add(new Item { Value = store.Id.ToString(), Text = store.Name });
                }

                combo.DataSource = _comboItems;
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                combo.SelectedIndex = 0;
            }
            else
            {

            }
            Loading.Close();
        }

        private void PopulateDataGridView(IEnumerable<ArticleDAO> articles)
        {
            var table = UtilityTools.ConvertToDataTable<ArticlesDataGridView>(articles.Select(x => new ArticlesDataGridView()
            {
                Id = x.Id,
                Address = x.Store.Address,
                NameStore = x.Store.Name,
                StoreId = x.StoreId,
                Code = x.Code,
                Description = x.Description,
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                TotalInShelf = x.TotalInShelf,
                TotalInVault = x.TotalInVault
            }).ToList());
            var source = new BindingSource { DataSource = table };
            dgvArticles.AutoGenerateColumns = true;
            dgvArticles.Columns.Clear();
            dgvArticles.DataSource = source;

            for (var i = 0; i < dgvArticles.Columns.Count; i++)
            {
                dgvArticles.Columns[i].DataPropertyName = table.Columns[i].ColumnName;
            }

            dgvArticles.Columns[0].Visible = false;

            dgvArticles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvArticles.Columns[1].Width = 150;
            dgvArticles.Columns[1].HeaderText = "Articulo";

            dgvArticles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvArticles.Columns[2].HeaderText = "Descripción";

            dgvArticles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvArticles.Columns[3].Width = 150;
            dgvArticles.Columns[3].HeaderText = "Código";

            dgvArticles.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvArticles.Columns[4].Width = 100;
            dgvArticles.Columns[4].HeaderText = "Precio";

            dgvArticles.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvArticles.Columns[5].Width = 100;
            dgvArticles.Columns[5].HeaderText = "Existencias";

            dgvArticles.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvArticles.Columns[6].Width = 110;
            dgvArticles.Columns[6].HeaderText = "Total Estante";

            dgvArticles.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvArticles.Columns[7].Width = 110;
            dgvArticles.Columns[7].HeaderText = "Total Almacen";

            dgvArticles.Columns[8].Visible = false;

            dgvArticles.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvArticles.Columns[9].HeaderText = "Sucursal";

            dgvArticles.Columns[10].Visible = false;

            dgvArticles.Update();
        }

        private async Task<IEnumerable<StoreDAO>> getStores()
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var response = await _storesRepository.GetAll();
            Loading.Close();
            if (response.Success)
            {
                return response.Value;
            }
            else
            {
                return new List<StoreDAO>();
            }
        }

        private async Task<IEnumerable<ArticleDAO>> GetArticlesByFilter(KeyValuePair<string, string> filter)
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var response = await _articlesRepository.GetArticlesByFilter($"/service/Article/SearchArticleByFilter?{filter.Key}={filter.Value}");
            Loading.Close();
            if (response.Success)
            {
                txtSearch.Text = "";
                return response.Value;
            }
            else
            {
                haveError = true;
                form = new MessageBoxForm(
                    "Solicitud Incompleta",
                    response.Message_Error,
                    TypeIcon.Warning);
                form.ShowDialog();
            }

            return new List<ArticleDAO>();
        }

        private void ValidDataResponse(IEnumerable<ArticleDAO> articles)
        {
            if (articles.Any())
            {
                PopulateDataGridView(articles);

                form = new MessageBoxForm(
                    "Solicitud Completada",
                    "Datos cargados correctamente",
                    TypeIcon.Success);
                form.ShowDialog();

            }
            else
            {
                if (haveError) return;
                do
                {
                    foreach (DataGridViewRow row in dgvArticles.Rows)
                    {
                        try
                        {
                            dgvArticles.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dgvArticles.Rows.Count > 1);

                form = new MessageBoxForm(
                    "Información",
                    "Sin resultados para mostrar",
                    TypeIcon.Info);
                form.ShowDialog();

            }

        }

        private async void ApplyFilter(bool IsComboSelected = false)
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            IEnumerable<ArticleDAO> data = null;
            var checkedBoxes = gbxFilter.Controls.OfType<RadioButton>().Where(c => c.Checked);
            switch (checkedBoxes.FirstOrDefault()?.Text)
            {
                case "Nombre":
                    data = await GetArticlesByFilter(new KeyValuePair<string, string>("Name", txtSearch.Text));
                    ValidDataResponse(data);
                    break;
                case "Id":
                    data = await GetArticlesByFilter(new KeyValuePair<string, string>("Id", txtSearch.Text));
                    ValidDataResponse(data);
                    break;
                case "Tienda":
                    data = await GetArticlesByFilter(new KeyValuePair<string, string>("Store", cbxStore.Text));
                    ValidDataResponse(data);
                    break;
            }
            Loading.Close();
        }

        #endregion

        #region EventsViews

        private void rbtStore_MouseCaptureChanged(object sender, EventArgs e)
        {
            cbxStore.SelectedIndex = 0;
            txtSearch.Visible = false;
            cbxStore.Visible = true;
            searchByStore = true;
        }

        private void rbtName_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbxStore.Visible = false;
            searchByStore = false;
        }

        private void rbtId_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbxStore.Visible = false;
            searchByStore = false;
        }

        #endregion

        #region EventButtons

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!searchByStore)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    ApplyFilter();
                }
                else
                {
                    form = new MessageBoxForm(
                        "Solicitud No Procesada",
                        "Debe de ingresar información en la caja de texto para poder realizar la búsqueda",
                        TypeIcon.Info);
                    form.ShowDialog();
                    txtSearch.Focus();
                }
            }
            else
            {
                if (cbxStore.SelectedIndex == 0)
                {
                    form = new MessageBoxForm(
                        "Solicitud No Procesada",
                        "Debe de seleccionar una sucursal para poder realizar la búsqueda",
                        TypeIcon.Info);
                    form.ShowDialog();
                    cbxStore.Focus();
                }
                else
                {
                    ApplyFilter();
                }
            }

        }
        
        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var response = await _articlesRepository.GetAll();
            PopulateDataGridView(response.Value);
            Loading.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region KeyEvents

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!searchByStore)
                {
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        ApplyFilter();
                    }
                    else
                    {
                        form = new MessageBoxForm(
                            "Solicitud No Procesada",
                            "Debe de ingresar información en la caja de texto para poder realizar la búsqueda",
                            TypeIcon.Info);
                        form.ShowDialog();
                        txtSearch.Focus();
                    }
                }
                else
                {
                    if (cbxStore.SelectedIndex == 0)
                    {
                        form = new MessageBoxForm(
                            "Solicitud No Procesada",
                            "Debe de seleccionar una sucursal para poder realizar la búsqueda",
                            TypeIcon.Info);
                        form.ShowDialog();
                        cbxStore.Focus();
                    }
                    else
                    {
                        ApplyFilter();
                    }
                }
            }
        }

        #endregion
    }
}
