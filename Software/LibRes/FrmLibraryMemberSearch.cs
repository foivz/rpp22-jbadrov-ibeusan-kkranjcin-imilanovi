﻿using BusinessLogicLayer.Services;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibRes
{
    public partial class FrmLibraryMemberSearch : Form
    {
        LibraryMemberService service = new LibraryMemberService();
        public FrmLibraryMemberSearch()
        {
            InitializeComponent();
        }

        private void FrmLibraryMemberSearch_Load(object sender, EventArgs e)
        {
            ShowAllMembers();
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmNewLibraryMember frmNewLibraryMember = new FrmNewLibraryMember();
            frmNewLibraryMember.ShowDialog();
            frmNewLibraryMember.Closed += FrmLibraryMember_FormClosed;
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Are You sure?", "Button Delete", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                var member = dgvMembers.CurrentRow.DataBoundItem as LibraryMember;
                service.DeleteLibraryMember(member);
            }
            ShowAllMembers();
        }

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            var member = dgvMembers.CurrentRow.DataBoundItem as LibraryMember;
            FrmLibraryMember frmLibraryMember = new FrmLibraryMember(member);
            frmLibraryMember.ShowDialog();

        }

        private void FrmLibraryMember_FormClosed(object sender, EventArgs e)
        {
            ShowAllMembers();
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            SearchMembers();
        }

        private void ShowAllMembers()
        {
            var allMembers = service.GetLibraryMembers();
            dgvMembers.DataSource = allMembers;
            dgvMembers.Columns[4].Visible = false;
        }

        private void SearchMembers()
        {
            var members = from m in service.GetLibraryMembers()
                          where m.ToString().ToLower().Contains(txtSearchMember.Text.ToLower())
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnFilter.Visible)
            {
                pnFilter.Visible = false;
            }
            else
            {
                pnFilter.Visible = true;
            }
        }

        private void btnFirstNameAsc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.FirstName ascending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnFirstNameDesc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.FirstName descending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnLastNameAsc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.LastName ascending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }

        private void btnLastNameDesc_Click(object sender, EventArgs e)
        {
            var members = from m in service.GetLibraryMembers()
                          orderby m.LastName descending
                          select m;
            dgvMembers.DataSource = members.ToList();
        }
    }
}
