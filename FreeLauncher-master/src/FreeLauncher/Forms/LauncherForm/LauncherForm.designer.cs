using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace FreeLauncher.Forms
{
    partial class LauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Версия");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Тип");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Дата выхода");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Последнего обновление");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Индекс ресурсов");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Зависимость");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn7 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Идентификатор");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn8 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Название");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Версия");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Конфигурация релизов");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn11 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Видимость лаунчера");
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.mainPageView = new Telerik.WinControls.UI.RadPageView();
            this.News = new Telerik.WinControls.UI.RadPageViewPage();
            this.newsBrowser = new System.Windows.Forms.WebBrowser();
            this.navBar = new Telerik.WinControls.UI.RadPanel();
            this.BackWebButton = new Telerik.WinControls.UI.RadButton();
            this.ForwardWebButton = new Telerik.WinControls.UI.RadButton();
            this.ConsolePage = new Telerik.WinControls.UI.RadPageViewPage();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.ConsoleOptionsPanel = new Telerik.WinControls.UI.RadPanel();
            this.SetToClipboardButton = new Telerik.WinControls.UI.RadButton();
            this.DebugModeButton = new Telerik.WinControls.UI.RadToggleButton();
            this.EditVersions = new Telerik.WinControls.UI.RadPageViewPage();
            this.versionsListView = new Telerik.WinControls.UI.RadListView();
            this.EditProfiles = new Telerik.WinControls.UI.RadPageViewPage();
            this.profilesListView = new Telerik.WinControls.UI.RadListView();
            this.AboutPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.AboutPageView = new Telerik.WinControls.UI.RadPageView();
            this.AboutPageViewPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radScrollablePanel2 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.CopyrightInfoLabel = new System.Windows.Forms.Label();
            this.LoggerGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.CloseGameOutput = new Telerik.WinControls.UI.RadCheckBox();
            this.EnableMinecraftLogging = new Telerik.WinControls.UI.RadCheckBox();
            this.MainGroupBox = new Telerik.WinControls.UI.RadGroupBox();
            this.CheckUpdatesCheckBox = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.LangDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.DownloadAssetsBox = new Telerik.WinControls.UI.RadCheckBox();
            this.AboutVersion = new Telerik.WinControls.UI.RadLabel();
            this.mcOfflineURL = new System.Windows.Forms.Label();
            this.MCofflineDescLabel = new System.Windows.Forms.Label();
            this.PartnersLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.gitURL = new System.Windows.Forms.Label();
            this.DevInfoLabel = new System.Windows.Forms.Label();
            this.ruMcURL = new System.Windows.Forms.Label();
            this.GratitudesDescLabel = new System.Windows.Forms.Label();
            this.GratitudesLabel = new Telerik.WinControls.UI.RadLabel();
            this.LicensesPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.licensePageView = new Telerik.WinControls.UI.RadPageView();
            this.FreeLauncherLicense = new Telerik.WinControls.UI.RadPageViewPage();
            this.FreeLauncherLicenseText = new Telerik.WinControls.UI.RadLabel();
            this.dotMCLauncherLicense = new Telerik.WinControls.UI.RadPageViewPage();
            this.dotMCLauncherLicenseText = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton9 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList3 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.DeleteProfileButton = new Telerik.WinControls.UI.RadButton();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.ManageUsersButton = new Telerik.WinControls.UI.RadButton();
            this.SelectedVersion = new System.Windows.Forms.Label();
            this.LaunchButton = new Telerik.WinControls.UI.RadButton();
            this.profilesDropDownBox = new Telerik.WinControls.UI.RadDropDownList();
            this.EditProfileButton = new Telerik.WinControls.UI.RadButton();
            this.NicknameDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.AddProfile = new Telerik.WinControls.UI.RadButton();
            this.object_9d39924e_142d_44c0_8d1e_26bdb2a8a921 = new Telerik.WinControls.RootRadElement();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radButton6 = new Telerik.WinControls.UI.RadButton();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.radButton7 = new Telerik.WinControls.UI.RadButton();
            this.radButton8 = new Telerik.WinControls.UI.RadButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.StatusBar = new Telerik.WinControls.UI.RadProgressBar();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.officeShape1 = new Telerik.WinControls.UI.OfficeShape();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).BeginInit();
            this.mainPageView.SuspendLayout();
            this.News.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackWebButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardWebButton)).BeginInit();
            this.ConsolePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleOptionsPanel)).BeginInit();
            this.ConsoleOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetToClipboardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebugModeButton)).BeginInit();
            this.EditVersions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.versionsListView)).BeginInit();
            this.EditProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilesListView)).BeginInit();
            this.AboutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutPageView)).BeginInit();
            this.AboutPageView.SuspendLayout();
            this.AboutPageViewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel2)).BeginInit();
            this.radScrollablePanel2.PanelContainer.SuspendLayout();
            this.radScrollablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoggerGroupBox)).BeginInit();
            this.LoggerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGameOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnableMinecraftLogging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGroupBox)).BeginInit();
            this.MainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckUpdatesCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LangDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadAssetsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartnersLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GratitudesLabel)).BeginInit();
            this.LicensesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licensePageView)).BeginInit();
            this.licensePageView.SuspendLayout();
            this.FreeLauncherLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeLauncherLicenseText)).BeginInit();
            this.dotMCLauncherLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotMCLauncherLicenseText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProfileButton)).BeginInit();
            this.DeleteProfileButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUsersButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaunchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesDropDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProfileButton)).BeginInit();
            this.EditProfileButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NicknameDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton8)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.radPageViewPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPageView
            // 
            this.mainPageView.Controls.Add(this.News);
            this.mainPageView.Controls.Add(this.ConsolePage);
            this.mainPageView.Controls.Add(this.EditVersions);
            this.mainPageView.Controls.Add(this.EditProfiles);
            this.mainPageView.Controls.Add(this.AboutPage);
            this.mainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageView.Location = new System.Drawing.Point(0, 0);
            this.mainPageView.Name = "mainPageView";
            this.mainPageView.SelectedPage = this.EditVersions;
            this.mainPageView.Size = new System.Drawing.Size(800, 488);
            this.mainPageView.TabIndex = 2;
            this.mainPageView.Visible = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Bottom;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.mainPageView.GetChildAt(0))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(20)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(250)))), ((int)(((byte)(195)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).BorderTopShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderInnerColor2 = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(212)))));
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).HorizontalLineColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderTopColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderLeftShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).ImageTransparentColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).FocusBorderColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).DrawText = true;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderDrawMode = Telerik.WinControls.BorderDrawModes.VerticalOverHorizontal;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).NumberOfColors = 1;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).ClipText = false;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).EnableElementShadow = false;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).EnableFocusBorder = false;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).EnableFocusBorderAnimation = true;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).EnableBorderHighlight = false;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Enabled = true;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).ClipDrawing = true;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1))).UseCompatibleTextRendering = true;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).DrawText = true;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).DrawFill = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).DrawBackgroundImage = true;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).DrawImage = true;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(252)))), ((int)(((byte)(242)))));
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).BorderInnerColor = System.Drawing.Color.Aqua;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).EnableFocusBorder = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).EnableFocusBorderAnimation = true;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).EnableHighlight = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).ToolTipText = "Scroll Strip Left";
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).ToolTipText = "Scroll Strip Right";
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).DrawFill = true;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).ToolTipText = "Close Selected Page";
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.UI.RadPageViewStripButtonElement)(this.mainPageView.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(3))).ClipDrawing = true;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.mainPageView.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Aqua;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.mainPageView.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // News
            // 
            this.News.Controls.Add(this.newsBrowser);
            this.News.Controls.Add(this.navBar);
            this.News.ItemSize = new System.Drawing.SizeF(69F, 28F);
            this.News.Location = new System.Drawing.Point(10, 10);
            this.News.Name = "News";
            this.News.Size = new System.Drawing.Size(779, 440);
            this.News.Text = "НОВОСТИ";
            // 
            // newsBrowser
            // 
            this.newsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsBrowser.Location = new System.Drawing.Point(0, 0);
            this.newsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.newsBrowser.Name = "newsBrowser";
            this.newsBrowser.ScriptErrorsSuppressed = true;
            this.newsBrowser.Size = new System.Drawing.Size(779, 411);
            this.newsBrowser.TabIndex = 0;
            this.newsBrowser.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.newsBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.newsBrowser_Navigated);
            this.newsBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.newsBrowser_Navigating);
            // 
            // navBar
            // 
            this.navBar.Controls.Add(this.BackWebButton);
            this.navBar.Controls.Add(this.ForwardWebButton);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navBar.Location = new System.Drawing.Point(0, 411);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(779, 29);
            this.navBar.TabIndex = 1;
            this.navBar.ThemeName = "VisualStudio2012Dark";
            this.navBar.Visible = false;
            // 
            // BackWebButton
            // 
            this.BackWebButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackWebButton.Location = new System.Drawing.Point(646, 3);
            this.BackWebButton.Name = "BackWebButton";
            this.BackWebButton.Size = new System.Drawing.Size(64, 23);
            this.BackWebButton.TabIndex = 1;
            this.BackWebButton.Text = "<";
            this.BackWebButton.ThemeName = "VisualStudio2012Dark";
            this.BackWebButton.Click += new System.EventHandler(this.backWebButton_Click);
            // 
            // ForwardWebButton
            // 
            this.ForwardWebButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ForwardWebButton.Location = new System.Drawing.Point(710, 3);
            this.ForwardWebButton.Name = "ForwardWebButton";
            this.ForwardWebButton.Size = new System.Drawing.Size(64, 23);
            this.ForwardWebButton.TabIndex = 0;
            this.ForwardWebButton.Text = ">";
            this.ForwardWebButton.ThemeName = "VisualStudio2012Dark";
            this.ForwardWebButton.Click += new System.EventHandler(this.forwardWebButton_Click);
            // 
            // ConsolePage
            // 
            this.ConsolePage.Controls.Add(this.logBox);
            this.ConsolePage.Controls.Add(this.ConsoleOptionsPanel);
            this.ConsolePage.ItemSize = new System.Drawing.SizeF(69F, 28F);
            this.ConsolePage.Location = new System.Drawing.Point(10, 10);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Size = new System.Drawing.Size(979, 501);
            this.ConsolePage.Text = "КОНСОЛЬ";
            // 
            // logBox
            // 
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(979, 472);
            this.logBox.TabIndex = 1;
            this.logBox.Text = "";
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // ConsoleOptionsPanel
            // 
            this.ConsoleOptionsPanel.Controls.Add(this.SetToClipboardButton);
            this.ConsoleOptionsPanel.Controls.Add(this.DebugModeButton);
            this.ConsoleOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConsoleOptionsPanel.Location = new System.Drawing.Point(0, 472);
            this.ConsoleOptionsPanel.Name = "ConsoleOptionsPanel";
            this.ConsoleOptionsPanel.Size = new System.Drawing.Size(979, 29);
            this.ConsoleOptionsPanel.TabIndex = 2;
            this.ConsoleOptionsPanel.ThemeName = "VisualStudio2012Dark";
            // 
            // SetToClipboardButton
            // 
            this.SetToClipboardButton.Location = new System.Drawing.Point(7, 3);
            this.SetToClipboardButton.Name = "SetToClipboardButton";
            this.SetToClipboardButton.Size = new System.Drawing.Size(131, 23);
            this.SetToClipboardButton.TabIndex = 1;
            this.SetToClipboardButton.Text = "Скопировать в буфер";
            this.SetToClipboardButton.ThemeName = "VisualStudio2012Dark";
            this.SetToClipboardButton.Click += new System.EventHandler(this.SetToClipboardButton_Click);
            // 
            // DebugModeButton
            // 
            this.DebugModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugModeButton.Location = new System.Drawing.Point(841, 3);
            this.DebugModeButton.Name = "DebugModeButton";
            this.DebugModeButton.Size = new System.Drawing.Size(131, 23);
            this.DebugModeButton.TabIndex = 0;
            this.DebugModeButton.Text = "Debug Mode";
            this.DebugModeButton.ThemeName = "VisualStudio2012Dark";
            // 
            // EditVersions
            // 
            this.EditVersions.Controls.Add(this.versionsListView);
            this.EditVersions.ItemSize = new System.Drawing.SizeF(149F, 28F);
            this.EditVersions.Location = new System.Drawing.Point(10, 10);
            this.EditVersions.Name = "EditVersions";
            this.EditVersions.Size = new System.Drawing.Size(779, 440);
            this.EditVersions.Text = "УПРАВЛЕНИЕ ВЕРСИЯМИ";
            // 
            // versionsListView
            // 
            this.versionsListView.AllowColumnReorder = false;
            this.versionsListView.AllowColumnResize = false;
            this.versionsListView.AllowEdit = false;
            this.versionsListView.AllowRemove = false;
            this.versionsListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.versionsListView.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick;
            listViewDetailColumn1.HeaderText = "Версия";
            listViewDetailColumn1.Width = 150F;
            listViewDetailColumn2.HeaderText = "Тип";
            listViewDetailColumn2.Width = 100F;
            listViewDetailColumn3.HeaderText = "Дата выхода";
            listViewDetailColumn3.Width = 150F;
            listViewDetailColumn4.HeaderText = "Последнего обновление";
            listViewDetailColumn4.Width = 150F;
            listViewDetailColumn5.HeaderText = "Индекс ресурсов";
            listViewDetailColumn5.Width = 120F;
            listViewDetailColumn6.HeaderText = "Зависимость";
            listViewDetailColumn6.Width = 100F;
            this.versionsListView.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.versionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionsListView.EnableColumnSort = true;
            this.versionsListView.EnableFiltering = true;
            this.versionsListView.EnableSorting = true;
            this.versionsListView.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this.versionsListView.ItemSpacing = -1;
            this.versionsListView.Location = new System.Drawing.Point(0, 0);
            this.versionsListView.Name = "versionsListView";
            this.versionsListView.SelectLastAddedItem = false;
            this.versionsListView.ShowItemToolTips = false;
            this.versionsListView.Size = new System.Drawing.Size(779, 440);
            this.versionsListView.TabIndex = 0;
            this.versionsListView.ThemeName = "VisualStudio2012Dark";
            this.versionsListView.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.versionsListView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.versionsListView.Visible = false;
            this.versionsListView.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.versionsListView_ItemMouseClick);
            // 
            // EditProfiles
            // 
            this.EditProfiles.Controls.Add(this.profilesListView);
            this.EditProfiles.ItemSize = new System.Drawing.SizeF(162F, 28F);
            this.EditProfiles.Location = new System.Drawing.Point(5, 5);
            this.EditProfiles.Name = "EditProfiles";
            this.EditProfiles.Size = new System.Drawing.Size(990, 513);
            this.EditProfiles.Text = "УПРАВЛЕНИЕ ПРОФИЛЯМИ";
            // 
            // profilesListView
            // 
            this.profilesListView.AllowColumnReorder = false;
            this.profilesListView.AllowColumnResize = false;
            this.profilesListView.AllowEdit = false;
            this.profilesListView.AllowRemove = false;
            this.profilesListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profilesListView.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick;
            listViewDetailColumn7.HeaderText = "Идентификатор";
            listViewDetailColumn8.HeaderText = "Название";
            listViewDetailColumn9.HeaderText = "Версия";
            listViewDetailColumn10.HeaderText = "Конфигурация релизов";
            listViewDetailColumn11.HeaderText = "Видимость лаунчера";
            this.profilesListView.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn7,
            listViewDetailColumn8,
            listViewDetailColumn9,
            listViewDetailColumn10,
            listViewDetailColumn11});
            this.profilesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilesListView.EnableColumnSort = true;
            this.profilesListView.EnableFiltering = true;
            this.profilesListView.EnableSorting = true;
            this.profilesListView.ItemSpacing = -1;
            this.profilesListView.Location = new System.Drawing.Point(0, 0);
            this.profilesListView.Name = "profilesListView";
            this.profilesListView.SelectLastAddedItem = false;
            this.profilesListView.ShowItemToolTips = false;
            this.profilesListView.Size = new System.Drawing.Size(990, 513);
            this.profilesListView.TabIndex = 1;
            this.profilesListView.ThemeName = "VisualStudio2012Dark";
            this.profilesListView.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.profilesListView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.profilesListView.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.profilesListView_ItemMouseClick);
            // 
            // AboutPage
            // 
            this.AboutPage.Controls.Add(this.AboutPageView);
            this.AboutPage.ItemSize = new System.Drawing.SizeF(83F, 28F);
            this.AboutPage.Location = new System.Drawing.Point(5, 5);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Size = new System.Drawing.Size(990, 513);
            this.AboutPage.Text = "О ЛАУНЧЕРЕ";
            // 
            // AboutPageView
            // 
            this.AboutPageView.Controls.Add(this.AboutPageViewPage);
            this.AboutPageView.Controls.Add(this.LicensesPage);
            this.AboutPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutPageView.Location = new System.Drawing.Point(0, 0);
            this.AboutPageView.Name = "AboutPageView";
            this.AboutPageView.SelectedPage = this.AboutPageViewPage;
            this.AboutPageView.Size = new System.Drawing.Size(990, 513);
            this.AboutPageView.TabIndex = 9;
            this.AboutPageView.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.AboutPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.AboutPageView.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.AboutPageView.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.AboutPageView.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Bottom;
            // 
            // AboutPageViewPage
            // 
            this.AboutPageViewPage.Controls.Add(this.radScrollablePanel2);
            this.AboutPageViewPage.Location = new System.Drawing.Point(5, 5);
            this.AboutPageViewPage.Name = "AboutPageViewPage";
            this.AboutPageViewPage.Size = new System.Drawing.Size(980, 478);
            this.AboutPageViewPage.Text = "О ЛАУНЧЕРЕ";
            // 
            // radScrollablePanel2
            // 
            this.radScrollablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScrollablePanel2.Location = new System.Drawing.Point(0, 0);
            this.radScrollablePanel2.Name = "radScrollablePanel2";
            // 
            // radScrollablePanel2.PanelContainer
            // 
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.CopyrightInfoLabel);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.LoggerGroupBox);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.MainGroupBox);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.AboutVersion);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.mcOfflineURL);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.MCofflineDescLabel);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.PartnersLabel);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.radLabel1);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.gitURL);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.DevInfoLabel);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.ruMcURL);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.GratitudesDescLabel);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.GratitudesLabel);
            this.radScrollablePanel2.PanelContainer.Size = new System.Drawing.Size(978, 476);
            this.radScrollablePanel2.Size = new System.Drawing.Size(980, 478);
            this.radScrollablePanel2.TabIndex = 9;
            this.radScrollablePanel2.ThemeName = "VisualStudio2012Dark";
            // 
            // CopyrightInfoLabel
            // 
            this.CopyrightInfoLabel.AutoSize = true;
            this.CopyrightInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightInfoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CopyrightInfoLabel.Location = new System.Drawing.Point(2, 254);
            this.CopyrightInfoLabel.Name = "CopyrightInfoLabel";
            this.CopyrightInfoLabel.Size = new System.Drawing.Size(464, 34);
            this.CopyrightInfoLabel.TabIndex = 14;
            this.CopyrightInfoLabel.Text = "\"Minecraft\" является торговой маркой Mojang AB. Все права защищены.\r\nMojang AB яв" +
    "ляется дочерней студией Microsoft Studios.\r\n";
            this.CopyrightInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoggerGroupBox
            // 
            this.LoggerGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.LoggerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.LoggerGroupBox.Controls.Add(this.CloseGameOutput);
            this.LoggerGroupBox.Controls.Add(this.EnableMinecraftLogging);
            this.LoggerGroupBox.HeaderText = "Логирование";
            this.LoggerGroupBox.Location = new System.Drawing.Point(469, 141);
            this.LoggerGroupBox.Name = "LoggerGroupBox";
            this.LoggerGroupBox.Size = new System.Drawing.Size(357, 121);
            this.LoggerGroupBox.TabIndex = 13;
            this.LoggerGroupBox.Text = "Логирование";
            this.LoggerGroupBox.ThemeName = "VisualStudio2012Dark";
            // 
            // CloseGameOutput
            // 
            this.CloseGameOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloseGameOutput.Location = new System.Drawing.Point(5, 45);
            this.CloseGameOutput.Name = "CloseGameOutput";
            this.CloseGameOutput.Size = new System.Drawing.Size(327, 18);
            this.CloseGameOutput.TabIndex = 2;
            this.CloseGameOutput.Text = "Закрывать вкладку, если завершение прошло без ошибок";
            this.CloseGameOutput.ThemeName = "VisualStudio2012Dark";
            this.CloseGameOutput.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // EnableMinecraftLogging
            // 
            this.EnableMinecraftLogging.Location = new System.Drawing.Point(5, 21);
            this.EnableMinecraftLogging.Name = "EnableMinecraftLogging";
            this.EnableMinecraftLogging.Size = new System.Drawing.Size(177, 18);
            this.EnableMinecraftLogging.TabIndex = 0;
            this.EnableMinecraftLogging.Text = "Выводить лог игры в консоль";
            this.EnableMinecraftLogging.ThemeName = "VisualStudio2012Dark";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.MainGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MainGroupBox.Controls.Add(this.CheckUpdatesCheckBox);
            this.MainGroupBox.Controls.Add(this.radLabel4);
            this.MainGroupBox.Controls.Add(this.LangDropDownList);
            this.MainGroupBox.Controls.Add(this.DownloadAssetsBox);
            this.MainGroupBox.HeaderText = "Основные";
            this.MainGroupBox.Location = new System.Drawing.Point(469, 14);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(357, 121);
            this.MainGroupBox.TabIndex = 12;
            this.MainGroupBox.Text = "Основные";
            this.MainGroupBox.ThemeName = "VisualStudio2012Dark";
            // 
            // CheckUpdatesCheckBox
            // 
            this.CheckUpdatesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUpdatesCheckBox.Location = new System.Drawing.Point(5, 51);
            this.CheckUpdatesCheckBox.Name = "CheckUpdatesCheckBox";
            this.CheckUpdatesCheckBox.Size = new System.Drawing.Size(245, 18);
            this.CheckUpdatesCheckBox.TabIndex = 6;
            this.CheckUpdatesCheckBox.Text = "Проверять наличие обновлений лаунчера";
            this.CheckUpdatesCheckBox.ThemeName = "VisualStudio2012Dark";
            this.CheckUpdatesCheckBox.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(5, 21);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(87, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Язык/Language:";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel4.GetChildAt(0))).Text = "Язык/Language:";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel4.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // LangDropDownList
            // 
            this.LangDropDownList.AutoCompleteDisplayMember = null;
            this.LangDropDownList.AutoCompleteValueMember = null;
            this.LangDropDownList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Tag = "ru_RU";
            radListDataItem1.Text = "Русский (default)";
            this.LangDropDownList.Items.Add(radListDataItem1);
            this.LangDropDownList.Location = new System.Drawing.Point(150, 21);
            this.LangDropDownList.Name = "LangDropDownList";
            this.LangDropDownList.Size = new System.Drawing.Size(202, 24);
            this.LangDropDownList.TabIndex = 3;
            this.LangDropDownList.Text = "Русский (ru-RU)";
            this.LangDropDownList.ThemeName = "VisualStudio2012Dark";
            this.LangDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.LangDropDownList_SelectedIndexChanged);
            // 
            // DownloadAssetsBox
            // 
            this.DownloadAssetsBox.Location = new System.Drawing.Point(5, 75);
            this.DownloadAssetsBox.Name = "DownloadAssetsBox";
            this.DownloadAssetsBox.Size = new System.Drawing.Size(181, 18);
            this.DownloadAssetsBox.TabIndex = 0;
            this.DownloadAssetsBox.Text = "Пропускать загрузку ресурсов";
            this.DownloadAssetsBox.ThemeName = "VisualStudio2012Dark";
            // 
            // AboutVersion
            // 
            this.AboutVersion.BackColor = System.Drawing.Color.Transparent;
            this.AboutVersion.ForeColor = System.Drawing.Color.DimGray;
            this.AboutVersion.Location = new System.Drawing.Point(122, 34);
            this.AboutVersion.MinimumSize = new System.Drawing.Size(58, 18);
            this.AboutVersion.Name = "AboutVersion";
            // 
            // 
            // 
            this.AboutVersion.RootElement.MinSize = new System.Drawing.Size(58, 18);
            this.AboutVersion.Size = new System.Drawing.Size(58, 18);
            this.AboutVersion.TabIndex = 1;
            this.AboutVersion.Text = "0.0.0.000";
            this.AboutVersion.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.AboutVersion.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.AboutVersion.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            ((Telerik.WinControls.UI.RadLabelElement)(this.AboutVersion.GetChildAt(0))).Text = "0.0.0.000";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.AboutVersion.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // mcOfflineURL
            // 
            this.mcOfflineURL.AutoSize = true;
            this.mcOfflineURL.BackColor = System.Drawing.Color.Transparent;
            this.mcOfflineURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcOfflineURL.ForeColor = System.Drawing.Color.Gray;
            this.mcOfflineURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mcOfflineURL.Location = new System.Drawing.Point(14, 201);
            this.mcOfflineURL.Name = "mcOfflineURL";
            this.mcOfflineURL.Size = new System.Drawing.Size(127, 13);
            this.mcOfflineURL.TabIndex = 11;
            this.mcOfflineURL.Text = "http://vk.com/mcoffline";
            this.mcOfflineURL.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // MCofflineDescLabel
            // 
            this.MCofflineDescLabel.AutoSize = true;
            this.MCofflineDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.MCofflineDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MCofflineDescLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MCofflineDescLabel.Location = new System.Drawing.Point(14, 184);
            this.MCofflineDescLabel.Name = "MCofflineDescLabel";
            this.MCofflineDescLabel.Size = new System.Drawing.Size(402, 17);
            this.MCofflineDescLabel.TabIndex = 9;
            this.MCofflineDescLabel.Text = "MCoffline - лучшая программа для серверных администраторов!";
            // 
            // PartnersLabel
            // 
            this.PartnersLabel.BackColor = System.Drawing.Color.Transparent;
            this.PartnersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.PartnersLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PartnersLabel.Location = new System.Drawing.Point(3, 147);
            this.PartnersLabel.Name = "PartnersLabel";
            this.PartnersLabel.Size = new System.Drawing.Size(140, 41);
            this.PartnersLabel.TabIndex = 10;
            this.PartnersLabel.Text = "Партнёры";
            this.PartnersLabel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.PartnersLabel.GetChildAt(0))).Text = "Партнёры";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PartnersLabel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(175, 41);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "FreeLauncher";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "FreeLauncher";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // gitURL
            // 
            this.gitURL.AutoSize = true;
            this.gitURL.BackColor = System.Drawing.Color.Transparent;
            this.gitURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gitURL.ForeColor = System.Drawing.Color.Gray;
            this.gitURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gitURL.Location = new System.Drawing.Point(14, 72);
            this.gitURL.Name = "gitURL";
            this.gitURL.Size = new System.Drawing.Size(163, 15);
            this.gitURL.TabIndex = 5;
            this.gitURL.Text = "https://github.com/dedepete";
            this.gitURL.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // DevInfoLabel
            // 
            this.DevInfoLabel.AutoSize = true;
            this.DevInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.DevInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DevInfoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DevInfoLabel.Location = new System.Drawing.Point(14, 55);
            this.DevInfoLabel.Name = "DevInfoLabel";
            this.DevInfoLabel.Size = new System.Drawing.Size(146, 17);
            this.DevInfoLabel.TabIndex = 3;
            this.DevInfoLabel.Text = "Разработано dedepete";
            // 
            // ruMcURL
            // 
            this.ruMcURL.AutoSize = true;
            this.ruMcURL.BackColor = System.Drawing.Color.Transparent;
            this.ruMcURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ruMcURL.ForeColor = System.Drawing.Color.Gray;
            this.ruMcURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ruMcURL.Location = new System.Drawing.Point(14, 135);
            this.ruMcURL.Name = "ruMcURL";
            this.ruMcURL.Size = new System.Drawing.Size(117, 13);
            this.ruMcURL.TabIndex = 8;
            this.ruMcURL.Text = "http://ru-minecraft.ru";
            this.ruMcURL.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // GratitudesDescLabel
            // 
            this.GratitudesDescLabel.AutoSize = true;
            this.GratitudesDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.GratitudesDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.GratitudesDescLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GratitudesDescLabel.Location = new System.Drawing.Point(14, 118);
            this.GratitudesDescLabel.Name = "GratitudesDescLabel";
            this.GratitudesDescLabel.Size = new System.Drawing.Size(449, 17);
            this.GratitudesDescLabel.TabIndex = 6;
            this.GratitudesDescLabel.Text = "Большое спасибо администрации портала ru-minecraft.ru за хост файлов";
            // 
            // GratitudesLabel
            // 
            this.GratitudesLabel.BackColor = System.Drawing.Color.Transparent;
            this.GratitudesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.GratitudesLabel.ForeColor = System.Drawing.Color.Transparent;
            this.GratitudesLabel.Location = new System.Drawing.Point(3, 81);
            this.GratitudesLabel.Name = "GratitudesLabel";
            this.GratitudesLabel.Size = new System.Drawing.Size(202, 41);
            this.GratitudesLabel.TabIndex = 7;
            this.GratitudesLabel.Text = "Благодарности";
            this.GratitudesLabel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.GratitudesLabel.GetChildAt(0))).Text = "Благодарности";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.GratitudesLabel.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // LicensesPage
            // 
            this.LicensesPage.Controls.Add(this.licensePageView);
            this.LicensesPage.Location = new System.Drawing.Point(5, 5);
            this.LicensesPage.Name = "LicensesPage";
            this.LicensesPage.Size = new System.Drawing.Size(838, 293);
            this.LicensesPage.Text = "ЛИЦЕНЗИИ";
            // 
            // licensePageView
            // 
            this.licensePageView.Controls.Add(this.FreeLauncherLicense);
            this.licensePageView.Controls.Add(this.dotMCLauncherLicense);
            this.licensePageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licensePageView.Location = new System.Drawing.Point(0, 0);
            this.licensePageView.Name = "licensePageView";
            this.licensePageView.SelectedPage = this.FreeLauncherLicense;
            this.licensePageView.Size = new System.Drawing.Size(838, 293);
            this.licensePageView.TabIndex = 0;
            this.licensePageView.ThemeName = "VisualStudio2012Dark";
            this.licensePageView.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.licensePageView.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(150, 0);
            // 
            // FreeLauncherLicense
            // 
            this.FreeLauncherLicense.Controls.Add(this.FreeLauncherLicenseText);
            this.FreeLauncherLicense.Location = new System.Drawing.Point(155, 4);
            this.FreeLauncherLicense.Name = "FreeLauncherLicense";
            this.FreeLauncherLicense.Size = new System.Drawing.Size(679, 285);
            this.FreeLauncherLicense.Text = "FreeLauncher";
            // 
            // FreeLauncherLicenseText
            // 
            this.FreeLauncherLicenseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreeLauncherLicenseText.Location = new System.Drawing.Point(0, 0);
            this.FreeLauncherLicenseText.Name = "FreeLauncherLicenseText";
            this.FreeLauncherLicenseText.Size = new System.Drawing.Size(679, 285);
            this.FreeLauncherLicenseText.TabIndex = 2;
            this.FreeLauncherLicenseText.Text = resources.GetString("FreeLauncherLicenseText.Text");
            this.FreeLauncherLicenseText.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.FreeLauncherLicenseText.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.FreeLauncherLicenseText.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // dotMCLauncherLicense
            // 
            this.dotMCLauncherLicense.AutoScroll = true;
            this.dotMCLauncherLicense.Controls.Add(this.dotMCLauncherLicenseText);
            this.dotMCLauncherLicense.Location = new System.Drawing.Point(155, 4);
            this.dotMCLauncherLicense.Name = "dotMCLauncherLicense";
            this.dotMCLauncherLicense.Size = new System.Drawing.Size(679, 285);
            this.dotMCLauncherLicense.Text = "dotMCLauncher";
            // 
            // dotMCLauncherLicenseText
            // 
            this.dotMCLauncherLicenseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotMCLauncherLicenseText.Location = new System.Drawing.Point(0, 0);
            this.dotMCLauncherLicenseText.Name = "dotMCLauncherLicenseText";
            this.dotMCLauncherLicenseText.Size = new System.Drawing.Size(679, 285);
            this.dotMCLauncherLicenseText.TabIndex = 1;
            this.dotMCLauncherLicenseText.Text = resources.GetString("dotMCLauncherLicenseText.Text");
            this.dotMCLauncherLicenseText.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.dotMCLauncherLicenseText.GetChildAt(0))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.dotMCLauncherLicenseText.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.Transparent;
            this.radPanel1.Controls.Add(this.tableLayoutPanel2);
            this.radPanel1.Controls.Add(this.DeleteProfileButton);
            this.radPanel1.Controls.Add(this.ManageUsersButton);
            this.radPanel1.Controls.Add(this.SelectedVersion);
            this.radPanel1.Controls.Add(this.LaunchButton);
            this.radPanel1.Controls.Add(this.profilesDropDownBox);
            this.radPanel1.Controls.Add(this.EditProfileButton);
            this.radPanel1.Controls.Add(this.AddProfile);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanel1.Location = new System.Drawing.Point(0, 488);
            this.radPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(800, 58);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.2849F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.92282F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.90579F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.radDropDownList3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radDropDownList2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 58);
            this.tableLayoutPanel2.TabIndex = 9;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radButton1);
            this.flowLayoutPanel1.Controls.Add(this.radButton2);
            this.flowLayoutPanel1.Controls.Add(this.radButton9);
            this.flowLayoutPanel1.Controls.Add(this.radButton3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(457, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.BackgroundImage = global::FreeLauncher.Properties.Resources.play;
            this.radButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radButton1.Location = new System.Drawing.Point(20, 0);
            this.radButton1.Margin = new System.Windows.Forms.Padding(20, 0, 15, 25);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(200, 55);
            this.radButton1.TabIndex = 7;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton1.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.Transparent;
            this.radButton2.BackgroundImage = global::FreeLauncher.Properties.Resources.settings;
            this.radButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radButton2.Location = new System.Drawing.Point(235, 10);
            this.radButton2.Margin = new System.Windows.Forms.Padding(0, 10, 15, 25);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(35, 35);
            this.radButton2.TabIndex = 8;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton2.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // radButton9
            // 
            this.radButton9.BackColor = System.Drawing.Color.Transparent;
            this.radButton9.BackgroundImage = global::FreeLauncher.Properties.Resources.folder;
            this.radButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radButton9.Location = new System.Drawing.Point(285, 10);
            this.radButton9.Margin = new System.Windows.Forms.Padding(0, 10, 10, 25);
            this.radButton9.Name = "radButton9";
            this.radButton9.Size = new System.Drawing.Size(35, 35);
            this.radButton9.TabIndex = 9;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton9.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // radButton3
            // 
            this.radButton3.BackColor = System.Drawing.Color.Transparent;
            this.radButton3.BackgroundImage = global::FreeLauncher.Properties.Resources.folder;
            this.radButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radButton3.Location = new System.Drawing.Point(10, 110);
            this.radButton3.Margin = new System.Windows.Forms.Padding(10, 30, 20, 25);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(35, 35);
            this.radButton3.TabIndex = 9;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton3.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            // 
            // radDropDownList3
            // 
            this.radDropDownList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDropDownList3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radDropDownList3.Location = new System.Drawing.Point(254, 10);
            this.radDropDownList3.Margin = new System.Windows.Forms.Padding(20, 10, 20, 25);
            this.radDropDownList3.Name = "radDropDownList3";
            // 
            // 
            // 
            this.radDropDownList3.RootElement.AutoSize = true;
            this.radDropDownList3.Size = new System.Drawing.Size(183, 23);
            this.radDropDownList3.TabIndex = 6;
            this.radDropDownList3.Text = "radDropDownList3";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList3.GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList3.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Text = "radDropDownList3";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).AutoSize = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, -1, 0, -1);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ShouldPaint = true;
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).MinSize = new System.Drawing.Size(16, 8);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).MaxSize = new System.Drawing.Size(16, 8);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ScaleTransform = new System.Drawing.SizeF(1F, 1F);
            ((Telerik.WinControls.Primitives.OverflowPrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3))).AutoSize = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).Font = new System.Drawing.Font("Segoe UI", 25.8F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList3.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).ScaleTransform = new System.Drawing.SizeF(1F, 1F);
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radDropDownList2.ForeColor = System.Drawing.Color.White;
            radListDataItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            radListDataItem2.ForeColor = System.Drawing.Color.White;
            radListDataItem2.Text = "ListItem 1";
            this.radDropDownList2.Items.Add(radListDataItem2);
            this.radDropDownList2.Location = new System.Drawing.Point(20, 10);
            this.radDropDownList2.Margin = new System.Windows.Forms.Padding(20, 10, 20, 25);
            this.radDropDownList2.Name = "radDropDownList2";
            // 
            // 
            // 
            this.radDropDownList2.RootElement.EnableFocusBorderAnimation = false;
            this.radDropDownList2.Size = new System.Drawing.Size(194, 23);
            this.radDropDownList2.TabIndex = 5;
            this.radDropDownList2.ThemeName = "ControlDefault";
            this.radDropDownList2.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownList2_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList2.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList2.GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownTextBoxElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).DrawFill = false;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).ImageTransparentColor = System.Drawing.Color.Magenta;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).EnableHighlight = false;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).HighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 0, 38, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, -3, 0, -2);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ShouldPaint = true;
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).MinSize = new System.Drawing.Size(16, 8);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).MaxSize = new System.Drawing.Size(16, 8);
            ((Telerik.WinControls.Primitives.ArrowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2))).ScaleTransform = new System.Drawing.SizeF(1F, 1F);
            ((Telerik.WinControls.Primitives.OverflowPrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(3))).AutoSize = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).Font = new System.Drawing.Font("Segoe UI", 25.8F);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).Visibility = Telerik.WinControls.ElementVisibility.Visible;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radDropDownList2.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4))).ScaleTransform = new System.Drawing.SizeF(1F, 1F);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Controls.Add(this.radDropDownList1);
            this.DeleteProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteProfileButton.Image")));
            this.DeleteProfileButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteProfileButton.Location = new System.Drawing.Point(468, 73);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(32, 24);
            this.DeleteProfileButton.TabIndex = 8;
            this.DeleteProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteProfileButton.ThemeName = "VisualStudio2012Dark";
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoCompleteDisplayMember = null;
            this.radDropDownList1.AutoCompleteValueMember = null;
            this.radDropDownList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDropDownList1.Location = new System.Drawing.Point(0, 0);
            this.radDropDownList1.Margin = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.NullText = "Ник";
            this.radDropDownList1.Size = new System.Drawing.Size(32, 24);
            this.radDropDownList1.TabIndex = 4;
            this.radDropDownList1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.radDropDownList1.GetChildAt(0))).AutoSize = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(0))).BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).DrawBorder = false;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).DrawFill = true;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).DrawBorder = false;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 13.8F);
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(0F, 9F);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).NullText = "Ник";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BorderDrawMode = Telerik.WinControls.BorderDrawModes.LeftOverBottom;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Red;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).AutoSize = true;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ClipDrawing = false;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).DrawBorder = false;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderInnerColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderTopColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(1);
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, -3, 0, 2);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).AutoSize = false;
            // 
            // ManageUsersButton
            // 
            this.ManageUsersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageUsersButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageUsersButton.Image")));
            this.ManageUsersButton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManageUsersButton.Location = new System.Drawing.Point(484, 6);
            this.ManageUsersButton.Name = "ManageUsersButton";
            this.ManageUsersButton.Size = new System.Drawing.Size(32, 24);
            this.ManageUsersButton.TabIndex = 7;
            this.ManageUsersButton.ThemeName = "VisualStudio2012Dark";
            this.ManageUsersButton.Click += new System.EventHandler(this.ManageUsersButton_Click);
            // 
            // SelectedVersion
            // 
            this.SelectedVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedVersion.AutoSize = true;
            this.SelectedVersion.BackColor = System.Drawing.Color.Transparent;
            this.SelectedVersion.ForeColor = System.Drawing.Color.White;
            this.SelectedVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectedVersion.Location = new System.Drawing.Point(573, 42);
            this.SelectedVersion.MinimumSize = new System.Drawing.Size(220, 13);
            this.SelectedVersion.Name = "SelectedVersion";
            this.SelectedVersion.Size = new System.Drawing.Size(220, 13);
            this.SelectedVersion.TabIndex = 6;
            this.SelectedVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LaunchButton.Location = new System.Drawing.Point(285, 33);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(231, 22);
            this.LaunchButton.TabIndex = 4;
            this.LaunchButton.Text = "Запуск игры";
            this.LaunchButton.ThemeName = "VisualStudio2012Dark";
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // profilesDropDownBox
            // 
            this.profilesDropDownBox.AutoCompleteDisplayMember = null;
            this.profilesDropDownBox.AutoCompleteValueMember = null;
            this.profilesDropDownBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.profilesDropDownBox.Location = new System.Drawing.Point(674, 27);
            this.profilesDropDownBox.Name = "profilesDropDownBox";
            this.profilesDropDownBox.Size = new System.Drawing.Size(191, 24);
            this.profilesDropDownBox.TabIndex = 2;
            this.profilesDropDownBox.ThemeName = "VisualStudio2012Dark";
            this.profilesDropDownBox.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.profilesDropDownBox_SelectedIndexChanged);
            // 
            // EditProfileButton
            // 
            this.EditProfileButton.Controls.Add(this.NicknameDropDownList);
            this.EditProfileButton.Location = new System.Drawing.Point(777, 66);
            this.EditProfileButton.Name = "EditProfileButton";
            this.EditProfileButton.Size = new System.Drawing.Size(110, 22);
            this.EditProfileButton.TabIndex = 1;
            this.EditProfileButton.Text = "Изменить профиль";
            this.EditProfileButton.TextWrap = true;
            this.EditProfileButton.ThemeName = "VisualStudio2012Dark";
            this.EditProfileButton.Click += new System.EventHandler(this.EditProfile_Click);
            // 
            // NicknameDropDownList
            // 
            this.NicknameDropDownList.AutoCompleteDisplayMember = null;
            this.NicknameDropDownList.AutoCompleteValueMember = null;
            this.NicknameDropDownList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NicknameDropDownList.Location = new System.Drawing.Point(0, 0);
            this.NicknameDropDownList.Margin = new System.Windows.Forms.Padding(30, 25, 30, 20);
            this.NicknameDropDownList.Name = "NicknameDropDownList";
            this.NicknameDropDownList.NullText = "Ник";
            this.NicknameDropDownList.Size = new System.Drawing.Size(110, 22);
            this.NicknameDropDownList.TabIndex = 3;
            this.NicknameDropDownList.ThemeName = "VisualStudio2012Dark";
            this.NicknameDropDownList.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.NicknameDropDownList_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.NicknameDropDownList.GetChildAt(0))).AutoSize = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(0))).BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.StackLayoutElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2))).DrawBorder = false;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).DrawFill = true;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).DrawBorder = false;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 13.8F);
            ((Telerik.WinControls.UI.RadDropDownListEditableAreaElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0))).PositionOffset = new System.Drawing.SizeF(0F, 9F);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).NullText = "Ник";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BorderDrawMode = Telerik.WinControls.BorderDrawModes.LeftOverBottom;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).AutoSize = true;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2))).ClipDrawing = false;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).DrawBorder = false;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderInnerColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderTopColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.LightVisualButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(3).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(1))).AutoSize = false;
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(1);
            ((Telerik.WinControls.UI.RadDropDownListArrowButtonElement)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, -3, 0, 2);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.NicknameDropDownList.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1))).AutoSize = false;
            // 
            // AddProfile
            // 
            this.AddProfile.Location = new System.Drawing.Point(641, 66);
            this.AddProfile.Name = "AddProfile";
            this.AddProfile.Size = new System.Drawing.Size(110, 22);
            this.AddProfile.TabIndex = 0;
            this.AddProfile.Text = "Добавить профиль";
            this.AddProfile.TextWrap = true;
            this.AddProfile.ThemeName = "VisualStudio2012Dark";
            this.AddProfile.Click += new System.EventHandler(this.AddProfile_Click);
            // 
            // object_9d39924e_142d_44c0_8d1e_26bdb2a8a921
            // 
            this.object_9d39924e_142d_44c0_8d1e_26bdb2a8a921.Name = "object_9d39924e_142d_44c0_8d1e_26bdb2a8a921";
            this.object_9d39924e_142d_44c0_8d1e_26bdb2a8a921.StretchHorizontally = true;
            this.object_9d39924e_142d_44c0_8d1e_26bdb2a8a921.StretchVertically = true;
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.Transparent;
            this.radPanel2.Controls.Add(this.radPageView1);
            this.radPanel2.Controls.Add(this.StatusBar);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel2.Location = new System.Drawing.Point(0, 0);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(800, 488);
            this.radPanel2.TabIndex = 5;
            ((Telerik.WinControls.UI.RadPanelElement)(this.radPanel2.GetChildAt(0))).Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 0, 15, 15);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).TopWidth = 1F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).LeftShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).TopShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).RightShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).BottomShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).InnerColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).InnerColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).InnerColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).AutoSize = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).ClipDrawing = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radPanel2.GetChildAt(0).GetChildAt(1))).PositionOffset = new System.Drawing.SizeF(-50F, 480F);
            // 
            // radPageView1
            // 
            this.radPageView1.BackColor = System.Drawing.Color.Transparent;
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Font = new System.Drawing.Font("PF BeauSans Pro", 10.2F);
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Margin = new System.Windows.Forms.Padding(0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.Padding = new System.Windows.Forms.Padding(20, 70, 20, 0);
            // 
            // 
            // 
            this.radPageView1.RootElement.BorderHighlightColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.BorderHighlightThickness = 0;
            this.radPageView1.RootElement.EnableFocusBorderAnimation = false;
            this.radPageView1.RootElement.FocusBorderColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.HighlightColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.RippleAnimationColor = System.Drawing.Color.Transparent;
            this.radPageView1.RootElement.ShadowColor = System.Drawing.Color.Transparent;
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(800, 488);
            this.radPageView1.TabIndex = 5;
            this.radPageView1.ThemeName = "VisualStudio2012Dark";
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).AnimatedStripScrolling = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Shrink;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Bottom;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemSpacing = 10;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).BorderColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(20, 70, 20, 0);
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderPadding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).DrawText = true;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).DrawBorder = true;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderWidth = 0F;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderBottomWidth = 2F;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderBottomColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderTopShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderBottomShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).EnableBorderHighlight = false;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).UseCompatibleTextRendering = true;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).AutoSize = true;
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(2);
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.radPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).HorizontalLineColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).ShadowColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).HighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).Text = "Сервера";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).EnableFocusBorderAnimation = false;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).Padding = new System.Windows.Forms.Padding(4);
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(3))).Text = "Сервера";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(3))).RippleAnimationColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(3))).EnableFocusBorderAnimation = false;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.BackColor = System.Drawing.Color.Transparent;
            this.radPageViewPage1.Controls.Add(this.tableLayoutPanel1);
            this.radPageViewPage1.ForeColor = System.Drawing.Color.Transparent;
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(67F, 25F);
            this.radPageViewPage1.Location = new System.Drawing.Point(21, 71);
            this.radPageViewPage1.Margin = new System.Windows.Forms.Padding(0);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(758, 386);
            this.radPageViewPage1.Text = "Сервера";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radButton6);
            this.flowLayoutPanel2.Controls.Add(this.radButton4);
            this.flowLayoutPanel2.Controls.Add(this.radButton5);
            this.flowLayoutPanel2.Controls.Add(this.radButton7);
            this.flowLayoutPanel2.Controls.Add(this.radButton8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(322, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 28);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // radButton6
            // 
            this.radButton6.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButton6.ForeColor = System.Drawing.Color.White;
            this.radButton6.Location = new System.Drawing.Point(360, 0);
            this.radButton6.Margin = new System.Windows.Forms.Padding(6, 0, 0, 6);
            this.radButton6.Name = "radButton6";
            this.radButton6.Size = new System.Drawing.Size(76, 25);
            this.radButton6.TabIndex = 2;
            this.radButton6.Text = "Вперед";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton6.GetChildAt(0))).Text = "Вперед";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(5);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton6.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            // 
            // radButton4
            // 
            this.radButton4.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButton4.ForeColor = System.Drawing.Color.White;
            this.radButton4.Location = new System.Drawing.Point(323, 0);
            this.radButton4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(25, 25);
            this.radButton4.TabIndex = 3;
            this.radButton4.Text = "3";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton4.GetChildAt(0))).Text = "3";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(5);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton4.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            // 
            // radButton5
            // 
            this.radButton5.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButton5.ForeColor = System.Drawing.Color.White;
            this.radButton5.Location = new System.Drawing.Point(286, 0);
            this.radButton5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(25, 25);
            this.radButton5.TabIndex = 4;
            this.radButton5.Text = "2";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Text = "2";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(5);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            // 
            // radButton7
            // 
            this.radButton7.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButton7.ForeColor = System.Drawing.Color.White;
            this.radButton7.Location = new System.Drawing.Point(249, 0);
            this.radButton7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.radButton7.Name = "radButton7";
            this.radButton7.Size = new System.Drawing.Size(25, 25);
            this.radButton7.TabIndex = 4;
            this.radButton7.Text = "1";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton7.GetChildAt(0))).Text = "1";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(5);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton7.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            // 
            // radButton8
            // 
            this.radButton8.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radButton8.ForeColor = System.Drawing.Color.White;
            this.radButton8.Location = new System.Drawing.Point(167, 0);
            this.radButton8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.radButton8.Name = "radButton8";
            this.radButton8.Size = new System.Drawing.Size(70, 25);
            this.radButton8.TabIndex = 5;
            this.radButton8.Text = "Назад";
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton8.GetChildAt(0))).Text = "Назад";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(0))).NumberOfColors = 1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(0))).CanFocus = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(5);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(83)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(2))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(3))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            ((Telerik.WinControls.Primitives.FocusPrimitive)(this.radButton8.GetChildAt(0).GetChildAt(3))).CanFocus = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel7);
            this.flowLayoutPanel3.Controls.Add(this.panel6);
            this.flowLayoutPanel3.Controls.Add(this.panel5);
            this.flowLayoutPanel3.Controls.Add(this.panel4);
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Controls.Add(this.panel2);
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(752, 352);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(752, 44);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel6.Location = new System.Drawing.Point(3, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(752, 44);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel5.Location = new System.Drawing.Point(3, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(752, 44);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel4.Location = new System.Drawing.Point(3, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(752, 44);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel3.Location = new System.Drawing.Point(3, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 44);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(3, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 44);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(3, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 44);
            this.panel1.TabIndex = 3;
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.BackColor = System.Drawing.Color.Transparent;
            this.radPageViewPage2.Controls.Add(this.tableLayoutPanel4);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(133F, 25F);
            this.radPageViewPage2.Location = new System.Drawing.Point(21, 76);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(758, 357);
            this.radPageViewPage2.Text = "Установщик читов";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91076F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.08924F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(758, 357);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.82058F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.17942F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(758, 49);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Image = global::FreeLauncher.Properties.Resources.edit;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Установи читы в один клик только у нас!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.BackColor = System.Drawing.Color.White;
            this.radPageViewPage3.BackgroundImage = global::FreeLauncher.Properties.Resources.background_Recovered2;
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(141F, 25F);
            this.radPageViewPage3.Location = new System.Drawing.Point(21, 81);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(758, 362);
            this.radPageViewPage3.Text = "Установщик сборок";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(3, 3);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(786, 24);
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "StatusBar";
            this.StatusBar.ThemeName = "VisualStudio2012Dark";
            this.StatusBar.Visible = false;
            this.StatusBar.Click += new System.EventHandler(this.StatusBar_Click);
            // 
            // officeShape1
            // 
            this.officeShape1.IsRightToLeft = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.panel8.Location = new System.Drawing.Point(0, 482);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 2);
            this.panel8.TabIndex = 0;
            // 
            // LauncherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FreeLauncher.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.mainPageView);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MadLauncher";
            this.ThemeName = "VisualStudio2012Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LauncherForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).EndInit();
            this.mainPageView.ResumeLayout(false);
            this.News.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            this.navBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackWebButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardWebButton)).EndInit();
            this.ConsolePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsoleOptionsPanel)).EndInit();
            this.ConsoleOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SetToClipboardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebugModeButton)).EndInit();
            this.EditVersions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.versionsListView)).EndInit();
            this.EditProfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilesListView)).EndInit();
            this.AboutPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutPageView)).EndInit();
            this.AboutPageView.ResumeLayout(false);
            this.AboutPageViewPage.ResumeLayout(false);
            this.radScrollablePanel2.PanelContainer.ResumeLayout(false);
            this.radScrollablePanel2.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel2)).EndInit();
            this.radScrollablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoggerGroupBox)).EndInit();
            this.LoggerGroupBox.ResumeLayout(false);
            this.LoggerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGameOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnableMinecraftLogging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainGroupBox)).EndInit();
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckUpdatesCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LangDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadAssetsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartnersLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GratitudesLabel)).EndInit();
            this.LicensesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.licensePageView)).EndInit();
            this.licensePageView.ResumeLayout(false);
            this.FreeLauncherLicense.ResumeLayout(false);
            this.FreeLauncherLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FreeLauncherLicenseText)).EndInit();
            this.dotMCLauncherLicense.ResumeLayout(false);
            this.dotMCLauncherLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dotMCLauncherLicenseText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteProfileButton)).EndInit();
            this.DeleteProfileButton.ResumeLayout(false);
            this.DeleteProfileButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUsersButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaunchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilesDropDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditProfileButton)).EndInit();
            this.EditProfileButton.ResumeLayout(false);
            this.EditProfileButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NicknameDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton8)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.radPageViewPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RadPageView mainPageView;
        private RadPageViewPage News;
        private WebBrowser newsBrowser;
        private RadPanel navBar;
        private RadButton BackWebButton;
        private RadButton ForwardWebButton;
        private RadPageViewPage ConsolePage;
        public RichTextBox logBox;
        private RadPageViewPage EditVersions;
        private RadListView versionsListView;
        private RadPageViewPage AboutPage;
        private RadPageView AboutPageView;
        private RadPageViewPage AboutPageViewPage;
        private RadScrollablePanel radScrollablePanel2;
        private Label mcOfflineURL;
        private Label MCofflineDescLabel;
        private RadLabel PartnersLabel;
        private RadLabel AboutVersion;
        private RadLabel radLabel1;
        private Label gitURL;
        private Label DevInfoLabel;
        private Label ruMcURL;
        private Label GratitudesDescLabel;
        private RadLabel GratitudesLabel;
        private RadPageViewPage LicensesPage;
        private RadPageView licensePageView;
        private RadPanel radPanel1;
        private RadButton ManageUsersButton;
        public RadDropDownList NicknameDropDownList;
        private Label SelectedVersion;
        private RadButton LaunchButton;
        public RadDropDownList profilesDropDownBox;
        private RadButton EditProfileButton;
        private RadButton AddProfile;
        private RadPageViewPage dotMCLauncherLicense;
        private RadPageViewPage FreeLauncherLicense;
        private RadLabel dotMCLauncherLicenseText;
        private RadPanel ConsoleOptionsPanel;
        private RadToggleButton DebugModeButton;
        private RadButton DeleteProfileButton;
        private RadButton SetToClipboardButton;
        private RadGroupBox LoggerGroupBox;
        public RadCheckBox CloseGameOutput;
        public RadCheckBox EnableMinecraftLogging;
        private RadGroupBox MainGroupBox;
        public RadLabel radLabel4;
        private RadDropDownList LangDropDownList;
        public RadCheckBox DownloadAssetsBox;
        private Label CopyrightInfoLabel;
        private RadLabel FreeLauncherLicenseText;
        private RadPageViewPage EditProfiles;
        private RadListView profilesListView;
        public RadCheckBox CheckUpdatesCheckBox;
        private Telerik.WinControls.RootRadElement object_9d39924e_142d_44c0_8d1e_26bdb2a8a921;
        private TableLayoutPanel tableLayoutPanel2;
        private RadPanel radPanel2;
        private RadProgressBar StatusBar;
        public RadDropDownList radDropDownList1;
        private RadDropDownList radDropDownList2;
        private RadDropDownList radDropDownList3;
        private VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private OfficeShape officeShape1;
        private RadButton radButton1;
        private RadPageView radPageView1;
        private RadPageViewPage radPageViewPage1;
        private RadPageViewPage radPageViewPage2;
        private RadPageViewPage radPageViewPage3;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadButton radButton2;
        private RadButton radButton3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadButton radButton6;
        private RadButton radButton4;
        private RadButton radButton5;
        private RadButton radButton7;
        private RadButton radButton8;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel8;
        private RadButton radButton9;
    }
}
