
namespace WagonRepairDepot.Windows
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wagonsButton = new System.Windows.Forms.Button();
            this.pages = new System.Windows.Forms.TabControl();
            this.wagonsPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.actualWagonsCheckbox = new System.Windows.Forms.CheckBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.worksPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.docsPage = new System.Windows.Forms.TabPage();
            this.docPages = new System.Windows.Forms.TabControl();
            this.recDocPage = new System.Windows.Forms.TabPage();
            this.retDocPage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.workersPage = new System.Windows.Forms.TabPage();
            this.inspectorsPage = new System.Windows.Forms.TabPage();
            this.receptionistsPage = new System.Windows.Forms.TabPage();
            this.brigadiersPage = new System.Windows.Forms.TabPage();
            this.brigadesPage = new System.Windows.Forms.TabPage();
            this.deleteBrigadeButton = new System.Windows.Forms.Button();
            this.editBrigadeButton = new System.Windows.Forms.Button();
            this.worksButton = new System.Windows.Forms.Button();
            this.docsButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.saveExportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pages.SuspendLayout();
            this.wagonsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.worksPage.SuspendLayout();
            this.docsPage.SuspendLayout();
            this.docPages.SuspendLayout();
            this.usersPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.brigadesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // wagonsButton
            // 
            this.wagonsButton.Location = new System.Drawing.Point(10, 9);
            this.wagonsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wagonsButton.Name = "wagonsButton";
            this.wagonsButton.Size = new System.Drawing.Size(164, 50);
            this.wagonsButton.TabIndex = 0;
            this.wagonsButton.Text = "Вагоны";
            this.wagonsButton.UseVisualStyleBackColor = true;
            this.wagonsButton.Click += new System.EventHandler(this.WagonsButtonClick);
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.Controls.Add(this.wagonsPage);
            this.pages.Controls.Add(this.worksPage);
            this.pages.Controls.Add(this.docsPage);
            this.pages.Controls.Add(this.usersPage);
            this.pages.Location = new System.Drawing.Point(179, 9);
            this.pages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(823, 482);
            this.pages.TabIndex = 1;
            // 
            // wagonsPage
            // 
            this.wagonsPage.BackColor = System.Drawing.Color.White;
            this.wagonsPage.Controls.Add(this.button1);
            this.wagonsPage.Controls.Add(this.actualWagonsCheckbox);
            this.wagonsPage.Controls.Add(this.dataGrid);
            this.wagonsPage.Location = new System.Drawing.Point(27, 4);
            this.wagonsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wagonsPage.Name = "wagonsPage";
            this.wagonsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wagonsPage.Size = new System.Drawing.Size(792, 474);
            this.wagonsPage.TabIndex = 1;
            this.wagonsPage.Text = "wagonsPage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // actualWagonsCheckbox
            // 
            this.actualWagonsCheckbox.AutoSize = true;
            this.actualWagonsCheckbox.Location = new System.Drawing.Point(5, 4);
            this.actualWagonsCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualWagonsCheckbox.Name = "actualWagonsCheckbox";
            this.actualWagonsCheckbox.Size = new System.Drawing.Size(74, 19);
            this.actualWagonsCheckbox.TabIndex = 2;
            this.actualWagonsCheckbox.Text = "Текущие";
            this.actualWagonsCheckbox.UseVisualStyleBackColor = true;
            this.actualWagonsCheckbox.CheckedChanged += new System.EventHandler(this.ActualWagonsCheckboxCheckedChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(5, 40);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 22, 3, 2);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(470, 271);
            this.dataGrid.TabIndex = 1;
            // 
            // worksPage
            // 
            this.worksPage.BackColor = System.Drawing.Color.White;
            this.worksPage.Controls.Add(this.button2);
            this.worksPage.Location = new System.Drawing.Point(27, 4);
            this.worksPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.worksPage.Name = "worksPage";
            this.worksPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.worksPage.Size = new System.Drawing.Size(792, 474);
            this.worksPage.TabIndex = 0;
            this.worksPage.Text = "worksPage";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // docsPage
            // 
            this.docsPage.Controls.Add(this.docPages);
            this.docsPage.Location = new System.Drawing.Point(27, 4);
            this.docsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docsPage.Name = "docsPage";
            this.docsPage.Size = new System.Drawing.Size(792, 474);
            this.docsPage.TabIndex = 2;
            this.docsPage.Text = "docsPage";
            this.docsPage.UseVisualStyleBackColor = true;
            // 
            // docPages
            // 
            this.docPages.Controls.Add(this.recDocPage);
            this.docPages.Controls.Add(this.retDocPage);
            this.docPages.Controls.Add(this.orderPage);
            this.docPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docPages.Location = new System.Drawing.Point(0, 0);
            this.docPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docPages.Name = "docPages";
            this.docPages.Padding = new System.Drawing.Point(0, 0);
            this.docPages.SelectedIndex = 0;
            this.docPages.Size = new System.Drawing.Size(792, 474);
            this.docPages.TabIndex = 0;
            // 
            // recDocPage
            // 
            this.recDocPage.Location = new System.Drawing.Point(4, 24);
            this.recDocPage.Margin = new System.Windows.Forms.Padding(0);
            this.recDocPage.Name = "recDocPage";
            this.recDocPage.Size = new System.Drawing.Size(784, 446);
            this.recDocPage.TabIndex = 0;
            this.recDocPage.Text = "Договора о приеме вагона";
            this.recDocPage.UseVisualStyleBackColor = true;
            // 
            // retDocPage
            // 
            this.retDocPage.Location = new System.Drawing.Point(4, 24);
            this.retDocPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retDocPage.Name = "retDocPage";
            this.retDocPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retDocPage.Size = new System.Drawing.Size(784, 446);
            this.retDocPage.TabIndex = 1;
            this.retDocPage.Text = "Заявления на выдачу вагона";
            this.retDocPage.UseVisualStyleBackColor = true;
            // 
            // orderPage
            // 
            this.orderPage.Location = new System.Drawing.Point(4, 24);
            this.orderPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderPage.Name = "orderPage";
            this.orderPage.Size = new System.Drawing.Size(784, 446);
            this.orderPage.TabIndex = 2;
            this.orderPage.Text = "Заказ-наряды";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.tabControl1);
            this.usersPage.Location = new System.Drawing.Point(27, 4);
            this.usersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(792, 474);
            this.usersPage.TabIndex = 3;
            this.usersPage.Text = "usersPage";
            this.usersPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientsPage);
            this.tabControl1.Controls.Add(this.workersPage);
            this.tabControl1.Controls.Add(this.inspectorsPage);
            this.tabControl1.Controls.Add(this.receptionistsPage);
            this.tabControl1.Controls.Add(this.brigadiersPage);
            this.tabControl1.Controls.Add(this.brigadesPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // clientsPage
            // 
            this.clientsPage.Location = new System.Drawing.Point(4, 24);
            this.clientsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsPage.Size = new System.Drawing.Size(784, 446);
            this.clientsPage.TabIndex = 0;
            this.clientsPage.Text = "Клиенты";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // workersPage
            // 
            this.workersPage.Location = new System.Drawing.Point(4, 24);
            this.workersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workersPage.Name = "workersPage";
            this.workersPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workersPage.Size = new System.Drawing.Size(784, 446);
            this.workersPage.TabIndex = 1;
            this.workersPage.Text = "Работники";
            this.workersPage.UseVisualStyleBackColor = true;
            // 
            // inspectorsPage
            // 
            this.inspectorsPage.Location = new System.Drawing.Point(4, 24);
            this.inspectorsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inspectorsPage.Name = "inspectorsPage";
            this.inspectorsPage.Size = new System.Drawing.Size(784, 446);
            this.inspectorsPage.TabIndex = 2;
            this.inspectorsPage.Text = "Осмотрщики";
            this.inspectorsPage.UseVisualStyleBackColor = true;
            // 
            // receptionistsPage
            // 
            this.receptionistsPage.Location = new System.Drawing.Point(4, 24);
            this.receptionistsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receptionistsPage.Name = "receptionistsPage";
            this.receptionistsPage.Size = new System.Drawing.Size(784, 446);
            this.receptionistsPage.TabIndex = 3;
            this.receptionistsPage.Text = "Приемщики";
            this.receptionistsPage.UseVisualStyleBackColor = true;
            // 
            // brigadiersPage
            // 
            this.brigadiersPage.Location = new System.Drawing.Point(4, 24);
            this.brigadiersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brigadiersPage.Name = "brigadiersPage";
            this.brigadiersPage.Size = new System.Drawing.Size(784, 446);
            this.brigadiersPage.TabIndex = 4;
            this.brigadiersPage.Text = "Бригадиры";
            this.brigadiersPage.UseVisualStyleBackColor = true;
            // 
            // brigadesPage
            // 
            this.brigadesPage.Controls.Add(this.deleteBrigadeButton);
            this.brigadesPage.Controls.Add(this.editBrigadeButton);
            this.brigadesPage.Location = new System.Drawing.Point(4, 24);
            this.brigadesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brigadesPage.Name = "brigadesPage";
            this.brigadesPage.Size = new System.Drawing.Size(784, 446);
            this.brigadesPage.TabIndex = 5;
            this.brigadesPage.Text = "Бригады";
            this.brigadesPage.UseVisualStyleBackColor = true;
            // 
            // deleteBrigadeButton
            // 
            this.deleteBrigadeButton.Location = new System.Drawing.Point(100, 13);
            this.deleteBrigadeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBrigadeButton.Name = "deleteBrigadeButton";
            this.deleteBrigadeButton.Size = new System.Drawing.Size(82, 22);
            this.deleteBrigadeButton.TabIndex = 1;
            this.deleteBrigadeButton.Text = "Удалить";
            this.deleteBrigadeButton.UseVisualStyleBackColor = true;
            // 
            // editBrigadeButton
            // 
            this.editBrigadeButton.Location = new System.Drawing.Point(12, 13);
            this.editBrigadeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBrigadeButton.Name = "editBrigadeButton";
            this.editBrigadeButton.Size = new System.Drawing.Size(82, 22);
            this.editBrigadeButton.TabIndex = 0;
            this.editBrigadeButton.Text = "Изменить";
            this.editBrigadeButton.UseVisualStyleBackColor = true;
            // 
            // worksButton
            // 
            this.worksButton.Location = new System.Drawing.Point(10, 64);
            this.worksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.worksButton.Name = "worksButton";
            this.worksButton.Size = new System.Drawing.Size(164, 50);
            this.worksButton.TabIndex = 2;
            this.worksButton.Text = "Работы";
            this.worksButton.UseVisualStyleBackColor = true;
            this.worksButton.Click += new System.EventHandler(this.WorksButtonClick);
            // 
            // docsButton
            // 
            this.docsButton.Location = new System.Drawing.Point(10, 118);
            this.docsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docsButton.Name = "docsButton";
            this.docsButton.Size = new System.Drawing.Size(164, 50);
            this.docsButton.TabIndex = 3;
            this.docsButton.Text = "Документы";
            this.docsButton.UseVisualStyleBackColor = true;
            this.docsButton.Click += new System.EventHandler(this.DocsButtonClick);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(10, 173);
            this.usersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(164, 50);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.UsersButtonClick);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 441);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(164, 50);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "Экспортировать текущую таблицу";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 500);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.docsButton);
            this.Controls.Add(this.worksButton);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.wagonsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pages.ResumeLayout(false);
            this.wagonsPage.ResumeLayout(false);
            this.wagonsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.worksPage.ResumeLayout(false);
            this.docsPage.ResumeLayout(false);
            this.docPages.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.brigadesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wagonsButton;
        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage worksPage;
        private System.Windows.Forms.TabPage wagonsPage;
        private System.Windows.Forms.Button worksButton;
        private System.Windows.Forms.TabPage docsPage;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.Button docsButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.CheckBox actualWagonsCheckbox;
        private System.Windows.Forms.TabControl docPages;
        private System.Windows.Forms.TabPage recDocPage;
        private System.Windows.Forms.TabPage retDocPage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.TabPage workersPage;
        private System.Windows.Forms.TabPage inspectorsPage;
        private System.Windows.Forms.TabPage receptionistsPage;
        private System.Windows.Forms.TabPage brigadiersPage;
        private System.Windows.Forms.TabPage brigadesPage;
        private System.Windows.Forms.Button editBrigadeButton;
        private System.Windows.Forms.Button deleteBrigadeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.SaveFileDialog saveExportFileDialog;
        private System.Windows.Forms.Button button2;
    }
}