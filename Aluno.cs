using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLP_P1
{
    class Aluno
    {
        private string _nome;
        private string _curso;
        private string _morada;
        private string _Ndocumento, _doc;
        private string _telefone;
        private string _genero;
        public string _Fotos;



        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public void Foto(string foto)
        {
            _Fotos = foto;
        }

        public string Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        public string Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }

        public string NDocumento
        {
            get { return _Ndocumento; }
            set { _Ndocumento = value; }
        }

        public string Documento
        {
            get { return _doc; }
            set { _doc = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
    }
}
