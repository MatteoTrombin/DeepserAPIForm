using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Deepser_Desktop
{
    public partial class DepartmentSetup : Form
    {
        public DepartmentSetup()
        {
            InitializeComponent();
            buttonAddDep.Click += ButtonAddSector_Click;
            buttonAddToDep.Click += ButtonAddToSect_Click;
            buttonDelDep.Click += ButtonDelSector_Click;
            buttonRemFromDep.Click += ButtonRemFromSect_Click;
            textDepartment.TextChanged += TextSector_TextChanged;
            selectDepartmentRemove.SelectedIndexChanged += SelectSectorRemove_SelectedIndexChanged;
            selectUserRemove.SelectedIndexChanged += SelectUserRemove_SelectedIndexChanged;
            selectUser.SelectedIndexChanged += SelectUser_SelectedIndexChanged;
            selectDepartment.SelectedIndexChanged += SelectSector_SelectedIndexChanged;
            selectDelDepartment.SelectedIndexChanged += SelectDelSector_SelectedIndexChanged;
            FillAllSector();
            FillAllUser();
        }

        private void TextSector_TextChanged(object? sender, EventArgs e)
        {
            buttonAddDep.Enabled = !string.IsNullOrWhiteSpace(textDepartment.Text);
        }

        private void SelectDelSector_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonDelDep.Enabled = selectDelDepartment.SelectedIndex != -1;
        }

        private void SelectSector_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonAddToDep.Enabled = selectDepartment.SelectedIndex != 1 && selectUser.SelectedIndex != -1;
        }

        private void SelectUser_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonAddToDep.Enabled = selectDepartment.SelectedIndex != 1 && selectUser.SelectedIndex != -1;
        }

        private void SelectUserRemove_SelectedIndexChanged(object? sender, EventArgs e)
        {
            buttonRemFromDep.Enabled = selectDepartmentRemove.SelectedIndex != 1 && selectUserRemove.SelectedIndex != -1;
        }

        private void SelectSectorRemove_SelectedIndexChanged(object? sender, EventArgs e)
        {
            FillUserRemove();
            buttonRemFromDep.Enabled = selectDepartmentRemove.SelectedIndex != 1 && selectUserRemove.SelectedIndex != -1;
        }

        private void ButtonRemFromSect_Click(object? sender, EventArgs e)
        {
            try
            {
                if (selectUserRemove.SelectedIndex != -1 && selectDepartmentRemove.SelectedIndex != -1)
                {
                    string user = (string)selectUserRemove.SelectedItem;
                    string sector = (string)selectDepartmentRemove.SelectedItem;
                    SqliteDataAccess.RemoveFromDepartment(user, sector);
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

        private void ButtonAddToSect_Click(object? sender, EventArgs e)
        {
            try
            {
                if (selectUser.SelectedIndex != -1 && selectDepartment.SelectedIndex != -1)
                {
                    string user = (string)selectUser.SelectedItem;
                    string sector = (string)selectDepartment.SelectedItem;
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
            selectDepartment.SelectedIndex = -1;
            selectDelDepartment.SelectedIndex = -1;
        }

        private void FillAllUser()
        {
            FillUserRemove();
            FillUserAdd();
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
        }

        private void FillSector()
        {
            try
            {
                selectDepartment.Items.Clear();
                List<string> sectorId = SqliteDataAccess.GetDepartments();
                object[] obj = sectorId.ToArray();
                selectDepartment.Items.AddRange(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
