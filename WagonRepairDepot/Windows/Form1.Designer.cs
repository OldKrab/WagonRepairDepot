
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
            this.actualWagonsCheckbox = new System.Windows.Forms.CheckBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.worksPage = new System.Windows.Forms.TabPage();
            this.docsPage = new System.Windows.Forms.TabPage();
            this.docPages = new System.Windows.Forms.TabControl();
            this.recDocPage = new System.Windows.Forms.TabPage();
            this.retDocPage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.worksButton = new System.Windows.Forms.Button();
            this.docsButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.workersPage = new System.Windows.Forms.TabPage();
            this.inspectorsPage = new System.Windows.Forms.TabPage();
            this.receptionistsPage = new System.Windows.Forms.TabPage();
            this.brigadiersPage = new System.Windows.Forms.TabPage();
            this.pages.SuspendLayout();
            this.wagonsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.docsPage.SuspendLayout();
            this.docPages.SuspendLayout();
            this.usersPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wagonsButton
            // 
            this.wagonsButton.Location = new System.Drawing.Point(12, 12);
            this.wagonsButton.Name = "wagonsButton";
            this.wagonsButton.Size = new System.Drawing.Size(187, 67);
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
            this.pages.Location = new System.Drawing.Point(205, 12);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(583, 426);
            this.pages.TabIndex = 1;
            // 
            // wagonsPage
            // 
            this.wagonsPage.BackColor = System.Drawing.Color.White;
            this.wagonsPage.Controls.Add(this.actualWagonsCheckbox);
            this.wagonsPage.Controls.Add(this.dataGrid);
            this.wagonsPage.Location = new System.Drawing.Point(30, 4);
            this.wagonsPage.Name = "wagonsPage";
            this.wagonsPage.Padding = new System.Windows.Forms.Padding(3);
            this.wagonsPage.Size = new System.Drawing.Size(549, 418);
            this.wagonsPage.TabIndex = 1;
            this.wagonsPage.Text = "wagonsPage";
            // 
            // actualWagonsCheckbox
            // 
            this.actualWagonsCheckbox.AutoSize = true;
            this.actualWagonsCheckbox.Location = new System.Drawing.Point(6, 6);
            this.actualWagonsCheckbox.Name = "actualWagonsCheckbox";
            this.actualWagonsCheckbox.Size = new System.Drawing.Size(90, 24);
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
            this.dataGrid.Location = new System.Drawing.Point(6, 54);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(537, 361);
            this.dataGrid.TabIndex = 1;
            // 
            // worksPage
            // 
            this.worksPage.BackColor = System.Drawing.Color.White;
            this.worksPage.Location = new System.Drawing.Point(30, 4);
            this.worksPage.Name = "worksPage";
            this.worksPage.Padding = new System.Windows.Forms.Padding(3);
            this.worksPage.Size = new System.Drawing.Size(549, 418);
            this.worksPage.TabIndex = 0;
            this.worksPage.Text = "worksPage";
            // 
            // docsPage
            // 
            this.docsPage.Controls.Add(this.docPages);
            this.docsPage.Location = new System.Drawing.Point(30, 4);
            this.docsPage.Name = "docsPage";
            this.docsPage.Size = new System.Drawing.Size(549, 418);
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
            this.docPages.Name = "docPages";
            this.docPages.Padding = new System.Drawing.Point(0, 0);
            this.docPages.SelectedIndex = 0;
            this.docPages.Size = new System.Drawing.Size(549, 418);
            this.docPages.TabIndex = 0;
            // 
            // recDocPage
            // 
            this.recDocPage.Location = new System.Drawing.Point(4, 29);
            this.recDocPage.Margin = new System.Windows.Forms.Padding(0);
            this.recDocPage.Name = "recDocPage";
            this.recDocPage.Size = new System.Drawing.Size(541, 385);
            this.recDocPage.TabIndex = 0;
            this.recDocPage.Text = "Договора о приеме вагона";
            this.recDocPage.UseVisualStyleBackColor = true;
            // 
            // retDocPage
            // 
            this.retDocPage.Location = new System.Drawing.Point(4, 29);
            this.retDocPage.Name = "retDocPage";
            this.retDocPage.Padding = new System.Windows.Forms.Padding(3);
            this.retDocPage.Size = new System.Drawing.Size(541, 385);
            this.retDocPage.TabIndex = 1;
            this.retDocPage.Text = "Заявления на выдачу вагона";
            this.retDocPage.UseVisualStyleBackColor = true;
            // 
            // orderPage
            // 
            this.orderPage.Location = new System.Drawing.Point(4, 29);
            this.orderPage.Name = "orderPage";
            this.orderPage.Size = new System.Drawing.Size(541, 385);
            this.orderPage.TabIndex = 2;
            this.orderPage.Text = "Заказ-наряды";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.tabControl1);
            this.usersPage.Location = new System.Drawing.Point(30, 4);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(549, 418);
            this.usersPage.TabIndex = 3;
            this.usersPage.Text = "usersPage";
            this.usersPage.UseVisualStyleBackColor = true;
            // 
            // worksButton
            // 
            this.worksButton.Location = new System.Drawing.Point(12, 85);
            this.worksButton.Name = "worksButton";
            this.worksButton.Size = new System.Drawing.Size(187, 67);
            this.worksButton.TabIndex = 2;
            this.worksButton.Text = "Работы";
            this.worksButton.UseVisualStyleBackColor = true;
            this.worksButton.Click += new System.EventHandler(this.WorksButtonClick);
            // 
            // docsButton
            // 
            this.docsButton.Location = new System.Drawing.Point(12, 158);
            this.docsButton.Name = "docsButton";
            this.docsButton.Size = new System.Drawing.Size(187, 67);
            this.docsButton.TabIndex = 3;
            this.docsButton.Text = "Документы";
            this.docsButton.UseVisualStyleBackColor = true;
            this.docsButton.Click += new System.EventHandler(this.DocsButtonClick);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(12, 231);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(187, 67);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.UsersButtonClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientsPage);
            this.tabControl1.Controls.Add(this.workersPage);
            this.tabControl1.Controls.Add(this.inspectorsPage);
            this.tabControl1.Controls.Add(this.receptionistsPage);
            this.tabControl1.Controls.Add(this.brigadiersPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // clientsPage
            // 
            this.clientsPage.Location = new System.Drawing.Point(4, 29);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsPage.Size = new System.Drawing.Size(541, 385);
            this.clientsPage.TabIndex = 0;
            this.clientsPage.Text = "Клиенты";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // workersPage
            // 
            this.workersPage.Location = new System.Drawing.Point(4, 29);
            this.workersPage.Name = "workersPage";
            this.workersPage.Padding = new System.Windows.Forms.Padding(3);
            this.workersPage.Size = new System.Drawing.Size(541, 385);
            this.workersPage.TabIndex = 1;
            this.workersPage.Text = "Работники";
            this.workersPage.UseVisualStyleBackColor = true;
            // 
            // inspectorsPage
            // 
            this.inspectorsPage.Location = new System.Drawing.Point(4, 29);
            this.inspectorsPage.Name = "inspectorsPage";
            this.inspectorsPage.Size = new System.Drawing.Size(541, 385);
            this.inspectorsPage.TabIndex = 2;
            this.inspectorsPage.Text = "Осмотрщики";
            this.inspectorsPage.UseVisualStyleBackColor = true;
            // 
            // receptionistsPage
            // 
            this.receptionistsPage.Location = new System.Drawing.Point(4, 29);
            this.receptionistsPage.Name = "receptionistsPage";
            this.receptionistsPage.Size = new System.Drawing.Size(541, 385);
            this.receptionistsPage.TabIndex = 3;
            this.receptionistsPage.Text = "Приемщики";
            this.receptionistsPage.UseVisualStyleBackColor = true;
            // 
            // brigadiersPage
            // 
            this.brigadiersPage.Location = new System.Drawing.Point(4, 29);
            this.brigadiersPage.Name = "brigadiersPage";
            this.brigadiersPage.Size = new System.Drawing.Size(541, 385);
            this.brigadiersPage.TabIndex = 4;
            this.brigadiersPage.Text = "Бригадиры";
            this.brigadiersPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.docsButton);
            this.Controls.Add(this.worksButton);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.wagonsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pages.ResumeLayout(false);
            this.wagonsPage.ResumeLayout(false);
            this.wagonsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.docsPage.ResumeLayout(false);
            this.docPages.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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
    }
}