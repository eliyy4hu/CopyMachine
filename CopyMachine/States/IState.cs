namespace CopyMachine.States
{
    public interface IState
    {
        void DepositMoney(int money);
        void SetStorageDevice(StorageDevice storageDevice);
        void SetDocumentName(string documentName);
        void PrintDocument();
        void GiveChange();
    }
}