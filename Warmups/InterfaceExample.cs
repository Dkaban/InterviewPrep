namespace Warmups
{
    public interface ITestInterface
    {
        void SetMessage(string msg);
        string GetMessage();
        void DisplayMessage();
    }
    
    public class TestExtendInterface : ITestInterface
    {
        private string _message;
        
        public void SetMessage(string msg)
        {
            _message += msg;
        }

        public string GetMessage()
        {
            return _message;
        }

        public void DisplayMessage()
        {
            Debug.Log(GetMessage());
        }
    }

    public class InterfaceExample
    {
        public static void Main(string[] args)
        {
            var testExtendInterface = new TestExtendInterface();
            testExtendInterface.SetMessage("Potato");
            testExtendInterface.DisplayMessage();
            testExtendInterface.SetMessage(testExtendInterface.GetMessage());
            testExtendInterface.DisplayMessage();
        }
    }
}