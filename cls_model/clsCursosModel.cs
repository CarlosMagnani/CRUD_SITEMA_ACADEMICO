using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_model
{
    public class clsCursosModel
    {
        private string _cursoName;
        private string _cursoSigla;
        private string _cursoObservacoes;
        private int _perId;

        public clsCursosModel(string cursoName, string cursoSigla, string cursoObservacoes, int perId)
        {
            _cursoName = cursoName;
            _cursoSigla = cursoSigla;
            _cursoObservacoes = cursoObservacoes;
            _perId = perId;
        }

        public string CursoName
        {
            get { return _cursoName; }
        }

        public string CursoSigla
        {
            get { return _cursoSigla; }
        }

        public string CursoObservacoes
        {
            get { return _cursoObservacoes; }
        }

        public int PerId
        {
            get { return _perId; }
        }
    }

}
