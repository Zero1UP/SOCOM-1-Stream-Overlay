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
        MemorySharp _m = null;
        private IntPtr currentCameraPointer;
        private decimal _userLivingStatus;
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
        public MemorySharp m
        {
            set { _m = value; }
        }
        public decimal UserLivingStatus
        {
            set { _userLivingStatus = value; }
        }
        public PlayerDataLabel()
        {
            InitializeComponent();
           
        }

        private void lbl_PlayerName_Click(object sender, EventArgs e)
        {
            if(_userLivingStatus == 0)
            {
                if (lbl_PlayerName.Tag != null)
                {
                    if (this.PDM._LivingStatus != "DEAD")
                    {
                        IntPtr camera1PointerAddress = new IntPtr(Convert.ToInt32(ByteConverstionHelper.byteArrayHexToAddressString(_m.Read<byte>(GameHelper.SPECTATOR_CAMERA_POINTER_ADDRESS, 4, false)), 16));
                        IntPtr playerPointer = this.PDM._pointerAddress;
                        currentCameraPointer = new IntPtr(_m.Read<int>(camera1PointerAddress + GameHelper.SPECTATOR_CAMERA_POINTER_OFFSET2, false));
                        _m.Write(camera1PointerAddress + GameHelper.SPECTATOR_CAMERA_POINTER_OFFSET1, playerPointer, false);
                        _m.Write(camera1PointerAddress + GameHelper.SPECTATOR_CAMERA_POINTER_OFFSET2, currentCameraPointer, false);
                    }

                }
            }

        }
    }
}
