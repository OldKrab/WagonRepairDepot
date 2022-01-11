﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WagonRepairDepot.Contexts;
using WagonRepairDepot.Controllers;

namespace WagonRepairDepot.Windows
{
    public partial class Form1 : Form
    {
        private Dictionary<TabPage, Point> pageToDataGridLocation = new();
        private Dictionary<TabPage, Action> pageToRefreshFunc = new();
        private BrigadesController _brigadesController;

        public Form1()
        {
            InitializeComponent();
            HideTabsHeader(pages);
            TrainContext db = new();


            _brigadesController = new BrigadesController(this);
            editBrigadeButton.Click += _brigadesController.EditButtonClick;
            deleteBrigadeButton.Click += _brigadesController.DeleteButtonClick;

            wagonsPage.Enter += WagonPageEnter;
            worksPage.Enter += WorksPageEnter;
            recDocPage.Enter += RecDocsPageEnter;
            retDocPage.Enter += RetDocsPageEnter;
            orderPage.Enter += OrderPageEnter;
            workersPage.Enter += WorkersPageEnter;
            receptionistsPage.Enter += ReceptionistPageEnter;
            inspectorsPage.Enter += InspectorsPageEnter;
            clientsPage.Enter += ClientsPageEnter;
            brigadiersPage.Enter += BrigadiersPageEnter;
            brigadesPage.Enter += BrigadesPageEnter;
            pages.SelectTab(wagonsPage);
            wagonsPage.Select();
            dataGrid.DataSource = db.Wagons.ToList();
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private TabPage currentPage;

        public object? GetSelectedObject() => dataGrid.SelectedRows.Count > 0 ? dataGrid.SelectedRows[0].DataBoundItem : null;

        public void RefreshDataGrid()
        {
            if (currentPage == wagonsPage) wagonsPage.Select();
            else worksPage.Select();
            currentPage.Select();
        }

        private void ConfDataGridOnPage(TabPage page, object dataSource)
        {
            dataGrid.Parent.Controls.Remove(dataGrid);
            Point loc = pageToDataGridLocation.ContainsKey(page) ? pageToDataGridLocation[page] : new Point(5, 60);
            dataGrid.Location = loc;
            dataGrid.Size = new Size(page.Size.Width - 2 * loc.X, page.Size.Height - loc.Y - loc.X);
            dataGrid.ClearSelection();
            page.Controls.Add(dataGrid);

            dataGrid.DataSource = dataSource;
            currentPage = page;

        }

        private void WagonsButtonClick(object sender, EventArgs e) => pages.SelectTab(wagonsPage);

        private void WorksButtonClick(object sender, EventArgs e) => pages.SelectTab(worksPage);

        private void DocsButtonClick(object sender, EventArgs e)
        {
            pages.SelectTab(docsPage);
            docPages.SelectTab(recDocPage);
        }

        private void UsersButtonClick(object sender, EventArgs e) => pages.SelectTab(usersPage);

        private void WagonPageEnter(object? sender, EventArgs e)
        {

            TrainContext db = new();
            ConfDataGridOnPage(wagonsPage, db.Wagons.ToList());
        }

        private void WorksPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(worksPage, db.Works.ToList());

        }
        private void RecDocsPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(recDocPage, db.WagonReceptionDocs.ToList());
        }
        private void RetDocsPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(retDocPage, db.WagonReturnDocs.ToList());
        }
        private void OrderPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(orderPage, db.WorkOrders.ToList());
        }
        private void WorkersPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(workersPage, db.Workers.ToList());
        }
        private void ReceptionistPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(receptionistsPage, db.Receptionists.ToList());
        }
        private void InspectorsPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(inspectorsPage, db.Inspectors.ToList());
        }
        private void ClientsPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(clientsPage, db.Clients.ToList());
        }
        private void BrigadiersPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            ConfDataGridOnPage(brigadiersPage, db.Brigadiers.ToList());
        }
        private void BrigadesPageEnter(object? sender, EventArgs e)
        {
            TrainContext db = new();
            db.Brigades.Load();
            ConfDataGridOnPage(brigadesPage, db.Brigades.Local.ToBindingList());
        }


        private void HideTabsHeader(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void ActualWagonsCheckboxCheckedChanged(object? sender, EventArgs e)
        {
            TrainContext db = new();
            dataGrid.DataSource = actualWagonsCheckbox.Checked ? db.ActualWagons() : db.Wagons.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFactory.CreatorForm(new Models.Wagon(), new Models.WagonFormModel()).Show();
        }
    }
}
