namespace DesignPatterns.FacadePattern
{
    public class SecurityCodeCheck
    {
        private int securityCode = 1234;

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public bool IsCodeCorrect(int securityCodeToCheck)
        {
            return securityCodeToCheck == securityCode;
        }
    }
}
