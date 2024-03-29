﻿
using System.Drawing;

namespace FriishProduce
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.NewProject = new System.Windows.Forms.RibbonOrbMenuItem();
            this.orbMenuSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.MenuItem_Settings = new System.Windows.Forms.RibbonOrbMenuItem();
            this.orbMenuSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.MenuItem_About = new System.Windows.Forms.RibbonOrbMenuItem();
            this.MenuItem_Exit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.RibbonButton_Settings = new System.Windows.Forms.RibbonButton();
            this.RibbonButton_About = new System.Windows.Forms.RibbonButton();
            this.ribbonTab_Home = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel_Project = new System.Windows.Forms.RibbonPanel();
            this.UseLibRetro = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_Open = new System.Windows.Forms.RibbonPanel();
            this.OpenROM = new System.Windows.Forms.RibbonButton();
            this.OpenImage = new System.Windows.Forms.RibbonButton();
            this.OpenManual = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel_Export = new System.Windows.Forms.RibbonPanel();
            this.ExportWAD = new System.Windows.Forms.RibbonButton();
            this.BrowseROM = new System.Windows.Forms.OpenFileDialog();
            this.SaveWAD = new System.Windows.Forms.SaveFileDialog();
            this.BrowseImage = new System.Windows.Forms.OpenFileDialog();
            this.TabContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Strip_OpenROM = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip_OpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Strip_UseLibRetro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Strip_ExportWAD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new MdiTabControl.TabControl();
            this.BrowseManual = new System.Windows.Forms.FolderBrowserDialog();
            this.TabContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            resources.ApplyResources(this.ribbon1, "ribbon1");
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.ContentButtonsMinWidth = 140;
            this.ribbon1.OrbDropDown.ContentRecentItemsMinWidth = 100;
            this.ribbon1.OrbDropDown.Font = ((System.Drawing.Font)(resources.GetObject("ribbon1.OrbDropDown.Font")));
            this.ribbon1.OrbDropDown.Location = ((System.Drawing.Point)(resources.GetObject("ribbon1.OrbDropDown.Location")));
            this.ribbon1.OrbDropDown.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("ribbon1.OrbDropDown.Margin")));
            this.ribbon1.OrbDropDown.MenuItems.Add(this.NewProject);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbMenuSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.MenuItem_Settings);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.orbMenuSeparator2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.MenuItem_About);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.MenuItem_Exit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItemsPadding = 3;
            this.ribbon1.OrbDropDown.Size = ((System.Drawing.Size)(resources.GetObject("ribbon1.OrbDropDown.Size")));
            this.ribbon1.OrbDropDown.TabIndex = ((int)(resources.GetObject("ribbon1.OrbDropDown.TabIndex")));
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010_Extended;
            this.ribbon1.OrbText = "File";
            this.ribbon1.PanelCaptionHeight = 14;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAccessToolbar.Items.Add(this.RibbonButton_Settings);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.RibbonButton_About);
            this.ribbon1.QuickAccessToolbar.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbon1.QuickAccessToolbar.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbon1.QuickAccessToolbar.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ribbon1.QuickAccessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Segoe UI", 8F);
            this.ribbon1.Tabs.Add(this.ribbonTab_Home);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            this.ribbon1.UseAlwaysStandardTheme = true;
            // 
            // NewProject
            // 
            this.NewProject.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.NewProject.Image = global::FriishProduce.Properties.Resources.document_large;
            this.NewProject.LargeImage = global::FriishProduce.Properties.Resources.document_large;
            this.NewProject.Name = "NewProject";
            this.NewProject.SmallImage = global::FriishProduce.Properties.Resources.document_large;
            this.NewProject.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.NewProject, "NewProject");
            // 
            // orbMenuSeparator1
            // 
            this.orbMenuSeparator1.Name = "orbMenuSeparator1";
            // 
            // MenuItem_Settings
            // 
            this.MenuItem_Settings.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.MenuItem_Settings.Image = global::FriishProduce.Properties.Resources.gear_large;
            this.MenuItem_Settings.LargeImage = global::FriishProduce.Properties.Resources.gear_large;
            this.MenuItem_Settings.Name = "MenuItem_Settings";
            this.MenuItem_Settings.SmallImage = global::FriishProduce.Properties.Resources.gear_large;
            resources.ApplyResources(this.MenuItem_Settings, "MenuItem_Settings");
            this.MenuItem_Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // orbMenuSeparator2
            // 
            this.orbMenuSeparator2.Name = "orbMenuSeparator2";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.MenuItem_About.Image = global::FriishProduce.Properties.Resources.lakitu_smw2;
            this.MenuItem_About.LargeImage = global::FriishProduce.Properties.Resources.lakitu_smw2;
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.SmallImage = global::FriishProduce.Properties.Resources.lakitu_smw2;
            resources.ApplyResources(this.MenuItem_About, "MenuItem_About");
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.MenuItem_Exit.Image = global::FriishProduce.Properties.Resources.arrow_curve_large;
            this.MenuItem_Exit.LargeImage = global::FriishProduce.Properties.Resources.arrow_curve_large;
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.SmallImage = global::FriishProduce.Properties.Resources.arrow_curve_large;
            resources.ApplyResources(this.MenuItem_Exit, "MenuItem_Exit");
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // RibbonButton_Settings
            // 
            this.RibbonButton_Settings.DrawDropDownIconsBar = false;
            this.RibbonButton_Settings.Image = ((System.Drawing.Image)(resources.GetObject("RibbonButton_Settings.Image")));
            this.RibbonButton_Settings.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_Settings.LargeImage")));
            this.RibbonButton_Settings.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.RibbonButton_Settings.Name = "RibbonButton_Settings";
            this.RibbonButton_Settings.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_Settings.SmallImage")));
            this.RibbonButton_Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // RibbonButton_About
            // 
            this.RibbonButton_About.DrawDropDownIconsBar = false;
            this.RibbonButton_About.Image = ((System.Drawing.Image)(resources.GetObject("RibbonButton_About.Image")));
            this.RibbonButton_About.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_About.LargeImage")));
            this.RibbonButton_About.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.RibbonButton_About.Name = "RibbonButton_About";
            this.RibbonButton_About.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibbonButton_About.SmallImage")));
            // 
            // ribbonTab_Home
            // 
            this.ribbonTab_Home.Name = "ribbonTab_Home";
            this.ribbonTab_Home.Panels.Add(this.ribbonPanel_Project);
            this.ribbonTab_Home.Panels.Add(this.ribbonPanel_Open);
            this.ribbonTab_Home.Panels.Add(this.ribbonPanel_Export);
            resources.ApplyResources(this.ribbonTab_Home, "ribbonTab_Home");
            // 
            // ribbonPanel_Project
            // 
            this.ribbonPanel_Project.ButtonMoreEnabled = false;
            this.ribbonPanel_Project.ButtonMoreVisible = false;
            this.ribbonPanel_Project.Items.Add(this.UseLibRetro);
            this.ribbonPanel_Project.Name = "ribbonPanel_Project";
            resources.ApplyResources(this.ribbonPanel_Project, "ribbonPanel_Project");
            // 
            // UseLibRetro
            // 
            this.UseLibRetro.Enabled = false;
            this.UseLibRetro.Image = global::FriishProduce.Properties.Resources.retroarch_large;
            this.UseLibRetro.LargeImage = global::FriishProduce.Properties.Resources.retroarch_large;
            this.UseLibRetro.Name = "UseLibRetro";
            this.UseLibRetro.SmallImage = global::FriishProduce.Properties.Resources.retroarch;
            resources.ApplyResources(this.UseLibRetro, "UseLibRetro");
            this.UseLibRetro.Click += new System.EventHandler(this.UseLibRetro_Click);
            // 
            // ribbonPanel_Open
            // 
            this.ribbonPanel_Open.ButtonMoreVisible = false;
            this.ribbonPanel_Open.Items.Add(this.OpenROM);
            this.ribbonPanel_Open.Items.Add(this.OpenImage);
            this.ribbonPanel_Open.Items.Add(this.OpenManual);
            this.ribbonPanel_Open.Name = "ribbonPanel_Open";
            resources.ApplyResources(this.ribbonPanel_Open, "ribbonPanel_Open");
            // 
            // OpenROM
            // 
            this.OpenROM.Enabled = false;
            this.OpenROM.Image = global::FriishProduce.Properties.Resources.disc_blue_large;
            this.OpenROM.LargeImage = global::FriishProduce.Properties.Resources.disc_blue_large;
            this.OpenROM.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenROM.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenROM.Name = "OpenROM";
            this.OpenROM.SmallImage = global::FriishProduce.Properties.Resources.disc_blue;
            resources.ApplyResources(this.OpenROM, "OpenROM");
            this.OpenROM.Click += new System.EventHandler(this.OpenROM_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Enabled = false;
            this.OpenImage.Image = global::FriishProduce.Properties.Resources.image_sunset_large;
            this.OpenImage.LargeImage = global::FriishProduce.Properties.Resources.image_sunset_large;
            this.OpenImage.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenImage.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.SmallImage = global::FriishProduce.Properties.Resources.image_sunset;
            resources.ApplyResources(this.OpenImage, "OpenImage");
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // OpenManual
            // 
            this.OpenManual.Enabled = false;
            this.OpenManual.Image = global::FriishProduce.Properties.Resources.book_large;
            this.OpenManual.LargeImage = global::FriishProduce.Properties.Resources.book_large;
            this.OpenManual.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenManual.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.OpenManual.Name = "OpenManual";
            this.OpenManual.SmallImage = global::FriishProduce.Properties.Resources.book;
            resources.ApplyResources(this.OpenManual, "OpenManual");
            this.OpenManual.Click += new System.EventHandler(this.OpenManual_Click);
            // 
            // ribbonPanel_Export
            // 
            this.ribbonPanel_Export.ButtonMoreVisible = false;
            this.ribbonPanel_Export.Items.Add(this.ExportWAD);
            this.ribbonPanel_Export.Name = "ribbonPanel_Export";
            resources.ApplyResources(this.ribbonPanel_Export, "ribbonPanel_Export");
            // 
            // ExportWAD
            // 
            this.ExportWAD.Enabled = false;
            this.ExportWAD.Image = global::FriishProduce.Properties.Resources.box_label_large;
            this.ExportWAD.LargeImage = global::FriishProduce.Properties.Resources.box_label_large;
            this.ExportWAD.Name = "ExportWAD";
            this.ExportWAD.SmallImage = global::FriishProduce.Properties.Resources.box_label;
            resources.ApplyResources(this.ExportWAD, "ExportWAD");
            this.ExportWAD.Click += new System.EventHandler(this.ExportWAD_Click);
            // 
            // BrowseROM
            // 
            this.BrowseROM.RestoreDirectory = true;
            // 
            // SaveWAD
            // 
            this.SaveWAD.DefaultExt = "wad";
            this.SaveWAD.RestoreDirectory = true;
            this.SaveWAD.SupportMultiDottedExtensions = true;
            // 
            // BrowseImage
            // 
            resources.ApplyResources(this.BrowseImage, "BrowseImage");
            this.BrowseImage.RestoreDirectory = true;
            // 
            // TabContextMenu
            // 
            this.TabContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip_OpenROM,
            this.Strip_OpenImage,
            this.toolStripSeparator1,
            this.Strip_UseLibRetro,
            this.toolStripSeparator2,
            this.Strip_ExportWAD,
            this.toolStripSeparator3,
            this.CloseTab});
            this.TabContextMenu.Name = "contextMenuStrip1";
            this.TabContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            resources.ApplyResources(this.TabContextMenu, "TabContextMenu");
            // 
            // Strip_OpenROM
            // 
            resources.ApplyResources(this.Strip_OpenROM, "Strip_OpenROM");
            this.Strip_OpenROM.Name = "Strip_OpenROM";
            this.Strip_OpenROM.Click += new System.EventHandler(this.OpenROM_Click);
            // 
            // Strip_OpenImage
            // 
            resources.ApplyResources(this.Strip_OpenImage, "Strip_OpenImage");
            this.Strip_OpenImage.Name = "Strip_OpenImage";
            this.Strip_OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // Strip_UseLibRetro
            // 
            resources.ApplyResources(this.Strip_UseLibRetro, "Strip_UseLibRetro");
            this.Strip_UseLibRetro.Name = "Strip_UseLibRetro";
            this.Strip_UseLibRetro.Click += new System.EventHandler(this.UseLibRetro_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // Strip_ExportWAD
            // 
            resources.ApplyResources(this.Strip_ExportWAD, "Strip_ExportWAD");
            this.Strip_ExportWAD.Name = "Strip_ExportWAD";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // CloseTab
            // 
            this.CloseTab.Name = "CloseTab";
            resources.ApplyResources(this.CloseTab, "CloseTab");
            this.CloseTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // tabControl
            // 
            this.tabControl.BackHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.tabControl.BackLowColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.CloseButtonVisible = true;
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.MenuRenderer = null;
            this.tabControl.Name = "tabControl";
            this.tabControl.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tabControl.TabBackHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.TabBackHighColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.tabControl.TabBackLowColor = System.Drawing.Color.WhiteSmoke;
            this.tabControl.TabBackLowColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(235)))));
            this.tabControl.TabBorderEnhanced = true;
            this.tabControl.TabBorderEnhanceWeight = MdiTabControl.TabControl.Weight.Soft;
            this.tabControl.TabCloseButtonImage = null;
            this.tabControl.TabCloseButtonImageDisabled = null;
            this.tabControl.TabCloseButtonImageHot = null;
            this.tabControl.TabCloseButtonSize = new System.Drawing.Size(14, 14);
            this.tabControl.TabCloseButtonVisible = false;
            this.tabControl.TabHeight = 25;
            this.tabControl.TabMaximumWidth = 350;
            this.tabControl.TabOffset = 5;
            this.tabControl.TabPadLeft = 7;
            this.tabControl.TabPadRight = 7;
            this.tabControl.SelectedTabChanged += new System.EventHandler(this.TabChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // BrowseManual
            // 
            resources.ApplyResources(this.BrowseManual, "BrowseManual");
            this.BrowseManual.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ribbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.TabContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab_Home;
        private System.Windows.Forms.RibbonPanel ribbonPanel_Open;
        private System.Windows.Forms.RibbonButton OpenROM;
        private System.Windows.Forms.RibbonOrbMenuItem MenuItem_Settings;
        private System.Windows.Forms.RibbonPanel ribbonPanel_Export;
        private System.Windows.Forms.RibbonButton ExportWAD;
        internal System.Windows.Forms.OpenFileDialog BrowseROM;
        internal System.Windows.Forms.SaveFileDialog SaveWAD;
        private System.Windows.Forms.RibbonButton OpenImage;
        private System.Windows.Forms.OpenFileDialog BrowseImage;
        private System.Windows.Forms.RibbonButton RibbonButton_Settings;
        private System.Windows.Forms.RibbonButton RibbonButton_About;
        private System.Windows.Forms.ContextMenuStrip TabContextMenu;
        private System.Windows.Forms.ToolStripMenuItem Strip_OpenROM;
        private System.Windows.Forms.ToolStripMenuItem Strip_OpenImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Strip_ExportWAD;
        private System.Windows.Forms.RibbonButton UseLibRetro;
        private System.Windows.Forms.ToolStripMenuItem Strip_UseLibRetro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.RibbonOrbMenuItem MenuItem_About;
        private System.Windows.Forms.RibbonOrbMenuItem MenuItem_Exit;
        private System.Windows.Forms.RibbonSeparator orbMenuSeparator1;
        internal MdiTabControl.TabControl tabControl;
        private System.Windows.Forms.RibbonPanel ribbonPanel_Project;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CloseTab;
        private System.Windows.Forms.RibbonOrbMenuItem NewProject;
        private System.Windows.Forms.RibbonSeparator orbMenuSeparator2;
        private System.Windows.Forms.RibbonButton OpenManual;
        private System.Windows.Forms.FolderBrowserDialog BrowseManual;
    }
}

