﻿namespace RaidCrawler
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ConnectionStatusText = new System.Windows.Forms.Label();
            this.InputSwitchIP = new System.Windows.Forms.TextBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelSwitchIP = new System.Windows.Forms.Label();
            this.LabelLoadedRaids = new System.Windows.Forms.Label();
            this.TeraType = new System.Windows.Forms.TextBox();
            this.LabelTeraType = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.TextBox();
            this.LabelPID = new System.Windows.Forms.Label();
            this.EC = new System.Windows.Forms.TextBox();
            this.LabelEC = new System.Windows.Forms.Label();
            this.Seed = new System.Windows.Forms.TextBox();
            this.LabelSeed = new System.Windows.Forms.Label();
            this.LabelIndex = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.TextBox();
            this.LabelUNK_2 = new System.Windows.Forms.Label();
            this.IVs = new System.Windows.Forms.TextBox();
            this.LabelIVs = new System.Windows.Forms.Label();
            this.ButtonReadRaids = new System.Windows.Forms.Button();
            this.ButtonAdvanceDate = new System.Windows.Forms.Button();
            this.IsEvent = new System.Windows.Forms.CheckBox();
            this.LabelIsEvent = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.TextBox();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ComboBox();
            this.LabelStoryProgress = new System.Windows.Forms.Label();
            this.ButtonViewRAM = new System.Windows.Forms.Button();
            this.Species = new System.Windows.Forms.TextBox();
            this.LabelSpecies = new System.Windows.Forms.Label();
            this.LabelMoves = new System.Windows.Forms.Label();
            this.Move1 = new System.Windows.Forms.TextBox();
            this.Move2 = new System.Windows.Forms.TextBox();
            this.Move4 = new System.Windows.Forms.TextBox();
            this.Move3 = new System.Windows.Forms.TextBox();
            this.LabelGame = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.ComboBox();
            this.LabelEventProgress = new System.Windows.Forms.Label();
            this.EventProgress = new System.Windows.Forms.ComboBox();
            this.Nature = new System.Windows.Forms.TextBox();
            this.LabelNature = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.TextBox();
            this.LabelGender = new System.Windows.Forms.Label();
            this.StopFilter = new System.Windows.Forms.Button();
            this.Sprite = new System.Windows.Forms.PictureBox();
            this.Ability = new System.Windows.Forms.TextBox();
            this.LabelAbility = new System.Windows.Forms.Label();
            this.GemIcon = new System.Windows.Forms.PictureBox();
            this.ButtonDumpRaid = new System.Windows.Forms.Button();
            this.ConfigSettings = new System.Windows.Forms.Button();
            this.HeightSize = new System.Windows.Forms.TextBox();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.WeightSize = new System.Windows.Forms.TextBox();
            this.LabelWeight = new System.Windows.Forms.Label();
            this.ScaleSize = new System.Windows.Forms.TextBox();
            this.LabelScale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Enabled = false;
            this.ButtonDisconnect.Location = new System.Drawing.Point(117, 51);
            this.ButtonDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(97, 27);
            this.ButtonDisconnect.TabIndex = 11;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(13, 51);
            this.ButtonConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(97, 27);
            this.ButtonConnect.TabIndex = 10;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ConnectionStatusText
            // 
            this.ConnectionStatusText.AutoSize = true;
            this.ConnectionStatusText.Location = new System.Drawing.Point(84, 32);
            this.ConnectionStatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnectionStatusText.Name = "ConnectionStatusText";
            this.ConnectionStatusText.Size = new System.Drawing.Size(89, 15);
            this.ConnectionStatusText.TabIndex = 9;
            this.ConnectionStatusText.Text = "Not connected.";
            // 
            // InputSwitchIP
            // 
            this.InputSwitchIP.Location = new System.Drawing.Point(84, 6);
            this.InputSwitchIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputSwitchIP.Name = "InputSwitchIP";
            this.InputSwitchIP.Size = new System.Drawing.Size(129, 23);
            this.InputSwitchIP.TabIndex = 8;
            this.InputSwitchIP.Text = "www.www.www.www";
            this.InputSwitchIP.TextChanged += new System.EventHandler(this.InputSwitchIP_Changed);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(30, 32);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(42, 15);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "Status:";
            // 
            // LabelSwitchIP
            // 
            this.LabelSwitchIP.AutoSize = true;
            this.LabelSwitchIP.Location = new System.Drawing.Point(13, 9);
            this.LabelSwitchIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSwitchIP.Name = "LabelSwitchIP";
            this.LabelSwitchIP.Size = new System.Drawing.Size(58, 15);
            this.LabelSwitchIP.TabIndex = 6;
            this.LabelSwitchIP.Text = "Switch IP:";
            // 
            // LabelLoadedRaids
            // 
            this.LabelLoadedRaids.AutoSize = true;
            this.LabelLoadedRaids.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLoadedRaids.Location = new System.Drawing.Point(220, 9);
            this.LabelLoadedRaids.Name = "LabelLoadedRaids";
            this.LabelLoadedRaids.Size = new System.Drawing.Size(97, 15);
            this.LabelLoadedRaids.TabIndex = 12;
            this.LabelLoadedRaids.Text = "Raids: 0 | Shiny: 0";
            // 
            // TeraType
            // 
            this.TeraType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeraType.Location = new System.Drawing.Point(531, 61);
            this.TeraType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeraType.Name = "TeraType";
            this.TeraType.ReadOnly = true;
            this.TeraType.Size = new System.Drawing.Size(97, 22);
            this.TeraType.TabIndex = 49;
            // 
            // LabelTeraType
            // 
            this.LabelTeraType.AutoSize = true;
            this.LabelTeraType.Location = new System.Drawing.Point(466, 63);
            this.LabelTeraType.Name = "LabelTeraType";
            this.LabelTeraType.Size = new System.Drawing.Size(58, 15);
            this.LabelTeraType.TabIndex = 48;
            this.LabelTeraType.Text = "Tera Type:";
            // 
            // PID
            // 
            this.PID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PID.Location = new System.Drawing.Point(533, 91);
            this.PID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Size = new System.Drawing.Size(95, 22);
            this.PID.TabIndex = 47;
            // 
            // LabelPID
            // 
            this.LabelPID.AutoSize = true;
            this.LabelPID.Location = new System.Drawing.Point(496, 93);
            this.LabelPID.Name = "LabelPID";
            this.LabelPID.Size = new System.Drawing.Size(28, 15);
            this.LabelPID.TabIndex = 46;
            this.LabelPID.Text = "PID:";
            // 
            // EC
            // 
            this.EC.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EC.Location = new System.Drawing.Point(357, 89);
            this.EC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EC.Name = "EC";
            this.EC.ReadOnly = true;
            this.EC.Size = new System.Drawing.Size(95, 22);
            this.EC.TabIndex = 45;
            // 
            // LabelEC
            // 
            this.LabelEC.AutoSize = true;
            this.LabelEC.Location = new System.Drawing.Point(232, 91);
            this.LabelEC.Name = "LabelEC";
            this.LabelEC.Size = new System.Drawing.Size(118, 15);
            this.LabelEC.TabIndex = 44;
            this.LabelEC.Text = "Encryption Constant:";
            // 
            // Seed
            // 
            this.Seed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seed.Location = new System.Drawing.Point(357, 61);
            this.Seed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Seed.Name = "Seed";
            this.Seed.ReadOnly = true;
            this.Seed.Size = new System.Drawing.Size(95, 22);
            this.Seed.TabIndex = 43;
            // 
            // LabelSeed
            // 
            this.LabelSeed.AutoSize = true;
            this.LabelSeed.Location = new System.Drawing.Point(315, 63);
            this.LabelSeed.Name = "LabelSeed";
            this.LabelSeed.Size = new System.Drawing.Size(35, 15);
            this.LabelSeed.TabIndex = 42;
            this.LabelSeed.Text = "Seed:";
            // 
            // LabelIndex
            // 
            this.LabelIndex.AutoSize = true;
            this.LabelIndex.Location = new System.Drawing.Point(89, 85);
            this.LabelIndex.Name = "LabelIndex";
            this.LabelIndex.Size = new System.Drawing.Size(48, 15);
            this.LabelIndex.TabIndex = 57;
            this.LabelIndex.Text = "ww/ww";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Enabled = false;
            this.ButtonNext.Location = new System.Drawing.Point(146, 80);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(33, 23);
            this.ButtonNext.TabIndex = 56;
            this.ButtonNext.Text = ">>";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Enabled = false;
            this.ButtonPrevious.Location = new System.Drawing.Point(47, 80);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(33, 23);
            this.ButtonPrevious.TabIndex = 55;
            this.ButtonPrevious.Text = "<<";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Area.Location = new System.Drawing.Point(357, 117);
            this.Area.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Size = new System.Drawing.Size(270, 22);
            this.Area.TabIndex = 61;
            // 
            // LabelUNK_2
            // 
            this.LabelUNK_2.AutoSize = true;
            this.LabelUNK_2.Location = new System.Drawing.Point(316, 121);
            this.LabelUNK_2.Name = "LabelUNK_2";
            this.LabelUNK_2.Size = new System.Drawing.Size(34, 15);
            this.LabelUNK_2.TabIndex = 60;
            this.LabelUNK_2.Text = "Area:";
            // 
            // IVs
            // 
            this.IVs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IVs.Location = new System.Drawing.Point(357, 201);
            this.IVs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IVs.Name = "IVs";
            this.IVs.ReadOnly = true;
            this.IVs.Size = new System.Drawing.Size(270, 22);
            this.IVs.TabIndex = 69;
            // 
            // LabelIVs
            // 
            this.LabelIVs.AutoSize = true;
            this.LabelIVs.Location = new System.Drawing.Point(325, 203);
            this.LabelIVs.Name = "LabelIVs";
            this.LabelIVs.Size = new System.Drawing.Size(25, 15);
            this.LabelIVs.TabIndex = 68;
            this.LabelIVs.Text = "IVs:";
            // 
            // ButtonReadRaids
            // 
            this.ButtonReadRaids.Enabled = false;
            this.ButtonReadRaids.Location = new System.Drawing.Point(13, 109);
            this.ButtonReadRaids.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonReadRaids.Name = "ButtonReadRaids";
            this.ButtonReadRaids.Size = new System.Drawing.Size(97, 27);
            this.ButtonReadRaids.TabIndex = 80;
            this.ButtonReadRaids.Text = "Read Raids";
            this.ButtonReadRaids.UseVisualStyleBackColor = true;
            this.ButtonReadRaids.Click += new System.EventHandler(this.ButtonReadRaids_Click);
            // 
            // ButtonAdvanceDate
            // 
            this.ButtonAdvanceDate.Enabled = false;
            this.ButtonAdvanceDate.Location = new System.Drawing.Point(117, 110);
            this.ButtonAdvanceDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonAdvanceDate.Name = "ButtonAdvanceDate";
            this.ButtonAdvanceDate.Size = new System.Drawing.Size(97, 27);
            this.ButtonAdvanceDate.TabIndex = 81;
            this.ButtonAdvanceDate.Text = "Advance Date";
            this.ButtonAdvanceDate.UseVisualStyleBackColor = true;
            this.ButtonAdvanceDate.Click += new System.EventHandler(this.ButtonAdvanceDate_Click);
            // 
            // IsEvent
            // 
            this.IsEvent.AutoCheck = false;
            this.IsEvent.AutoSize = true;
            this.IsEvent.Location = new System.Drawing.Point(357, 41);
            this.IsEvent.Name = "IsEvent";
            this.IsEvent.Size = new System.Drawing.Size(15, 14);
            this.IsEvent.TabIndex = 83;
            this.IsEvent.UseVisualStyleBackColor = true;
            // 
            // LabelIsEvent
            // 
            this.LabelIsEvent.AutoSize = true;
            this.LabelIsEvent.Location = new System.Drawing.Point(307, 40);
            this.LabelIsEvent.Name = "LabelIsEvent";
            this.LabelIsEvent.Size = new System.Drawing.Size(41, 15);
            this.LabelIsEvent.TabIndex = 84;
            this.LabelIsEvent.Text = "Event?";
            // 
            // Difficulty
            // 
            this.Difficulty.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Difficulty.Location = new System.Drawing.Point(356, 173);
            this.Difficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.Size = new System.Drawing.Size(88, 22);
            this.Difficulty.TabIndex = 86;
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Location = new System.Drawing.Point(292, 176);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(58, 15);
            this.LabelDifficulty.TabIndex = 85;
            this.LabelDifficulty.Text = "Difficulty:";
            // 
            // Progress
            // 
            this.Progress.FormattingEnabled = true;
            this.Progress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Progress.Location = new System.Drawing.Point(164, 168);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(48, 23);
            this.Progress.TabIndex = 87;
            this.Progress.Text = "w";
            this.Progress.SelectedIndexChanged += new System.EventHandler(this.Progress_SelectedIndexChanged);
            // 
            // LabelStoryProgress
            // 
            this.LabelStoryProgress.AutoSize = true;
            this.LabelStoryProgress.Location = new System.Drawing.Point(13, 171);
            this.LabelStoryProgress.Name = "LabelStoryProgress";
            this.LabelStoryProgress.Size = new System.Drawing.Size(115, 15);
            this.LabelStoryProgress.TabIndex = 88;
            this.LabelStoryProgress.Text = "Story Progress Level:";
            // 
            // ButtonViewRAM
            // 
            this.ButtonViewRAM.Enabled = false;
            this.ButtonViewRAM.Location = new System.Drawing.Point(545, 6);
            this.ButtonViewRAM.Name = "ButtonViewRAM";
            this.ButtonViewRAM.Size = new System.Drawing.Size(83, 23);
            this.ButtonViewRAM.TabIndex = 89;
            this.ButtonViewRAM.Text = "Dump Block";
            this.ButtonViewRAM.UseVisualStyleBackColor = true;
            this.ButtonViewRAM.Click += new System.EventHandler(this.ViewRAM_Click);
            // 
            // Species
            // 
            this.Species.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Species.Location = new System.Drawing.Point(356, 145);
            this.Species.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            this.Species.Size = new System.Drawing.Size(270, 22);
            this.Species.TabIndex = 93;
            // 
            // LabelSpecies
            // 
            this.LabelSpecies.AutoSize = true;
            this.LabelSpecies.Location = new System.Drawing.Point(300, 147);
            this.LabelSpecies.Name = "LabelSpecies";
            this.LabelSpecies.Size = new System.Drawing.Size(49, 15);
            this.LabelSpecies.TabIndex = 92;
            this.LabelSpecies.Text = "Species:";
            // 
            // LabelMoves
            // 
            this.LabelMoves.AutoSize = true;
            this.LabelMoves.Location = new System.Drawing.Point(305, 245);
            this.LabelMoves.Name = "LabelMoves";
            this.LabelMoves.Size = new System.Drawing.Size(45, 15);
            this.LabelMoves.TabIndex = 94;
            this.LabelMoves.Text = "Moves:";
            // 
            // Move1
            // 
            this.Move1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Move1.Location = new System.Drawing.Point(357, 231);
            this.Move1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Move1.Name = "Move1";
            this.Move1.ReadOnly = true;
            this.Move1.Size = new System.Drawing.Size(133, 22);
            this.Move1.TabIndex = 95;
            // 
            // Move2
            // 
            this.Move2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Move2.Location = new System.Drawing.Point(494, 231);
            this.Move2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Move2.Name = "Move2";
            this.Move2.ReadOnly = true;
            this.Move2.Size = new System.Drawing.Size(133, 22);
            this.Move2.TabIndex = 96;
            // 
            // Move4
            // 
            this.Move4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Move4.Location = new System.Drawing.Point(494, 256);
            this.Move4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Move4.Name = "Move4";
            this.Move4.ReadOnly = true;
            this.Move4.Size = new System.Drawing.Size(133, 22);
            this.Move4.TabIndex = 98;
            // 
            // Move3
            // 
            this.Move3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Move3.Location = new System.Drawing.Point(357, 256);
            this.Move3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Move3.Name = "Move3";
            this.Move3.ReadOnly = true;
            this.Move3.Size = new System.Drawing.Size(133, 22);
            this.Move3.TabIndex = 97;
            // 
            // LabelGame
            // 
            this.LabelGame.AutoSize = true;
            this.LabelGame.Location = new System.Drawing.Point(13, 144);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(41, 15);
            this.LabelGame.TabIndex = 100;
            this.LabelGame.Text = "Game:";
            // 
            // Game
            // 
            this.Game.FormattingEnabled = true;
            this.Game.Items.AddRange(new object[] {
            "Scarlet",
            "Violet"});
            this.Game.Location = new System.Drawing.Point(116, 141);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(96, 23);
            this.Game.TabIndex = 99;
            this.Game.Text = "w";
            this.Game.SelectedIndexChanged += new System.EventHandler(this.Game_SelectedIndexChanged);
            // 
            // LabelEventProgress
            // 
            this.LabelEventProgress.AutoSize = true;
            this.LabelEventProgress.Location = new System.Drawing.Point(12, 199);
            this.LabelEventProgress.Name = "LabelEventProgress";
            this.LabelEventProgress.Size = new System.Drawing.Size(117, 15);
            this.LabelEventProgress.TabIndex = 102;
            this.LabelEventProgress.Text = "Event Progress Level:";
            // 
            // EventProgress
            // 
            this.EventProgress.FormattingEnabled = true;
            this.EventProgress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.EventProgress.Location = new System.Drawing.Point(164, 196);
            this.EventProgress.Name = "EventProgress";
            this.EventProgress.Size = new System.Drawing.Size(48, 23);
            this.EventProgress.TabIndex = 101;
            this.EventProgress.Text = "w";
            this.EventProgress.SelectedIndexChanged += new System.EventHandler(this.EventProgress_SelectedIndexChanged);
            // 
            // Nature
            // 
            this.Nature.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nature.Location = new System.Drawing.Point(530, 284);
            this.Nature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Nature.Name = "Nature";
            this.Nature.ReadOnly = true;
            this.Nature.Size = new System.Drawing.Size(97, 22);
            this.Nature.TabIndex = 106;
            // 
            // LabelNature
            // 
            this.LabelNature.AutoSize = true;
            this.LabelNature.Location = new System.Drawing.Point(465, 286);
            this.LabelNature.Name = "LabelNature";
            this.LabelNature.Size = new System.Drawing.Size(46, 15);
            this.LabelNature.TabIndex = 105;
            this.LabelNature.Text = "Nature:";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.Location = new System.Drawing.Point(356, 284);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Size = new System.Drawing.Size(95, 22);
            this.Gender.TabIndex = 104;
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Location = new System.Drawing.Point(302, 286);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(48, 15);
            this.LabelGender.TabIndex = 103;
            this.LabelGender.Text = "Gender:";
            // 
            // StopFilter
            // 
            this.StopFilter.Location = new System.Drawing.Point(13, 250);
            this.StopFilter.Name = "StopFilter";
            this.StopFilter.Size = new System.Drawing.Size(199, 23);
            this.StopFilter.TabIndex = 107;
            this.StopFilter.Text = "Set Stop Filters";
            this.StopFilter.UseVisualStyleBackColor = true;
            this.StopFilter.Click += new System.EventHandler(this.StopFilter_Click);
            // 
            // Sprite
            // 
            this.Sprite.Location = new System.Drawing.Point(471, -1);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(68, 56);
            this.Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Sprite.TabIndex = 108;
            this.Sprite.TabStop = false;
            // 
            // Ability
            // 
            this.Ability.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ability.Location = new System.Drawing.Point(494, 173);
            this.Ability.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ability.Name = "Ability";
            this.Ability.ReadOnly = true;
            this.Ability.Size = new System.Drawing.Size(132, 22);
            this.Ability.TabIndex = 110;
            // 
            // LabelAbility
            // 
            this.LabelAbility.AutoSize = true;
            this.LabelAbility.Location = new System.Drawing.Point(443, 176);
            this.LabelAbility.Name = "LabelAbility";
            this.LabelAbility.Size = new System.Drawing.Size(44, 15);
            this.LabelAbility.TabIndex = 109;
            this.LabelAbility.Text = "Ability:";
            // 
            // GemIcon
            // 
            this.GemIcon.Location = new System.Drawing.Point(405, -1);
            this.GemIcon.Name = "GemIcon";
            this.GemIcon.Size = new System.Drawing.Size(60, 60);
            this.GemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GemIcon.TabIndex = 111;
            this.GemIcon.TabStop = false;
            // 
            // ButtonDumpRaid
            // 
            this.ButtonDumpRaid.Enabled = false;
            this.ButtonDumpRaid.Location = new System.Drawing.Point(545, 32);
            this.ButtonDumpRaid.Name = "ButtonDumpRaid";
            this.ButtonDumpRaid.Size = new System.Drawing.Size(83, 23);
            this.ButtonDumpRaid.TabIndex = 112;
            this.ButtonDumpRaid.Text = "Dump Raid";
            this.ButtonDumpRaid.UseVisualStyleBackColor = true;
            this.ButtonDumpRaid.Click += new System.EventHandler(this.ButtonDumpRaid_Click);
            // 
            // ConfigSettings
            // 
            this.ConfigSettings.Location = new System.Drawing.Point(13, 279);
            this.ConfigSettings.Name = "ConfigSettings";
            this.ConfigSettings.Size = new System.Drawing.Size(199, 23);
            this.ConfigSettings.TabIndex = 115;
            this.ConfigSettings.Text = "Open Settings";
            this.ConfigSettings.UseVisualStyleBackColor = true;
            this.ConfigSettings.Click += new System.EventHandler(this.ConfigSettings_Click);
            // 
            // Height
            // 
            this.HeightSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightSize.Location = new System.Drawing.Point(357, 312);
            this.HeightSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HeightSize.Name = "Height";
            this.HeightSize.ReadOnly = true;
            this.HeightSize.Size = new System.Drawing.Size(46, 22);
            this.HeightSize.TabIndex = 117;
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Location = new System.Drawing.Point(303, 314);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(46, 15);
            this.LabelHeight.TabIndex = 116;
            this.LabelHeight.Text = "Height:";
            // 
            // Weight
            // 
            this.WeightSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightSize.Location = new System.Drawing.Point(465, 311);
            this.WeightSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WeightSize.Name = "Weight";
            this.WeightSize.ReadOnly = true;
            this.WeightSize.Size = new System.Drawing.Size(46, 22);
            this.WeightSize.TabIndex = 119;
            // 
            // LabelWeight
            // 
            this.LabelWeight.AutoSize = true;
            this.LabelWeight.Location = new System.Drawing.Point(410, 314);
            this.LabelWeight.Name = "LabelWeight";
            this.LabelWeight.Size = new System.Drawing.Size(48, 15);
            this.LabelWeight.TabIndex = 118;
            this.LabelWeight.Text = "Weight:";
            // 
            // ScaleSize
            // 
            this.ScaleSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScaleSize.Location = new System.Drawing.Point(562, 311);
            this.ScaleSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ScaleSize.Name = "ScaleSize";
            this.ScaleSize.ReadOnly = true;
            this.ScaleSize.Size = new System.Drawing.Size(46, 22);
            this.ScaleSize.TabIndex = 121;
            // 
            // LabelScale
            // 
            this.LabelScale.AutoSize = true;
            this.LabelScale.Location = new System.Drawing.Point(518, 314);
            this.LabelScale.Name = "LabelScale";
            this.LabelScale.Size = new System.Drawing.Size(37, 15);
            this.LabelScale.TabIndex = 120;
            this.LabelScale.Text = "Scale:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 344);
            this.Controls.Add(this.ScaleSize);
            this.Controls.Add(this.LabelScale);
            this.Controls.Add(this.WeightSize);
            this.Controls.Add(this.LabelWeight);
            this.Controls.Add(this.HeightSize);
            this.Controls.Add(this.LabelHeight);
            this.Controls.Add(this.ConfigSettings);
            this.Controls.Add(this.ButtonDumpRaid);
            this.Controls.Add(this.GemIcon);
            this.Controls.Add(this.Ability);
            this.Controls.Add(this.LabelAbility);
            this.Controls.Add(this.Sprite);
            this.Controls.Add(this.StopFilter);
            this.Controls.Add(this.Nature);
            this.Controls.Add(this.LabelNature);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.LabelEventProgress);
            this.Controls.Add(this.EventProgress);
            this.Controls.Add(this.LabelGame);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Move4);
            this.Controls.Add(this.Move3);
            this.Controls.Add(this.Move2);
            this.Controls.Add(this.Move1);
            this.Controls.Add(this.LabelMoves);
            this.Controls.Add(this.Species);
            this.Controls.Add(this.LabelSpecies);
            this.Controls.Add(this.ButtonViewRAM);
            this.Controls.Add(this.LabelStoryProgress);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.LabelDifficulty);
            this.Controls.Add(this.LabelIsEvent);
            this.Controls.Add(this.IsEvent);
            this.Controls.Add(this.ButtonAdvanceDate);
            this.Controls.Add(this.ButtonReadRaids);
            this.Controls.Add(this.IVs);
            this.Controls.Add(this.LabelIVs);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.LabelUNK_2);
            this.Controls.Add(this.LabelIndex);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.TeraType);
            this.Controls.Add(this.LabelTeraType);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.LabelPID);
            this.Controls.Add(this.EC);
            this.Controls.Add(this.LabelEC);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.LabelSeed);
            this.Controls.Add(this.LabelLoadedRaids);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ConnectionStatusText);
            this.Controls.Add(this.InputSwitchIP);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelSwitchIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GemIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonDisconnect;
        private Button ButtonConnect;
        private Label ConnectionStatusText;
        private TextBox InputSwitchIP;
        private Label LabelStatus;
        private Label LabelSwitchIP;
        private Label LabelLoadedRaids;
        private TextBox TeraType;
        private Label LabelTeraType;
        private TextBox PID;
        private Label LabelPID;
        private TextBox EC;
        private Label LabelEC;
        private TextBox Seed;
        private Label LabelSeed;
        private Label LabelIndex;
        private Button ButtonNext;
        private Button ButtonPrevious;
        private TextBox Area;
        private Label LabelUNK_2;
        private TextBox IVs;
        private Label LabelIVs;
        private Button ButtonReadRaids;
        private Button ButtonAdvanceDate;
        private CheckBox IsEvent;
        private Label LabelIsEvent;
        private TextBox Difficulty;
        private Label LabelDifficulty;
        private ComboBox Progress;
        private Label LabelStoryProgress;
        private Button ButtonViewRAM;
        private TextBox Species;
        private Label LabelSpecies;
        private Label LabelMoves;
        private TextBox Move1;
        private TextBox Move2;
        private TextBox Move4;
        private TextBox Move3;
        private Label LabelGame;
        private ComboBox Game;
        private Label LabelEventProgress;
        private ComboBox EventProgress;
        private TextBox Nature;
        private Label LabelNature;
        private TextBox Gender;
        private Label LabelGender;
        private Button StopFilter;
        private PictureBox Sprite;
        private TextBox Ability;
        private Label LabelAbility;
        private PictureBox GemIcon;
        private Button ButtonDumpRaid;
        private Button ConfigSettings;
        private TextBox HeightSize;
        private Label LabelHeight;
        private TextBox WeightSize;
        private Label LabelWeight;
        private TextBox ScaleSize;
        private Label LabelScale;
    }
}