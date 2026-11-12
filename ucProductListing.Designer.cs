namespace Damas_Week06_Work05
{
    partial class ucProductListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbItemDetails = new GroupBox();
            cmbUnit = new ComboBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            lbxItems = new ListBox();
            lblPrompt = new Label();
            gbItemDetails.SuspendLayout();
            SuspendLayout();
            // 
            // gbItemDetails
            // 
            gbItemDetails.BackColor = SystemColors.ActiveCaption;
            gbItemDetails.Controls.Add(cmbUnit);
            gbItemDetails.Controls.Add(txtAmount);
            gbItemDetails.Controls.Add(lblAmount);
            gbItemDetails.Controls.Add(txtDescription);
            gbItemDetails.Controls.Add(lblDescription);
            gbItemDetails.Location = new Point(47, 15);
            gbItemDetails.Name = "gbItemDetails";
            gbItemDetails.Size = new Size(372, 92);
            gbItemDetails.TabIndex = 2;
            gbItemDetails.TabStop = false;
            gbItemDetails.Text = "ItemDetails";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(233, 60);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(82, 23);
            cmbUnit.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(71, 59);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 23);
            txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(22, 62);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(71, 26);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(278, 23);
            txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 28);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.Location = new Point(442, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(442, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbxItems
            // 
            lbxItems.FormattingEnabled = true;
            lbxItems.ItemHeight = 15;
            lbxItems.Location = new Point(47, 113);
            lbxItems.Name = "lbxItems";
            lbxItems.Size = new Size(465, 184);
            lbxItems.TabIndex = 5;
            lbxItems.SelectedIndexChanged += lbxItems_SelectedIndexChanged;
            // 
            // lblPrompt
            // 
            lblPrompt.BackColor = Color.IndianRed;
            lblPrompt.Location = new Point(47, 310);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(465, 27);
            lblPrompt.TabIndex = 5;
            lblPrompt.Text = "Prompt";
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            lblPrompt.Visible = false;
            // 
            // ucProductListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(lblPrompt);
            Controls.Add(lbxItems);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(gbItemDetails);
            Name = "ucProductListing";
            Size = new Size(658, 346);
            Load += ucProductListing_Load;
            gbItemDetails.ResumeLayout(false);
            gbItemDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbItemDetails;
        private ComboBox cmbUnit;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox lbxItems;
        private Label lblAmount;
        private Label lblPrompt;
    }
}
