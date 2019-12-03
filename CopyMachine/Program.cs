namespace CopyMachine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var copyMachine = new CopyMachine();
            copyMachine.DepositMoney(8);
            copyMachine.SetStorageDevice(StorageDevice.flash);
            copyMachine.SetDocumentName("shpargalochka.txt");
            copyMachine.PrintDocument();
            copyMachine.DepositMoney(14);
            copyMachine.PrintDocument();
            copyMachine.SetDocumentName("kursach.docx");
            copyMachine.PrintDocument();
            copyMachine.GiveChange();
            //--
            copyMachine.SetDocumentName("flash");
        }
    }
}