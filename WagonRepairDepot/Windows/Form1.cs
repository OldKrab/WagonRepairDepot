using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WagonRepairDepot.Contexts;
using WagonRepairDepot.Models;

namespace WagonRepairDepot.Windows
{
    public partial class Form1 : Form
    {
        private TrainContext db = new();
        private Dictionary<TabPage, object> pageToDataSource = new();
        private Dictionary<TabPage, Point> pageToDataGridLocation = new();

        public Form1()
        {
            InitializeComponent();
            HideTabsHeader(pages);

            pages.SelectTab(wagonsPage);
            dataGrid.DataSource = db.Wagons.ToList();

            pageToDataSource[wagonsPage] = db.Wagons.ToList();
            pageToDataSource[worksPage] = db.Works.ToList();
            pageToDataSource[recDocPage] = db.WagonReceptionDocs.ToList();
            pageToDataSource[retDocPage] = db.WagonReturnDocs.ToList();
            pageToDataSource[orderPage] = db.WorkOrders.ToList();
            pageToDataSource[clientsPage] = db.Clients.ToList();
            pageToDataSource[workersPage] = db.Workers.ToList();
            pageToDataSource[inspectorsPage] = db.Inspectors.ToList();
            pageToDataSource[receptionistsPage] = db.Receptionists.ToList();
            pageToDataSource[brigadiersPage] = db.Brigadiers.ToList();

            foreach (var page in pageToDataSource.Keys)
            {
                page.Enter += SetDataGridOnPageEnter;
                pageToDataGridLocation[page] = new Point(5, 60);
            }
        }

        private void SetDataGridOnPageEnter(object? sender, EventArgs e)
        {
            var page = (TabPage)sender!;
            if (pageToDataSource.TryGetValue(page, out var data))
            {
                dataGrid.Parent.Controls.Remove(dataGrid);
               
                var loc = pageToDataGridLocation[page];
                dataGrid.Location = loc;
                dataGrid.Size = new Size(page.Size.Width - 2 * loc.X, page.Size.Height - loc.Y);
                
                page.Controls.Add(dataGrid);
                
                dataGrid.DataSource = data;
                Console.WriteLine(dataGrid.Location);
                Console.WriteLine(dataGrid.Size);
            }
        }
        private void WagonsButtonClick(object sender, EventArgs e) => pages.SelectTab(wagonsPage);

        private void WorksButtonClick(object sender, EventArgs e) => pages.SelectTab(worksPage);

        private void DocsButtonClick(object sender, EventArgs e)
        {
            pages.SelectTab(docsPage);
            docPages.SelectTab(recDocPage);
        }

        private void UsersButtonClick(object sender, EventArgs e) => pages.SelectTab(usersPage);


        private void HideTabsHeader(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void ActualWagonsCheckboxCheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = actualWagonsCheckbox.Checked ? db.ActualWagons() : db.Wagons.ToList();

        }


    }
}
