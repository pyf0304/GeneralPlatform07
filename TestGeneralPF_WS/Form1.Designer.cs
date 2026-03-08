namespace TestGeneralPF_WS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.cboUserRoles = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnGetMenus4RoleId = new System.Windows.Forms.Button();
            this.btnLoginByPrjId = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnPrjUserRelation = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGetIdByMenuSetName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "根据条件获取用户的DataTable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(484, 177);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(14, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "根据用户ID获取角色ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(295, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 74);
            this.listBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(14, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "根据用户ID获取角色相关表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(6, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 25);
            this.button4.TabIndex = 5;
            this.button4.Text = "根据领导ID获取相关下属UserId";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(6, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 25);
            this.button5.TabIndex = 6;
            this.button5.Text = "根据用户ID获取入学年";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(246, 25);
            this.button6.TabIndex = 7;
            this.button6.Text = "根据用户ID获取用户对象";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(14, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 25);
            this.button7.TabIndex = 8;
            this.button7.Text = "根据用户ID获取用户名";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(14, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(244, 25);
            this.button8.TabIndex = 9;
            this.button8.Text = "获取部门列表";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(246, 25);
            this.button9.TabIndex = 10;
            this.button9.Text = "测试用户登录";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(14, 257);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(244, 25);
            this.button10.TabIndex = 11;
            this.button10.Text = "测试添加用户";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(14, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 90);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "教务管理系统专用";
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(14, 288);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(244, 25);
            this.button11.TabIndex = 13;
            this.button11.Text = "测试添加角色";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // cboUserRoles
            // 
            this.cboUserRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserRoles.FormattingEnabled = true;
            this.cboUserRoles.Location = new System.Drawing.Point(58, 18);
            this.cboUserRoles.Name = "cboUserRoles";
            this.cboUserRoles.Size = new System.Drawing.Size(164, 22);
            this.cboUserRoles.TabIndex = 14;
            this.cboUserRoles.SelectedIndexChanged += new System.EventHandler(this.cboUserRoles_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboUserRoles);
            this.groupBox2.Location = new System.Drawing.Point(502, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 411);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色菜单";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 47);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(202, 358);
            this.treeView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "角色";
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.Location = new System.Drawing.Point(14, 319);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(255, 25);
            this.button12.TabIndex = 16;
            this.button12.Text = "根据部门ID获取该部门的二级管理员ID";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.Location = new System.Drawing.Point(3, 96);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(255, 25);
            this.button13.TabIndex = 17;
            this.button13.Text = "测试用户获取菜单的HTML";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 275);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 207);
            this.textBox1.TabIndex = 18;
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Location = new System.Drawing.Point(3, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(255, 25);
            this.button14.TabIndex = 19;
            this.button14.Text = "测试公共函数";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 68);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(246, 25);
            this.button15.TabIndex = 20;
            this.button15.Text = "根据用户登录名获取用户ID";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnGetMenus4RoleId
            // 
            this.btnGetMenus4RoleId.AutoSize = true;
            this.btnGetMenus4RoleId.Location = new System.Drawing.Point(3, 127);
            this.btnGetMenus4RoleId.Name = "btnGetMenus4RoleId";
            this.btnGetMenus4RoleId.Size = new System.Drawing.Size(255, 25);
            this.btnGetMenus4RoleId.TabIndex = 21;
            this.btnGetMenus4RoleId.Text = "测试角色获取菜单的HTML";
            this.btnGetMenus4RoleId.UseVisualStyleBackColor = true;
            this.btnGetMenus4RoleId.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnLoginByPrjId
            // 
            this.btnLoginByPrjId.Location = new System.Drawing.Point(295, 499);
            this.btnLoginByPrjId.Name = "btnLoginByPrjId";
            this.btnLoginByPrjId.Size = new System.Drawing.Size(182, 25);
            this.btnLoginByPrjId.TabIndex = 22;
            this.btnLoginByPrjId.Text = "测试用户登录ByPrjId";
            this.btnLoginByPrjId.UseVisualStyleBackColor = true;
            this.btnLoginByPrjId.Click += new System.EventHandler(this.btnLoginByPrjId_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.Location = new System.Drawing.Point(3, 158);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(255, 25);
            this.button16.TabIndex = 23;
            this.button16.Text = "测试用户获取菜单的HTML";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_1);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.Location = new System.Drawing.Point(3, 189);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(255, 25);
            this.button17.TabIndex = 24;
            this.button17.Text = "测试用户获取菜单的HTML";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.Location = new System.Drawing.Point(295, 603);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(255, 25);
            this.button18.TabIndex = 25;
            this.button18.Text = "测试获取用户视图信息";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // btnPrjUserRelation
            // 
            this.btnPrjUserRelation.Location = new System.Drawing.Point(3, 34);
            this.btnPrjUserRelation.Name = "btnPrjUserRelation";
            this.btnPrjUserRelation.Size = new System.Drawing.Size(246, 25);
            this.btnPrjUserRelation.TabIndex = 26;
            this.btnPrjUserRelation.Text = "测试工程用户关系";
            this.btnPrjUserRelation.UseVisualStyleBackColor = true;
            this.btnPrjUserRelation.Click += new System.EventHandler(this.btnPrjUserRelation_Click);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.Location = new System.Drawing.Point(3, 220);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(255, 25);
            this.button19.TabIndex = 27;
            this.button19.Text = "测试角色获取某菜单集菜单的HTML";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.Location = new System.Drawing.Point(3, 251);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(255, 25);
            this.button20.TabIndex = 28;
            this.button20.Text = "测试角色Ids获取某菜单集菜单的HTML";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.AutoSize = true;
            this.button21.Location = new System.Drawing.Point(3, 282);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(244, 25);
            this.button21.TabIndex = 29;
            this.button21.Text = "测试自定义WS";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.AutoSize = true;
            this.button22.Location = new System.Drawing.Point(3, 65);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(255, 25);
            this.button22.TabIndex = 30;
            this.button22.Text = "测试获取某工程菜单集菜单的Obj";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.btnPrjUserRelation);
            this.flowLayoutPanel1.Controls.Add(this.button22);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.btnGetMenus4RoleId);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Controls.Add(this.button17);
            this.flowLayoutPanel1.Controls.Add(this.button19);
            this.flowLayoutPanel1.Controls.Add(this.button20);
            this.flowLayoutPanel1.Controls.Add(this.button21);
            this.flowLayoutPanel1.Controls.Add(this.btnGetIdByMenuSetName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(777, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 466);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // btnGetIdByMenuSetName
            // 
            this.btnGetIdByMenuSetName.AutoSize = true;
            this.btnGetIdByMenuSetName.Location = new System.Drawing.Point(3, 313);
            this.btnGetIdByMenuSetName.Name = "btnGetIdByMenuSetName";
            this.btnGetIdByMenuSetName.Size = new System.Drawing.Size(244, 25);
            this.btnGetIdByMenuSetName.TabIndex = 31;
            this.btnGetIdByMenuSetName.Text = "根据菜单集名获取Id";
            this.btnGetIdByMenuSetName.UseVisualStyleBackColor = true;
            this.btnGetIdByMenuSetName.Click += new System.EventHandler(this.btnGetIdByMenuSetName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 652);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.btnLoginByPrjId);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox cboUserRoles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnGetMenus4RoleId;
        private System.Windows.Forms.Button btnLoginByPrjId;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnPrjUserRelation;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGetIdByMenuSetName;
    }
}

