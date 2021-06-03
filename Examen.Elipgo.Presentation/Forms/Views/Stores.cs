using Examen.Elipgo.BusinessLogic.Entities;
using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.Presentation.Configuration.Contexts;
using Examen.Elipgo.Presentation.Forms.Loader;
using Examen.Elipgo.Presentation.Forms.MessageBoxUI;
using Examen.Elipgo.Presentation.Tools;
using Examen.Elipgo.Presentation.Tools.Enums;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation.Forms.Views
{
    public partial class Stores : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly IStoresRepository _repository;
        private MessageBoxForm form = null;
        private bool edit = false;
        public Stores()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _repository = new StoresRepository(_context.ApplicationSettings
                .Where(x => x.Id == 1)
                .Select(x => x.UrlConnectionRestAPI)
                .FirstOrDefault());
        }

        #region LoadView

        private async void Stores_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            CheckPermmissions();
        }

        private void Stores_Resize(object sender, EventArgs e)
        {
            UtilityTools.CenterX(pnlTitulo, lblTitulo);
            UtilityTools.CenterXY(pnlContent, pnlForm);
            UtilityTools.CenterXY(pnlAddStore, gbxInfo);
            UtilityTools.CenterXY(pnlStoreHeader, grbButtonsStoreHeader);
            UtilityTools.CenterXY(pnlStoresContent, dgvStores);
            //UtilityTools.CenterXY(pnlForm, gbxInfo);
        }

        #endregion

        #region EventButtons

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm()) return;
            var store = new StoreDAO()
            {
                Name = txtName.Text,
                Address = txtAddress.Text
            };
            if (edit)
            {
                var Loading = new LoaderForm();
                Loading.Show(this);
                store.Id = Convert.ToInt32(lblID.Text.Trim());
                var responseUpdate = await _repository.Update(Convert.ToInt32(lblID.Text.Trim()), store);
                Loading.Close();
                if (responseUpdate.Success)
                {
                    form = new MessageBoxForm(
                        "Solicitud Completada",
                        responseUpdate.Message,
                        TypeIcon.Success);
                    form.ShowDialog();
                    PopulateDataGridView();
                    txtAddress.Text = "";
                    txtName.Text = "";
                }
                else
                {
                    form = new MessageBoxForm(
                        "Solicitud Incompleta",
                        responseUpdate.Message_Error,
                        TypeIcon.Warning);
                    form.ShowDialog();
                    txtAddress.Text = "";
                    txtName.Text = "";
                }
            }
            else
            {
                var Loading = new LoaderForm();
                Loading.Show(this);
                var response = await _repository.AddStore(store);
                Loading.Close();
                if (response.Success)
                {
                    form = new MessageBoxForm(
                        "Solicitud Completada",
                        response.Message,
                        TypeIcon.Success);
                    form.ShowDialog();
                    PopulateDataGridView();
                    txtAddress.Text = "";
                    txtName.Text = "";
                }
                else
                {
                    form = new MessageBoxForm(
                        "Solicitud Incompleta",
                        response.Message_Error,
                        TypeIcon.Warning);
                    form.ShowDialog();
                    txtAddress.Text = "";
                    txtName.Text = "";
                }

            }
        }

        private void btnEditStoreHeader_Click(object sender, EventArgs e)
        {
            if (dgvStores.RowCount == 0)
            {
                btnEditStoreHeader.Enabled = false;
                btnRemoveStoreHeader.Enabled = false;
                form = new MessageBoxForm(
                    "Solicitud Completada",
                    "No exiten mas sucursales por eliminar",
                    TypeIcon.Info);
                form.ShowDialog();
            }
            else
            {

                edit = true;
                btnAceptar.Text = "Actualizar";
                lblID.Text = dgvStores.SelectedCells[0].Value.ToString().PadLeft(3, '0');
                txtName.Text = dgvStores.SelectedCells[1].Value.ToString();
                txtAddress.Text = dgvStores.SelectedCells[2].Value.ToString();
                lblID.Visible = true;
                lblSucursal.Visible = true;
            }
        }

        private async void btnRemoveStoreHeader_Click(object sender, EventArgs e)
        {
            if (dgvStores.RowCount == 0)
            {
                btnEditStoreHeader.Enabled = false;
                btnRemoveStoreHeader.Enabled = false;
                form = new MessageBoxForm(
                    "Solicitud Completada",
                   "No exiten mas sucursales por eliminar",
                    TypeIcon.Info);
                form.ShowDialog();
                return;
            }
            else
            {
                var Loading = new LoaderForm();
                Loading.Show(this);
                var data = Convert.ToInt32(dgvStores.SelectedCells[0].Value.ToString());
                var response = await _repository.Delete(data);
                Loading.Close();
                if (response.Success)
                {
                    form = new MessageBoxForm(
                        "Solicitud Completada",
                        response.Message,
                        TypeIcon.Success);
                    form.ShowDialog();
                    dgvStores.Rows.RemoveAt(dgvStores.SelectedCells[0].RowIndex);
                    PopulateDataGridView();
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

            dgvStores.Update();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            btnAceptar.Text = "Aceptar";
            edit = false;
            lblID.Visible = false;
            lblSucursal.Visible = false;
        }

        #endregion

        #region PrivateMethods

        private bool IsValidForm()
        {
            if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtAddress.Text))
            {
                form = new MessageBoxForm(
                    "Formulario Vacio",
                    "Debe llenar los campos Nombre y Dirección para continuar",
                    TypeIcon.Warning);
                form.ShowDialog();
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                form = new MessageBoxForm(
                    "Campo Vacio",
                    "Debe llenar el campo nombre",
                    TypeIcon.Warning);
                form.ShowDialog();
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                form = new MessageBoxForm(
                    "Campo Vacio",
                    "Debe llenar el campo dirección",
                    TypeIcon.Warning);
                form.ShowDialog();
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private async void PopulateDataGridView()
        {
            var Loading = new LoaderForm();
            Loading.Show(this);
            var response = await _repository.GetAll();
            Loading.Close();
            if (!response.Value.Any())
            {
                btnEditStoreHeader.Enabled = false;
                btnRemoveStoreHeader.Enabled = false;
            }
            var table = UtilityTools.ConvertToDataTable<StoreDAO>(response.Value.ToList());
            var source = new BindingSource { DataSource = table };
            dgvStores.AutoGenerateColumns = true;
            dgvStores.Columns.Clear();
            dgvStores.DataSource = source;

            for (int i = 0; i < dgvStores.Columns.Count; i++)
            {
                dgvStores.Columns[i].DataPropertyName = table.Columns[i].ColumnName;
            }

            dgvStores.Columns[0].Visible = false;
            dgvStores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dgvStores.Columns[0].Width = 50;
            dgvStores.Columns[1].HeaderText = "Sucursal";
            dgvStores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStores.Columns[2].HeaderText = "Dirección";
            dgvStores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvStores.Update();
        }

        private async void CheckPermmissions()
        {
           var user = await _context.Users
               .Include(x => x.Permissions)
               .Where(x => x.IsActiveSession).FirstOrDefaultAsync();

           if (user.Roles.Split(',').ToList().Contains("Basic"))
           {
               grbButtonsStoreHeader.Visible = false;
           }
        }

        #endregion

        #region ViewEvents

        private void dgvStores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnEditStoreHeader.Enabled = true;
            btnRemoveStoreHeader.Enabled = true;
        }

        #endregion


    }
}
