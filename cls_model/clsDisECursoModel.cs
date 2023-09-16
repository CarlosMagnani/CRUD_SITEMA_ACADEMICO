using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_model
{
    public class clsDisECursoModel
    {
            private int _disId;
            private int _cursoId;

            public clsDisECursoModel(int disId, int cursoId)
            {
                _disId = disId;
                _cursoId = cursoId;
            }

            public int DisId { get { return _disId; } }
            public int CursoId { get { return _cursoId; } }
        
    }
}
