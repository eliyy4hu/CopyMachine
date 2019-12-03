using System;

namespace CopyMachine.States
{
    public class PrintState : StateBase
    {
        public override void SetStorageDevice(StorageDevice storageDevice)
        {
            CopyMachine.StorageDevice = storageDevice;
            CopyMachine.State = new SetDocumentState(CopyMachine);
        }

        public override void SetDocumentName(string documentName)
        {
            CopyMachine.DocumentName = documentName;
        }

        public override void PrintDocument()
        {
            if (CopyMachine.Money >= CopyMachine.DocumentCopyCost)
            {
                Console.WriteLine($"printing {CopyMachine.DocumentName}...");
                CopyMachine.Money -= CopyMachine.DocumentCopyCost;
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
            }
        }

        public PrintState(CopyMachine copyMachine) : base(copyMachine)
        {
        }
    }
}