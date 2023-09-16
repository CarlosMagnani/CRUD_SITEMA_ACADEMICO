namespace cls_model
{
    public class clsPeriodosModel
    {
        private string _pername;
        private string _persigla;


        public clsPeriodosModel(string name, string sigla) {
            _pername = name;
            _persigla = sigla;
        }

        public string Pername {  get { return _pername; } }
        public string Persigla { get {  return _persigla; } }
    }
}