
using ATMW.Datas;
using Apulsetech.Rfid.Type;
using System.Windows.Forms;

namespace ATMW.Forms
{
    public partial class ATMW_Main : Form
    {
        private async void InventoryToggle()
        {
            await SharedValues.Reader.SetToggleAsync(RFID.OFF).ConfigureAwait(true);
        }

        private async void InventoryOperationSettingsRemoteFilter()
        {
            await SharedValues.Reader.SetInventoryEpcFilterStateAsync(RFID.ON).ConfigureAwait(true);
        }

    }
}
