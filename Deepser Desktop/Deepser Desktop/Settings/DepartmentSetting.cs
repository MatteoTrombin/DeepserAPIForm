using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class DepartmentSetting : Form
    {
        public DepartmentSetting()
        {
            InitializeComponent();
            buttonAddSector.Click += ButtonAddSector_Click;
            buttonAddToDep.Click += ButtonAddToSect_Click;
            buttonBack.Click += ButtonBack_Click;
            buttonDelDepartment.Click += ButtonDelSector_Click;
            buttonManagment.Click += ButtonManagment_Click;
            buttonRemFromDep.Click += ButtonRemFromSect_Click;
            textDepartment.TextChanged += TextSector_TextChanged;
            selectDepartmentRemove.SelectedIndexChanged += SelectSectorRemove_SelectedIndexChanged;
            selectUserRemove.SelectedIndexChanged += SelectUserRemove_SelectedIndexChanged;
            selectUser.SelectedIndexChanged += SelectUser_SelectedIndexChanged;
            selectSector.SelectedIndexChanged += SelectSector_SelectedIndexChanged;
            selectDelDepartment.SelectedIndexChanged += SelectDelSector_SelectedIndexChanged;
            FillAllSector();
            FillAllUser();
            FillGridSector();
        }

        private void ButtonBack_Click(object? sender, EventArgs e)
        {
            selectDelDepartment.Visible = false;
            selectUserRemove.Visible = false;
            selectDepartmentRemove.Visible = false;
            selectSector.Visible = false;
            textDepartment.Visible = false;
            buttonAddSector.Visible = false;
            buttonAddToDep.Visible = false;
            buttonDelDepartment.Visible = false;
            buttonRemFromDep.Visible = false;
            buttonManagment.Visible = true;
            dataGridDepartment.Visible = true;
            buttonBack.Visible = false;
        }

        private void ButtonManagment_Click(object? sender, EventArgs e)
        {
            selectDelDepartment.Visible = true;
            selectUserRemove.Visible = true;
            selectDepartmentRemove.Visible = true;
            selectSector.Visible = true;
            textDepartment.Visible = true;
            buttonAddSector.Visible = true;
            buttonAddToDep.Visible = true;
            buttonDelDepartment.Visible = true;
            buttonRemFromDep.Visible = true;
            buttonManagment.Visible = false;
            dataGridDepartment.Visible = false;
            buttonBack.Visible = true;
        }



        private void TextSector_TextChanged(object? sender, EventArgs e)
        {
            buttonAddSector.Enabled = !string.IsNullOrWhiteSpace(textDepartment.Text);
        }

        private void SelectDelSector_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonDelDepartment.Enabled = selectDelDepartment.SelectedIndex != -1;
        }

        private void SelectSector_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonAddToDep.Enabled = selectSector.SelectedIndex != -1 && selectUser.SelectedIndex != -1;
        }

        private void SelectUser_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonAddToDep.Enabled = selectSector.SelectedIndex != 1 && selectUser.SelectedIndex != -1;
        }

        private void SelectUserRemove_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonRemFromDep.Enabled = selectDepartmentRemove.SelectedIndex != -1 && selectUserRemove.SelectedIndex != -1;
        }

        private void SelectSectorRemove_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FillUserRemove();
            buttonRemFromDep.Enabled = selectDepartmentRemove.SelectedIndex != -1 && selectUserRemove.SelectedIndex != -1;
        }

        private void ButtonRemFromSect_Click(object? sender, EventArgs e)
        {
            try
            {
                if (selectUserRemove.SelectedIndex != -1 && selectDepartmentRemove.SelectedIndex != -1)
                {
                    if (SqliteDataAccess.AllRelation() > 1)
                    {
                        string user = (string)selectUserRemove.SelectedItem;
                        string sector = (string)selectDepartmentRemove.SelectedItem;
                        SqliteDataAccess.RemoveFromDepartment(user, sector);
                        ClearSelections();
                        FillAllUser();
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Are you sure you want to delete the last link user department? you will be moved to a page where you have to add user to your sectors.", "Last User Deparment", buttons);
                        if(result == DialogResult.Yes)
                        {
                            string user = (string)selectUserRemove.SelectedItem;
                            string sector = (string)selectDepartmentRemove.SelectedItem;
                            SqliteDataAccess.RemoveFromDepartment(user, sector);
                            ClearSelections();
                            FillAllUser();
                            Application.Restart();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleziona un utente e un settore validi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAddToSect_Click(object? sender, EventArgs e)
        {
            try
            {
                if (selectUser.SelectedIndex != -1 && selectSector.SelectedIndex != -1)
                {
                    string user = (string)selectUser.SelectedItem;
                    string sector = (string)selectSector.SelectedItem;
                    SqliteDataAccess.AddUserToDepartment(user, sector);
                    ClearSelections();
                    FillAllUser();
                }
                else
                {
                    MessageBox.Show("Seleziona un utente e un settore validi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDelSector_Click(object? sender, EventArgs e)
        {
            try
            {
                if (selectDelDepartment.SelectedIndex != -1 && !string.IsNullOrEmpty((string)selectDelDepartment.SelectedItem))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult dialog = MessageBox.Show($"Are you sure to remove {selectDelDepartment.SelectedItem} section? It is an irreversible operation", "Sector Deletion", buttons);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                        DialogResult dialog2 = MessageBox.Show($"Are you very sure to remove {selectDelDepartment.SelectedItem} section and all the link with the user that works in this section? It is an irreversible operation", "Sector Deletion", buttons2);

                        if (dialog2 == DialogResult.Yes)
                        {
                            string sector = (string)selectDelDepartment.SelectedItem;
                            SqliteDataAccess.DeleteDepartment(sector);
                            ClearSelections();
                            FillAllSector();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAddSector_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textDepartment.Text))
                {
                    string sector = textDepartment.Text;
                    SqliteDataAccess.AddDepartment(sector);
                    textDepartment.Text = string.Empty;
                    ClearSelections();
                    FillAllSector();
                }
                else
                {
                    MessageBox.Show("Inserisci un nome valido per il settore.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearSelections()
        {
            selectUserRemove.SelectedIndex = -1;
            selectDepartmentRemove.SelectedIndex = -1;
            selectUser.SelectedIndex = -1;
            selectSector.SelectedIndex = -1;
            selectDelDepartment.SelectedIndex = -1;
        }

        private void FillAllUser()
        {
            FillUserRemove();
            FillUserAdd();
            FillGridSector();
        }

        private void FillUserRemove()
        {
            selectUserRemove.Items.Clear();
            string sector = (string)selectDepartmentRemove.SelectedItem;
            var list2 = SqliteDataAccess.GetUsers(sector);
            selectUserRemove.Items.AddRange(list2.ToArray());
        }

        private void FillUserAdd()
        {
            selectUser.Items.Clear();
            var list = SqliteDataAccess.Users();
            selectUser.Items.AddRange(list.ToArray());
        }


        private void FillAllSector()
        {
            FillSector();
            FillSectoreDel();
            FillSectorRemove();
            FillGridSector();
        }

        private void FillSector()
        {
            try
            {
                selectSector.Items.Clear();
                List<string> sectorId = SqliteDataAccess.GetDepartments();
                object[] obj = sectorId.ToArray();
                selectSector.Items.AddRange(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillGridSector()
        {
            try
            {
                dataGridDepartment.Rows.Clear();
                var sectors = SqliteDataAccess.GetDepartments();
                foreach (var sector in sectors)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = sector;
                    row.Cells.Add(cell);
                    DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                    List<string> list = SqliteDataAccess.UserForDepartment(sector);
                    string userforsector = string.Join(", ", list);
                    cell2.Value = userforsector;
                    row.Cells.Add(cell2);
                    dataGridDepartment.Rows.Add(row);
                }

            }
            catch
            {

            }
        }

        private void FillSectoreDel()
        {
            try
            {
                selectDelDepartment.Items.Clear();
                List<string> sectorId = SqliteDataAccess.GetDepartments();
                object[] obj = sectorId.ToArray();
                selectDelDepartment.Items.AddRange(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillSectorRemove()
        {
            try
            {
                selectDepartmentRemove.Items.Clear();
                List<string> sectorId = SqliteDataAccess.GetDepartments();
                object[] obj = sectorId.ToArray();
                selectDepartmentRemove.Items.AddRange(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
