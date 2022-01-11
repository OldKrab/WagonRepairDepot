
namespace WagonRepairDepot.Windows
{
    partial class EditBrigadeForm
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
            this.brigadierComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.deleteWorkerButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // brigadierComboBox
            // 
            this.brigadierComboBox.FormattingEnabled = true;
            this.brigadierComboBox.Location = new System.Drawing.Point(12, 32);
            this.brigadierComboBox.Name = "brigadierComboBox";
            this.brigadierComboBox.Size = new System.Drawing.Size(307, 28);
            this.brigadierComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бригадир";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Работник";
            // 
            // workerComboBox
            // 
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(12, 99);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(307, 28);
            this.workerComboBox.TabIndex = 2;
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(325, 99);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(168, 30);
            this.addWorkerButton.TabIndex = 4;
            this.addWorkerButton.Text = "Добавить работника";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.AddWorkerButtonClick);
            // 
            // deleteWorkerButton
            // 
            this.deleteWorkerButton.Location = new System.Drawing.Point(325, 167);
            this.deleteWorkerButton.Name = "deleteWorkerButton";
            this.deleteWorkerButton.Size = new System.Drawing.Size(168, 30);
            this.deleteWorkerButton.TabIndex = 6;
            this.deleteWorkerButton.Text = "Удалить работника";
            this.deleteWorkerButton.UseVisualStyleBackColor = true;
            this.deleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButtonClick);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(325, 414);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(168, 30);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 414);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(168, 30);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(307, 224);
            this.listBox1.TabIndex = 9;
            // 
            // EditBrigadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 456);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.deleteWorkerButton);
            this.Controls.Add(this.addWorkerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brigadierComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditBrigadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение бригады";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brigadierComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.Button addWorkerButton;
        private System.Windows.Forms.Button deleteWorkerButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}