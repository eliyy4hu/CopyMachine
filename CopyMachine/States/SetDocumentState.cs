using System;

namespace CopyMachine.States
{
    public class SetDocumentState : StateBase
    {
        public override void SetStorageDevice(StorageDevice storageDevice)
        {
            CopyMachine.StorageDevice = storageDevice;
            CopyMachine.State = new SetDocumentState(CopyMachine);
        }

        public override void SetDocumentName(string documentName)
        {
            CopyMachine.DocumentName = documentName;
            CopyMachine.State = new PrintState(CopyMachine);
        }

        public override void PrintDocument()
        {
            throw new Exception($"Choose document to print firstly");
        }

        public SetDocumentState(CopyMachine copyMachine) : base(copyMachine)
        {
        }
    }
}