namespace Warmups
{
    #region ABSTRACT_CLASS_SETUP
    public abstract class TestAbstractClass
    {
        protected int TestProtectedInt;

        public abstract void SetTestAbstractInt(int amount);
        public abstract int GetTestAbstractInt();
        
        public abstract void TestAbstractMethod();
    }

    public class TestAbstractClassExample1 : TestAbstractClass
    {
        public override void SetTestAbstractInt(int amount)
        {
            TestProtectedInt = amount;
        }

        public override int GetTestAbstractInt()
        {
            Debug.Log($"The int is {TestProtectedInt}");
            return TestProtectedInt;
        }

        public override void TestAbstractMethod()
        {
            Debug.Log("This is TestAbstractClassExample1");
        }
    }
    
    public class TestAbstractClassExample2 : TestAbstractClass
    {
        public override void SetTestAbstractInt(int amount)
        {
            TestProtectedInt = amount * 2;
        }

        public override int GetTestAbstractInt()
        {
            TestProtectedInt += 2;
            Debug.Log($"The int is {TestProtectedInt}");
            return TestProtectedInt;
        }

        public override void TestAbstractMethod()
        {
            Debug.Log("This is TestAbstractClassExample # 2");
        }
    }

    #endregion

    public class AbstractClassExample
    {
        public static void Main(string[] args)
        {
            TestAbstractClass testAbstractClass = new TestAbstractClassExample1();
            testAbstractClass.TestAbstractMethod();
            testAbstractClass.SetTestAbstractInt(3);
            testAbstractClass.GetTestAbstractInt();

            testAbstractClass = new TestAbstractClassExample2();
            testAbstractClass.TestAbstractMethod();
            testAbstractClass.SetTestAbstractInt(5);
            testAbstractClass.GetTestAbstractInt();
        }
    }
}