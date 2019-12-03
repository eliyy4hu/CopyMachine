using System;

namespace CopyMachine.States
{
    public class InitState : StateBase
    {
        public override void DepositMoney(int money)
        {
            CopyMachine.Money += money;
            Console.WriteLine($"your deposit - {CopyMachine.Money} coins");
            CopyMachine.State = new SetStorageState(CopyMachine);
        }

        public override void SetStorageDevice(StorageDevice storageDevice)
        {
            throw new Exception($"Deposit your money firstly");
        }

        public override void SetDocumentName(string documentName)
        {
            throw new Exception($"Deposit your money firstly");
        }

        public override void PrintDocument()
        {
            throw new Exception($"Deposit your money firstly");
        }

        public InitState(CopyMachine copyMachine) : base(copyMachine)
        {
        }
    }
}