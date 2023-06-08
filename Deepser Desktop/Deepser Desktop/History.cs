using Deepser.Framework.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Deepser.Framework.Request.Filter;

namespace Deepser_Desktop
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            buttonClose.Click += ButtonClose_Click;
            modalEffect.Tick += ModalEffect_Tick;
            this.Load += History_Load;
            dataGridHistory.CellClick += DataGridHistory_CellClick;
            dataGridHistory.RowsAdded += DataGridHistory_RowsAdded;
            buttonDeleteAll.Click += ButtonDeleteAll_Click;
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

        private void DataGridHistory_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            buttonDeleteAll.Enabled = true;
        }

        private void ButtonDeleteAll_Click(object? sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete all the history? It is an irreversible operation", "Delete history", buttons);
            if (dialog == DialogResult.Yes)
            {
                var dash = Dashboard.GetIstance();
                if (dataGridHistory.Rows.Count > 0)
                {
                    if (dash.main.Controls[0] is Load)
                    {
                        SqliteDataAccess.DeleteAllFromHistory("load");
                        dataGridHistory.Rows.Clear();
                    }
                    else if (dash.main.Controls[0] is LoadActivity)
                    {
                        SqliteDataAccess.DeleteAllFromHistory("loadActivity");
                        dataGridHistory.Rows.Clear();
                    }
                    else if (dash.main.Controls[0] is Collection)
                    {
                        SqliteDataAccess.DeleteAllFromHistory("collection");
                        dataGridHistory.Rows.Clear();
                    }
                    else
                    {
                        SqliteDataAccess.DeleteAllFromHistory("collectionActivity");
                        dataGridHistory.Rows.Clear();
                    }
                }
            }
        }

        private void DataGridHistory_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                {
                    var dash = Dashboard.GetIstance();
                    DataGridViewRow row = dataGridHistory.Rows[e.RowIndex];
                    if (dash.main.Controls[0] is Load)
                    {
                        Load loadControl = (Load)dash.main.Controls[0];
                        loadControl.selectEntity.SelectedItem = row.Cells[0].Value;
                        loadControl.textId.Text = (string)row.Cells[1].Value;
                        loadControl.textField.Text = (string)row.Cells[2].Value;
                        loadControl.textSingle.Text = (string)row.Cells[3].Value;
                    }
                    else if (dash.main.Controls[0] is Collection)
                    {
                        Collection collControl = (Collection)dash.main.Controls[0];
                        collControl.selectEntity.SelectedItem = row.Cells[0].Value;
                        if (row.Cells[1].Value != null)
                        {
                            Dictionary<string, object> dictJson = JsonConvert.DeserializeObject<Dictionary<string, object>>((string)row.Cells[1].Value);
                            collControl.filter.filters = ParseFilters(dictJson);
                            collControl.UpdateFilter();
                        }
                        if (row.Cells[2].Value != null)
                        {
                            collControl.parameter.parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>((string)row.Cells[2].Value);
                            collControl.UpdateParameter();
                        }
                    }
                    else if (dash.main.Controls[0] is LoadActivity)
                    {
                        LoadActivity actControl = (LoadActivity)dash.main.Controls[0];
                        actControl.selectEntity.SelectedItem = row.Cells[0].Value;
                        actControl.textId.Text = (string)row.Cells[1].Value;
                        actControl.textActivity.Text = (string)row.Cells[2].Value;
                        actControl.textSingle.Text = (string)row.Cells[3].Value;
                    }
                    else
                    {
                        ActivityCollection actCollControl = (ActivityCollection)dash.main.Controls[0];
                        actCollControl.selectEntity.SelectedItem = row.Cells[0].Value;
                        actCollControl.textIdField.Text = row.Cells[1].Value.ToString();
                        if (row.Cells[2].Value != null)
                        {
                            actCollControl.filter.filters = ParseFilters(JsonConvert.DeserializeObject<Dictionary<string, object>>((string)row.Cells[2].Value));
                            actCollControl.UpdateFilter();
                        }
                        if (row.Cells[3].Value != null)
                        {
                            actCollControl.parameter.parameters = ParseFilters(JsonConvert.DeserializeObject<Dictionary<string, object>>((string)row.Cells[3].Value));
                            actCollControl.UpdateParameter();
                        }
                    }

                    this.Close();
                }
            }
        }


        public void CollectionGrid()
        {
            dataGridHistory.Rows.Clear();
            dataGridHistory.Columns.Clear();

            DataGridViewTextBoxColumn columnEntity = new DataGridViewTextBoxColumn();
            columnEntity.Name = "columnEntity";
            columnEntity.HeaderText = "Entity";
            columnEntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnEntity);

            DataGridViewTextBoxColumn columnFilter = new DataGridViewTextBoxColumn();
            columnFilter.Name = "columnFilter";
            columnFilter.HeaderText = "Filters";
            columnFilter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnFilter);

            DataGridViewTextBoxColumn columnParameters = new DataGridViewTextBoxColumn();
            columnParameters.Name = "columnParameters";
            columnParameters.HeaderText = "Parameters";
            columnParameters.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnParameters);

            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            columnDate.Name = "columnDate";
            columnDate.HeaderText = "Date";
            columnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridHistory.Columns.Add(columnDate);

            var list = SqliteDataAccess.GetCollectionHistory();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridHistory);

                row.Cells[0].Value = item.Entity;
                row.Cells[1].Value = item.Filters;
                row.Cells[2].Value = item.Parameters;
                row.Cells[3].Value = item.Date;

                dataGridHistory.Rows.Add(row);
            }
        }

        public void LoadGrid()
        {
            dataGridHistory.Rows.Clear();
            dataGridHistory.Columns.Clear();

            DataGridViewTextBoxColumn columnEntity = new DataGridViewTextBoxColumn();
            columnEntity.Name = "columnEntity";
            columnEntity.HeaderText = "Entity";
            columnEntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnEntity);

            DataGridViewTextBoxColumn columnEntityId = new DataGridViewTextBoxColumn();
            columnEntityId.Name = "columnEntityId";
            columnEntityId.HeaderText = "Id or Value";
            columnEntityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnEntityId);

            DataGridViewTextBoxColumn columnAttribute = new DataGridViewTextBoxColumn();
            columnAttribute.Name = "columnAttribute";
            columnAttribute.HeaderText = "Attribute";
            columnAttribute.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnAttribute);

            DataGridViewTextBoxColumn columnSingle = new DataGridViewTextBoxColumn();
            columnSingle.Name = "columnSingle";
            columnSingle.HeaderText = "Single";
            columnSingle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnSingle);

            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            columnDate.Name = "columnDate";
            columnDate.HeaderText = "Date";
            columnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridHistory.Columns.Add(columnDate);

            var list = SqliteDataAccess.GetLoadHistory();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridHistory);

                row.Cells[0].Value = item.Entity;
                row.Cells[1].Value = item.EntityID;
                row.Cells[2].Value = item.Attribute;
                row.Cells[3].Value = item.Single;
                row.Cells[4].Value = item.Date;

                dataGridHistory.Rows.Add(row);
            }
        }

        public void LoadActivityGrid()
        {
            dataGridHistory.Rows.Clear();
            dataGridHistory.Columns.Clear();

            DataGridViewTextBoxColumn columnEntity = new DataGridViewTextBoxColumn();
            columnEntity.Name = "columnEntity";
            columnEntity.HeaderText = "Entity";
            columnEntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnEntity);

            DataGridViewTextBoxColumn columnEntityId = new DataGridViewTextBoxColumn();
            columnEntityId.Name = "columnEntityId";
            columnEntityId.HeaderText = "Id";
            columnEntityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnEntityId);

            DataGridViewTextBoxColumn columnFilter = new DataGridViewTextBoxColumn();
            columnFilter.Name = "columnFilter";
            columnFilter.HeaderText = "Filters";
            columnFilter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnFilter);

            DataGridViewTextBoxColumn columnParameters = new DataGridViewTextBoxColumn();
            columnParameters.Name = "columnParameters";
            columnParameters.HeaderText = "Parameters";
            columnParameters.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnParameters);

            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            columnDate.Name = "columnDate";
            columnDate.HeaderText = "Date";
            columnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridHistory.Columns.Add(columnDate);

            var list = SqliteDataAccess.GetLoadActivityHistory();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridHistory);

                row.Cells[0].Value = item.Entity;
                row.Cells[1].Value = item.EntityID;
                row.Cells[2].Value = item.ActivityID;
                row.Cells[3].Value = item.Single;
                row.Cells[4].Value = item.Date;

                dataGridHistory.Rows.Add(row);
            }
        }

        public void CollectionActivityGrid()
        {
            dataGridHistory.Rows.Clear();
            dataGridHistory.Columns.Clear();

            DataGridViewTextBoxColumn columnEntity = new DataGridViewTextBoxColumn();
            columnEntity.Name = "columnEntity";
            columnEntity.HeaderText = "Entity";
            columnEntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnEntity);

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.Name = "columnId";
            columnId.HeaderText = "ID";
            columnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnId);

            DataGridViewTextBoxColumn columnFilter = new DataGridViewTextBoxColumn();
            columnFilter.Name = "columnFilter";
            columnFilter.HeaderText = "Filters";
            columnFilter.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnFilter);

            DataGridViewTextBoxColumn columnParameters = new DataGridViewTextBoxColumn();
            columnParameters.Name = "columnParameters";
            columnParameters.HeaderText = "Parameters";
            columnParameters.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnParameters);

            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            columnDate.Name = "columnDate";
            columnDate.HeaderText = "Date";
            columnDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridHistory.Columns.Add(columnDate);

            var list = SqliteDataAccess.GetCollectionActivityHistory();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridHistory);

                row.Cells[0].Value = item.Entity;
                row.Cells[1].Value = item.EntityID;
                row.Cells[2].Value = item.Filters;
                row.Cells[3].Value = item.Parameters;
                row.Cells[4].Value = item.Date;
                dataGridHistory.Rows.Add(row);
            }
        }

        internal static Dictionary<string, object> ParseFilters(Dictionary<string, object> input)
        {
            Dictionary<string, object> output = new Dictionary<string, object>();

            foreach (var item in input)
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(item.Value.ToString());


                if (dict.ContainsKey("From") && dict.ContainsKey("To"))
                {
                    var filter = new FilterFromTo
                    {
                        From = dict["From"],
                        To = dict["To"]
                    };
                    output[item.Key] = filter;
                }
                else if (dict.ContainsKey("Operator") && dict.ContainsKey("Value"))
                {
                    var filter = new OtherFilter
                    {
                        Operator = dict["Operator"],
                        Value = dict["Value"]
                    };
                    output[item.Key] = filter;
                }
                else if (dict.ContainsKey("Operator"))
                {
                    var filter = new FilterOr
                    {
                        Operator = dict["Operator"],
                        Values = new List<FilterOrValue>()
                    };
                    foreach (var subValue in ((JArray)dict["Values"]).ToObject<List<object>>())
                    {
                        var subDict = ((JObject)subValue).ToObject<Dictionary<string, object>>();
                        var subFilter = new FilterOrValue
                        {
                            Operator = subDict["Operator"].ToString(),
                            Value = subDict["Value"]
                        };

                        filter.Values.Add(subFilter);
                    }
                    output[item.Key] = filter;
                }
            }

            return output;
        }

        

        private void History_Load(object? sender, EventArgs e)
        {
            i = Dashboard.parentY + 100;
            this.Location = new Point(Dashboard.parentX + 300, Dashboard.parentY + 150);
        }
        int i;
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


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
