using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_model
{
    public class clsDisciplinasModel
    {
        private string _disciplinaNome;
        private string _disciplinaSigla;
        private string _disciplinaObservacoes;

        public clsDisciplinasModel(string disciplinaNome, string disciplinaSigla, string disciplinaObservacoes)
        {
            _disciplinaNome = disciplinaNome;
            _disciplinaSigla = disciplinaSigla;
            _disciplinaObservacoes = disciplinaObservacoes;
        }

        public string DisciplinaNome
        {
            get { return _disciplinaNome; }
        }

        public string DisciplinaSigla
        {
            get { return _disciplinaSigla; }
        }

        public string DisciplinaObservacoes
        {
            get { return _disciplinaObservacoes; }
        }
    }
}
