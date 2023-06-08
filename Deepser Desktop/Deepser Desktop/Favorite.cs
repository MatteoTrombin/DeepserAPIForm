using Dapper;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class Favorite : Form
    {
        public Favorite()
        {
            InitializeComponent();
            this.Load += Favorite_Load;
            dataGridFav.CellClick += DataGridFav_CellClick;
            modalEffect.Tick += ModalEffect_Tick;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        private void DataGridFav_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            var dash = Dashboard.GetIstance();
            if (e.RowIndex > -1 && dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                    DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string text = Microsoft.VisualBasic.Interaction.InputBox("How do you want to rename this favorite?", "Rename Favorite", "");
       
                    if (dash.main.Controls[0] is Collection)
                    {
                        string entity = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value?.ToString();
                        string filters = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value?.ToString();
                        string parameters = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value?.ToString();

                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            cell.Value = text;
                            SqliteDataAccess.ChangeNameFavColl(text, entity, filters, parameters);
                        }
                    }
                    else
                    {
                        string entity = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value?.ToString();
                        string entityId = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value?.ToString();
                        string filters = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value?.ToString();
                        string parameters = dataGridFav.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value?.ToString();

                        if (!string.IsNullOrWhiteSpace(text))
                        {
                                         cell.Value = text;
                            SqliteDataAccess.ChangeNameFavCollAct(text, entity, entityId, filters, parameters);
                        }
                    }
                }
                else
                {
                    DataGridViewRow row = dataGridFav.Rows[e.RowIndex];
                    if (dash.main.Controls[0] is Collection)
                    {
                        Collection collControl = (Collection)dash.main.Controls[0];
                        collControl.selectEntity.SelectedItem = row.Cells[1].Value;
                        if (row.Cells[2].Value != null)
                        {
                            Dictionary<string, object> dictJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(row.Cells[2].Value.ToString());
                            collControl.filter.filters = History.ParseFilters(dictJson);
                            collControl.UpdateFilter();
                        }
                        if (row.Cells[3].Value != null)
                        {
                            collControl.parameter.parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(row.Cells[3].Value.ToString());
                            collControl.UpdateParameter();
                        }
                    }
                    else
                    {
                        ActivityCollection actCollControl = (ActivityCollection)dash.main.Controls[0];
                        actCollControl.selectEntity.SelectedItem = row.Cells[1].Value;
                        actCollControl.textIdField.Text = row.Cells[2].Value.ToString();
                        if (row.Cells[3].Value != null)
                        {
                            Dictionary<string, object> dictJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(row.Cells[3].Value.ToString());
                            actCollControl.filter.filters = History.ParseFilters(dictJson);
                            actCollControl.UpdateFilter();
                        }
                        if (row.Cells[4].Value != null)
                        {
                            actCollControl.parameter.parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(row.Cells[4].Value.ToString());
                            actCollControl.UpdateParameter();
                        }
                    }
                    this.Close();
                }
            }
        }

        public void CollectionGrid()
        {
            dataGridFav.Rows.Clear();
            dataGridFav.Columns.Clear();

            DataGridViewTextBoxColumn  columnRename = new DataGridViewTextBoxColumn();
            columnRename.Name = "columnRename";
            columnRename.HeaderText = "Rename";
            columnRename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnRename);

            DataGridViewTextBoxColumn columnEntity = new DataGridViewTextBoxColumn();
            columnEntity.Name = "columnEntity";
            columnEntity.HeaderText = "Entity";
            columnEntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnEntity);

            DataGridViewTextBoxColumn columnFilter = new DataGridViewTextBoxColumn();
            columnFilter.Name = "columnFilter";
            columnFilter.HeaderText = "Filters";
            columnFilter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnFilter);

            DataGridViewTextBoxColumn columnParameters = new DataGridViewTextBoxColumn();
            columnParameters.Name = "columnParameters";
            columnParameters.HeaderText = "Parameters";
            columnParameters.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnParameters);

            var list = SqliteDataAccess.GetCollectionFav();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridFav);

                if (item.Name == null)
                {
                    row.Cells[0].Value = "Click to rename";
                }
                else
                {
                    row.Cells[0].Value = item.Name;
                }
                row.Cells[1].Value = item.Entity;
                row.Cells[2].Value = item.Filters;
                row.Cells[3].Value = item.Parameters;

                dataGridFav.Rows.Add(row);
            }
        }

        public void CollectionActivityGrid()
        {
            dataGridFav.Rows.Clear();
            dataGridFav.Columns.Clear();

            DataGridViewTextBoxColumn columnRename = new DataGridViewTextBoxColumn();
            columnRename.Name = "columnRename";
            columnRename.HeaderText = "Rename";
            columnRename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnRename);

            DataGridViewTextBoxColumn columnEntity = new DataGridViewTextBoxColumn();
            columnEntity.Name = "columnEntity";
            columnEntity.HeaderText = "Entity";
            columnEntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnEntity);

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.Name = "columnId";
            columnId.HeaderText = "ID";
            columnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnId);

            DataGridViewTextBoxColumn columnFilter = new DataGridViewTextBoxColumn();
            columnFilter.Name = "columnFilter";
            columnFilter.HeaderText = "Filters";
            columnFilter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnFilter);

            DataGridViewTextBoxColumn columnParameters = new DataGridViewTextBoxColumn();
            columnParameters.Name = "columnParameters";
            columnParameters.HeaderText = "Parameters";
            columnParameters.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridFav.Columns.Add(columnParameters);

            var list = SqliteDataAccess.GetCollectionActivityFav();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridFav);

                if (item.Name == null)
                {
                    row.Cells[0].Value = "Click to rename";
                }
                else
                {
                    row.Cells[0].Value = item.Name;
                }
                row.Cells[1].Value = item.Entity;
                row.Cells[2].Value = item.EntityID;
                row.Cells[3].Value = item.Filters;
                row.Cells[4].Value = item.Parameters;

                dataGridFav.Rows.Add(row);
            }
        }

        int i;
        private void Favorite_Load(object? sender, EventArgs e)
        {
            i = Dashboard.parentY + 100;
            this.Location = new Point(Dashboard.parentX + 350, Dashboard.parentY + 150);
        }

        private void ModalEffect_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = Dashboard.parentY += 3;
            this.Location = new Point(Dashboard.parentX + 175, y);
            if (y >= i)
            {
                modalEffect.Stop();
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
