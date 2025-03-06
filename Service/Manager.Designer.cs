namespace QLCF_APP
{
    partial class Manager
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
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnChangeFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbPriceFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dataToDay = new System.Windows.Forms.DateTimePicker();
            this.dataFromDay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tcManager = new System.Windows.Forms.TabControl();
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tpAccount.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tcManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel19);
            this.tpAccount.Controls.Add(this.panel22);
            this.tpAccount.Controls.Add(this.panel27);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(961, 397);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnViewAccount);
            this.panel19.Controls.Add(this.btnChangeAccount);
            this.panel19.Controls.Add(this.btnDeleteAccount);
            this.panel19.Controls.Add(this.btnAddAccount);
            this.panel19.Location = new System.Drawing.Point(6, 6);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(575, 42);
            this.panel19.TabIndex = 9;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(448, 3);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(124, 36);
            this.btnViewAccount.TabIndex = 3;
            this.btnViewAccount.Text = "Xem";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Location = new System.Drawing.Point(292, 3);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(150, 36);
            this.btnChangeAccount.TabIndex = 2;
            this.btnChangeAccount.Text = "Xóa";
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            this.btnChangeAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(151, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(135, 36);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Sửa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(13, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(132, 36);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.panel24);
            this.panel22.Controls.Add(this.panel25);
            this.panel22.Controls.Add(this.panel26);
            this.panel22.Location = new System.Drawing.Point(590, 60);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(368, 337);
            this.panel22.TabIndex = 8;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.tbDisplayName);
            this.panel24.Controls.Add(this.label10);
            this.panel24.Location = new System.Drawing.Point(6, 60);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(362, 51);
            this.panel24.TabIndex = 5;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(109, 14);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(250, 22);
            this.tbDisplayName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.numericUpDown1);
            this.panel25.Controls.Add(this.label11);
            this.panel25.Location = new System.Drawing.Point(6, 117);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(362, 51);
            this.panel25.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại TK";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.tbUserName);
            this.panel26.Controls.Add(this.label12);
            this.panel26.Location = new System.Drawing.Point(6, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(362, 51);
            this.panel26.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(109, 14);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(250, 22);
            this.tbUserName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(3, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên tk:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.dataAccount);
            this.panel27.Location = new System.Drawing.Point(6, 60);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(578, 337);
            this.panel27.TabIndex = 7;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 25);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(961, 397);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Món ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbSearchFoodName);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Location = new System.Drawing.Point(571, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 42);
            this.panel6.TabIndex = 3;
            // 
            // tbSearchFoodName
            // 
            this.tbSearchFoodName.Location = new System.Drawing.Point(3, 10);
            this.tbSearchFoodName.Name = "tbSearchFoodName";
            this.tbSearchFoodName.Size = new System.Drawing.Size(269, 22);
            this.tbSearchFoodName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(278, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnViewFood);
            this.panel5.Controls.Add(this.btnChangeFood);
            this.panel5.Controls.Add(this.btnDeleteFood);
            this.panel5.Controls.Add(this.btnAddFood);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(559, 42);
            this.panel5.TabIndex = 2;
            // 
            // btnViewFood
            // 
            this.btnViewFood.Location = new System.Drawing.Point(411, 3);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(124, 36);
            this.btnViewFood.TabIndex = 3;
            this.btnViewFood.Text = "Xem";
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // btnChangeFood
            // 
            this.btnChangeFood.Location = new System.Drawing.Point(285, 3);
            this.btnChangeFood.Name = "btnChangeFood";
            this.btnChangeFood.Size = new System.Drawing.Size(120, 36);
            this.btnChangeFood.TabIndex = 2;
            this.btnChangeFood.Text = "Sửa";
            this.btnChangeFood.UseVisualStyleBackColor = true;
            this.btnChangeFood.Click += new System.EventHandler(this.btnChangeFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(142, 3);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(137, 36);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(3, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(133, 36);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(571, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 337);
            this.panel4.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tbPriceFood);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(3, 174);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(378, 51);
            this.panel10.TabIndex = 5;
            // 
            // tbPriceFood
            // 
            this.tbPriceFood.Location = new System.Drawing.Point(115, 17);
            this.tbPriceFood.MaxLength = 1000000000;
            this.tbPriceFood.Name = "tbPriceFood";
            this.tbPriceFood.Size = new System.Drawing.Size(250, 22);
            this.tbPriceFood.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 117);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(378, 51);
            this.panel9.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(115, 17);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(250, 24);
            this.cbCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 60);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(378, 51);
            this.panel8.TabIndex = 3;
            // 
            // tbFoodName
            // 
            this.tbFoodName.Location = new System.Drawing.Point(115, 14);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(250, 22);
            this.tbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbFoodID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 51);
            this.panel7.TabIndex = 2;
            // 
            // tbFoodID
            // 
            this.tbFoodID.Location = new System.Drawing.Point(115, 14);
            this.tbFoodID.Name = "tbFoodID";
            this.tbFoodID.ReadOnly = true;
            this.tbFoodID.Size = new System.Drawing.Size(250, 22);
            this.tbFoodID.TabIndex = 1;
            this.tbFoodID.TextChanged += new System.EventHandler(this.tbFoodID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(6, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 337);
            this.panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(3, 6);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(553, 328);
            this.dtgvFood.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(961, 397);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dataToDay);
            this.panel2.Controls.Add(this.dataFromDay);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 30);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(601, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(117, 23);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kế";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dataToDay
            // 
            this.dataToDay.Location = new System.Drawing.Point(283, 3);
            this.dataToDay.Name = "dataToDay";
            this.dataToDay.Size = new System.Drawing.Size(274, 22);
            this.dataToDay.TabIndex = 1;
            // 
            // dataFromDay
            // 
            this.dataFromDay.Location = new System.Drawing.Point(0, 3);
            this.dataFromDay.Name = "dataFromDay";
            this.dataFromDay.Size = new System.Drawing.Size(274, 22);
            this.dataFromDay.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 344);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(746, 335);
            this.dtgvBill.TabIndex = 0;
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpBill);
            this.tcManager.Controls.Add(this.tpFood);
            this.tcManager.Controls.Add(this.tpAccount);
            this.tcManager.Location = new System.Drawing.Point(16, 12);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(969, 426);
            this.tcManager.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcManager.TabIndex = 0;
            // 
            // dataAccount
            // 
            this.dataAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Location = new System.Drawing.Point(3, 0);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.RowHeadersWidth = 51;
            this.dataAccount.RowTemplate.Height = 24;
            this.dataAccount.Size = new System.Drawing.Size(572, 334);
            this.dataAccount.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.tcManager);
            this.Name = "Manager";
            this.Text = "Manager";
            this.tpAccount.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tcManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnChangeAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbSearchFoodName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnChangeFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbPriceFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dataToDay;
        private System.Windows.Forms.DateTimePicker dataFromDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}