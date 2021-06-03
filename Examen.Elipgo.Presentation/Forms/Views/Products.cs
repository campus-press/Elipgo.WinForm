using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Elipgo.BusinessLogic.Entities;
using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.Presentation.Configuration.Contexts;
using Examen.Elipgo.Presentation.Forms.Loader;
using Examen.Elipgo.Presentation.Forms.MessageBoxUI;
using Examen.Elipgo.Presentation.Tools;
using Examen.Elipgo.Presentation.Tools.ComboBox;
using Examen.Elipgo.Presentation.Tools.Enums;

namespace Examen.Elipgo.Presentation.Forms.Views
{
    public partial class Products : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly IArticlesRepository _articlesRepository;
        private readonly IStoresRepository _storesRepository;
        private MessageBoxForm form = null;
        private bool ClearFormFlag = false;
        public Products()
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

        private void Products_Load(object sender, EventArgs e)
        {
            PopulateComboBox(cmbStore);
        }

        private void Products_Resize(object sender, EventArgs e)
        {
            UtilityTools.CenterX(pnlTitulo, lblTitulo);
            UtilityTools.CenterXY(pnlContent, pnlForm);
            UtilityTools.CenterXY(pnlForm, gbxInfo);
        }

        #endregion

        #region EventButtons

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                if (Convert.ToInt32(txtShelf.Text) + Convert.ToInt32(txtVault.Text) > Convert.ToInt32(txtQuantity.Text))
                {
                    form = new MessageBoxForm(
                        "Error!",
                        "La suma de las cantidades en estantes y en almacén superan la cantidad que ingreso en el campo, Favor de verificar",
                        TypeIcon.Warning);
                    form.ShowDialog();
                    txtShelf.Focus();
                }
                else if (Convert.ToInt32(txtShelf.Text) + Convert.ToInt32(txtVault.Text) <
                         Convert.ToInt32(txtQuantity.Text))
                {
                    form = new MessageBoxForm(
                        "Error!",
                        "La suma de las cantidades en estantes y en almacén no cubren la cantidad que ingreso en el campo, Favor de verificar",
                        TypeIcon.Warning);
                    form.ShowDialog();
                    txtShelf.Focus();
                }
                else
                {
                    var article = new ArticleDAO()
                    {
                        Code = txtCode.Text,
                        Description = txtDescription.Text ?? "",
                        Name = txtNombre.Text,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        TotalInShelf = Convert.ToInt32(txtShelf.Text),
                        TotalInVault = Convert.ToInt32(txtVault.Text),
                        StoreId = Convert.ToInt32(cmbStore.SelectedValue)
                    };

                    var Loading = new LoaderForm();
                    Loading.Show(this);
                    var response = await _articlesRepository.AddArticle(article);
                    Loading.Close();

                    if (response.Success)
                    {
                        form = new MessageBoxForm(
                            "Solicitud Completada",
                            response.Message,
                            TypeIcon.Success);
                        form.ShowDialog();
                        ClearFormFlag = true;
                        ClearForm();
                        ClearFormFlag = false;
                    }
                    else
                    {
                        form = new MessageBoxForm(
                            "Solicitud Incompleta",
                            response.Message_Error,
                            TypeIcon.Warning);
                        form.ShowDialog();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region TextChangedControl

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.ForeColor = Color.Black;
            if (txtNombre.Text.Length == 0 && !ClearFormFlag)
            {
                lblNombre.ForeColor = Color.Red;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.ForeColor = Color.Black;
            if (txtDescription.Text.Length == 0 && !ClearFormFlag)
            {
                lblDescription.ForeColor = Color.Red;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            lblPrice.ForeColor = Color.Black;
            if (txtPrice.Text.Length == 0 && !ClearFormFlag)
            {
                lblPrice.ForeColor = Color.Red;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            lblQuantity.ForeColor = Color.Black;
            if (txtQuantity.Text.Length == 0 && !ClearFormFlag)
            {
                lblQuantity.ForeColor = Color.Red;
            }
        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStore.ForeColor = Color.Black;
            if (cmbStore.SelectedIndex == -1 && !ClearFormFlag)
            {
                lblStore.ForeColor = Color.Red;
            }
        }

        #endregion

        #region ValidInputTextBox

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtShelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVault_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region FormControl

        private void ClearForm()
        {
            var TextBoxes = UtilityTools.FindControls<TextBox>(this);
            foreach (var textBox in TextBoxes)
            {
                textBox.Text = string.Empty;
            }

            cmbStore.DataSource = null;
            PopulateComboBox(cmbStore);
        }

        private bool ValidForm()
        {
            var validTextBox = UtilityTools.FindControls<TextBox>(this);
            var validComboBox = UtilityTools.FindControls<ComboBox>(this);
            var getLabels = UtilityTools.FindControls<Label>(this);
            bool valid = true;

            foreach (var textBox in validTextBox)
            {

                if (textBox.Name != "txtDescription")
                {
                    if (!string.IsNullOrEmpty(textBox.Text)) continue;
                    var text = textBox.Name.Substring(3);
                    var label = getLabels.FirstOrDefault(x => x.Name.Contains(text));
                    label.ForeColor = Color.Red;
                    valid = false;
                }
            }
            foreach (var cmbox in validComboBox)
            {
                if (cmbox.SelectedIndex != 0) continue;
                cmbox.Focus();
                var text = cmbox.Name.Substring(5);
                var label = getLabels.FirstOrDefault(x => x.Name.Contains(text));
                label.ForeColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        #endregion

        #region PrivateMethods

        private async void PopulateComboBox(ComboBox combo)
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var stores = await getStores();
            Loading.Close();
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

        #endregion


    }
}
