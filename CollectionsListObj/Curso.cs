﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsListObj
{
    class Curso
    {
        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {

            get { return new ReadOnlyCollection<Aula>(aulas); }
            
        }
        

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome 
        { 
            get { return nome; }
            set { nome = value; }
        }

        

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }


        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public int TempoTotal
        {
            get
            {
                //uma forma de retornar o total de tempo
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;

                //}
                //return total;

                //outra forma utilizando LINQ

                return aulas.Sum(aula => aula.Tempo);
            }
            
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal} , aulas: {string.Join(",", aulas)}";
        }
    }
}
