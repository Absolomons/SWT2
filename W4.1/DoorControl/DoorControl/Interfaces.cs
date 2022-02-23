using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public interface IDoor
    {
        void Open();
        void Close();
    }

    public interface IDoorControl
    {
        void DoorOpened();
        void DoorClosed();
        void RequestEntry(int id);
    }

    public interface IEntryNotification
    {
        void NotifyEntryGranted(int id);
        void NotifyEntryDenied(int id);
    }

    public interface IAlarm
    {
        void RaiseAlarm();
    }

    public interface IUserValidation
    {
        bool ValidateEntryRequest(int id);
    }

}
