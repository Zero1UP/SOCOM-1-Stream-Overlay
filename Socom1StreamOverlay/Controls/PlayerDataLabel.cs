using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Socom1StreamOverlay.Helpers;
using Socom1StreamOverlay.Models;
using Binarysharp.MemoryManagement;
namespace Socom1StreamOverlay.Controls
{
    public partial class PlayerDataLabel : UserControl
    {
        private PlayerDataModel _pdm;
        public Color livingStatus
        {
            set { this.BackColor = value; }
        }

        public string playerName
        {
            get { return lbl_PlayerName.Text; }
            set
            {
                lbl_PlayerName.Text = value;

            }
        }

        public Color playerNameColor
        {
            set { lbl_PlayerName.ForeColor = value; }
        }

        public bool healthSet
        {
            set { hb_PlayerHealth.healthSet = value; }
        }

        public Color healthBarColor
        {
            set { hb_PlayerHealth.healthBarColor = value; }
        }

        public int playerHealth
        {
            set { hb_PlayerHealth.playerHealth = value; }
        }

        public PlayerDataModel PDM
        {
            get { return (PlayerDataModel)lbl_PlayerName.Tag; }
            set { lbl_PlayerName.Tag = (PlayerDataModel)value; }
        }
        public PlayerDataLabel()
        {
            InitializeComponent();
           
        }

    }
}
