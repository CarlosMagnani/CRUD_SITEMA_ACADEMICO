namespace cls_model
{
    public class loginModel
    {
        private string _pername;
        private string _password;


        public loginModel(string name, string password)
        {
            _pername = name;
            _password = password;
        }

        public string Pername { get { return _pername; } }
        public string Password { get { return _password; } }
    }
}
