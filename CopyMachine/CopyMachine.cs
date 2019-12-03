using CopyMachine.States;

namespace CopyMachine
{
    public class CopyMachine
    {
        public IState State;
        public int Money = 0;
        public string DocumentName;
        public int DocumentCopyCost = 10;
        public StorageDevice StorageDevice;

        public CopyMachine()
        {
            State = new InitState(this);
        }

        public void DepositMoney(int money)
        {
            State.DepositMoney(money);
        }

        public void SetStorageDevice(StorageDevice storageDevice)
        {
            State.SetStorageDevice(storageDevice);
        }

        public void SetDocumentName(string documentName)
        {
            State.SetDocumentName(documentName);
        }

        public void PrintDocument()
        {
            State.PrintDocument();
        }

        public void GiveChange()
        {
            State.GiveChange();
        }
    }
}