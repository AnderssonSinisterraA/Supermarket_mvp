namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            DgProduct = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabPageProductDetail = new TabPage();
            TxtProductCategoryId = new TextBox();
            TxtProductStock = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 27);
            label1.Name = "label1";
            label1.Size = new Size(149, 49);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(label3);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 322);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(19, 71);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.Size = new Size(571, 238);
            DgProduct.TabIndex = 15;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar1;
            BtnClose.Location = new Point(613, 254);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(160, 55);
            BtnClose.TabIndex = 14;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(613, 193);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(160, 55);
            BtnDelete.TabIndex = 13;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(613, 132);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(160, 55);
            BtnEdit.TabIndex = 12;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(613, 71);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(160, 55);
            BtnNew.TabIndex = 11;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(535, 13);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(55, 45);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(19, 35);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(510, 23);
            TxtSearch.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 13);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 8;
            label3.Text = "Search Pay Mode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 10);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductCategoryId);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(label8);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 322);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductCategoryId
            // 
            TxtProductCategoryId.Location = new Point(32, 208);
            TxtProductCategoryId.Name = "TxtProductCategoryId";
            TxtProductCategoryId.Size = new Size(338, 23);
            TxtProductCategoryId.TabIndex = 14;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(32, 164);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(338, 23);
            TxtProductStock.TabIndex = 13;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(32, 120);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(338, 23);
            TxtProductPrice.TabIndex = 12;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(32, 76);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(338, 23);
            TxtProductName.TabIndex = 11;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(32, 30);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(338, 23);
            TxtProductId.TabIndex = 10;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(160, 247);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(88, 58);
            BtnCancel.TabIndex = 9;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(32, 247);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(92, 58);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 190);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 4;
            label8.Text = "Category Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 146);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 3;
            label7.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 102);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 2;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 58);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 12);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 0;
            label4.Text = "Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Label label2;
        private DataGridView DgProduct;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductCategoryId;
        private TextBox TxtProductStock;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
    }
}