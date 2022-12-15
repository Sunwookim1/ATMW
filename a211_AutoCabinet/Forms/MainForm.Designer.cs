
using ATMW.Controls;

namespace ATMW.Forms
{
    partial class ATMW_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMW_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gateModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTimeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripLog = new System.Windows.Forms.StatusStrip();
            this.panelTagDataView = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTagDataView = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExcelSave = new System.Windows.Forms.Button();
            this.btnInvenStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxComList = new System.Windows.Forms.ComboBox();
            this.labelRfidInventoryElapsedTimeValue = new System.Windows.Forms.Label();
            this.buttonComSearch = new System.Windows.Forms.Button();
            this.buttonRfidInventory = new System.Windows.Forms.Button();
            this.buttonRfidConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewAntTagData = new System.Windows.Forms.ListView();
            this.colEpc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRssi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.labelEventAntNum = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTagSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearchTag = new System.Windows.Forms.TextBox();
            this.buttonSearchTag = new System.Windows.Forms.Button();
            this.CurrentLoactionColorCheck = new System.Windows.Forms.Timer(this.components);
            this.LVDebugMode = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buffersize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InventoryTimer = new System.Windows.Forms.Timer(this.components);
            this.listViewTagDataView = new System.Windows.Forms.ListView();
            this.APITimer = new System.Windows.Forms.Timer(this.components);
            this.tabPageDebugMode = new System.Windows.Forms.TabPage();
            this.tabPageListMode = new System.Windows.Forms.TabPage();
            this.tabPageTableMode = new System.Windows.Forms.TabPage();
            this.tabControlModeTab = new System.Windows.Forms.TabControl();
            this.HartBitTimer = new System.Windows.Forms.Timer(this.components);
            this.tagDataView1 = new ATMW.Controls.TagDataView();
            this.tagDataView2 = new ATMW.Controls.TagDataView();
            this.tagDataView3 = new ATMW.Controls.TagDataView();
            this.tagDataView4 = new ATMW.Controls.TagDataView();
            this.tagDataView5 = new ATMW.Controls.TagDataView();
            this.tagDataView6 = new ATMW.Controls.TagDataView();
            this.tagDataView7 = new ATMW.Controls.TagDataView();
            this.tagDataView8 = new ATMW.Controls.TagDataView();
            this.tagDataView9 = new ATMW.Controls.TagDataView();
            this.tagDataView10 = new ATMW.Controls.TagDataView();
            this.tagDataView11 = new ATMW.Controls.TagDataView();
            this.tagDataView12 = new ATMW.Controls.TagDataView();
            this.tagDataView13 = new ATMW.Controls.TagDataView();
            this.tagDataView14 = new ATMW.Controls.TagDataView();
            this.tagDataView15 = new ATMW.Controls.TagDataView();
            this.tagDataView16 = new ATMW.Controls.TagDataView();
            this.tagDataView17 = new ATMW.Controls.TagDataView();
            this.tagDataView18 = new ATMW.Controls.TagDataView();
            this.tagDataView19 = new ATMW.Controls.TagDataView();
            this.tagDataView20 = new ATMW.Controls.TagDataView();
            this.tagDataView21 = new ATMW.Controls.TagDataView();
            this.tagDataView22 = new ATMW.Controls.TagDataView();
            this.tagDataView23 = new ATMW.Controls.TagDataView();
            this.tagDataView24 = new ATMW.Controls.TagDataView();
            this.tagDataView25 = new ATMW.Controls.TagDataView();
            this.tagDataView26 = new ATMW.Controls.TagDataView();
            this.tagDataView27 = new ATMW.Controls.TagDataView();
            this.tagDataView28 = new ATMW.Controls.TagDataView();
            this.tagDataView29 = new ATMW.Controls.TagDataView();
            this.tagDataView30 = new ATMW.Controls.TagDataView();
            this.tagDataView31 = new ATMW.Controls.TagDataView();
            this.tagDataView32 = new ATMW.Controls.TagDataView();
            this.tagDataView33 = new ATMW.Controls.TagDataView();
            this.tagDataView34 = new ATMW.Controls.TagDataView();
            this.tagDataView35 = new ATMW.Controls.TagDataView();
            this.tagDataView36 = new ATMW.Controls.TagDataView();
            this.tagDataView37 = new ATMW.Controls.TagDataView();
            this.tagDataView38 = new ATMW.Controls.TagDataView();
            this.tagDataView39 = new ATMW.Controls.TagDataView();
            this.tagDataView40 = new ATMW.Controls.TagDataView();
            this.tagDataView41 = new ATMW.Controls.TagDataView();
            this.tagDataView42 = new ATMW.Controls.TagDataView();
            this.tagDataView43 = new ATMW.Controls.TagDataView();
            this.tagDataView44 = new ATMW.Controls.TagDataView();
            this.tagDataView45 = new ATMW.Controls.TagDataView();
            this.tagDataView46 = new ATMW.Controls.TagDataView();
            this.tagDataView47 = new ATMW.Controls.TagDataView();
            this.tagDataView48 = new ATMW.Controls.TagDataView();
            this.tagDataView49 = new ATMW.Controls.TagDataView();
            this.tagDataView50 = new ATMW.Controls.TagDataView();
            this.tagDataView51 = new ATMW.Controls.TagDataView();
            this.tagDataView52 = new ATMW.Controls.TagDataView();
            this.tagDataView53 = new ATMW.Controls.TagDataView();
            this.tagDataView54 = new ATMW.Controls.TagDataView();
            this.tagDataView55 = new ATMW.Controls.TagDataView();
            this.tagDataView56 = new ATMW.Controls.TagDataView();
            this.tagDataView57 = new ATMW.Controls.TagDataView();
            this.tagDataView58 = new ATMW.Controls.TagDataView();
            this.tagDataView59 = new ATMW.Controls.TagDataView();
            this.tagDataView60 = new ATMW.Controls.TagDataView();
            this.tagDataView61 = new ATMW.Controls.TagDataView();
            this.tagDataView62 = new ATMW.Controls.TagDataView();
            this.tagDataView63 = new ATMW.Controls.TagDataView();
            this.tagDataView64 = new ATMW.Controls.TagDataView();
            this.tagDataView65 = new ATMW.Controls.TagDataView();
            this.tagDataView66 = new ATMW.Controls.TagDataView();
            this.tagDataView67 = new ATMW.Controls.TagDataView();
            this.tagDataView68 = new ATMW.Controls.TagDataView();
            this.tagDataView69 = new ATMW.Controls.TagDataView();
            this.tagDataView70 = new ATMW.Controls.TagDataView();
            this.tagDataView71 = new ATMW.Controls.TagDataView();
            this.tagDataView72 = new ATMW.Controls.TagDataView();
            this.tagDataView73 = new ATMW.Controls.TagDataView();
            this.tagDataView74 = new ATMW.Controls.TagDataView();
            this.tagDataView75 = new ATMW.Controls.TagDataView();
            this.tagDataView76 = new ATMW.Controls.TagDataView();
            this.tagDataView77 = new ATMW.Controls.TagDataView();
            this.tagDataView78 = new ATMW.Controls.TagDataView();
            this.tagDataView79 = new ATMW.Controls.TagDataView();
            this.tagDataView80 = new ATMW.Controls.TagDataView();
            this.tagDataView81 = new ATMW.Controls.TagDataView();
            this.tagDataView82 = new ATMW.Controls.TagDataView();
            this.tagDataView83 = new ATMW.Controls.TagDataView();
            this.tagDataView84 = new ATMW.Controls.TagDataView();
            this.tagDataView85 = new ATMW.Controls.TagDataView();
            this.tagDataView86 = new ATMW.Controls.TagDataView();
            this.tagDataView87 = new ATMW.Controls.TagDataView();
            this.tagDataView88 = new ATMW.Controls.TagDataView();
            this.tagDataView89 = new ATMW.Controls.TagDataView();
            this.tagDataView90 = new ATMW.Controls.TagDataView();
            this.tagDataView91 = new ATMW.Controls.TagDataView();
            this.tagDataView92 = new ATMW.Controls.TagDataView();
            this.tagDataView93 = new ATMW.Controls.TagDataView();
            this.tagDataView94 = new ATMW.Controls.TagDataView();
            this.tagDataView95 = new ATMW.Controls.TagDataView();
            this.tagDataView96 = new ATMW.Controls.TagDataView();
            this.tagDataView97 = new ATMW.Controls.TagDataView();
            this.tagDataView98 = new ATMW.Controls.TagDataView();
            this.tagDataView99 = new ATMW.Controls.TagDataView();
            this.tagDataView100 = new ATMW.Controls.TagDataView();
            this.tagDataView101 = new ATMW.Controls.TagDataView();
            this.tagDataView102 = new ATMW.Controls.TagDataView();
            this.tagDataView103 = new ATMW.Controls.TagDataView();
            this.tagDataView104 = new ATMW.Controls.TagDataView();
            this.tagDataView105 = new ATMW.Controls.TagDataView();
            this.tagDataView106 = new ATMW.Controls.TagDataView();
            this.tagDataView107 = new ATMW.Controls.TagDataView();
            this.tagDataView108 = new ATMW.Controls.TagDataView();
            this.tagDataView109 = new ATMW.Controls.TagDataView();
            this.tagDataView110 = new ATMW.Controls.TagDataView();
            this.tagDataView111 = new ATMW.Controls.TagDataView();
            this.tagDataView112 = new ATMW.Controls.TagDataView();
            this.tagDataView113 = new ATMW.Controls.TagDataView();
            this.tagDataView114 = new ATMW.Controls.TagDataView();
            this.tagDataView115 = new ATMW.Controls.TagDataView();
            this.tagDataView116 = new ATMW.Controls.TagDataView();
            this.tagDataView117 = new ATMW.Controls.TagDataView();
            this.tagDataView118 = new ATMW.Controls.TagDataView();
            this.tagDataView119 = new ATMW.Controls.TagDataView();
            this.tagDataView120 = new ATMW.Controls.TagDataView();
            this.tagDataView121 = new ATMW.Controls.TagDataView();
            this.tagDataView122 = new ATMW.Controls.TagDataView();
            this.tagDataView123 = new ATMW.Controls.TagDataView();
            this.tagDataView124 = new ATMW.Controls.TagDataView();
            this.tagDataView125 = new ATMW.Controls.TagDataView();
            this.tagDataView126 = new ATMW.Controls.TagDataView();
            this.tagDataView127 = new ATMW.Controls.TagDataView();
            this.tagDataView128 = new ATMW.Controls.TagDataView();
            this.menuStrip1.SuspendLayout();
            this.panelTagDataView.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxTagSearch.SuspendLayout();
            this.tabControlModeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // memuToolStripMenuItem
            // 
            resources.ApplyResources(this.memuToolStripMenuItem, "memuToolStripMenuItem");
            this.memuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1,
            this.languageToolStripMenuItem,
            this.gateModeToolStripMenuItem});
            this.memuToolStripMenuItem.Name = "memuToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // gateModeToolStripMenuItem
            // 
            resources.ApplyResources(this.gateModeToolStripMenuItem, "gateModeToolStripMenuItem");
            this.gateModeToolStripMenuItem.Name = "gateModeToolStripMenuItem";
            this.gateModeToolStripMenuItem.Click += new System.EventHandler(this.gateModeToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korToolStripMenuItem,
            this.engToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // korToolStripMenuItem
            // 
            resources.ApplyResources(this.korToolStripMenuItem, "korToolStripMenuItem");
            this.korToolStripMenuItem.Checked = true;
            this.korToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.korToolStripMenuItem.Name = "korToolStripMenuItem";
            this.korToolStripMenuItem.Click += new System.EventHandler(this.korToolStripMenuItem_Click);
            // 
            // engToolStripMenuItem
            // 
            resources.ApplyResources(this.engToolStripMenuItem, "engToolStripMenuItem");
            this.engToolStripMenuItem.Name = "engToolStripMenuItem";
            this.engToolStripMenuItem.Click += new System.EventHandler(this.engToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            resources.ApplyResources(this.settingToolStripMenuItem, "settingToolStripMenuItem");
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultSettingsToolStripMenuItem,
            this.modeSettingToolStripMenuItem,
            this.updateTimeSettingToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            // 
            // defaultSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.defaultSettingsToolStripMenuItem, "defaultSettingsToolStripMenuItem");
            this.defaultSettingsToolStripMenuItem.Name = "defaultSettingsToolStripMenuItem";
            this.defaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.devSettingToolStripMenuItem_Click);
            // 
            // modeSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.modeSettingToolStripMenuItem, "modeSettingToolStripMenuItem");
            this.modeSettingToolStripMenuItem.Name = "modeSettingToolStripMenuItem";
            this.modeSettingToolStripMenuItem.Click += new System.EventHandler(this.modeSettingToolStripMenuItem_Click);
            // 
            // updateTimeSettingToolStripMenuItem
            // 
            resources.ApplyResources(this.updateTimeSettingToolStripMenuItem, "updateTimeSettingToolStripMenuItem");
            this.updateTimeSettingToolStripMenuItem.Name = "updateTimeSettingToolStripMenuItem";
            this.updateTimeSettingToolStripMenuItem.Click += new System.EventHandler(this.updateTimeSettingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStripLog
            // 
            resources.ApplyResources(this.statusStripLog, "statusStripLog");
            this.statusStripLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStripLog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripLog.Name = "statusStripLog";
            // 
            // panelTagDataView
            // 
            resources.ApplyResources(this.panelTagDataView, "panelTagDataView");
            this.panelTagDataView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTagDataView.Controls.Add(this.tableLayoutPanelTagDataView);
            this.panelTagDataView.Name = "panelTagDataView";
            // 
            // tableLayoutPanelTagDataView
            // 
            resources.ApplyResources(this.tableLayoutPanelTagDataView, "tableLayoutPanelTagDataView");
            this.tableLayoutPanelTagDataView.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelTagDataView.Name = "tableLayoutPanelTagDataView";
            this.tableLayoutPanelTagDataView.Resize += new System.EventHandler(this.tableLayoutPanelTagDataView_Resize);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBoxTagSearch);
            this.panel2.Name = "panel2";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.btnExcelSave);
            this.groupBox4.Controls.Add(this.btnInvenStop);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxComList);
            this.groupBox4.Controls.Add(this.labelRfidInventoryElapsedTimeValue);
            this.groupBox4.Controls.Add(this.buttonComSearch);
            this.groupBox4.Controls.Add(this.buttonRfidInventory);
            this.groupBox4.Controls.Add(this.buttonRfidConnect);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btnExcelSave
            // 
            resources.ApplyResources(this.btnExcelSave, "btnExcelSave");
            this.btnExcelSave.Name = "btnExcelSave";
            this.btnExcelSave.UseVisualStyleBackColor = true;
            this.btnExcelSave.Click += new System.EventHandler(this.btnExcelSave_Click);
            // 
            // btnInvenStop
            // 
            resources.ApplyResources(this.btnInvenStop, "btnInvenStop");
            this.btnInvenStop.Name = "btnInvenStop";
            this.btnInvenStop.UseVisualStyleBackColor = true;
            this.btnInvenStop.Click += new System.EventHandler(this.btnInvenStop_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxComList
            // 
            resources.ApplyResources(this.comboBoxComList, "comboBoxComList");
            this.comboBoxComList.FormattingEnabled = true;
            this.comboBoxComList.Name = "comboBoxComList";
            this.comboBoxComList.DropDown += new System.EventHandler(this.comboBoxComList_DropDown);
            this.comboBoxComList.SelectedIndexChanged += new System.EventHandler(this.comboBoxComList_SelectedIndexChanged);
            // 
            // labelRfidInventoryElapsedTimeValue
            // 
            resources.ApplyResources(this.labelRfidInventoryElapsedTimeValue, "labelRfidInventoryElapsedTimeValue");
            this.labelRfidInventoryElapsedTimeValue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelRfidInventoryElapsedTimeValue.Name = "labelRfidInventoryElapsedTimeValue";
            // 
            // buttonComSearch
            // 
            resources.ApplyResources(this.buttonComSearch, "buttonComSearch");
            this.buttonComSearch.Name = "buttonComSearch";
            this.buttonComSearch.UseVisualStyleBackColor = true;
            this.buttonComSearch.Click += new System.EventHandler(this.buttonComSearch_Click);
            // 
            // buttonRfidInventory
            // 
            resources.ApplyResources(this.buttonRfidInventory, "buttonRfidInventory");
            this.buttonRfidInventory.Name = "buttonRfidInventory";
            this.buttonRfidInventory.UseVisualStyleBackColor = true;
            this.buttonRfidInventory.Click += new System.EventHandler(this.buttonRfidInventory_Click);
            // 
            // buttonRfidConnect
            // 
            resources.ApplyResources(this.buttonRfidConnect, "buttonRfidConnect");
            this.buttonRfidConnect.Name = "buttonRfidConnect";
            this.buttonRfidConnect.UseVisualStyleBackColor = true;
            this.buttonRfidConnect.Click += new System.EventHandler(this.buttonRfidConnect_Click);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.listViewAntTagData);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelEventAntNum);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // listViewAntTagData
            // 
            resources.ApplyResources(this.listViewAntTagData, "listViewAntTagData");
            this.listViewAntTagData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEpc,
            this.colRssi});
            this.listViewAntTagData.FullRowSelect = true;
            this.listViewAntTagData.GridLines = true;
            this.listViewAntTagData.HideSelection = false;
            this.listViewAntTagData.Name = "listViewAntTagData";
            this.listViewAntTagData.UseCompatibleStateImageBehavior = false;
            this.listViewAntTagData.View = System.Windows.Forms.View.Details;
            // 
            // colEpc
            // 
            resources.ApplyResources(this.colEpc, "colEpc");
            // 
            // colRssi
            // 
            resources.ApplyResources(this.colRssi, "colRssi");
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // labelEventAntNum
            // 
            resources.ApplyResources(this.labelEventAntNum, "labelEventAntNum");
            this.labelEventAntNum.Name = "labelEventAntNum";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBoxTagSearch
            // 
            resources.ApplyResources(this.groupBoxTagSearch, "groupBoxTagSearch");
            this.groupBoxTagSearch.Controls.Add(this.textBoxSearchTag);
            this.groupBoxTagSearch.Controls.Add(this.buttonSearchTag);
            this.groupBoxTagSearch.Name = "groupBoxTagSearch";
            this.groupBoxTagSearch.TabStop = false;
            // 
            // textBoxSearchTag
            // 
            resources.ApplyResources(this.textBoxSearchTag, "textBoxSearchTag");
            this.textBoxSearchTag.Name = "textBoxSearchTag";
            // 
            // buttonSearchTag
            // 
            resources.ApplyResources(this.buttonSearchTag, "buttonSearchTag");
            this.buttonSearchTag.Name = "buttonSearchTag";
            this.buttonSearchTag.UseVisualStyleBackColor = true;
            this.buttonSearchTag.Click += new System.EventHandler(this.buttonSearchTag_Click);
            // 
            // CurrentLoactionColorCheck
            // 
            this.CurrentLoactionColorCheck.Interval = 400;
            this.CurrentLoactionColorCheck.Tick += new System.EventHandler(this.CurrentLoactionColorCheck_Tick);
            // 
            // LVDebugMode
            // 
            resources.ApplyResources(this.LVDebugMode, "LVDebugMode");
            this.LVDebugMode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.buffersize});
            this.LVDebugMode.FullRowSelect = true;
            this.LVDebugMode.GridLines = true;
            this.LVDebugMode.HideSelection = false;
            this.LVDebugMode.Name = "LVDebugMode";
            this.LVDebugMode.UseCompatibleStateImageBehavior = false;
            this.LVDebugMode.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeader14
            // 
            resources.ApplyResources(this.columnHeader14, "columnHeader14");
            // 
            // columnHeader15
            // 
            resources.ApplyResources(this.columnHeader15, "columnHeader15");
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // columnHeader17
            // 
            resources.ApplyResources(this.columnHeader17, "columnHeader17");
            // 
            // columnHeader18
            // 
            resources.ApplyResources(this.columnHeader18, "columnHeader18");
            // 
            // columnHeader19
            // 
            resources.ApplyResources(this.columnHeader19, "columnHeader19");
            // 
            // columnHeader20
            // 
            resources.ApplyResources(this.columnHeader20, "columnHeader20");
            // 
            // columnHeader21
            // 
            resources.ApplyResources(this.columnHeader21, "columnHeader21");
            // 
            // columnHeader22
            // 
            resources.ApplyResources(this.columnHeader22, "columnHeader22");
            // 
            // buffersize
            // 
            resources.ApplyResources(this.buffersize, "buffersize");
            // 
            // InventoryTimer
            // 
            this.InventoryTimer.Tick += new System.EventHandler(this.InventoryTimer_Tick);
            // 
            // listViewTagDataView
            // 
            resources.ApplyResources(this.listViewTagDataView, "listViewTagDataView");
            this.listViewTagDataView.FullRowSelect = true;
            this.listViewTagDataView.GridLines = true;
            this.listViewTagDataView.HideSelection = false;
            this.listViewTagDataView.Name = "listViewTagDataView";
            this.listViewTagDataView.UseCompatibleStateImageBehavior = false;
            this.listViewTagDataView.View = System.Windows.Forms.View.Details;
            // 
            // APITimer
            // 
            this.APITimer.Tick += new System.EventHandler(this.APITimer_Tick);
            // 
            // tabPageDebugMode
            // 
            resources.ApplyResources(this.tabPageDebugMode, "tabPageDebugMode");
            this.tabPageDebugMode.Name = "tabPageDebugMode";
            this.tabPageDebugMode.UseVisualStyleBackColor = true;
            // 
            // tabPageListMode
            // 
            resources.ApplyResources(this.tabPageListMode, "tabPageListMode");
            this.tabPageListMode.Name = "tabPageListMode";
            // 
            // tabPageTableMode
            // 
            resources.ApplyResources(this.tabPageTableMode, "tabPageTableMode");
            this.tabPageTableMode.Name = "tabPageTableMode";
            this.tabPageTableMode.UseVisualStyleBackColor = true;
            // 
            // tabControlModeTab
            // 
            resources.ApplyResources(this.tabControlModeTab, "tabControlModeTab");
            this.tabControlModeTab.Controls.Add(this.tabPageTableMode);
            this.tabControlModeTab.Controls.Add(this.tabPageListMode);
            this.tabControlModeTab.Controls.Add(this.tabPageDebugMode);
            this.tabControlModeTab.Name = "tabControlModeTab";
            this.tabControlModeTab.SelectedIndex = 0;
            this.tabControlModeTab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // HartBitTimer
            // 
            this.HartBitTimer.Tick += new System.EventHandler(this.HartBitTimer_Tick);
            // 
            // tagDataView1
            // 
            resources.ApplyResources(this.tagDataView1, "tagDataView1");
            this.tagDataView1.BackColor = System.Drawing.Color.White;
            this.tagDataView1.Name = "tagDataView1";
            // 
            // tagDataView2
            // 
            resources.ApplyResources(this.tagDataView2, "tagDataView2");
            this.tagDataView2.BackColor = System.Drawing.Color.White;
            this.tagDataView2.Name = "tagDataView2";
            // 
            // tagDataView3
            // 
            resources.ApplyResources(this.tagDataView3, "tagDataView3");
            this.tagDataView3.BackColor = System.Drawing.Color.White;
            this.tagDataView3.Name = "tagDataView3";
            // 
            // tagDataView4
            // 
            resources.ApplyResources(this.tagDataView4, "tagDataView4");
            this.tagDataView4.BackColor = System.Drawing.Color.White;
            this.tagDataView4.Name = "tagDataView4";
            // 
            // tagDataView5
            // 
            resources.ApplyResources(this.tagDataView5, "tagDataView5");
            this.tagDataView5.BackColor = System.Drawing.Color.White;
            this.tagDataView5.Name = "tagDataView5";
            // 
            // tagDataView6
            // 
            resources.ApplyResources(this.tagDataView6, "tagDataView6");
            this.tagDataView6.BackColor = System.Drawing.Color.White;
            this.tagDataView6.Name = "tagDataView6";
            // 
            // tagDataView7
            // 
            resources.ApplyResources(this.tagDataView7, "tagDataView7");
            this.tagDataView7.BackColor = System.Drawing.Color.White;
            this.tagDataView7.Name = "tagDataView7";
            // 
            // tagDataView8
            // 
            resources.ApplyResources(this.tagDataView8, "tagDataView8");
            this.tagDataView8.BackColor = System.Drawing.Color.White;
            this.tagDataView8.Name = "tagDataView8";
            // 
            // tagDataView9
            // 
            resources.ApplyResources(this.tagDataView9, "tagDataView9");
            this.tagDataView9.BackColor = System.Drawing.Color.White;
            this.tagDataView9.Name = "tagDataView9";
            // 
            // tagDataView10
            // 
            resources.ApplyResources(this.tagDataView10, "tagDataView10");
            this.tagDataView10.BackColor = System.Drawing.Color.White;
            this.tagDataView10.Name = "tagDataView10";
            // 
            // tagDataView11
            // 
            resources.ApplyResources(this.tagDataView11, "tagDataView11");
            this.tagDataView11.BackColor = System.Drawing.Color.White;
            this.tagDataView11.Name = "tagDataView11";
            // 
            // tagDataView12
            // 
            resources.ApplyResources(this.tagDataView12, "tagDataView12");
            this.tagDataView12.BackColor = System.Drawing.Color.White;
            this.tagDataView12.Name = "tagDataView12";
            // 
            // tagDataView13
            // 
            resources.ApplyResources(this.tagDataView13, "tagDataView13");
            this.tagDataView13.BackColor = System.Drawing.Color.White;
            this.tagDataView13.Name = "tagDataView13";
            // 
            // tagDataView14
            // 
            resources.ApplyResources(this.tagDataView14, "tagDataView14");
            this.tagDataView14.BackColor = System.Drawing.Color.White;
            this.tagDataView14.Name = "tagDataView14";
            // 
            // tagDataView15
            // 
            resources.ApplyResources(this.tagDataView15, "tagDataView15");
            this.tagDataView15.BackColor = System.Drawing.Color.White;
            this.tagDataView15.Name = "tagDataView15";
            // 
            // tagDataView16
            // 
            resources.ApplyResources(this.tagDataView16, "tagDataView16");
            this.tagDataView16.BackColor = System.Drawing.Color.White;
            this.tagDataView16.Name = "tagDataView16";
            // 
            // tagDataView17
            // 
            resources.ApplyResources(this.tagDataView17, "tagDataView17");
            this.tagDataView17.BackColor = System.Drawing.Color.White;
            this.tagDataView17.Name = "tagDataView17";
            // 
            // tagDataView18
            // 
            resources.ApplyResources(this.tagDataView18, "tagDataView18");
            this.tagDataView18.BackColor = System.Drawing.Color.White;
            this.tagDataView18.Name = "tagDataView18";
            // 
            // tagDataView19
            // 
            resources.ApplyResources(this.tagDataView19, "tagDataView19");
            this.tagDataView19.BackColor = System.Drawing.Color.White;
            this.tagDataView19.Name = "tagDataView19";
            // 
            // tagDataView20
            // 
            resources.ApplyResources(this.tagDataView20, "tagDataView20");
            this.tagDataView20.BackColor = System.Drawing.Color.White;
            this.tagDataView20.Name = "tagDataView20";
            // 
            // tagDataView21
            // 
            resources.ApplyResources(this.tagDataView21, "tagDataView21");
            this.tagDataView21.BackColor = System.Drawing.Color.White;
            this.tagDataView21.Name = "tagDataView21";
            // 
            // tagDataView22
            // 
            resources.ApplyResources(this.tagDataView22, "tagDataView22");
            this.tagDataView22.BackColor = System.Drawing.Color.White;
            this.tagDataView22.Name = "tagDataView22";
            // 
            // tagDataView23
            // 
            resources.ApplyResources(this.tagDataView23, "tagDataView23");
            this.tagDataView23.BackColor = System.Drawing.Color.White;
            this.tagDataView23.Name = "tagDataView23";
            // 
            // tagDataView24
            // 
            resources.ApplyResources(this.tagDataView24, "tagDataView24");
            this.tagDataView24.BackColor = System.Drawing.Color.White;
            this.tagDataView24.Name = "tagDataView24";
            // 
            // tagDataView25
            // 
            resources.ApplyResources(this.tagDataView25, "tagDataView25");
            this.tagDataView25.BackColor = System.Drawing.Color.White;
            this.tagDataView25.Name = "tagDataView25";
            // 
            // tagDataView26
            // 
            resources.ApplyResources(this.tagDataView26, "tagDataView26");
            this.tagDataView26.BackColor = System.Drawing.Color.White;
            this.tagDataView26.Name = "tagDataView26";
            // 
            // tagDataView27
            // 
            resources.ApplyResources(this.tagDataView27, "tagDataView27");
            this.tagDataView27.BackColor = System.Drawing.Color.White;
            this.tagDataView27.Name = "tagDataView27";
            // 
            // tagDataView28
            // 
            resources.ApplyResources(this.tagDataView28, "tagDataView28");
            this.tagDataView28.BackColor = System.Drawing.Color.White;
            this.tagDataView28.Name = "tagDataView28";
            // 
            // tagDataView29
            // 
            resources.ApplyResources(this.tagDataView29, "tagDataView29");
            this.tagDataView29.BackColor = System.Drawing.Color.White;
            this.tagDataView29.Name = "tagDataView29";
            // 
            // tagDataView30
            // 
            resources.ApplyResources(this.tagDataView30, "tagDataView30");
            this.tagDataView30.BackColor = System.Drawing.Color.White;
            this.tagDataView30.Name = "tagDataView30";
            // 
            // tagDataView31
            // 
            resources.ApplyResources(this.tagDataView31, "tagDataView31");
            this.tagDataView31.BackColor = System.Drawing.Color.White;
            this.tagDataView31.Name = "tagDataView31";
            // 
            // tagDataView32
            // 
            resources.ApplyResources(this.tagDataView32, "tagDataView32");
            this.tagDataView32.BackColor = System.Drawing.Color.White;
            this.tagDataView32.Name = "tagDataView32";
            // 
            // tagDataView33
            // 
            resources.ApplyResources(this.tagDataView33, "tagDataView33");
            this.tagDataView33.BackColor = System.Drawing.Color.White;
            this.tagDataView33.Name = "tagDataView33";
            // 
            // tagDataView34
            // 
            resources.ApplyResources(this.tagDataView34, "tagDataView34");
            this.tagDataView34.BackColor = System.Drawing.Color.White;
            this.tagDataView34.Name = "tagDataView34";
            // 
            // tagDataView35
            // 
            resources.ApplyResources(this.tagDataView35, "tagDataView35");
            this.tagDataView35.BackColor = System.Drawing.Color.White;
            this.tagDataView35.Name = "tagDataView35";
            // 
            // tagDataView36
            // 
            resources.ApplyResources(this.tagDataView36, "tagDataView36");
            this.tagDataView36.BackColor = System.Drawing.Color.White;
            this.tagDataView36.Name = "tagDataView36";
            // 
            // tagDataView37
            // 
            resources.ApplyResources(this.tagDataView37, "tagDataView37");
            this.tagDataView37.BackColor = System.Drawing.Color.White;
            this.tagDataView37.Name = "tagDataView37";
            // 
            // tagDataView38
            // 
            resources.ApplyResources(this.tagDataView38, "tagDataView38");
            this.tagDataView38.BackColor = System.Drawing.Color.White;
            this.tagDataView38.Name = "tagDataView38";
            // 
            // tagDataView39
            // 
            resources.ApplyResources(this.tagDataView39, "tagDataView39");
            this.tagDataView39.BackColor = System.Drawing.Color.White;
            this.tagDataView39.Name = "tagDataView39";
            // 
            // tagDataView40
            // 
            resources.ApplyResources(this.tagDataView40, "tagDataView40");
            this.tagDataView40.BackColor = System.Drawing.Color.White;
            this.tagDataView40.Name = "tagDataView40";
            // 
            // tagDataView41
            // 
            resources.ApplyResources(this.tagDataView41, "tagDataView41");
            this.tagDataView41.BackColor = System.Drawing.Color.White;
            this.tagDataView41.Name = "tagDataView41";
            // 
            // tagDataView42
            // 
            resources.ApplyResources(this.tagDataView42, "tagDataView42");
            this.tagDataView42.BackColor = System.Drawing.Color.White;
            this.tagDataView42.Name = "tagDataView42";
            // 
            // tagDataView43
            // 
            resources.ApplyResources(this.tagDataView43, "tagDataView43");
            this.tagDataView43.BackColor = System.Drawing.Color.White;
            this.tagDataView43.Name = "tagDataView43";
            // 
            // tagDataView44
            // 
            resources.ApplyResources(this.tagDataView44, "tagDataView44");
            this.tagDataView44.BackColor = System.Drawing.Color.White;
            this.tagDataView44.Name = "tagDataView44";
            // 
            // tagDataView45
            // 
            resources.ApplyResources(this.tagDataView45, "tagDataView45");
            this.tagDataView45.BackColor = System.Drawing.Color.White;
            this.tagDataView45.Name = "tagDataView45";
            // 
            // tagDataView46
            // 
            resources.ApplyResources(this.tagDataView46, "tagDataView46");
            this.tagDataView46.BackColor = System.Drawing.Color.White;
            this.tagDataView46.Name = "tagDataView46";
            // 
            // tagDataView47
            // 
            resources.ApplyResources(this.tagDataView47, "tagDataView47");
            this.tagDataView47.BackColor = System.Drawing.Color.White;
            this.tagDataView47.Name = "tagDataView47";
            // 
            // tagDataView48
            // 
            resources.ApplyResources(this.tagDataView48, "tagDataView48");
            this.tagDataView48.BackColor = System.Drawing.Color.White;
            this.tagDataView48.Name = "tagDataView48";
            // 
            // tagDataView49
            // 
            resources.ApplyResources(this.tagDataView49, "tagDataView49");
            this.tagDataView49.BackColor = System.Drawing.Color.White;
            this.tagDataView49.Name = "tagDataView49";
            // 
            // tagDataView50
            // 
            resources.ApplyResources(this.tagDataView50, "tagDataView50");
            this.tagDataView50.BackColor = System.Drawing.Color.White;
            this.tagDataView50.Name = "tagDataView50";
            // 
            // tagDataView51
            // 
            resources.ApplyResources(this.tagDataView51, "tagDataView51");
            this.tagDataView51.BackColor = System.Drawing.Color.White;
            this.tagDataView51.Name = "tagDataView51";
            // 
            // tagDataView52
            // 
            resources.ApplyResources(this.tagDataView52, "tagDataView52");
            this.tagDataView52.BackColor = System.Drawing.Color.White;
            this.tagDataView52.Name = "tagDataView52";
            // 
            // tagDataView53
            // 
            resources.ApplyResources(this.tagDataView53, "tagDataView53");
            this.tagDataView53.BackColor = System.Drawing.Color.White;
            this.tagDataView53.Name = "tagDataView53";
            // 
            // tagDataView54
            // 
            resources.ApplyResources(this.tagDataView54, "tagDataView54");
            this.tagDataView54.BackColor = System.Drawing.Color.White;
            this.tagDataView54.Name = "tagDataView54";
            // 
            // tagDataView55
            // 
            resources.ApplyResources(this.tagDataView55, "tagDataView55");
            this.tagDataView55.BackColor = System.Drawing.Color.White;
            this.tagDataView55.Name = "tagDataView55";
            // 
            // tagDataView56
            // 
            resources.ApplyResources(this.tagDataView56, "tagDataView56");
            this.tagDataView56.BackColor = System.Drawing.Color.White;
            this.tagDataView56.Name = "tagDataView56";
            // 
            // tagDataView57
            // 
            resources.ApplyResources(this.tagDataView57, "tagDataView57");
            this.tagDataView57.BackColor = System.Drawing.Color.White;
            this.tagDataView57.Name = "tagDataView57";
            // 
            // tagDataView58
            // 
            resources.ApplyResources(this.tagDataView58, "tagDataView58");
            this.tagDataView58.BackColor = System.Drawing.Color.White;
            this.tagDataView58.Name = "tagDataView58";
            // 
            // tagDataView59
            // 
            resources.ApplyResources(this.tagDataView59, "tagDataView59");
            this.tagDataView59.BackColor = System.Drawing.Color.White;
            this.tagDataView59.Name = "tagDataView59";
            // 
            // tagDataView60
            // 
            resources.ApplyResources(this.tagDataView60, "tagDataView60");
            this.tagDataView60.BackColor = System.Drawing.Color.White;
            this.tagDataView60.Name = "tagDataView60";
            // 
            // tagDataView61
            // 
            resources.ApplyResources(this.tagDataView61, "tagDataView61");
            this.tagDataView61.BackColor = System.Drawing.Color.White;
            this.tagDataView61.Name = "tagDataView61";
            // 
            // tagDataView62
            // 
            resources.ApplyResources(this.tagDataView62, "tagDataView62");
            this.tagDataView62.BackColor = System.Drawing.Color.White;
            this.tagDataView62.Name = "tagDataView62";
            // 
            // tagDataView63
            // 
            resources.ApplyResources(this.tagDataView63, "tagDataView63");
            this.tagDataView63.BackColor = System.Drawing.Color.White;
            this.tagDataView63.Name = "tagDataView63";
            // 
            // tagDataView64
            // 
            resources.ApplyResources(this.tagDataView64, "tagDataView64");
            this.tagDataView64.BackColor = System.Drawing.Color.White;
            this.tagDataView64.Name = "tagDataView64";
            // 
            // tagDataView65
            // 
            resources.ApplyResources(this.tagDataView65, "tagDataView65");
            this.tagDataView65.BackColor = System.Drawing.Color.White;
            this.tagDataView65.Name = "tagDataView65";
            // 
            // tagDataView66
            // 
            resources.ApplyResources(this.tagDataView66, "tagDataView66");
            this.tagDataView66.BackColor = System.Drawing.Color.White;
            this.tagDataView66.Name = "tagDataView66";
            // 
            // tagDataView67
            // 
            resources.ApplyResources(this.tagDataView67, "tagDataView67");
            this.tagDataView67.BackColor = System.Drawing.Color.White;
            this.tagDataView67.Name = "tagDataView67";
            // 
            // tagDataView68
            // 
            resources.ApplyResources(this.tagDataView68, "tagDataView68");
            this.tagDataView68.BackColor = System.Drawing.Color.White;
            this.tagDataView68.Name = "tagDataView68";
            // 
            // tagDataView69
            // 
            resources.ApplyResources(this.tagDataView69, "tagDataView69");
            this.tagDataView69.BackColor = System.Drawing.Color.White;
            this.tagDataView69.Name = "tagDataView69";
            // 
            // tagDataView70
            // 
            resources.ApplyResources(this.tagDataView70, "tagDataView70");
            this.tagDataView70.BackColor = System.Drawing.Color.White;
            this.tagDataView70.Name = "tagDataView70";
            // 
            // tagDataView71
            // 
            resources.ApplyResources(this.tagDataView71, "tagDataView71");
            this.tagDataView71.BackColor = System.Drawing.Color.White;
            this.tagDataView71.Name = "tagDataView71";
            // 
            // tagDataView72
            // 
            resources.ApplyResources(this.tagDataView72, "tagDataView72");
            this.tagDataView72.BackColor = System.Drawing.Color.White;
            this.tagDataView72.Name = "tagDataView72";
            // 
            // tagDataView73
            // 
            resources.ApplyResources(this.tagDataView73, "tagDataView73");
            this.tagDataView73.BackColor = System.Drawing.Color.White;
            this.tagDataView73.Name = "tagDataView73";
            // 
            // tagDataView74
            // 
            resources.ApplyResources(this.tagDataView74, "tagDataView74");
            this.tagDataView74.BackColor = System.Drawing.Color.White;
            this.tagDataView74.Name = "tagDataView74";
            // 
            // tagDataView75
            // 
            resources.ApplyResources(this.tagDataView75, "tagDataView75");
            this.tagDataView75.BackColor = System.Drawing.Color.White;
            this.tagDataView75.Name = "tagDataView75";
            // 
            // tagDataView76
            // 
            resources.ApplyResources(this.tagDataView76, "tagDataView76");
            this.tagDataView76.BackColor = System.Drawing.Color.White;
            this.tagDataView76.Name = "tagDataView76";
            // 
            // tagDataView77
            // 
            resources.ApplyResources(this.tagDataView77, "tagDataView77");
            this.tagDataView77.BackColor = System.Drawing.Color.White;
            this.tagDataView77.Name = "tagDataView77";
            // 
            // tagDataView78
            // 
            resources.ApplyResources(this.tagDataView78, "tagDataView78");
            this.tagDataView78.BackColor = System.Drawing.Color.White;
            this.tagDataView78.Name = "tagDataView78";
            // 
            // tagDataView79
            // 
            resources.ApplyResources(this.tagDataView79, "tagDataView79");
            this.tagDataView79.BackColor = System.Drawing.Color.White;
            this.tagDataView79.Name = "tagDataView79";
            // 
            // tagDataView80
            // 
            resources.ApplyResources(this.tagDataView80, "tagDataView80");
            this.tagDataView80.BackColor = System.Drawing.Color.White;
            this.tagDataView80.Name = "tagDataView80";
            // 
            // tagDataView81
            // 
            resources.ApplyResources(this.tagDataView81, "tagDataView81");
            this.tagDataView81.BackColor = System.Drawing.Color.White;
            this.tagDataView81.Name = "tagDataView81";
            // 
            // tagDataView82
            // 
            resources.ApplyResources(this.tagDataView82, "tagDataView82");
            this.tagDataView82.BackColor = System.Drawing.Color.White;
            this.tagDataView82.Name = "tagDataView82";
            // 
            // tagDataView83
            // 
            resources.ApplyResources(this.tagDataView83, "tagDataView83");
            this.tagDataView83.BackColor = System.Drawing.Color.White;
            this.tagDataView83.Name = "tagDataView83";
            // 
            // tagDataView84
            // 
            resources.ApplyResources(this.tagDataView84, "tagDataView84");
            this.tagDataView84.BackColor = System.Drawing.Color.White;
            this.tagDataView84.Name = "tagDataView84";
            // 
            // tagDataView85
            // 
            resources.ApplyResources(this.tagDataView85, "tagDataView85");
            this.tagDataView85.BackColor = System.Drawing.Color.White;
            this.tagDataView85.Name = "tagDataView85";
            // 
            // tagDataView86
            // 
            resources.ApplyResources(this.tagDataView86, "tagDataView86");
            this.tagDataView86.BackColor = System.Drawing.Color.White;
            this.tagDataView86.Name = "tagDataView86";
            // 
            // tagDataView87
            // 
            resources.ApplyResources(this.tagDataView87, "tagDataView87");
            this.tagDataView87.BackColor = System.Drawing.Color.White;
            this.tagDataView87.Name = "tagDataView87";
            // 
            // tagDataView88
            // 
            resources.ApplyResources(this.tagDataView88, "tagDataView88");
            this.tagDataView88.BackColor = System.Drawing.Color.White;
            this.tagDataView88.Name = "tagDataView88";
            // 
            // tagDataView89
            // 
            resources.ApplyResources(this.tagDataView89, "tagDataView89");
            this.tagDataView89.BackColor = System.Drawing.Color.White;
            this.tagDataView89.Name = "tagDataView89";
            // 
            // tagDataView90
            // 
            resources.ApplyResources(this.tagDataView90, "tagDataView90");
            this.tagDataView90.BackColor = System.Drawing.Color.White;
            this.tagDataView90.Name = "tagDataView90";
            // 
            // tagDataView91
            // 
            resources.ApplyResources(this.tagDataView91, "tagDataView91");
            this.tagDataView91.BackColor = System.Drawing.Color.White;
            this.tagDataView91.Name = "tagDataView91";
            // 
            // tagDataView92
            // 
            resources.ApplyResources(this.tagDataView92, "tagDataView92");
            this.tagDataView92.BackColor = System.Drawing.Color.White;
            this.tagDataView92.Name = "tagDataView92";
            // 
            // tagDataView93
            // 
            resources.ApplyResources(this.tagDataView93, "tagDataView93");
            this.tagDataView93.BackColor = System.Drawing.Color.White;
            this.tagDataView93.Name = "tagDataView93";
            // 
            // tagDataView94
            // 
            resources.ApplyResources(this.tagDataView94, "tagDataView94");
            this.tagDataView94.BackColor = System.Drawing.Color.White;
            this.tagDataView94.Name = "tagDataView94";
            // 
            // tagDataView95
            // 
            resources.ApplyResources(this.tagDataView95, "tagDataView95");
            this.tagDataView95.BackColor = System.Drawing.Color.White;
            this.tagDataView95.Name = "tagDataView95";
            // 
            // tagDataView96
            // 
            resources.ApplyResources(this.tagDataView96, "tagDataView96");
            this.tagDataView96.BackColor = System.Drawing.Color.White;
            this.tagDataView96.Name = "tagDataView96";
            // 
            // tagDataView97
            // 
            resources.ApplyResources(this.tagDataView97, "tagDataView97");
            this.tagDataView97.BackColor = System.Drawing.Color.White;
            this.tagDataView97.Name = "tagDataView97";
            // 
            // tagDataView98
            // 
            resources.ApplyResources(this.tagDataView98, "tagDataView98");
            this.tagDataView98.BackColor = System.Drawing.Color.White;
            this.tagDataView98.Name = "tagDataView98";
            // 
            // tagDataView99
            // 
            resources.ApplyResources(this.tagDataView99, "tagDataView99");
            this.tagDataView99.BackColor = System.Drawing.Color.White;
            this.tagDataView99.Name = "tagDataView99";
            // 
            // tagDataView100
            // 
            resources.ApplyResources(this.tagDataView100, "tagDataView100");
            this.tagDataView100.BackColor = System.Drawing.Color.White;
            this.tagDataView100.Name = "tagDataView100";
            // 
            // tagDataView101
            // 
            resources.ApplyResources(this.tagDataView101, "tagDataView101");
            this.tagDataView101.BackColor = System.Drawing.Color.White;
            this.tagDataView101.Name = "tagDataView101";
            // 
            // tagDataView102
            // 
            resources.ApplyResources(this.tagDataView102, "tagDataView102");
            this.tagDataView102.BackColor = System.Drawing.Color.White;
            this.tagDataView102.Name = "tagDataView102";
            // 
            // tagDataView103
            // 
            resources.ApplyResources(this.tagDataView103, "tagDataView103");
            this.tagDataView103.BackColor = System.Drawing.Color.White;
            this.tagDataView103.Name = "tagDataView103";
            // 
            // tagDataView104
            // 
            resources.ApplyResources(this.tagDataView104, "tagDataView104");
            this.tagDataView104.BackColor = System.Drawing.Color.White;
            this.tagDataView104.Name = "tagDataView104";
            // 
            // tagDataView105
            // 
            resources.ApplyResources(this.tagDataView105, "tagDataView105");
            this.tagDataView105.BackColor = System.Drawing.Color.White;
            this.tagDataView105.Name = "tagDataView105";
            // 
            // tagDataView106
            // 
            resources.ApplyResources(this.tagDataView106, "tagDataView106");
            this.tagDataView106.BackColor = System.Drawing.Color.White;
            this.tagDataView106.Name = "tagDataView106";
            // 
            // tagDataView107
            // 
            resources.ApplyResources(this.tagDataView107, "tagDataView107");
            this.tagDataView107.BackColor = System.Drawing.Color.White;
            this.tagDataView107.Name = "tagDataView107";
            // 
            // tagDataView108
            // 
            resources.ApplyResources(this.tagDataView108, "tagDataView108");
            this.tagDataView108.BackColor = System.Drawing.Color.White;
            this.tagDataView108.Name = "tagDataView108";
            // 
            // tagDataView109
            // 
            resources.ApplyResources(this.tagDataView109, "tagDataView109");
            this.tagDataView109.BackColor = System.Drawing.Color.White;
            this.tagDataView109.Name = "tagDataView109";
            // 
            // tagDataView110
            // 
            resources.ApplyResources(this.tagDataView110, "tagDataView110");
            this.tagDataView110.BackColor = System.Drawing.Color.White;
            this.tagDataView110.Name = "tagDataView110";
            // 
            // tagDataView111
            // 
            resources.ApplyResources(this.tagDataView111, "tagDataView111");
            this.tagDataView111.BackColor = System.Drawing.Color.White;
            this.tagDataView111.Name = "tagDataView111";
            // 
            // tagDataView112
            // 
            resources.ApplyResources(this.tagDataView112, "tagDataView112");
            this.tagDataView112.BackColor = System.Drawing.Color.White;
            this.tagDataView112.Name = "tagDataView112";
            // 
            // tagDataView113
            // 
            resources.ApplyResources(this.tagDataView113, "tagDataView113");
            this.tagDataView113.BackColor = System.Drawing.Color.White;
            this.tagDataView113.Name = "tagDataView113";
            // 
            // tagDataView114
            // 
            resources.ApplyResources(this.tagDataView114, "tagDataView114");
            this.tagDataView114.BackColor = System.Drawing.Color.White;
            this.tagDataView114.Name = "tagDataView114";
            // 
            // tagDataView115
            // 
            resources.ApplyResources(this.tagDataView115, "tagDataView115");
            this.tagDataView115.BackColor = System.Drawing.Color.White;
            this.tagDataView115.Name = "tagDataView115";
            // 
            // tagDataView116
            // 
            resources.ApplyResources(this.tagDataView116, "tagDataView116");
            this.tagDataView116.BackColor = System.Drawing.Color.White;
            this.tagDataView116.Name = "tagDataView116";
            // 
            // tagDataView117
            // 
            resources.ApplyResources(this.tagDataView117, "tagDataView117");
            this.tagDataView117.BackColor = System.Drawing.Color.White;
            this.tagDataView117.Name = "tagDataView117";
            // 
            // tagDataView118
            // 
            resources.ApplyResources(this.tagDataView118, "tagDataView118");
            this.tagDataView118.BackColor = System.Drawing.Color.White;
            this.tagDataView118.Name = "tagDataView118";
            // 
            // tagDataView119
            // 
            resources.ApplyResources(this.tagDataView119, "tagDataView119");
            this.tagDataView119.BackColor = System.Drawing.Color.White;
            this.tagDataView119.Name = "tagDataView119";
            // 
            // tagDataView120
            // 
            resources.ApplyResources(this.tagDataView120, "tagDataView120");
            this.tagDataView120.BackColor = System.Drawing.Color.White;
            this.tagDataView120.Name = "tagDataView120";
            // 
            // tagDataView121
            // 
            resources.ApplyResources(this.tagDataView121, "tagDataView121");
            this.tagDataView121.BackColor = System.Drawing.Color.White;
            this.tagDataView121.Name = "tagDataView121";
            // 
            // tagDataView122
            // 
            resources.ApplyResources(this.tagDataView122, "tagDataView122");
            this.tagDataView122.BackColor = System.Drawing.Color.White;
            this.tagDataView122.Name = "tagDataView122";
            // 
            // tagDataView123
            // 
            resources.ApplyResources(this.tagDataView123, "tagDataView123");
            this.tagDataView123.BackColor = System.Drawing.Color.White;
            this.tagDataView123.Name = "tagDataView123";
            // 
            // tagDataView124
            // 
            resources.ApplyResources(this.tagDataView124, "tagDataView124");
            this.tagDataView124.BackColor = System.Drawing.Color.White;
            this.tagDataView124.Name = "tagDataView124";
            // 
            // tagDataView125
            // 
            resources.ApplyResources(this.tagDataView125, "tagDataView125");
            this.tagDataView125.BackColor = System.Drawing.Color.White;
            this.tagDataView125.Name = "tagDataView125";
            // 
            // tagDataView126
            // 
            resources.ApplyResources(this.tagDataView126, "tagDataView126");
            this.tagDataView126.BackColor = System.Drawing.Color.White;
            this.tagDataView126.Name = "tagDataView126";
            // 
            // tagDataView127
            // 
            resources.ApplyResources(this.tagDataView127, "tagDataView127");
            this.tagDataView127.BackColor = System.Drawing.Color.White;
            this.tagDataView127.Name = "tagDataView127";
            // 
            // tagDataView128
            // 
            resources.ApplyResources(this.tagDataView128, "tagDataView128");
            this.tagDataView128.BackColor = System.Drawing.Color.White;
            this.tagDataView128.Name = "tagDataView128";
            // 
            // ATMW_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlModeTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewTagDataView);
            this.Controls.Add(this.panelTagDataView);
            this.Controls.Add(this.statusStripLog);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LVDebugMode);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ATMW_Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTagDataView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxTagSearch.ResumeLayout(false);
            this.groupBoxTagSearch.PerformLayout();
            this.tabControlModeTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStripLog;
        private System.Windows.Forms.Panel panelTagDataView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTagDataView;
        private System.Windows.Forms.ToolStripMenuItem memuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        private TagDataView tagDataView1;
        private TagDataView tagDataView2;
        private TagDataView tagDataView3;
        private TagDataView tagDataView4;
        private TagDataView tagDataView5;
        private TagDataView tagDataView6;
        private TagDataView tagDataView7;
        private TagDataView tagDataView8;
        private TagDataView tagDataView9;
        private TagDataView tagDataView10;
        private TagDataView tagDataView11;
        private TagDataView tagDataView12;
        private TagDataView tagDataView13;
        private TagDataView tagDataView14;
        private TagDataView tagDataView15;
        private TagDataView tagDataView16;
        private TagDataView tagDataView17;
        private TagDataView tagDataView18;
        private TagDataView tagDataView19;
        private TagDataView tagDataView20;
        private TagDataView tagDataView21;
        private TagDataView tagDataView22;
        private TagDataView tagDataView23;
        private TagDataView tagDataView24;
        private TagDataView tagDataView25;
        private TagDataView tagDataView26;
        private TagDataView tagDataView27;
        private TagDataView tagDataView28;
        private TagDataView tagDataView29;
        private TagDataView tagDataView30;
        private TagDataView tagDataView31;
        private TagDataView tagDataView32;
        private TagDataView tagDataView33;
        private TagDataView tagDataView34;
        private TagDataView tagDataView35;
        private TagDataView tagDataView36;
        private TagDataView tagDataView37;
        private TagDataView tagDataView38;
        private TagDataView tagDataView39;
        private TagDataView tagDataView40;
        private TagDataView tagDataView41;
        private TagDataView tagDataView42;
        private TagDataView tagDataView43;
        private TagDataView tagDataView44;
        private TagDataView tagDataView45;
        private TagDataView tagDataView46;
        private TagDataView tagDataView47;
        private TagDataView tagDataView48;
        private TagDataView tagDataView49;
        private TagDataView tagDataView50;
        private TagDataView tagDataView51;
        private TagDataView tagDataView52;
        private TagDataView tagDataView53;
        private TagDataView tagDataView54;
        private TagDataView tagDataView55;
        private TagDataView tagDataView56;
        private TagDataView tagDataView57;
        private TagDataView tagDataView58;
        private TagDataView tagDataView59;
        private TagDataView tagDataView60;
        private TagDataView tagDataView61;
        private TagDataView tagDataView62;
        private TagDataView tagDataView63;
        private TagDataView tagDataView64;
        private TagDataView tagDataView65;
        private TagDataView tagDataView66;
        private TagDataView tagDataView67;
        private TagDataView tagDataView68;
        private TagDataView tagDataView69;
        private TagDataView tagDataView70;
        private TagDataView tagDataView71;
        private TagDataView tagDataView72;
        private TagDataView tagDataView73;
        private TagDataView tagDataView74;
        private TagDataView tagDataView75;
        private TagDataView tagDataView76;
        private TagDataView tagDataView77;
        private TagDataView tagDataView78;
        private TagDataView tagDataView79;
        private TagDataView tagDataView80;
        private TagDataView tagDataView81;
        private TagDataView tagDataView82;
        private TagDataView tagDataView83;
        private TagDataView tagDataView84;
        private TagDataView tagDataView85;
        private TagDataView tagDataView86;
        private TagDataView tagDataView87;
        private TagDataView tagDataView88;
        private TagDataView tagDataView89;
        private TagDataView tagDataView90;
        private TagDataView tagDataView91;
        private TagDataView tagDataView92;
        private TagDataView tagDataView93;
        private TagDataView tagDataView94;
        private TagDataView tagDataView95;
        private TagDataView tagDataView96;
        private TagDataView tagDataView97;
        private TagDataView tagDataView98;
        private TagDataView tagDataView99;
        private TagDataView tagDataView100;
        private TagDataView tagDataView101;
        private TagDataView tagDataView102;
        private TagDataView tagDataView103;
        private TagDataView tagDataView104;
        private TagDataView tagDataView105;
        private TagDataView tagDataView106;
        private TagDataView tagDataView107;
        private TagDataView tagDataView108;
        private TagDataView tagDataView109;
        private TagDataView tagDataView110;
        private TagDataView tagDataView111;
        private TagDataView tagDataView112;
        private TagDataView tagDataView113;
        private TagDataView tagDataView114;
        private TagDataView tagDataView115;
        private TagDataView tagDataView116;
        private TagDataView tagDataView117;
        private TagDataView tagDataView118;
        private TagDataView tagDataView119;
        private TagDataView tagDataView120;
        private TagDataView tagDataView121;
        private TagDataView tagDataView122;
        private TagDataView tagDataView123;
        private TagDataView tagDataView124;
        private TagDataView tagDataView125;
        private TagDataView tagDataView126;
        private TagDataView tagDataView127;
        private TagDataView tagDataView128;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engToolStripMenuItem;
        private System.Windows.Forms.Button buttonRfidInventory;
        private System.Windows.Forms.Button buttonRfidConnect;
        private System.Windows.Forms.Button buttonComSearch;
        private System.Windows.Forms.ComboBox comboBoxComList;
        private System.Windows.Forms.GroupBox groupBoxTagSearch;
        private System.Windows.Forms.TextBox textBoxSearchTag;
        private System.Windows.Forms.Button buttonSearchTag;
        private System.Windows.Forms.Label labelRfidInventoryElapsedTimeValue;
        private System.Windows.Forms.Timer CurrentLoactionColorCheck;
        private System.Windows.Forms.ToolStripMenuItem defaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewAntTagData;
        private System.Windows.Forms.ColumnHeader colEpc;
        private System.Windows.Forms.ColumnHeader colRssi;
        private System.Windows.Forms.Label labelEventAntNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LVDebugMode;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader buffersize;
        private System.Windows.Forms.Timer InventoryTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewTagDataView;
        private System.Windows.Forms.Button btnInvenStop;
        private System.Windows.Forms.Button btnExcelSave;
        private System.Windows.Forms.ToolStripMenuItem modeSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTimeSettingToolStripMenuItem;
        private System.Windows.Forms.Timer APITimer;
        private System.Windows.Forms.TabPage tabPageDebugMode;
        private System.Windows.Forms.TabPage tabPageListMode;
        private System.Windows.Forms.TabPage tabPageTableMode;
        private System.Windows.Forms.TabControl tabControlModeTab;
        private System.Windows.Forms.Timer HartBitTimer;
        private System.Windows.Forms.ToolStripMenuItem gateModeToolStripMenuItem;
    }
}