namespace Socom1StreamOverlay
{
    partial class frm_Main
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
            this.lbl_T_Rounds = new System.Windows.Forms.Label();
            this.lbl_GameTime = new System.Windows.Forms.Label();
            this.lbl_T_Alive = new System.Windows.Forms.Label();
            this.lbl_S_Alive = new System.Windows.Forms.Label();
            this.pct_Teams = new System.Windows.Forms.PictureBox();
            this.pnl_Background = new System.Windows.Forms.Panel();
            this.con_ScoreboardMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.letterBoxSpecCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_LetterBoxSpecOn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_PCSX2Detected = new System.Windows.Forms.Panel();
            this.lbl_S_Rounds = new System.Windows.Forms.Label();
            this.lbl_Terr_p8 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p7 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p3 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p2 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p1 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p6 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p5 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Terr_p4 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p8 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p7 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p6 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p5 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p4 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p3 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p2 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.lbl_Seal_p1 = new Socom1StreamOverlay.Controls.PlayerDataLabel();
            this.tmr_PCSX2Check = new System.Windows.Forms.Timer(this.components);
            this.tmr_GetGameData = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Teams)).BeginInit();
            this.pnl_Background.SuspendLayout();
            this.con_ScoreboardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_T_Rounds
            // 
            this.lbl_T_Rounds.BackColor = System.Drawing.Color.Transparent;
            this.lbl_T_Rounds.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_T_Rounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lbl_T_Rounds.Location = new System.Drawing.Point(437, 39);
            this.lbl_T_Rounds.Name = "lbl_T_Rounds";
            this.lbl_T_Rounds.Size = new System.Drawing.Size(27, 22);
            this.lbl_T_Rounds.TabIndex = 20;
            this.lbl_T_Rounds.Text = "0";
            this.lbl_T_Rounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_GameTime
            // 
            this.lbl_GameTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GameTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lbl_GameTime.Location = new System.Drawing.Point(383, 4);
            this.lbl_GameTime.Name = "lbl_GameTime";
            this.lbl_GameTime.Size = new System.Drawing.Size(81, 38);
            this.lbl_GameTime.TabIndex = 19;
            this.lbl_GameTime.Text = "00:00";
            this.lbl_GameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_T_Alive
            // 
            this.lbl_T_Alive.BackColor = System.Drawing.Color.Transparent;
            this.lbl_T_Alive.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_T_Alive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lbl_T_Alive.Location = new System.Drawing.Point(486, 23);
            this.lbl_T_Alive.Name = "lbl_T_Alive";
            this.lbl_T_Alive.Size = new System.Drawing.Size(27, 38);
            this.lbl_T_Alive.TabIndex = 18;
            this.lbl_T_Alive.Text = "0";
            this.lbl_T_Alive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_S_Alive
            // 
            this.lbl_S_Alive.BackColor = System.Drawing.Color.Transparent;
            this.lbl_S_Alive.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_Alive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lbl_S_Alive.Location = new System.Drawing.Point(333, 23);
            this.lbl_S_Alive.Name = "lbl_S_Alive";
            this.lbl_S_Alive.Size = new System.Drawing.Size(27, 38);
            this.lbl_S_Alive.TabIndex = 17;
            this.lbl_S_Alive.Text = "0";
            this.lbl_S_Alive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pct_Teams
            // 
            this.pct_Teams.BackColor = System.Drawing.Color.Transparent;
            this.pct_Teams.Image = global::Socom1StreamOverlay.Properties.Resources.s2GUI_50p;
            this.pct_Teams.Location = new System.Drawing.Point(314, 5);
            this.pct_Teams.Name = "pct_Teams";
            this.pct_Teams.Size = new System.Drawing.Size(215, 62);
            this.pct_Teams.TabIndex = 0;
            this.pct_Teams.TabStop = false;
            // 
            // pnl_Background
            // 
            this.pnl_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_Background.ContextMenuStrip = this.con_ScoreboardMenu;
            this.pnl_Background.Controls.Add(this.pnl_PCSX2Detected);
            this.pnl_Background.Controls.Add(this.lbl_S_Rounds);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p8);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p7);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p3);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p2);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p1);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p6);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p5);
            this.pnl_Background.Controls.Add(this.lbl_Terr_p4);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p8);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p7);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p6);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p5);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p4);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p3);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p2);
            this.pnl_Background.Controls.Add(this.lbl_Seal_p1);
            this.pnl_Background.Controls.Add(this.lbl_T_Rounds);
            this.pnl_Background.Controls.Add(this.lbl_GameTime);
            this.pnl_Background.Controls.Add(this.lbl_T_Alive);
            this.pnl_Background.Controls.Add(this.lbl_S_Alive);
            this.pnl_Background.Controls.Add(this.pct_Teams);
            this.pnl_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Background.Location = new System.Drawing.Point(0, 0);
            this.pnl_Background.Name = "pnl_Background";
            this.pnl_Background.Size = new System.Drawing.Size(844, 83);
            this.pnl_Background.TabIndex = 18;
            this.pnl_Background.MouseEnter += new System.EventHandler(this.pnl_Background_MouseEnter);
            this.pnl_Background.MouseLeave += new System.EventHandler(this.pnl_Background_MouseLeave);
            this.pnl_Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Background_MouseMove);
            // 
            // con_ScoreboardMenu
            // 
            this.con_ScoreboardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letterBoxSpecCamToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.con_ScoreboardMenu.Name = "con_ScoreboardMenu";
            this.con_ScoreboardMenu.Size = new System.Drawing.Size(184, 70);
            // 
            // letterBoxSpecCamToolStripMenuItem
            // 
            this.letterBoxSpecCamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_LetterBoxSpecOn});
            this.letterBoxSpecCamToolStripMenuItem.Name = "letterBoxSpecCamToolStripMenuItem";
            this.letterBoxSpecCamToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.letterBoxSpecCamToolStripMenuItem.Text = "Letter Box Spec Cam";
            // 
            // menu_LetterBoxSpecOn
            // 
            this.menu_LetterBoxSpecOn.Checked = true;
            this.menu_LetterBoxSpecOn.CheckOnClick = true;
            this.menu_LetterBoxSpecOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_LetterBoxSpecOn.Name = "menu_LetterBoxSpecOn";
            this.menu_LetterBoxSpecOn.Size = new System.Drawing.Size(180, 22);
            this.menu_LetterBoxSpecOn.Text = "On";
            this.menu_LetterBoxSpecOn.CheckStateChanged += new System.EventHandler(this.menu_LetterBoxSpecOn_CheckStateChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnl_PCSX2Detected
            // 
            this.pnl_PCSX2Detected.Location = new System.Drawing.Point(817, 63);
            this.pnl_PCSX2Detected.Name = "pnl_PCSX2Detected";
            this.pnl_PCSX2Detected.Size = new System.Drawing.Size(15, 13);
            this.pnl_PCSX2Detected.TabIndex = 47;
            // 
            // lbl_S_Rounds
            // 
            this.lbl_S_Rounds.BackColor = System.Drawing.Color.Transparent;
            this.lbl_S_Rounds.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_S_Rounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lbl_S_Rounds.Location = new System.Drawing.Point(389, 39);
            this.lbl_S_Rounds.Name = "lbl_S_Rounds";
            this.lbl_S_Rounds.Size = new System.Drawing.Size(27, 22);
            this.lbl_S_Rounds.TabIndex = 45;
            this.lbl_S_Rounds.Text = "0";
            this.lbl_S_Rounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Terr_p8
            // 
            this.lbl_Terr_p8.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p8.Location = new System.Drawing.Point(737, 32);
            this.lbl_Terr_p8.Name = "lbl_Terr_p8";
            this.lbl_Terr_p8.PDM = null;
            this.lbl_Terr_p8.playerName = "";
            this.lbl_Terr_p8.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p8.TabIndex = 44;
            // 
            // lbl_Terr_p7
            // 
            this.lbl_Terr_p7.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p7.Location = new System.Drawing.Point(737, 7);
            this.lbl_Terr_p7.Name = "lbl_Terr_p7";
            this.lbl_Terr_p7.PDM = null;
            this.lbl_Terr_p7.playerName = "";
            this.lbl_Terr_p7.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p7.TabIndex = 43;
            // 
            // lbl_Terr_p3
            // 
            this.lbl_Terr_p3.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p3.Location = new System.Drawing.Point(531, 57);
            this.lbl_Terr_p3.Name = "lbl_Terr_p3";
            this.lbl_Terr_p3.PDM = null;
            this.lbl_Terr_p3.playerName = "";
            this.lbl_Terr_p3.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p3.TabIndex = 42;
            // 
            // lbl_Terr_p2
            // 
            this.lbl_Terr_p2.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p2.Location = new System.Drawing.Point(531, 32);
            this.lbl_Terr_p2.Name = "lbl_Terr_p2";
            this.lbl_Terr_p2.PDM = null;
            this.lbl_Terr_p2.playerName = "";
            this.lbl_Terr_p2.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p2.TabIndex = 41;
            // 
            // lbl_Terr_p1
            // 
            this.lbl_Terr_p1.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p1.Location = new System.Drawing.Point(531, 7);
            this.lbl_Terr_p1.Name = "lbl_Terr_p1";
            this.lbl_Terr_p1.PDM = null;
            this.lbl_Terr_p1.playerName = "";
            this.lbl_Terr_p1.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p1.TabIndex = 40;
            // 
            // lbl_Terr_p6
            // 
            this.lbl_Terr_p6.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p6.Location = new System.Drawing.Point(634, 57);
            this.lbl_Terr_p6.Name = "lbl_Terr_p6";
            this.lbl_Terr_p6.PDM = null;
            this.lbl_Terr_p6.playerName = "";
            this.lbl_Terr_p6.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p6.TabIndex = 39;
            // 
            // lbl_Terr_p5
            // 
            this.lbl_Terr_p5.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p5.Location = new System.Drawing.Point(634, 32);
            this.lbl_Terr_p5.Name = "lbl_Terr_p5";
            this.lbl_Terr_p5.PDM = null;
            this.lbl_Terr_p5.playerName = "";
            this.lbl_Terr_p5.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p5.TabIndex = 38;
            // 
            // lbl_Terr_p4
            // 
            this.lbl_Terr_p4.BackColor = System.Drawing.Color.White;
            this.lbl_Terr_p4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Terr_p4.Location = new System.Drawing.Point(634, 7);
            this.lbl_Terr_p4.Name = "lbl_Terr_p4";
            this.lbl_Terr_p4.PDM = null;
            this.lbl_Terr_p4.playerName = "";
            this.lbl_Terr_p4.Size = new System.Drawing.Size(100, 19);
            this.lbl_Terr_p4.TabIndex = 37;
            // 
            // lbl_Seal_p8
            // 
            this.lbl_Seal_p8.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p8.Location = new System.Drawing.Point(6, 32);
            this.lbl_Seal_p8.Name = "lbl_Seal_p8";
            this.lbl_Seal_p8.PDM = null;
            this.lbl_Seal_p8.playerName = "";
            this.lbl_Seal_p8.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p8.TabIndex = 36;
            // 
            // lbl_Seal_p7
            // 
            this.lbl_Seal_p7.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p7.Location = new System.Drawing.Point(6, 7);
            this.lbl_Seal_p7.Name = "lbl_Seal_p7";
            this.lbl_Seal_p7.PDM = null;
            this.lbl_Seal_p7.playerName = "";
            this.lbl_Seal_p7.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p7.TabIndex = 34;
            // 
            // lbl_Seal_p6
            // 
            this.lbl_Seal_p6.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p6.Location = new System.Drawing.Point(109, 57);
            this.lbl_Seal_p6.Name = "lbl_Seal_p6";
            this.lbl_Seal_p6.PDM = null;
            this.lbl_Seal_p6.playerName = "";
            this.lbl_Seal_p6.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p6.TabIndex = 32;
            // 
            // lbl_Seal_p5
            // 
            this.lbl_Seal_p5.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p5.Location = new System.Drawing.Point(109, 32);
            this.lbl_Seal_p5.Name = "lbl_Seal_p5";
            this.lbl_Seal_p5.PDM = null;
            this.lbl_Seal_p5.playerName = "";
            this.lbl_Seal_p5.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p5.TabIndex = 30;
            // 
            // lbl_Seal_p4
            // 
            this.lbl_Seal_p4.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p4.Location = new System.Drawing.Point(109, 7);
            this.lbl_Seal_p4.Name = "lbl_Seal_p4";
            this.lbl_Seal_p4.PDM = null;
            this.lbl_Seal_p4.playerName = "";
            this.lbl_Seal_p4.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p4.TabIndex = 28;
            // 
            // lbl_Seal_p3
            // 
            this.lbl_Seal_p3.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p3.Location = new System.Drawing.Point(212, 57);
            this.lbl_Seal_p3.Name = "lbl_Seal_p3";
            this.lbl_Seal_p3.PDM = null;
            this.lbl_Seal_p3.playerName = "";
            this.lbl_Seal_p3.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p3.TabIndex = 26;
            // 
            // lbl_Seal_p2
            // 
            this.lbl_Seal_p2.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p2.Location = new System.Drawing.Point(212, 32);
            this.lbl_Seal_p2.Name = "lbl_Seal_p2";
            this.lbl_Seal_p2.PDM = null;
            this.lbl_Seal_p2.playerName = "";
            this.lbl_Seal_p2.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p2.TabIndex = 24;
            // 
            // lbl_Seal_p1
            // 
            this.lbl_Seal_p1.BackColor = System.Drawing.Color.White;
            this.lbl_Seal_p1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Seal_p1.Location = new System.Drawing.Point(212, 7);
            this.lbl_Seal_p1.Name = "lbl_Seal_p1";
            this.lbl_Seal_p1.PDM = null;
            this.lbl_Seal_p1.playerName = "";
            this.lbl_Seal_p1.Size = new System.Drawing.Size(100, 19);
            this.lbl_Seal_p1.TabIndex = 22;
            // 
            // tmr_PCSX2Check
            // 
            this.tmr_PCSX2Check.Enabled = true;
            this.tmr_PCSX2Check.Tick += new System.EventHandler(this.tmr_PCSX2Check_Tick);
            // 
            // tmr_GetGameData
            // 
            this.tmr_GetGameData.Enabled = true;
            this.tmr_GetGameData.Tick += new System.EventHandler(this.tmr_GetGameData_Tick);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 83);
            this.Controls.Add(this.pnl_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Teams)).EndInit();
            this.pnl_Background.ResumeLayout(false);
            this.con_ScoreboardMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
 
        private System.Windows.Forms.Label lbl_T_Rounds;
        private System.Windows.Forms.Label lbl_GameTime;
        private System.Windows.Forms.Label lbl_T_Alive;
        private System.Windows.Forms.Label lbl_S_Alive;
        private System.Windows.Forms.PictureBox pct_Teams;
        private System.Windows.Forms.Panel pnl_Background;
        private Controls.PlayerDataLabel lbl_Seal_p1;
        private Controls.PlayerDataLabel lbl_Seal_p8;
        private Controls.PlayerDataLabel lbl_Seal_p7;
        private Controls.PlayerDataLabel lbl_Seal_p6;
        private Controls.PlayerDataLabel lbl_Seal_p5;
        private Controls.PlayerDataLabel lbl_Seal_p4;
        private Controls.PlayerDataLabel lbl_Seal_p3;
        private Controls.PlayerDataLabel lbl_Seal_p2;
        private Controls.PlayerDataLabel lbl_Terr_p8;
        private Controls.PlayerDataLabel lbl_Terr_p7;
        private Controls.PlayerDataLabel lbl_Terr_p3;
        private Controls.PlayerDataLabel lbl_Terr_p2;
        private Controls.PlayerDataLabel lbl_Terr_p1;
        private Controls.PlayerDataLabel lbl_Terr_p6;
        private Controls.PlayerDataLabel lbl_Terr_p5;
        private Controls.PlayerDataLabel lbl_Terr_p4;
        private System.Windows.Forms.Label lbl_S_Rounds;
        private System.Windows.Forms.Timer tmr_PCSX2Check;
        private System.Windows.Forms.Panel pnl_PCSX2Detected;
        private System.Windows.Forms.Timer tmr_GetGameData;
        private System.Windows.Forms.ContextMenuStrip con_ScoreboardMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterBoxSpecCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_LetterBoxSpecOn;
    }
}

