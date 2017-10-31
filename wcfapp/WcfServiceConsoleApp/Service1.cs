namespace WcfServiceConsoleApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string Hello(string name)
        {
            return string.Format("Hello {0} from Container!", name);
        }
    }
}
