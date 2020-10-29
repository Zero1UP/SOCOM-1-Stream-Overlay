using Binarysharp.MemoryManagement;
using Socom1StreamOverlay.Controls;
using Socom1StreamOverlay.Helpers;
using Socom1StreamOverlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Socom1StreamOverlay
{
    public partial class frm_Main : Form
    {
        MemorySharp m = null;
        private const string PCSX2PROCESSNAME = "pcsx2dis";
        bool pcsx2Running;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public frm_Main()
        {
            InitializeComponent();

            //Don't really want to rotate the background image in paint for just this.
            Image backGroundImage = pct_Teams.Image;
            backGroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pct_Teams.Image = backGroundImage;
          

            this.TransparencyKey = (BackColor); // make GUI form transparent, also removes the border

            // initialize labels to be transparent on picturebox
            lbl_S_Alive.Parent = pct_Teams;
            lbl_S_Alive.Location = new Point(20, 20);//point
            lbl_S_Alive.BackColor = Color.Transparent;

            lbl_T_Alive.Parent = pct_Teams;
            lbl_T_Alive.Location = new Point(172, 20);//point
            lbl_T_Alive.BackColor = Color.Transparent;

            lbl_GameTime.Parent = pct_Teams;
            lbl_GameTime.Location = new Point(68, 0);//point
            lbl_GameTime.BackColor = Color.Transparent;

            lbl_T_Rounds.Parent = pct_Teams;
            lbl_T_Rounds.Location = new Point(120, 37);//point
            lbl_T_Rounds.BackColor = Color.Transparent;
            
            lbl_S_Rounds.Parent = pct_Teams;
            lbl_S_Rounds.Location = new Point(74, 37);//point
            lbl_S_Rounds.BackColor = Color.Transparent;

        }

        private void pnl_Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnl_Background_MouseLeave(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pnl_Background_MouseEnter(object sender, EventArgs e)
        {
            pnl_Background.BackColor = Color.FromArgb(25, 25, 25);

        }

        public void resetPlayers()
        {
            foreach (var label in pnl_Background.Controls.OfType<PlayerDataLabel>())
            {
                label.playerName = "";
                label.playerNameColor = Color.FromArgb(175, 175, 175);
                label.BackColor = Color.Transparent;

                label.healthSet = false;
                label.healthBarColor = Color.FromArgb(20, 20, 20);
                label.playerHealth = 0;
            }
        }

        public void setLabel(PlayerDataLabel label, PlayerDataModel player)
        {
            label.playerName = player._PlayerName;
            label.healthBarColor = Color.FromArgb(25, 140, 25);
            label.playerHealth = (int)player._PlayerHealth;
            label.PDM = player;

            if (player._LivingStatus == "DEAD")
            {

                label.playerNameColor = Color.FromArgb(175, 175, 175);

            }
            else
            {
                label.playerNameColor = Color.FromArgb(255, 255, 255);

            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_PCSX2Check_Tick(object sender, EventArgs e)
        {
            Process[] pcsx2 = Process.GetProcessesByName(PCSX2PROCESSNAME);

            if (pcsx2.Length > 0)
            {
                pnl_PCSX2Detected.BackColor = Color.FromArgb(23, 42, 44);
                pcsx2Running = true;
                return;
            }
            pnl_PCSX2Detected.BackColor = Color.FromArgb(55, 27, 27);
            pcsx2Running = false;
        }

        private void tmr_GetGameData_Tick(object sender, EventArgs e)
        {
            List<PlayerDataModel> playerData = new List<PlayerDataModel>();

            if (pcsx2Running)
            {
                m = new MemorySharp(Process.GetProcessesByName(PCSX2PROCESSNAME).First());


                if ((m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4, false) != null) && (!m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4,false).SequenceEqual(new byte[] { 0, 0, 0, 0 })))
                {

                  
                    if (m.Read<byte>(GameHelper.GAME_ENDED_ADDRESS,false) == 0)
                    {
                        IntPtr playerDataLocationAddress = new IntPtr(Convert.ToInt32(ByteConverstionHelper.byteArrayHexToAddressString(m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4, false)), 16));
                     
                        string playerTeam = GameHelper.GetTeamName(ByteConverstionHelper.byteArrayHexToHexString(m.Read<byte>(playerDataLocationAddress + GameHelper.PLAYER_TEAMID_OFFSET, 4,false)));

                        //Get Room specific data
                        int sealsRoundsWon = m.Read<byte>(GameHelper.SEAL_WIN_COUNTER_ADDRESS,false);
                        int terrRoundsWon = m.Read<byte>(GameHelper.TERR_WIN_COUNTER_ADDRESS, false);
                        int sealsAlive = m.Read<byte>(GameHelper.SEALS_ALIVE_COUNTER_ADDRESS, false);
                        int terrAlive = m.Read<byte>(GameHelper.TERR_ALIVE_COUNTER_ADDRESS, false);

                        string roundTime = ByteConverstionHelper.convertBytesToString(m.Read<byte>(GameHelper.ROUND_TIMER, 5, false));

                       
                        playerData = processPlayers();

                        resetPlayers();

                        foreach (var item in playerData)
                        {

                            if (item._Team == "SEALS")
                            {

                                var playerDataLabel = pnl_Background.Controls
                               .OfType<PlayerDataLabel>()
                               .Where(pdl => pdl.Name.Contains("lbl_Seal_") && pdl.Text == "")
                               .OrderBy(label => label.Name); ;

                                setLabel(GetLabels("lbl_Seal_").First(), item);

                            }
                            else if (item._Team == "TERRORISTS")
                            {
                                var playerDataLabel = pnl_Background.Controls
                                   .OfType<PlayerDataLabel>()
                                   .Where(pdl => pdl.Name.Contains("lbl_Terr_") && pdl.Text == "")
                                   .OrderBy(label => label.Name);
                                setLabel(GetLabels("lbl_Terr_").First(), item);


                            }


                        }

                        lbl_S_Alive.Text = sealsAlive.ToString();
                        lbl_S_Rounds.Text = sealsRoundsWon.ToString();
                        lbl_T_Alive.Text = terrAlive.ToString();
                        lbl_T_Rounds.Text = terrRoundsWon.ToString();
                        lbl_GameTime.Text = roundTime.ToString();


                    }
                }
                else
                {
                    resetPlayers();
                    lbl_S_Rounds.Text = "0";
                    lbl_T_Rounds.Text = "0";
                    lbl_T_Alive.Text = "0";
                    lbl_S_Alive.Text = "0";
                    lbl_GameTime.Text = "00:00";
                }
            }
        }

        private List<PlayerDataLabel> GetLabels(string labelNameContents)
        {
            return pnl_Background.Controls
                                    .OfType<PlayerDataLabel>()
                                    .Where(label => label.Name.Contains(labelNameContents) && label.playerName == "")
                                    .OrderBy(label => label.Name).ToList(); ;
        }
        private List<PlayerDataModel> processPlayers()
        {
            List<PlayerDataModel> playerData = new List<PlayerDataModel>();
            //Make sure we are in a game.
            if ((m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4, false) != null) && (!m.Read<byte>(GameHelper.PLAYER_POINTER_ADDRESS, 4, false).SequenceEqual(new byte[] { 0, 0, 0, 0 })))
            {
                IntPtr objectPtr = new IntPtr(Convert.ToInt32(ByteConverstionHelper.byteArrayHexToAddressString(m.Read<byte>(GameHelper.PLAYER_INDEX_POINTER_ADDRESS, 4, false)), 16));

                do
                {
                    IntPtr playerPointerAddress = new IntPtr(Convert.ToInt32(ByteConverstionHelper.byteArrayHexToAddressString(m.Read<byte>(objectPtr +  GameHelper.PLAYER_INDEX_PLAYER_POINTER_OFFSET,4, false)),16));
                    IntPtr playerNamePointerAddress = new IntPtr(Convert.ToInt32(ByteConverstionHelper.byteArrayHexToAddressString(m.Read<byte>(playerPointerAddress + GameHelper.PLAYER_NAME_OFFSET,4, false)),16));
                    
                    string teamID = ByteConverstionHelper.byteArrayHexToHexString(m.Read<byte>(playerPointerAddress + GameHelper.PLAYER_TEAMID_OFFSET,4, false));
                    string teamName = GameHelper.GetTeamName(teamID);


                    if (teamName == "SEALS" || teamName == "TERRORISTS")
                    {
                        PlayerDataModel PD = new PlayerDataModel();
                        PD._Team = teamName;
                        PD._PlayerHealth = ByteConverstionHelper.byteHexFloatToDecimal(m.Read<byte>(playerPointerAddress + GameHelper.PLAYER_HEALTH_OFFSET,4, false));

                        PD._PlayerName = ByteConverstionHelper.convertBytesToString(m.Read<byte>(playerNamePointerAddress, 20, false));
                        //PD._hasMPBomb = m.readByte((int.Parse(playerPointerAddress, System.Globalization.NumberStyles.HexNumber) + GameHelper.ENTITY_HAS_MPBOMB).ToString("X4"));

                        PD._pointerAddress = playerPointerAddress - 0x20000000;

                        if (PD._PlayerHealth != 0)
                        {
                            PD._LivingStatus = "ALIVE";
                        }
                        else
                        {
                            PD._LivingStatus = "DEAD";
                        }

                        playerData.Add(PD);

                    }

                    objectPtr = new IntPtr(Convert.ToInt32(ByteConverstionHelper.byteArrayHexToAddressString(m.Read<byte>(objectPtr, 4, false)),16)); // Get the next pointer in the list

                } while (objectPtr != GameHelper.PLAYER_INDEX_POINTER_ADDRESS);
            }

            return playerData;

        }
    }
}
