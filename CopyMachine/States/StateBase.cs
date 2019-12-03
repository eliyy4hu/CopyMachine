using System;

namespace CopyMachine.States
{
    public abstract class StateBase : IState
    {
        protected readonly CopyMachine CopyMachine;

        protected StateBase(CopyMachine copyMachine)
        {
            this.CopyMachine = copyMachine;
        }

        public virtual void DepositMoney(int money)
        {
            CopyMachine.Money += money;
            Console.WriteLine($"your deposit - {CopyMachine.Money} coins");
        }

        public abstract void SetStorageDevice(StorageDevice storageDevice);

        public abstract void SetDocumentName(string documentName);

        public abstract void PrintDocument();


        public virtual void GiveChange()
        {
            Console.WriteLine($"Take your {CopyMachine.Money} coins");
            CopyMachine.Money = 0;
            CopyMachine.State = new InitState(CopyMachine);
        }
    }
}