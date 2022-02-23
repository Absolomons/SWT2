using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    internal class DoorControl : IDoorControl
    {
        public enum DoorState
        {
            DoorClosed,
            DoorClosing,
            DoorOpening,
            DoorBreached
        };

        private IDoor _door;
        private IEntryNotification _en;
        private IAlarm _alarm;
        private IUserValidation _uv;
        private DoorState _state;

        public DoorControl(IDoor door, IEntryNotification en, IAlarm alarm, IUserValidation uv)
        {
            _state = DoorState.DoorClosed;
            _door = door;
            _en = en;
            _alarm = alarm;
            _uv = uv;
        }

        public void DoorOpened()
        {
            _door.Close();
            _state = DoorState.DoorClosing;
        }

        public void DoorClosed()
        {
            _state = DoorState.DoorClosed;
        }

        public void RequestEntry(int id)
        {
            if (_uv.ValidateEntryRequest(id))
            {
                _door.Open();
                _en.NotifyEntryGranted(id);
                _state = DoorState.DoorOpening;
            }

        }
    }
}
