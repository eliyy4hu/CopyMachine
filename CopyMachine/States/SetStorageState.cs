using System;

namespace CopyMachine.States
{
    public class SetStorageState : StateBase
    {
        public override void SetStorageDevice(StorageDevice storageDevice)
        {
            CopyMachine.StorageDevice = storageDevice;
            CopyMachine.State = new SetDocumentState(CopyMachine);
        }

        public override void SetDocumentName(string documentName)
        {
            throw new Exception($"Choose your storage device firstly");
        }

        public override void PrintDocument()
        {
            throw new Exception($"Choose your storage device firstly");
        }

        public SetStorageState(CopyMachine copyMachine) : base(copyMachine)
        {
        }
    }
}